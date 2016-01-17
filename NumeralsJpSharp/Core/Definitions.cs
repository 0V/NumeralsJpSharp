﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeralsJpSharp.Core
{
    public struct Definitions
    {
        public static string[] KanjiNumerals = { "", "一", "二", "三", "四", "五", "六", "七", "八", "九" };
        public static string[] SmallFactors = { "", "十","百","千" };

        // [memo]
        // n番目 10^4n
        // 杼は本当はのぎへん
        public static string[] LargeFactors =
        {
            "",
            "万","億","兆","京","垓","(杼)","譲","講","澗","正",
            "載","極","恒河沙","阿僧祇","那由他","不可思議","無量大数"
        };

        // [memo]
        // n番目 10^(7*2^(n-1))
        public static string[] AvataṃsakaSūtraFactors =
        {
            //  "洛叉", // 10^5
            "倶胝",
            "阿庾多",
            "那由他",
            "頻波羅",
            "矜羯羅",
            "阿伽羅",
            "最勝",
            "摩婆羅",
            "阿婆羅",
            "多婆羅",
            "界分",
            "普摩",
            "禰摩",
            "阿婆鈐",
            "弥伽婆",
            "毘攞伽",
            "毘伽婆",
            "僧羯邏摩",
            "毘薩羅",
            "毘贍婆",
            "毘盛伽",
            "毘素陀",
            "毘婆訶",
            "毘薄底",
            "毘贍婆",
            "称量",
            "一持",
            "異路",
            "顛倒",
            "三末耶",
            "毘睹羅",
            "奚婆羅",
            "伺察",
            "周広",
            "高出",
            "最妙",
            "泥羅婆",
            "訶理婆",
            "一動",
            "訶理蒲",
            "訶理三",
            "奚魯伽",
            "達攞歩陀",
            "訶魯那",
            "摩魯陀",
            "懺慕陀",
            "瑿攞陀",
            "摩魯摩",
            "調伏",
            "離憍慢",
            "不動",
            "極量",
            "阿麼怛羅",
            "勃麼怛羅",
            "伽麼怛羅",
            "那麼怛羅",
            "奚麼怛羅",
            "鞞麼怛羅",
            "鉢羅麼怛羅",
            "尸婆麼怛羅",
            "翳羅",
            "薜羅",
            "諦羅",
            "偈羅",
            "窣歩羅",
            "泥羅",
            "計羅",
            "細羅",
            "睥羅",
            "謎羅",
            "娑攞荼",
            "謎魯陀",
            "契魯陀",
            "摩睹羅",
            "娑母羅",
            "阿野娑",
            "迦麼羅",
            "摩伽婆",
            "阿怛羅",
            "醯魯耶",
            "薜魯婆",
            "羯羅波",
            "訶婆婆",
            "毘婆羅",
            "那婆羅",
            "摩攞羅",
            "娑婆羅",
            "迷攞普",
            "者麼羅",
            "駄麼羅",
            "鉢攞麼陀",
            "毘迦摩",
            "烏波跋多",
            "演説",
            "無尽",
            "出生",
            "無我",
            "阿畔多",
            "青蓮華",
            "鉢頭摩",
            "僧祇",
            "趣",
            "至",
            "阿僧祇",
            "阿僧祇転",
            "無量",
            "無量転",
            "無辺",
            "無辺転",
            "無等",
            "無等転",
            "不可数",
            "不可数転",
            "不可称",
            "不可称転",
            "不可思",
            "不可思転",
            "不可量",
            "不可量転",
            "不可説",
            "不可説転",
            "不可説不可説",
            "不可説不可説転", // 10^37218383881977644441306597687849648128
        };
    }
}
