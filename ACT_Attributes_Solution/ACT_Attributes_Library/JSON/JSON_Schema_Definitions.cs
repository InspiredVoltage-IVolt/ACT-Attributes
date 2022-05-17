using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes
{
    [System.AttributeUsage(System.AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class JSON_Schema_Definitions : Attribute
    {
        private string _JSON_Schema_Identifier;
        private int _NamedInt;

        /// <summary>
        /// This is a JSON Schema Definitions
        /// </summary>
        /// <param name="JSON_Schema_Identifier"></param>
        public JSON_Schema_Definitions(string JSON_Schema_Identifier)
        {
            this._JSON_Schema_Identifier = JSON_Schema_Identifier;
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

        /// <summary>
        /// Process the Positional String
        /// </summary>
        private void ProcessPositionalString()
        {
            // Connect To API If Cache Doesnt Contain Schema
        }
    }    
}
