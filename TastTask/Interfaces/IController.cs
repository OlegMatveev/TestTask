using System.Collections.Generic;
using System.Threading.Tasks;
using TastTask;
using TestTask.Interfaces;

namespace TestTask
{
    public interface IController
    {
        Task<List<string>> CheckPath(string path, IFolderScanner scanner, IConverter converter);
    }
}
