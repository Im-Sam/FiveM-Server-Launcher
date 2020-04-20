using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FLG_RP_Launcher
{
    class Launcher
    {
        public static void PlayGame(string url)
        {
            Process.Start(url);
        }

        public static void LaunchWebsite(string url)
        {
            Process.Start(url);  
        }

        public static void LaunchCad(string url)
        {
            Process.Start(url);
        }
            
    }

}
