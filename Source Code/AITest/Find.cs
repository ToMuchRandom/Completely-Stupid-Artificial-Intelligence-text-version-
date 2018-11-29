using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITest
{



    class Find
    {

        public static string FindString = "";

        public static void Run()
        {

            Random rnd = new Random();



            if (rnd.Next(1, 2) == 1)
            {

               

                if (Program.Text.Contains(FindString))
                {

                   

                    Program.Output = Program.Output + FindString;

                }

            }


        }



    }
}
