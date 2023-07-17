// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The weapon types list
///</summary>
public static class WeaponType
{
    /// <summary>
    /// Gets the name of the identifier.
    /// </summary>
    /// <value>
    /// The name of the identifier.
    /// </value>
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        { 0, "Great Sword" },
        { 1, "Heavy Bowgun" },
        { 2, "Hammer" },
        { 3, "Lance" },
        { 4, "Sword and Shield" },
        { 5, "Light Bowgun" },
        { 6, "Dual Swords" },
        { 7, "Long Sword" },
        { 8, "Hunting Horn" },
        { 9, "Gunlance" },
        { 10, "Bow" },
        { 11, "Tonfa" },
        { 12, "Switch Axe F" },
        { 13, "Magnet Spike" },
        { 14, "Group" },
    });
};
