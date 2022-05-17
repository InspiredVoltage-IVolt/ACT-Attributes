using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACT.Core.Attributes.History
{
    public class ACT_Attribute_History : ACT_Attribute
    {
        public ACT_Attribute_History()
        {
            this.OnDetected += ACT_Attribute_History_OnDetected;
        }

        private void ACT_Attribute_History_OnDetected(object sender, ACT_Attribute e)
        {
            // GrabLastHash
        }
    }
}
