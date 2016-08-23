using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Interfaces
{
    public interface IConverter
    {
        List<string> ConvertList(List<string> list, string path);
    }
}
