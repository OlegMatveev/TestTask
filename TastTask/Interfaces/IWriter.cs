using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TastTask.Interfaces
{
    public interface IWriter
    {
        string Save(List<string> list);
    }
}
