using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "";
            string dag;

            Console.Write("Ange en veckodags namn. ");
            dag = Console.ReadLine();
            
            switch (dag)
            {
                case "Måndag":
                    msg = ("dag 1 i veckan");
                    break;
                case "Tisdag":
                    msg = ("dag 2 i veckan");
                    break;
                case "Onsdag":
                    msg = ("dag 3 i veckan, lillördag!!");
                    break;
                case "Torsdag":
                    msg = ("dag 4 i veckan");
                    break;
                case "Fredag":
                    msg = ("dag 5 i veckan");
                    break;
                case "Lördag":
                    msg = ("dag 6 i veckan");
                    break;
                case "Söndag":
                    msg = ("dag 7 i veckan");
                    break;
            }
            //print
            Console.Write("Du valde {0}, vilket är {1}. ", dag, msg);

            Console.ReadKey();

        }
    }
}
