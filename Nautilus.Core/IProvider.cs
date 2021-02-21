using Nautilus.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nautilus.Core
{
    public interface IProvider
    {
        public List<ParamModel> Get;
    }
}
