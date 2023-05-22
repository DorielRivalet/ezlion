using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZlion.Mapper
{
    ///<summary>
    ///The weapon styles list
    ///</summary>
    public static class WeaponStyle
    {
        /// <summary>
        /// Gets the name of the identifier.
        /// </summary>
        /// <value>
        /// The name of the identifier.
        /// </value>
        public static IReadOnlyDictionary<int, string> IDName { get; } = new Dictionary<int, string>
        {
            {0, "Earth Style"},
            {1, "Heaven Style"},
            {2, "Storm Style"},
            {3, "Extreme Style"}
        };
    };
}
