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
    public class Calculator
    {
        private Calculator()
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
            var chunks = str.Skip(count % 4).Chunk(4).ToList();
            chunks.Insert(0, str.Take(count % 4));
            var sb = new StringBuilder();

            var unit = count / 4;

            for (int i = 0; i <= unit; i++)
            {
                sb.Append(ArabicToKanjiSmall(int.Parse(new string(chunks[i].ToArray()))));
                sb.Append(Definitions.LargeFactors[unit - i]);
            }
            return sb.ToString();
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

        public static string ArabicToKanjiSmall(IEnumerable<char> str)
        {
            throw new NotImplementedException("まって");
        }

        public static string KanjiToArabic(string str)
        {
            throw new NotImplementedException("あとで");
        }
    }
}