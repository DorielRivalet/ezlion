// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The halk skill list
///</summary>
public static class SkillHalk
{
    /// <summary>
    /// Gets the name of the identifier.
    /// </summary>
    /// <value>
    /// The name of the identifier.
    /// </value>
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        { 0, "None" },
        { 1, "Large Monster Priority" },
        { 2, "Small Monster Priority" },
        { 3, "Near Hunter Priority" },
        { 4, "Always Aggressive" },
        { 5, "Item Defender" },
        { 6, "Rising Intent" },
        { 7, "Carving Defender" },
        { 8, "Unescapable" },
        { 9, "Health Conscious" },
        { 10, "Helper [Health]" },
        { 11, "Helper [Antidote]" },
        { 12, "Helper [Deoderant]" },
        { 13, "Gook Luck" },
        { 14, "Fast Riser" },
        { 15, "Bomber" },
        { 16, "Unflinching" },
        { 17, "Monster Spotter" },
        { 18, "Mapper" },
        { 19, "Breath Ball Attack" },
        { 20, "Claw Attack Focus" },
        { 21, "More Pugi Appearances" },
        { 22, "Flying Wyvern Offense" },
        { 23, "Fanged Beast Offense" },
        { 24, "Piscine Offense" },
        { 25, "Carapaceon Offense" },
        { 26, "Bird Wyvern Offense" },
        { 27, "Elder Dragon Offense" },
        { 28, "Elemental Beam Attack" },
        { 29, "Demon Drug Dust" },
        { 30, "Armour Drug Dust" },
        { 31, "Affinity Added" },
        { 32, "Improve Status Attack" },
        { 33, "Improve Evasion" },
        { 34, "Improve Attack" },
        { 35, "Signal to Halt Attacks" },
        { 36, "Improve Fire Element" },
        { 37, "Improve Ice Element" },
        { 38, "Improve Water Element" },
        { 39, "Improve Thunder Element" },
        { 40, "Improve Dragon Element" },
        { 41, "Small Bomber" },
        { 42, "Supporter" },
        { 43, "Elemental Bite" },
        { 44, "Brute Wyvern Offense" },
        { 45, "Breath Ball Support" },
        { 46, "Attack Focus" },
        { 47, "Defence Focus" },
        { 48, "Jungle Attack" },
        { 49, "Desert Attack" },
        { 50, "Swamp Attack" },
        { 51, "Snowy Mountains Attack" },
        { 52, "Volcano Attack" },
        { 53, "Tower Attack" },
        { 54, "Forest and Hills Attack" },
        { 55, "Great Forest Attack" },
        { 56, "Arena Attack" },
        { 57, "Gorge Attack" },
        { 58, "Highlands Attack" },
        { 59, "Tidal Island Attack" },
        { 60, "Wind Pressure" },
        { 61, "Earplugs" },
        { 62, "Lone Attack" },
        { 63, "Party Attack" },
        { 64, "Gathering Affection" },
        { 65, "Danger Affection" },
        { 66, "Secret Area Affection" },
        { 67, "Leviathan Offense" },
        { 68, "Rapid Breath Attack" },
        { 69, "Empower Attack and Def" },
        { 70, "Charging Attack" },
        { 71, "Smash Attack" },
        { 72, "Polar Sea Attack" },
        { 73, "Summer Assault" },
        { 74, "Winter Assault" },
        { 75, "Contain Monster" },
        { 76, "Swift Battle" },
        { 77, "Long Battle" },
        { 78, "Fanged Wyvern Offense" },
        { 79, "Flower Field Attack" },
        { 80, "White Lake Attack" },
        { 81, "Painted Falls Attack" },
    });
};
