using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terminal.Gui;

namespace BruetforcePassCheckerTUI
{
    class Program
    {
        static void Main()
        {
            Application.Init();
            try
            {
                Application.Run(new MyView());
            }
            finally
            {
                Application.Shutdown();
            }
        }
    }
}
