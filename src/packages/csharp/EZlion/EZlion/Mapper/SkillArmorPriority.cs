﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZlion.Mapper
{
    ///<summary>
    /// The armor skills priority list
    ///</summary>
    public static class SkillArmorPriority
    {
        /// <summary>
        /// Gets the name of the identifier.
        /// </summary>
        /// <value>
        /// The name of the identifier.
        /// </value>
        public static IReadOnlyDictionary<int, string> IDName { get; } = new Dictionary<int, string>
        {
            { 0, "SnS Tech"},
            { 1, "DS Tech"},
            { 2, "GS Tech"},
            { 3, "LS Tech"},
            { 4, "Hammer Tech"},
            { 5, "HH Tech"},
            { 6, "Lance Tech"},
            { 7, "GL Tech"},
            { 8, "Switch Axe Tech"},
            { 9, "Tonfa Tech"},
            { 10, "Magnet Spike Tech"},
            { 11, "HBG Tech"},
            { 12, "LBG Tech"},
            { 13, "Bow Tech"},
            { 14, "Determination"},
            { 15, "Strong Attack"},
            { 16, "Issen"},
            { 17, "Furious"},
            { 18, "Exploit Weakness"},
            { 19, "Dissolver"},
            { 20, "Thunder Clad"},
            { 21, "Rush"},
            { 22, "Grace"},
            { 23, "Sword God"},
            { 24, "Edgemaster"},
            { 25, "Critical Shot"},
            { 26, "Point Breakthrough"},
            { 27, "Compensation"},
            { 28, "Rapid Fire"},
            { 29, "Three Worlds"},
            { 30, "Reflect"},
            { 31, "Drawing Arts"},
            { 32, "Encourage"},
            { 33, "Steady Hand"},
            { 34, "Mounting"},
            { 35, "Gentle Shot"},
            { 36, "Spacing"},
            { 37, "Combo Expert"},
            { 38, "Shiriagari"},
            { 39, "Lone Wolf"},
            { 40, "Light Tread"},
            { 41, "Vitality"},
            { 42, "Skilled"},
            { 43, "Trained"},
            { 44, "Rage"},
            { 45, "Iron Arm"},
            { 46, "Breeder"},
            { 47, "Survivor"},
            { 48, "Relief"},
            { 49, "Hunter"},
            { 50, "Sobriety"},
            { 51, "Blast Resistance"},
            { 52, "Crystal Res"},
            { 53, "Magnetic Res"},
            { 54, "Freeze Res"},
            { 55, "Evade Distance"},
            { 56, "Charge Attack Up"},
            { 57, "Bullet Saver"},
            { 58, "Movement Speed"},
            { 59, "Reinforcement"},
            { 60, "Vampirism"},
            { 61, "Adaptation"},
            { 62, "Ice Age"},
            { 63, "Vigorous"},
            { 64, "Dark Pulse"},
            { 65, "Herbal Science"},
            { 66, "Incitement"},
            { 67, "Blazing Grace"},
            { 68, "Abnormality"},
            { 69, "Drug Knowledge"},
            { 70, "Status Assault"},
            { 71, "Stylish Assault"},
            { 72, "Stylish"},
            { 73, "Absolute Defense"},
            { 74, "Assistance"},
            { 75, "Combat Supremacy"},
            { 76, "Mindfulness"},
            { 77, "相討ち"},
            { 78, "Weapon Handling"},
            { 79, "Elemental Attack"},
            { 80, "Stamina Recovery"},
            { 81, "Guts"},
            { 82, "Speed Setup"},
            { 83, "Status Res"},
            { 84, "Fencing"},
            { 85, "Knife Throwing"},
            { 86, "Caring"},
            { 87, "Def Lock"},
            { 88, "Para"},
            { 89, "Sleep"},
            { 90, "Stun"},
            { 91, "Poison"},
            { 92, "Deoderant"},
            { 93, "Snowball Res"},
            { 94, "Stealth"},
            { 95, "Health"},
            { 96, "Recovery Speed"},
            { 97, "Lavish Attack"},
            { 98, "Sharpness"},
            { 99, "Artisan"},
            { 100, "Expert"},
            { 101, "Crit Conversion"},
            { 102, "Ceaseless"},
            { 103, "Sharpening"},
            { 104, "Obscurity"},
            { 105, "Fortification"},
            { 106, "Guard"},
            { 107, "Auto-Guard"},
            { 108, "Throwing"},
            { 109, "Reload"},
            { 110, "Sniper"},
            { 111, "Auto-Reload"},
            { 112, "Recoil"},
            { 113, "Normal Shot Up"},
            { 114, "Pierce Shot Up"},
            { 115, "Pellet Shot Up"},
            { 116, "Normal Shot Add"},
            { 117, "Pierce Shot Add"},
            { 118, "Pellet Shot Add"},
            { 119, "Crag Shot Add"},
            { 120, "Cluster Shot Add"},
            { 121, "Status Attack"},
            { 122, "Bomb Boost"},
            { 123, "Hunger"},
            { 124, "Gluttony"},
            { 125, "Attack"},
            { 126, "Defense"},
            { 127, "Protection"},
            { 128, "Hearing Protection"},
            { 129, "Anti-Theft"},
            { 130, "Wide-Area"},
            { 131, "Backpacking"},
            { 132, "All Res Up"},
            { 133, "Fire Res"},
            { 134, "Water Res"},
            { 135, "Ice Res"},
            { 136, "Thunder Res"},
            { 137, "Dragon Res"},
            { 138, "Heat Res"},
            { 139, "Cold Res"},
            { 140, "Wind Pressure"},
            { 141, "Map"},
            { 142, "Gathering"},
            { 143, "Gathering Speed"},
            { 144, "Whim"},
            { 145, "Fate"},
            { 146, "Fishing"},
            { 147, "Psychic"},
            { 148, "Recovery"},
            { 149, "Combining"},
            { 150, "Ammo Combiner"},
            { 151, "Alchemy"},
            { 152, "Evasion Boost"},
            { 153, "Evasion"},
            { 154, "Adrenaline"},
            { 155, "Everlasting"},
            { 156, "Stamina"},
            { 157, "Loading"},
            { 158, "Precision"},
            { 159, "Monster"},
            { 160, "Eating"},
            { 161, "Carving"},
            { 162, "Terrain"},
            { 163, "Quake Res"},
            { 164, "Vocal Chords"},
            { 165, "Cooking"},
            { 166, "Gunnery"},
            { 167, "Flute Expert"},
            { 168, "Breakout"},
            { 169, "Martial Arts"},
            { 170, "Strong Arm"},
            { 171, "Inspiration"},
            { 172, "Passive"},
            { 173, "Bond"},
            { 174, "Pressure"},
            { 175, "Capture Proficiency"},
            { 176, "Poison Coating Add"},
            { 177, "Para Coating Add"},
            { 178, "Sleep Coating Add"},
            { 179, "Fire Attack"},
            { 180, "Water Attack"},
            { 181, "Thunder Attack"},
            { 182, "Ice Attack"},
            { 183, "Dragon Attack"},
            { 184, "Fasting"},
            { 185, "Bomb Sword"},
            { 186, "Power Sword"},
            { 187, "Poison Sword"},
            { 188, "Para Sword"},
            { 189, "Sleep Sword"},
            { 190, "Fire Sword"},
            { 191, "Water Sword"},
            { 192, "Thunder Sword"},
            { 193, "Ice Sword"},
            { 194, "Dragon Sword"},
            { 195, "Focus"}
        };
    };
}
