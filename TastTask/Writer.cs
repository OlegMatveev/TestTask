using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using TastTask.Interfaces;

namespace TastTask
{
    public class Writer : IWriter
    {
        public string Save(List<string> list)
        {
            string _fileResult = Environment.CurrentDirectory + "\\result.txt";

            using (StreamWriter stream = new StreamWriter(_fileResult))
            {
                foreach (string item in list)
                {
                    stream.WriteLine(item);
                }
            }

            return _fileResult;

        }
    }
}
