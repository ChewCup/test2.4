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
            
            switch (dag.ToLower())
            {
                case "måndag":
                    msg = ("dag 1 i veckan");
                    break;
                case "tisdag":
                    msg = ("dag 2 i veckan");
                    break;
                case "onsdag":
                    msg = ("dag 3 i veckan, lillördag!!");
                    break;
                case "torsdag":
                    msg = ("dag 4 i veckan");
                    break;
                case "fredag":
                    msg = ("dag 5 i veckan");
                    break;
                case "lördag":
                    msg = ("dag 6 i veckan");
                    break;
                case "söndag":
                    msg = ("dag 7 i veckan");
                    break;
                default:
                    msg = ("retard");
                    break;

            }
            //print
            Console.Write("Du valde {0}, vilket är {1}. ", dag, msg);

            Console.ReadKey();

        }
    }
}
