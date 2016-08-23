using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using TastTask;

namespace TestTask
{
    public class FolderScanner : IFolderScanner
    {

        public async Task<List<string>> GetFilesList(string path)
        {
            return await Task.Run(() =>
            {
                List<string> filesList = new List<string>();  
                
                IEnumerable<string> files = Directory.EnumerateFiles(path);
                filesList.AddRange(files);

                string[] dir = Directory.GetDirectories(path);
                if (path != null)
                {

                    foreach (string item in dir)
                    {
                        try
                        {
                            filesList.AddRange(GetFilesList(item).GetAwaiter().GetResult());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }                   

                }
                return filesList;
            });

        }

        public async Task<List<string>> GetFilesList(string path, string extension)
        {
            return await Task.Run(() =>
            {
                List<string> filesList = new List<string>();

                IEnumerable<string> files = Directory.EnumerateFiles(path, extension);
                filesList.AddRange(files); ;

                string[] dir = Directory.GetDirectories(path);
                if (path != null)
                {
                    foreach (string item in dir)
                    {
                        try
                        {
                            filesList.AddRange(GetFilesList(item,extension).GetAwaiter().GetResult());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }

                }
                return filesList;
            });
        }      
        
        private List<string> cutStartPath(List<string> filesList, string path)
        {
            if (filesList.Count > 0)
            {
                List<string> tmpList = new List<string>();

                foreach (string item in filesList)
                {
                    tmpList.Add(item.Remove(0, path.Length));
                }

                return tmpList;
            }

            return filesList;
        }
         
    }
}


