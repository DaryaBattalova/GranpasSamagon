using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GrandpasSamagon.Models
{
    public class SugarInfo
    {
        /// <summary>
        /// Gets or sets a total weight of a sugar needed.
        /// </summary>
        public int WeightNeeded { get; set; }

        /// <summary>
        /// Gets or sets an array of sugar sacks weight.
        /// </summary>
        public string WeightArray { get; set; }
    }
}