using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TastTask;
using TastTask.Interfaces;
using TestTask.Converters;
using TestTask.Interfaces;

namespace TestTask
{
    public class Creator
    {
        public IController GetController(string name)
        {
            IController controller = null;

            switch (name.ToLower())
            {
                case "all":
                    controller = new AllController();
                    break;
                case ".cpp":
                    controller = new CppController();
                    break;
                case "reversed1":
                    controller = new ReversController();
                    break;
                case "reversed2":
                    controller = new Revers2Controller();
                    break;
                default:
                    Console.WriteLine("incorrect command name");
                    break;
            }

            return controller;
        }

        public IWriter GetWriter()
        {
            return new Writer();
        }

        public IFolderScanner GetScanner()
        {
            return new FolderScanner();
        }

        public IConverter GetConverter(string name)
        {
            IConverter converter = null;

            switch (name.ToLower())
            {
                case "base":
                    converter = new Converter();
                    break;
                case "all":
                    converter = new AllConverter();
                    break;
                default:
                    converter = new Converter();
                    break;
            }

            return converter;
        }
      
    }
}
