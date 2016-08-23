using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TastTask;
using TestTask.Interfaces;

namespace TestTask
{
    public class Revers2Controller : IController
    {
        public async Task<List<string>> CheckPath(string path, IFolderScanner scanner, IConverter converter)
        {
            if (path != null)
            {
                List<string> FilesList = await scanner.GetFilesList(path);

                if (FilesList.Count > 0)
                {
                    List<string> tmpList = new List<string>();

                    foreach (string item in FilesList)
                    {
                        tmpList.Add(item.Remove(0, path.Length));
                    }

                    FilesList = Revers(tmpList);

                    return FilesList;
                }
                else
                {
                    return FilesList;
                }

            }

            return new List<string>();
        }

        private List<string> Revers(List<string> list)
        {
 
            List<string> returnList = new List<string>();

            foreach (string item in list)
            {
                char[] arr = item.ToCharArray();
                Array.Reverse(arr);
                returnList.Add(new string(arr));
            }

            return returnList;
        }
    }
}
