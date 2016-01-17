using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumeralsJpSharp.Core
{
    public class StringTrimer
    {
        /// <summary>
        /// 「,」および「，」を削除して数字のみの文字列IEnumerableを返します。
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static IEnumerable<string> SplitCommaNumerals(string str)
        {
            var numstr = Regex.Replace(Regex.Replace(str, "[,，]", ""), @"[^0-9]", "_");
            var result = SplitNumerals(numstr, 1);
            return result;
        }

        /// <summary>
        /// 数字と数字の間に count (default : 2)以上の数字以外の文字があったとき分割します．
        /// </summary>
        /// <param name="str"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<string> SplitNumerals(string str, int count = 2)
        {
            var numstr = Regex.Replace(str, @"[^0-9]", "_");
            var result = new List<string>();

            var sb = new StringBuilder();
            int checkCount = 0;
            foreach (var c in numstr)
            {
                if (checkCount >= count)
                {
                    if (sb.Length > 0)
                    {
                        result.Add(sb.ToString());
                        sb.Clear();
                        checkCount = 0;
                    }
                }

                if (c == '_')
                {
                    checkCount++;
                }
                else
                {
                    sb.Append(c);
                    checkCount = 0;
                }
            }

            if (sb.Length > 0)
            {
                result.Add(sb.ToString());
            }
            return result;
        }
    }
}
