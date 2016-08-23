using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Interfaces;

namespace TestTask.Converters
{
    public class Converter : IConverter
    {
        public virtual List<string> ConvertList(List<string> list, string path)
        {
            if (list.Count > 0)
            {
                List<string> tmpList = new List<string>();

                foreach (string item in list)
                {
                    tmpList.Add(item.Remove(0, path.Length));
                }

                return tmpList;
            }

            return list;
        }
        
    }
}
