using ACT.Core.Interfaces.Data.JSON_Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class JSON_Schema_ReturnInfo : Attribute
    {
        private string _JSON_Schema_Identifier_DLL = "";
        private string _JSON_Schema_Identifier_FullClassName = "";
        private string _JSON_Schema_Example_Blank = "{\"Common\"}";
        private string _JSON_Schema_Identifier = "CommonNameValue";
        private int _NamedInt;

        /// <summary>
        /// This is a JSON Schema Definitions
        /// </summary>
        /// <param name="JSON_Schema_Identifier"></param>
        public JSON_Schema_ReturnInfo(string JSON_Schema_Identifier, string ImplementationPluginJSONIdentifier = "")
        {
           // I_PluginDefinition _PluginParser = ACT.
            this._JSON_Schema_Identifier = JSON_Schema_Identifier;
          //  this._JSON_Schema_Identifier_DLL = DLLName;
          //  this._JSON_Schema_Identifier_FullClassName = FullClassName;

        }

        /// <summary>
        /// JSON Schema Identifier
        /// </summary>
        public string JSON_Schema_Identifier
        {
            get { return _JSON_Schema_Identifier; }
        }

        /// <summary>
        /// JSON Schema Identifier
        /// </summary>
        public int NamedInt { get { return _NamedInt; } }

        public string JSON_Schema_Identifier_DLL { get => _JSON_Schema_Identifier_DLL; }
        public string JSON_Schema_Identifier_FullClassName { get => _JSON_Schema_Identifier_FullClassName; }
        public string JSON_Schema_Example_Blank { get => _JSON_Schema_Example_Blank; }

        /// <summary>
        /// Process the Positional String
        /// </summary>
        private void ProcessPositionalString()
        {
            // Connect To API If Cache Doesnt Contain Schema
        }
    }    
}
