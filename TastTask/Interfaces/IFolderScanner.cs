using System.Collections.Generic;
using System.Threading.Tasks;

namespace TastTask
{
    public interface IFolderScanner
    {
        Task<List<string>> GetFilesList(string path);
        Task<List<string>> GetFilesList(string path, string extension);        
    }
}
