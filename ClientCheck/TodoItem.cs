using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ClientCheck
{
    public class TodoItem
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        [JsonProperty(PropertyName = "complete")]
        public bool Complete { get; set; }

        //eigen code

        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "SurName")]
        public string SurName { get; set; }

        [JsonProperty(PropertyName = "Adres")]
        public string Adres { get; set; }

        [JsonProperty(PropertyName = "Phone")]
        public int Phone { get; set; }

        [JsonProperty(PropertyName = "Email")]
        public string Email { get; set; }

        
    }
}
