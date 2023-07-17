using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZlion.Mapper
{
    ///<summary>
    ///The objective type list
    ///</summary>
    public static class ObjectiveType
    {
        /// <summary>
        /// Gets the name of the identifier.
        /// </summary>
        /// <value>
        /// The name of the identifier.
        /// </value>
        public static IReadOnlyDictionary<int, string> IDName { get; } = new Dictionary<int, string>
        {
            { 0x0, "Nothing" },
            { 0x1, "Hunt" },
            { 0x101, "Capture" },
            { 0x201, "Slay" },
            { 0x8004, "Damage" },
            { 0x18004, "Slay or Damage" },
            { 0x40000, "Slay All" },
            { 0x20000, "Slay Total" },
            { 0x02, "Deliver" },
            { 0x4004, "Break Part" },
            { 0x1002, "Deliver Flag" },
            { 0x10, "Esoteric Action" } //what is this for?
        };
    };
}
