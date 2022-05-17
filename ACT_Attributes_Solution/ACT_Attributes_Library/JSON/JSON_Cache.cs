using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Interfaces.Attributes
{
    public class JSON_Data
    {
        public string JSON_Schema_Identifier_DLL = "";
        public string JSON_Schema_Identifier_FullClassName = "";
        public string JSON_Schema_Example_Blank = "";
        public string JSON_Schema_Identifier = "";
        public Dictionary<string, string> JSON_Schema_AdditionalInfo = new Dictionary<string, string>();
        public int DatabaseID;
        public DateTime? UpdateDate = null;
    }

    public static class JSON_Schema_Information_Cache
    {
        public static Dictionary<string, JSON_Data> JSON_Cache = new Dictionary<string, JSON_Data>();

        public static JSON_Data Get_Schema(string Identifier)
        {
            if (JSON_Cache.ContainsKey(Identifier)) { return JSON_Cache[Identifier]; }
            else { return null; }
        }

        public static void AddUpdateSchema(JSON_Data Data)
        {
            if (JSON_Cache.ContainsKey(Data.JSON_Schema_Identifier))
            {
                if (Data.UpdateDate > JSON_Cache[Data.JSON_Schema_Identifier].UpdateDate)
                {
                    JSON_Cache[Data.JSON_Schema_Identifier] = Data;
                }
            }
            else
            {
                JSON_Cache.Add(Data.JSON_Schema_Identifier, Data);
            }
        }

        public static void ClearCache()
        {
            JSON_Cache.Clear();
        }
    }
}
