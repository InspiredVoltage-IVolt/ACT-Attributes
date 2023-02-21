using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace ACT.Core.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = true, AllowMultiple = false)]
    public abstract class ACT_Attribute : Attribute
    {
        public event EventHandler<ACT_Attribute> OnDetected;

    }
}
