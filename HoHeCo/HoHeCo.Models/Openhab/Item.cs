using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoHeCo.Models.Openhab
{
#pragma warning disable IDE1006 // Naming Styles

    public class Item
    {
        public string link { get; set; }
        public object state { get; set; }
        public bool editable { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string label { get; set; }
        public List<object> tags { get; set; }
        public List<string> groupNames { get; set; }
        public StateDescription stateDescription { get; set; }
        public List<object> members { get; set; }
        public string category { get; set; }
        public CommandDescription commandDescription { get; set; }
    }

    public class Option
    {
        public string value { get; set; }
        public string label { get; set; }
    }

    public class StateDescription
    {
        public int minimum { get; set; }
        public int maximum { get; set; }
        public int step { get; set; }
        public string pattern { get; set; }
        public bool readOnly { get; set; }
        public List<Option> options { get; set; }
    }

    public class CommandOption
    {
        public string command { get; set; }
        public string label { get; set; }
    }

    public class CommandDescription
    {
        public List<CommandOption> commandOptions { get; set; }
    }

#pragma warning restore IDE1006 // Naming Styles
}