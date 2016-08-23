using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask
{
    class Program
    {
        static void Main(string[] args)
        {

            if(args.Length == 2)
            {
                string path = args[0];
                string command = args[1];

                if (Directory.Exists(path))
                {                    
                    if(command.ToLower() == "all" || command.ToLower() == ".cpp" || command.ToLower() == "reversed1" || command.ToLower() == "reversed2")
                    {
                        MainController controller = new MainController(args);
                        Console.WriteLine("Please wait ... ");                        
                        string fileResult = controller.GetResultList();
                        Console.WriteLine("File result : " + fileResult);                        
                    }
                    else
                    {
                        Console.WriteLine("Incorrect command name");
                    }
                }
                else
                {
                    Console.WriteLine("Folder not found");
                }
            }
            else
            {
                Console.WriteLine("Incorrect input");
                return;               
            }
            
        }
    }
}
