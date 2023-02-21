using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACT.Core.Attributes.JSON;

namespace ACT.Core.Attributes.Developer
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class Developer_Information : Attribute
    {
        public Developer_Information() { }

        [JsonProperty("application_id", NullValueHandling = NullValueHandling.Ignore)]
        public string Application_ID { get; set; }

        [JsonProperty("classname", NullValueHandling = NullValueHandling.Ignore)]
        public string Classname { get; set; }

        [JsonProperty("typename", NullValueHandling = NullValueHandling.Ignore)]
        public string Typename { get; set; }

        [JsonProperty("todo", NullValueHandling = NullValueHandling.Ignore)]
        protected internal bool ToDo { get; set; } = false;

        [JsonProperty("todo_description", NullValueHandling = NullValueHandling.Ignore)]
        protected internal string ToDo_Description { get; set; } = "";

        [JsonProperty("removebeforerelease", NullValueHandling = NullValueHandling.Ignore)]
        protected internal bool RemoveBeforeRelease { get; set; } = false;

        [JsonProperty("removebeforerelease_description", NullValueHandling = NullValueHandling.Ignore)]
        protected internal string RemoveBeforeRelease_Description { get; set; } = "";

        [JsonProperty("priority", NullValueHandling = NullValueHandling.Ignore)]
        public int Priority { get; set; } = 0;

        //JSON Export Of the Original Entry"
        [JsonProperty("original_developer_info", NullValueHandling = NullValueHandling.Ignore)]
        public string Original_Developer_Info { get; set; } = "";

        // string i.e "John Prine, JohnPrineForever@goofmail.com"
        [JsonProperty("last_developer_info", NullValueHandling = NullValueHandling.Ignore)]
        public string Last_Developer_Info { get; set; } = "";

        //public static Attribute_Single_Development_Definition ToDevelopmentDefinition(Developer_Information DeveloperInformationInstance, string ClassName, string TypeName)
        //{
        //    Attribute_Single_Development_Definition TmpReturn = new Attribute_Single_Development_Definition
        //    {
        //        Classname = ClassName,
        //        Typename = TypeName,
        //        Todo = DeveloperInformationInstance.ToDo.ToString(),
        //        Todo_Description = DeveloperInformationInstance.ToDo_Description.ToString(),
        //        Removebeforerelease = DeveloperInformationInstance.RemoveBeforeRelease.ToString(),
        //        Removebeforerelease_Description = DeveloperInformationInstance.RemoveBeforeRelease_Description.ToString(),
        //        Priority = DeveloperInformationInstance.Priority,
        //        Originadeveloperinfo = DeveloperInformationInstance.Original_Developer_Info.ToString(),
        //        Lastdeveloperinfo = DeveloperInformationInstance.Last_Developer_Info.ToString()
        //    };

        //    return TmpReturn;
        //}

        public string ToJson()
        {
	        return JsonConvert.SerializeObject(this, DefaultConverter.Settings);
        }

        public static Developer_Information FromJson(string json)
        {
	        return JsonConvert.DeserializeObject<Developer_Information>(json, DefaultConverter.Settings);
        }
    }
}
