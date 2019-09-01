using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knack.NET.Models
{
    public class RecordBase
    {
        [JsonProperty(PropertyName = "total_pages")]
        public string Total_Pages { get; set; }

        [JsonProperty(PropertyName = "current_page")]
        public string Current_Page { get; set; }

        [JsonProperty(PropertyName = "total_records")]
        public string Total_Records { get; set; }

        [JsonProperty(PropertyName = "records")]
        public List<Contact> Records { get; set; }

    }
}
