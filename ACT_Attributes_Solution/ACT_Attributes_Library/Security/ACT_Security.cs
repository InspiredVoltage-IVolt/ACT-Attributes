using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Attributes.Security
{
    public class ACT_Encrypt : Attribute
    {
        string _EncryptionPattern = "secure,secret,password,encrypted";
        bool _EncryptAll = false;
        bool _UseInternalEncryption = true;
        string _EncryptionKeySource = "";        

        /// <summary>
        /// Encrypt All Properties and Fields
        /// </summary>
        public bool EncryptAll { get { return _EncryptAll; } set { _EncryptAll = value; } }

        /// <summary>
        /// Pattern to Look For In Properties and Fields.  If Found Encrypt At Rest
        /// Default = "secure,secret,password,encrypted"
        /// </summary>
        public string EncryptionPattern { get { return _EncryptionPattern; } set { _EncryptionPattern = value; } }

        /// <summary>
        /// USE INTERNAL ENCRYPTION - Fastest Way
        /// </summary>
        public bool UseInternalEncryption { get { return _UseInternalEncryption; } set { _UseInternalEncryption = value; } }

        /// <summary>
        /// Options Are (ACT Key, SystemConfiguration)
        /// </summary>
        public string EncryptionKeySource { get => _EncryptionKeySource; set => _EncryptionKeySource = value; }                
    }
}
