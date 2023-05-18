using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZlion
{
    /// <summary>
    /// Item (potions, decorations, etc.)
    /// </summary>
    public class Item
    {
        /// <summary>
        /// The ID of the item
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; } = 0;

        /// <summary>
        /// The name of the item
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The flavor text of the item
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; } = string.Empty;
    }

    /// <summary>
    /// List of Items
    /// </summary>
    public static class Items
    {
        /// <summary>
        /// Gets a JSON string representation of the object
        /// </summary>
        /// <returns>A JSON string representation of the object</returns>
        public static string GetJson()
        {
            var items = new List<Item>
            {
                new Item { Id = 0, Name = "None", Description = "No Item" },
                // Add more items as needed
            };

            return JsonConvert.SerializeObject(items);
        }
    }
}
