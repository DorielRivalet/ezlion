// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

/// <summary>
/// Skills from road/duremudira/tower
/// </summary>
public static class SkillRoadTower
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
        { 1, "Attack" },
        { 2, "Defense" },
        { 3, string.Empty },
        { 4, string.Empty },
        { 5, "Recovery" },
        { 6, string.Empty },
        { 7, string.Empty },
        { 8, string.Empty },
        { 9, string.Empty },
        { 10, string.Empty },
        { 11, string.Empty },
        { 12, string.Empty },
        { 13, string.Empty },
        { 14, "Care" },
        { 15, "Pharmacist" },
        { 16, string.Empty },
        { 17, string.Empty },
        { 18, "Virus Res." },
        { 19, "Guardian Offense" },
        { 20, "Guardian Defense" },
        { 21, string.Empty },
        { 22, "Frost Res." },
        { 23, "Fire Res" },
        { 24, "Water Res" },
        { 25, "Ice Res" },
        { 26, "Thunder Res" },
        { 27, "Dragon Res" },
        { 28, "Dragon Res" },
        { 29, "Rd P Up" },
        { 30, "Revival Sage" },
        { 31, "Advancement Guru" },
        { 32, "Last Stand" },
        { 33, "Bonus Encounter" },
        { 34, "All Res" },
        { 35, "Rewards Up" },
    });
}
