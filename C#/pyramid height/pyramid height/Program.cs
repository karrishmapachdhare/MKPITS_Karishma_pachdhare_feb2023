using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pyramid_height
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int height = 13;
                for(int outercounter=1; outercounter<=height; outercounter++)
                {
                for (int innercounter1 =1;innercounter1<= height;outercounter--)
                {
                    Console.WriteLine("");
                }
                for (int innercounter2 = 1; innercounter2 <=2* outercounter-1;innercounter2++) ;
                {
                    Console.Write("*");
                }
                Console.WriteLine();    
                 NNBHBHH
            

                }
        }
    }
}
