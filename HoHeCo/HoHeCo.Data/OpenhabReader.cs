using HoHeCo.Models.Openhab;
using RadLogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading;

namespace HoHeCo.Data
{
    public class OpenhabReader : IDataReader
    {
        private readonly string _openhabUrl;
        private readonly ILogger _logger;

        public OpenhabReader(ILogger logger, string openhabUrl)
        {
            _logger = logger;
            _openhabUrl = openhabUrl;
        }

        public object GetData()
        {
            _logger.LogInfo("Start data GetData");
            var task = GetAllItemsAsync();
            task.Wait(); // Blocks current thread until GetFooAsync task completes
                         // For pedagogical use only: in general, don't do this!
            Item[] items = task.Result;
            return items.ToList();
        }

        private async System.Threading.Tasks.Task<Item[]> GetAllItemsAsync()
        {
            var client = new HttpClient();

            // Get the response.
            HttpResponseMessage response = await client.GetAsync(_openhabUrl + "/rest/items?recursive=false").ConfigureAwait(false);

            // Get the response content.
            HttpContent responseContent = response.Content;

            // Get the stream of the content.
            using var reader = new StreamReader(await responseContent.ReadAsStreamAsync().ConfigureAwait(false));
            // Write the output.
            return JsonSerializer.Deserialize<Item[]>(await reader.ReadToEndAsync().ConfigureAwait(false));
        }
    }
}