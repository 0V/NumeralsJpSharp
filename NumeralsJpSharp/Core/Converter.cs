using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NumeralsJpSharp.Extensions;

/// <summary>
/// You can easily to convert Kanji characters which express numbers to Arabic numerals by this library.
/// </summary>
namespace NumeralsJpSharp.Core
{
    public class Converter
    {
        private Converter()
        {
        }

        public static IEnumerable<string> TrimArabicToKanji(string str)
        {
            var list = new List<string>();
            foreach (var s in StringTrimer.SplitCommaNumerals(str))
            {
                list.Add(ArabicToKanji(s));
            }
            return list;
        }

        public static string ArabicToKanji(int num) => ArabicToKanji(num.ToString());
        public static string ArabicToKanji(long num) => ArabicToKanji(num.ToString());
        public static string ArabicToKanji(string str)
        {
            var count = str.Length;
            int remnant = count % 4;
            var chunks = str.Skip(remnant).Chunk(4).ToList();
            if (remnant > 0)
            {
                chunks.Insert(0, str.Take(remnant));
            }
            var sb = new StringBuilder();

            var unit = count / 5;

            for (int i = 0; i <= unit; i++)
            {
                var small = ArabicToKanjiSmall(int.Parse(new string(chunks[i].ToArray())));
                if (small != "")
                {
                    sb.Append(small);
                    sb.Append(Definitions.LargeFactors[unit - i]);
                }
            }
            var result = sb.ToString();
            return result != "" ? result : "零";
        }

        public static string ArabicToKanjiSmall(int num)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                var remnant = num % 10;
                num /= 10;
                if (remnant > 0)
                {
                    sb.Insert(0, Definitions.SmallFactors[i]);
                }
                if (remnant != 1 || i == 0)
                {
                    sb.Insert(0, Definitions.KanjiNumerals[remnant]);
                }
            }
            return sb.ToString();
        }

        public static string ArabicToKanjiSmall(string str)
        {
            var num = Convert.ToInt32(str);

            return ArabicToKanjiSmall(num);
        }

        public static string KanjiToArabic(string str)
        {
            throw new NotImplementedException("あとで");
        }
    }
}