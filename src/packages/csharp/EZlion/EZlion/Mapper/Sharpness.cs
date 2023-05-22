using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZlion.Mapper
{
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
        public static IReadOnlyDictionary<int, string> IDName { get; } = new Dictionary<int, string>
        {
            {0, "Red"},
            {1, "Orange"},
            {2, "Yellow"},
            {3, "Green"},
            {4, "Blue"},
            {5, "White"},
            {6, "Purple"},
            {7, "Cyan"}
        };
    };
}
