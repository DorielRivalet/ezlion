﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZlion.Mapper
{
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
        public static IReadOnlyDictionary<int, string> IDName { get; } = new Dictionary<int, string>
        {
            {0, "None"},
            {1, "Attack"},
            {2, "Defense"},
            {3,""},
            {4,""},
            {5,"Recovery"},
            {6,""},
            {7,""},
            {8,""},
            {9,""},
            {10,""},
            {11,"" },
            {12,""},
            {13,""},
            {14,"Care"},
            {15,"Pharmacist"},
            {16,""},
            {17,""},
            {18,"Virus Res."},
            {19,"Guardian Offense"},
            {20,"Guardian Defense"},
            {21,""},
            {22,"Frost Res."},
            {23,"Fire Res"},
            {24,"Water Res"},
            {25,"Ice Res"},
            {26,"Thunder Res"},
            {27,"Dragon Res"},
            {28,"Dragon Res"},
            {29,"Rd P Up"},
            {30,"Revival Sage"},
            {31,"Advancement Guru"},
            {32,"Last Stand"},
            {33,"Bonus Encounter"},
            {34,"All Res"},
            {35,"Rewards Up"}
        };
    }
}
