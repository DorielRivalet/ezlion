// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The weapon class list
///</summary>
public static class WeaponClass
{
    /// <summary>
    /// Gets the name of the identifier.
    /// </summary>
    /// <value>
    /// The name of the identifier.
    /// </value>
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        { 0, "Blademaster" },
        { 1, "Gunner" },
        { 2, "Blademaster" },
        { 3, "Blademaster" },
        { 4, "Blademaster" },
        { 5, "Gunner" },
        { 6, "Blademaster" },
        { 7, "Blademaster" },
        { 8, "Blademaster" },
        { 9, "Blademaster" },
        { 10, "Gunner" },
        { 11, "Blademaster" },
        { 12, "Blademaster" },
        { 13, "Blademaster" },
    });
};
