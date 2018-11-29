using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITest
{






    class Command
    {

        public static void scan()
        {


            if (Program.COMMAND == "help")
            {


                Console.WriteLine("1T. Random");
                Console.WriteLine("2T. Not really learning but kinda?");




            }











            if (Program.COMMAND.Contains("run"))
            {



                if (Program.COMMAND.Contains("-1"))
                {

                    Program.OOT = 1;



                        if (Program.COMMAND.Contains("/i"))
                        {


                            string ITS = Program.COMMAND.Substring(Program.COMMAND.IndexOf("/i") + 2);


                            Program.Iteration = System.Convert.ToInt32(ITS);

                            Program.Start = true;



                        }



                 



                }




                if (Program.COMMAND.Contains("-2"))
                {


                    Program.OOT = 2;




                    if (Program.COMMAND.Contains("/dau"))
                    {

                        Program.DAU = true;



                    }



                    if (Program.COMMAND.Contains("/de"))
                    {


                        Program.de = true;


                    }





                    if (Program.COMMAND.Contains("/i"))
                    {



                        string ITS = Program.COMMAND.Substring(Program.COMMAND.IndexOf("/i") + 2);


                        Program.Iteration = System.Convert.ToInt32(ITS);


                        Program.Start = true;




                    }

                    



                }






            }

            

        }

       

    }
}
