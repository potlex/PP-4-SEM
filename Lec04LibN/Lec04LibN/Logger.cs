using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lec04LibN
{
    public partial class Logger : ILogger
    {
        private string LogFileName =
            string.Format(@"{0}/LOG{1}.txt", Directory.GetCurrentDirectory(), DateTime.Now.ToString("yyyyMMdd-HH-mm-ss"));

        public partial void log(string message = "")
        {
            MethodBase caller = new StackTrace().GetFrame(1).GetMethod();

            string info = status.ContainsKey(caller.Name) ? status[caller.Name] : "INFO";

            string ns = " ";
            
            foreach (string item in namespaces) 
            {
                ns += item;
                ns += ":";
            }

            using (writer = new StreamWriter(LogFileName, true))
            {
                writer.WriteLine(picker.ToString("D6") + "-" +
                    DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss") + "-" + info + 
                    ns + " " + message);
                picker++;
            }
        }
        public static partial ILogger create()
        {
            if (instance == null)
            {
                instance = new Logger();
                instance.log();
            }
            return instance;
        }
        public partial void start(string title)
        {
            namespaces.AddLast(title);
            instance.log();
        }
        public partial void stop()
        {
            namespaces.RemoveLast();
            instance.log();
        }
    }
}