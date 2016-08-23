using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TastTask;
using TestTask.Interfaces;

namespace TestTask
{
    public class ReversController : IController
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
            List<string> newList = new List<string>();

            foreach (string item in list)
            {
                string[] str = item.Split(new char[] { '\\' });
                Array.Reverse(str);
                string str2 = string.Empty;

                for (int i = 0; i < str.Length; i++)
                {
                    if (i != (str.Length - 1))
                    {
                        str2 += str[i] + '\\';
                    }
                    else
                    {
                        str2 += str[i];
                    }
                }

                newList.Add(str2);
            }

            return newList;
        }
    }
}
