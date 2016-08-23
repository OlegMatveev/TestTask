using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Converters
{
    public class CppConverter : Converter
    {
        public override List<string> ConvertList(List<string> list, string path)
        {
            List<string> tmpList = base.ConvertList(list, path);
            tmpList = addString(tmpList);

            return list;
        }

        private List<string> addString(List<string> tmpList)
        {
            List<string> list = new List<string>();
            foreach (string item in tmpList)
            {
                string str = item + " /";
                list.Add(str);
            }

            return list;
        }
    }
}
