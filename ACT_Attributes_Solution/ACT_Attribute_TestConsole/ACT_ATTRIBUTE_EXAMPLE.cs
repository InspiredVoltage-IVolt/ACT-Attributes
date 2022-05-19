using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACT.Core.Attributes.Developer;

namespace ACT.TestConsole.Attribute
{
    [DevTask( ClassName = "ACT_ATTRIBUTE_EXAMPLE", Last_Developer_Info = "Mark Alicz", Original_Developer_Info = "Mark Alicz", Priority = 1)]
    public class ACT_ATTRIBUTE_EXAMPLE
    {
        public static Dictionary<string, string> GetAllAttributes<T>(T ClassObj)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();

            foreach (var AttrBD in typeof(T).GetCustomAttributesData())
            {
                string _AType = AttrBD.AttributeType.FullName;
                attributes.Add("Attribute-Type", _AType);

                foreach (var NArg in AttrBD.NamedArguments)
                {
                    attributes.Add(_AType + "::" + NArg.MemberName, NArg.TypedValue.Value.ToString());
                }
            }

            return attributes;
        }
    }
}
