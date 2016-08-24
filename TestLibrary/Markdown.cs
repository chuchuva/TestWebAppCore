using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary
{
    public class Markdown
    {
        public static string ConvertToHtml(string s)
        {
            return CommonMark.CommonMarkConverter.Convert(s);
        }
    }
}
