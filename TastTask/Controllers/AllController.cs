using System.Collections.Generic;
using System.Threading.Tasks;
using TastTask;
using TestTask.Interfaces;

namespace TestTask
{
    public class AllController : IController
    {
        public async Task<List<string>> CheckPath(string path, IFolderScanner scanner, IConverter converter)
        {
            if (path != null)
            {               
                List<string> FilesList = await scanner.GetFilesList(path);
                FilesList = converter.ConvertList(FilesList, path);

                return FilesList;               
            }

            return new List<string>();
        }
    }
}