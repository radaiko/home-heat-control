using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace RadLogger.Test
{
    [TestClass]
    public class ConsolLoggerTest
    {
        [TestMethod]
        public void LogError_ShouldOutputString()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            ConsoleLogger consolLogger = new ConsoleLogger();
            consolLogger.LogError("Test");

            string expected = string.Format("{0} ERROR: Test{1}", DateTime.Now, Environment.NewLine);
            Assert.AreEqual<string>(expected, sw.ToString());
        }

        [TestMethod]
        public void LogInfo_ShouldOutputString()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            ConsoleLogger consolLogger = new ConsoleLogger();
            consolLogger.LogInfo("Test");

            string expected = string.Format("{0} Info: Test{1}", DateTime.Now, Environment.NewLine);
            Assert.AreEqual<string>(expected, sw.ToString());
        }

        [TestMethod]
        public void LogDebug_ShouldOutputString()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            ConsoleLogger consolLogger = new ConsoleLogger();
            consolLogger.LogDebug("Test");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                string expected = string.Format("{0} DEBUG: Test{1}", DateTime.Now, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
            else
            {
                Assert.AreEqual<string>("", sw.ToString());
            }
        }

        [TestMethod]
        public void Log_Error_ShouldOutputString()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            ConsoleLogger consolLogger = new ConsoleLogger();
            consolLogger.Log(EType.Error, "Test");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                string expected = string.Format("{0} ERROR: Test{1}", DateTime.Now, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
            else
            {
                Assert.AreEqual<string>("", sw.ToString());
            }
        }

        [TestMethod]
        public void Log_Info_ShouldOutputString()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            ConsoleLogger consolLogger = new ConsoleLogger();
            consolLogger.Log(EType.Info, "Test");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                string expected = string.Format("{0} Info: Test{1}", DateTime.Now, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
            else
            {
                Assert.AreEqual<string>("", sw.ToString());
            }
        }

        [TestMethod]
        public void Log_Debug_ShouldOutputString()
        {
            using StringWriter sw = new StringWriter();
            Console.SetOut(sw);

            ConsoleLogger consolLogger = new ConsoleLogger();
            consolLogger.Log(EType.Debug, "Test");

            if (System.Diagnostics.Debugger.IsAttached)
            {
                string expected = string.Format("{0} DEBUG: Test{1}", DateTime.Now, Environment.NewLine);
                Assert.AreEqual<string>(expected, sw.ToString());
            }
            else
            {
                Assert.AreEqual<string>("", sw.ToString());
            }
        }
    }
}