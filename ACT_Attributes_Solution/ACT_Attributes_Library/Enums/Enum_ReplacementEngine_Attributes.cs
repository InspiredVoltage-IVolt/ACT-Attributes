using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Attributes.Enums
{
    #region Enum_ReplacementEngine_Attribute Documentation
    /// Class:  Enum_ReplacementEngine_Attributes
    /// Summary:    An enum replacement engine attributes.
    /// Author: Mark Alicz
    /// Date:   2/6/2023
    #endregion
    [AttributeUsage(AttributeTargets.Enum, Inherited = false, AllowMultiple = true)]
    public class Enum_ReplacementEngine_Attribute : System.Attribute
    {
        public int DefinedParameters { get; set; }
        
        public string JSONConfiguration { get; set; }

        public string PluginDefinition_JSON_Type { get; set; }


    }
}
