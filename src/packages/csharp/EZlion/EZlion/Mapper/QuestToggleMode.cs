// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The toggle mode list
///</summary>
public static class QuestToggleMode
{
    /// <summary>
    /// Gets the name of the identifier.
    /// </summary>
    /// <value>
    /// The name of the identifier.
    /// </value>
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        { 0, "Normal" },
        { 1, "Hardcore" },
        { 3, "Unlimited" },
    });
}
