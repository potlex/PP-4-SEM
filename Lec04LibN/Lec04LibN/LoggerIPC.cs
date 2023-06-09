using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec04LibN
{
    public partial class Logger : ILogger
    {
        private int picker;
        private static Logger instance;
        private StreamWriter writer;
        private LinkedList<string> namespaces;
        private Dictionary<string, string> status;

        public static partial ILogger create();
        public partial void log(string message = "");
        public partial void start(string title);
        public partial void stop();

        private Logger()
        {
            picker = 1;
            namespaces = new LinkedList<string>();
            status = new Dictionary<string, string>()
            {
                { "create", "INIT" },
                { "start", "STRT" },
                { "stop", "STOP" }
            };
        }
    }
}
