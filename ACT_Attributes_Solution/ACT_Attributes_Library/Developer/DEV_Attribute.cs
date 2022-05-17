using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Attributes.Developer
{
    [System.AttributeUsage(System.AttributeTargets.Class | AttributeTargets.Assembly, Inherited = false, AllowMultiple = true)]
    public class DevTask : Attribute
    {
        #region Constructor
        public DevTask() { }
        #endregion

        [JsonProperty("class-name", NullValueHandling = NullValueHandling.Ignore)]
        public string ClassName { get; set; }

        [JsonProperty("return-type-name", NullValueHandling = NullValueHandling.Ignore)]
        public string Return_Type_Name { get; set; }

        [JsonProperty("todo", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDo { get; set; }

        [JsonProperty("todo-description", NullValueHandling = NullValueHandling.Ignore)]
        public string ToDo_Description { get; set; }

        [JsonProperty("remove-before-release", NullValueHandling = NullValueHandling.Ignore)]
        public string Remove_Before_Release { get; set; }

        [JsonProperty("remove-before-release_description", NullValueHandling = NullValueHandling.Ignore)]
        public string Remove_Before_Release_Description { get; set; }

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Include)]
        public int Priority { get; set; }

        [JsonProperty("original-developer-info", NullValueHandling = NullValueHandling.Ignore)]
        public string Original_Developer_Info { get; set; }

        [JsonProperty("last-developer-info", NullValueHandling = NullValueHandling.Ignore)]
        public string Last_Developer_Info { get; set; }

        public static DevTask FromJson(string json) => JsonConvert.DeserializeObject<DevTask>(json, Converter.Settings);

        public string ToJson() => JsonConvert.SerializeObject(this, Converter.Settings);

        internal static class Converter
        {
            public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
            {
                MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                DateParseHandling = DateParseHandling.None,
                Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
            };
        }

    }
}
