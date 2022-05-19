using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Attributes
{
    public class ACT_AttributeMaster
    {
        public static Dictionary<string, string> GetAllAttributes<T>(T ClassObj)
        {
            Dictionary<string, string> attributes = new Dictionary<string, string>();

            foreach(var AttrBD in typeof(T).GetCustomAttributesData())
            {
                string _AType = AttrBD.AttributeType.FullName;
                attributes.Add("Attribute-Type", _AType);

                foreach(var NArg in AttrBD.NamedArguments)
                {
                    attributes.Add(_AType + "::" + NArg.MemberName, NArg.TypedValue.Value.ToString());
                }
            }

            return attributes;
        }
    }
}
