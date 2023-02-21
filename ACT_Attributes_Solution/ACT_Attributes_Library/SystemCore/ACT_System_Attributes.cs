using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ACT.Core.Attributes.SystemCore
{
    [AttributeUsage(validOn: AttributeTargets.Class)]
    public class ACT_SystemCore_FileType : Attribute
    {
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("typename", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeName { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        [JsonProperty("min_compatible_version", NullValueHandling = NullValueHandling.Ignore)]
        public string Min_Compatible_Version { get; set; }

        /// <summary>
        /// This works off 4 Place Versions
        /// 4.5.22.1 Converts To 04502201 Which is Finalized By Adding a 1 To The Left = 104502201
        /// </summary>
        [JsonIgnore()]
        public int MinCompatibleVersion
        {
            get
            {
                string _TmpReturn = Min_Compatible_Version.Replace(" ", "");

                try
                {
                    string[] Parts = new string[4];
                    string[] _Data = _TmpReturn.Split('.', StringSplitOptions.RemoveEmptyEntries);

                    if (_Data.Count () != 4) { return 0; }
                    if (_Data[0].Length == 1) { Parts[0] = "0" + _Data[0]; } else { Parts[0] = _Data[0]; }
                    if (_Data[1].Length == 1) { Parts[1] = "0" + _Data[1]; } else { Parts[1] = _Data[1]; }
                    if (_Data[2].Length == 1) { Parts[2] = "0" + _Data[2]; } else { Parts[2] = _Data[2]; }
                    if (_Data[3].Length == 1) { Parts[3] = "0" + _Data[3]; } else { Parts[3] = _Data[3]; }

                    _TmpReturn = "";
                    _TmpReturn = "1" + Parts[0] + Parts[1] + Parts[2] + Parts[3];

                    return Convert.ToInt32(_TmpReturn);
                }
                catch
                {
                    // Log Error
                    return 0;
                }
            }
            set
            {
                int _Val = value;
                if (_Val <= 99999999) { throw new Exception("The Integer Must Be Greater Than 99999999"); }
                else
                {
                    string _Data = _Val.ToString();
                    if (_Data.Length != 9) { throw new Exception("This is not a valid number. Max Number Value IS 199999999"); }
                    if (Convert.ToInt32(_Data[0]) != 1) { throw new Exception("This is not a valid number. Max Number Value IS 199999999"); }

                    string[] Parts = new string[4];
                    Parts[0] = _Data[2].ToString() + _Data[3].ToString();
                    Parts[1] = _Data[4].ToString() + _Data[5].ToString();
                    Parts[2] = _Data[6].ToString() + _Data[7].ToString();
                    Parts[3] = _Data[8].ToString() + _Data[9].ToString();

                    Min_Compatible_Version = Parts[0] + Parts[1] + Parts[2] + Parts[3];
                }
            }
        }

        [JsonIgnore()]
        public int CurrentVersion
        {
            get
            {
                string _TmpReturn = Version.Replace(" ", "");

                try
                {
                    string[] Parts = new string[4];
                    string[] _Data = _TmpReturn.Split('.', StringSplitOptions.RemoveEmptyEntries);

                    if (_Data.Count() != 4) { return 0; }
                    if (_Data[0].Length == 1) { Parts[0] = "0" + _Data[0]; } else { Parts[0] = _Data[0]; }
                    if (_Data[1].Length == 1) { Parts[1] = "0" + _Data[1]; } else { Parts[1] = _Data[1]; }
                    if (_Data[2].Length == 1) { Parts[2] = "0" + _Data[2]; } else { Parts[2] = _Data[2]; }
                    if (_Data[3].Length == 1) { Parts[3] = "0" + _Data[3]; } else { Parts[3] = _Data[3]; }

                    _TmpReturn = "";
                    _TmpReturn = "1" + Parts[0] + Parts[1] + Parts[2] + Parts[3];

                    return Convert.ToInt32(_TmpReturn);
                }
                catch
                {
                    // Log Error
                    return 0;
                }
            }
            set
            {
                int _Val = value;
                if (_Val <= 99999999) { throw new Exception("The Integer Must Be Greater Than 99999999"); }
                else
                {
                    string _Data = _Val.ToString();
                    if (_Data.Length != 9) { throw new Exception("This is not a valid number. Max Number Value IS 199999999"); }
                    if (Convert.ToInt32(_Data[0]) != 1) { throw new Exception("This is not a valid number. Max Number Value IS 199999999"); }

                    string[] Parts = new string[4];
                    Parts[0] = _Data[2].ToString() + _Data[3].ToString();
                    Parts[1] = _Data[4].ToString() + _Data[5].ToString();
                    Parts[2] = _Data[6].ToString() + _Data[7].ToString();
                    Parts[3] = _Data[8].ToString() + _Data[9].ToString();

                    Version = Parts[0] + Parts[1] + Parts[2] + Parts[3];
                }
            }
        }
    }
}
