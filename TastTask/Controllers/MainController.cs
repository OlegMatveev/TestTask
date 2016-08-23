using System.Collections.Generic;
using TastTask;
using TastTask.Interfaces;
using TestTask.Interfaces;

namespace TestTask
{
    public class MainController
    {

        private string _directory;
        private string _command;
        private Creator _creator;

        public MainController(string[] args)
        {
            _directory = args[0].ToLower();
            _command = args[1].ToLower();
            _creator = new Creator();
        }
       

        public string GetResultList()
        {
            IController _controller = _creator.GetController(_command);
            IFolderScanner _scanner = _creator.GetScanner();
            IConverter _converter = _creator.GetConverter(_command);

            List<string> list = _controller.CheckPath(_directory, _scanner, _converter).GetAwaiter().GetResult(); 
                       
            IWriter writer = _creator.GetWriter();
            string pathToFileResult =  writer.Save(list);

            return pathToFileResult;
        }

    }
}
