using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Knack.NET
{ 
    public class Contact
    {
        public Contact(string field1)
        {
            Field_1 = field1;
        }
        [JsonProperty(PropertyName = "field_1")]
        public string Field_1 { get; set; }

    }
}
