using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Converters
{
    public class AllConverter :  Converter
    {
        public override List<string> ConvertList(List<string> list, string path)
        {
            return base.ConvertList(list, path);
        }
    }
}
