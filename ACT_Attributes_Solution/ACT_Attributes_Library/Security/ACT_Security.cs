using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACT.Core.Enums.Security;

namespace ACT.Core.Enums.Security
{
    public enum AttributeEncryptionPattern
    {
        MachineSecure, UserSecure, Secret, Password, Encrypted
    }

    public enum AttributeKeySource
    {
        Internal_Key, 
        SystemConfiguration,
        User_Provided_Key
    }
}

namespace ACT.Core.Attributes.Security
{
    public class ACT_Encrypt : Attribute
    {
        private ACT.Core.Enums.Security.AttributeEncryptionPattern _EncryptPattern = AttributeEncryptionPattern.MachineSecure;
        private ACT.Core.Enums.Security.AttributeKeySource _KeySource = AttributeKeySource.SystemConfiguration;
        private string _EncryptionPattern = "secure,secret,password,encrypted";
        private bool _EncryptAll = false;
        private bool _UseInternalEncryption = true;
        private string _EncryptionKeySource = "";

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
        /// Defined Using Enum
        /// </summary>
        public ACT.Core.Enums.Security.AttributeEncryptionPattern EncryptPattern { get { return _EncryptPattern; } set { _EncryptPattern = value; } }

        /// <summary>
        /// USE INTERNAL ENCRYPTION - Fastest Way
        /// </summary>
        public bool UseInternalEncryption { get { return _UseInternalEncryption; } set { _UseInternalEncryption = value; } }

        /// <summary>
        /// Options Are (ACT Key, SystemConfiguration)
        /// </summary>
        public string EncryptionKeySource { get { return _EncryptionKeySource; } set { _EncryptionKeySource = value; } }

        /// <summary>
        /// Options Are (ACT Key, SystemConfiguration)
        /// </summary>
        public AttributeKeySource KeySource { get { return _KeySource; } set { _KeySource = value; } }
    }
}
