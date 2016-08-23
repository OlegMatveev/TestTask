using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TastTask;
using TestTask.Interfaces;

namespace TestTask
{
    public class CppController : IController
    {
        public async Task<List<string>> CheckPath(string path, IFolderScanner scanner, IConverter converter)
        {
            if (path != null)
            {
                List<string> FilesList = await scanner.GetFilesList(path, "*.cpp");

                if (FilesList.Count > 0)
                {
                    List<string> tmpList = new List<string>();

                    foreach (string item in FilesList)
                    {
                        tmpList.Add(item.Remove(0, path.Length));
                    }

                    FilesList = addString(tmpList);
                    return FilesList;
                }
                else
                {
                    return FilesList;
                }

            }

            return new List<string>();
        }

        private List<string> addString(List<string> tmpList)
        {
            List<string> list = new List<string>();
            foreach (string item in tmpList)
            {
                string str = item + " /";
                list.Add(str);
            }

            return list;
        }
    }
}
