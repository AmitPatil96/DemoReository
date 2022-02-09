using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcaseprogram
{
    class Program
    {
        static void Main(string[] args)
       {
            Printmenu();
            Executemenuoptions();
            Console.ReadLine();
        }
        static void Printmenu()
        {
            Console.Clear();
            Console.WriteLine("1. If Else Statment");
            Console.WriteLine("2. For Loop");
            Console.WriteLine("3.For Each Loop");
            Console.WriteLine("4.Array Example");
            Console.WriteLine("5.Parameter Example");
            Console.WriteLine("6.Params Examaple");
            Console.WriteLine("7.Structure Example");
        }

        static void Executemenuoptions()
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Enter Any Choice");
           // Console.ForegroundColor = ConsoleColor.Yellow;
            int choice = int.Parse(Console.ReadLine());
            //controlstructer obj = new controlstructer();
            switch (choice)
             {

                case 1:
                    controlstructer obj = new controlstructer();
                    obj.IfElseStatment();
                    break;
                case 2:
                    controlstructer Amit = new controlstructer();
                    Amit.ForLoop();
                    break;
                case 3:
                    controlstructer Shubham = new controlstructer();
                    Shubham.ForEachLoop();
                    break;
                case 4:
                    controlstructer AT = new controlstructer();
                    AT.Arrayexample();
                    break;
                 case 5:
                    ParameterExample Ap = new ParameterExample();
                    Ap.InitializeParameter();
                    break;
                 case 6:
                    ParameterExample A = new ParameterExample();
                    A.ParamExample();
                    break;
                case 7:
                    ParameterExample B = new ParameterExample();
                    B.StructureExample();
                    break;
                default:
                    Console.WriteLine("Invalid Choice Existing....");
                    break;
            }
        }
    }

}  