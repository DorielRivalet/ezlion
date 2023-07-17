// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

///<summary>
///The sharpness list
///</summary>
public static class Sharpness
{
    /// <summary>
    /// Gets the name of the identifier.
    /// </summary>
    /// <value>
    /// The name of the identifier.
    /// </value>
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        { 0, "Red" },
        { 1, "Orange" },
        { 2, "Yellow" },
        { 3, "Green" },
        { 4, "Blue" },
        { 5, "White" },
        { 6, "Purple" },
        { 7, "Cyan" },
    });
};
