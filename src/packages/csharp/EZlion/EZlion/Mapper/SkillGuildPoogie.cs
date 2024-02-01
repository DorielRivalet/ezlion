// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The guild poogie skill list.
///</summary>
public static class SkillGuildPoogie
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
        { 1, "Poogie Thrift" },
        { 2, "Poogie Discount" },
        { 3, "Poogie Taijutsu" },
        { 4, "Poogie Status Attack" },
        { 5, "Poogie Reward Technique" },
        { 6, "Poogie Defense" },
        { 7, "Poogie Escape Technique" },
        { 8, "Poogie Transporation" },
        { 9, "Poogie Trap Mastery" },
        { 10, "Poogie Patience" },
    });
};
