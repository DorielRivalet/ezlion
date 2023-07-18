// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The SR skills list
///</summary>
public static class SkillStyleRank
{
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        //the bonuses totals are:
        //defense+50
        //res+10.
        //all res+5
        //conquest def+200 (300 base at x11 gsr999, +10 per g rank weapon unlock)
        //conquest atk+50 (100 base at x11 gsr999, +5 per g rank weapon unlock)
        { 0, "Nothing" },
        { 1, string.Empty },
        { 2, string.Empty },
        { 3, string.Empty },
        { 4, string.Empty },
        { 5, string.Empty },
        { 6, string.Empty },
        { 7, string.Empty },
        { 8, string.Empty },
        { 9, string.Empty },
        { 10, "Defense+110" },//?
        { 11, "Conquest Def+0" },//+200 at gsr999, +300 at x11 gsr999, goes to 330 with the 3 weapon unlocks at g rank
        { 12, "Conquest Atk+0" },// see above. but with 100 + 5+ 5+5.
        { 13, "Passive Master" },
        { 14, "Soul Revival" },
        { 15, "Secret Tech" },
        { 16, "Sharpening Up" },
        { 17, "Max Sharpen" },
        { 18, string.Empty },
        { 19, string.Empty },
        { 20, string.Empty },
        { 21, string.Empty },
        { 22, string.Empty },
        { 23, string.Empty },
        { 24, string.Empty },
        { 25, string.Empty },
        { 26, string.Empty },
        { 27, "Def+60" },//start
        { 28, string.Empty },
        { 29, string.Empty },
        { 30, string.Empty },
        { 31, "Def+100" },//after nosus. no g rank weps
        { 32, "Def+110" },//after swaxe?. 1 g rank wep.
        { 33, "Def+120" },//120. then 121,... (from bonus) (+10 from magnet spike). 2 g rank weps.
        { 34, "Def+130" },//TODO: needs testing. is at least 140 min. 3 g rank weps. max is 180.
        { 35, string.Empty },
        { 36, string.Empty },
        { 37, string.Empty },
        { 38, string.Empty },
        { 39, string.Empty },
        { 40, string.Empty },
        { 41, string.Empty },
        { 42, string.Empty },
        { 43, string.Empty },
        { 44, "Fire Res+15" },//start
        { 45, string.Empty },
        { 46, string.Empty },
        { 47, string.Empty },
        { 48, "Fire Res+20" },//after hr6
        { 49, "Fire Res+22" },//1 grank wep
        { 50, "Fire Res+24" },//2 grank wep
        { 51, "Fire Res+25" },//3rd grank wep goes by +1.
        { 52, string.Empty },
        { 53, string.Empty },
        { 54, string.Empty },
        { 55, string.Empty },
        { 56, string.Empty },
        { 57, string.Empty },
        { 58, string.Empty },
        { 59, string.Empty },
        { 60, string.Empty },
        { 61, "Water Res+15" },
        { 62, string.Empty },
        { 63, string.Empty },
        { 64, string.Empty },
        { 65, "Water Res+20" },//after nosus
        { 66, "Water Res+22" },
        { 67, "Water Res+24" },
        { 68, "Water Res+25" },
        { 69, string.Empty },
        { 70, string.Empty },
        { 71, string.Empty },
        { 72, string.Empty },
        { 73, string.Empty },
        { 74, string.Empty },
        { 75, string.Empty },
        { 76, string.Empty },
        { 77, string.Empty },
        { 78, "Thunder Res+15" },//start
        { 79, string.Empty },
        { 80, string.Empty },
        { 81, string.Empty },
        { 82, "Thunder Res+20" },
        { 83, "Thunder Res+22" },
        { 84, "Thunder Res+24" },
        { 85, "Thunder Res+25" },
        { 86, string.Empty },
        { 87, string.Empty },
        { 88, string.Empty },
        { 89, string.Empty },
        { 90, string.Empty },
        { 91, string.Empty },
        { 92, string.Empty },
        { 93, string.Empty },
        { 94, string.Empty },
        { 95, "Ice Res+15" },
        { 96, string.Empty },
        { 97, string.Empty },
        { 98, string.Empty },
        { 99, "Ice Res+20" },
        { 100, "Ice Res+22" },
        { 101, "Ice Res+24" },
        { 102, "Ice Res+25" },
        { 103, string.Empty },
        { 104, string.Empty },
        { 105, string.Empty },
        { 106, string.Empty },
        { 107, string.Empty },
        { 108, string.Empty },
        { 109, string.Empty },
        { 110, string.Empty },
        { 111, string.Empty },
        { 112, "Dragon Res+15" },
        { 113, string.Empty },
        { 114, string.Empty },
        { 115, string.Empty },
        { 116, "Dragon Res+20" },
        { 117, "Dragon Res+22" },
        { 118, "Dragon Res+24" },
        { 119, "Dragon Res+25" },
        { 120, string.Empty },
        { 121, string.Empty },
        { 122, string.Empty },
        { 123, string.Empty },
        { 124, "All Res+7" },
        { 125, string.Empty },//untested
        { 126, string.Empty },//untested
        { 127, "All Res+10" },//from 7 to 10. after hr6.
        { 128, "All Res+12" },//1st g rank wep
        { 129, "All Res+14" },//2nd g rank wep
        { 130, "All Res+15" },//3rd g rank wep
        { 131, string.Empty },
        { 132, string.Empty },
        { 133, string.Empty },
        { 134, string.Empty },
        { 135, string.Empty },
        { 136, string.Empty },
        { 137, string.Empty },
        { 138, string.Empty },
        { 139, string.Empty },
        { 140, string.Empty },
        { 141, string.Empty },
        { 142, string.Empty },
        { 143, string.Empty },
        { 144, string.Empty },
        { 145, string.Empty },
        { 146, string.Empty },
        { 147, string.Empty },
        { 148, string.Empty },
        { 149, string.Empty },
        { 150, string.Empty },
        { 151, string.Empty },
        { 152, string.Empty },
        { 153, string.Empty },
        { 154, string.Empty },
        { 155, "Affinity+20" },//everything in this dictionary needs testing  
        { 156, "Affinity+22" },
        { 157, "Affinity+24" },
        { 158, "Affinity+26" },
    });
};
