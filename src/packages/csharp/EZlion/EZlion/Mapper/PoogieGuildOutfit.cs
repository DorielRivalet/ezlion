// Copyright 2023 Doriel Rivalet
// Use of this source code is governed by a MIT license that can be
// found in the LICENSE file.

namespace EZlion.Mapper;

/// <summary>
/// The poogie guild outfit list.
/// </summary>
public static class PoogieGuildOutfit
{
    /// <summary>
    /// Gets the name of the identifier.
    /// </summary>
    /// <value>
    /// The name of the identifier.
    /// </value>
    public static ReadOnlyDictionary<int, string> IDName { get; } = new(new Dictionary<int, string>
    {
        { 0, "Red & White" },
        { 1, "Naked Emperor" },
        { 2, "Soporific White" },
        { 3, "Black Green Clash" },
        { 4, "Silent Suit" },
        { 5, "Bewitching Pink" },
        { 6, "Nostalgic Stripe" },
        { 7, "Soothing Sky" },
        { 8, "Gentle Green" },
        { 9, "Restless Brown" },
    });
};
