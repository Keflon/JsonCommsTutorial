using System;
using System.Collections.Generic;
using System.Text;

namespace JsonCommsTutorial.Models
{
    public class StartupCheckRequest
    {
        public StartupCheckRequest(string platform, string version)
        {
            Platform = platform;
            Version = version;
        }

        public string Platform { get; }
        public string Version { get; }
    }
}
