using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Automation {

    internal class Program {

        static void Main(string[] args) {
            var app = ConfigurationManager.AppSettings["app"];
            var root = ConfigurationManager.AppSettings["root"];
            var auto = new Automated(app, root);

            while (true) {
                auto.ClickButton("Button 1");
                Thread.Sleep(30000);
            }
        }
    }
}
