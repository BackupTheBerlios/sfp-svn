#region Using directives

using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace SFP.Core.Module.Interfaces
{
    public interface IConnectable
    {
        void RaiseSuiteEvent(String Text);
    }
}
