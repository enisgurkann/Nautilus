using System;
using System.Collections.Generic;
using System.Text;

namespace Nautilus.Core.Models
{

    public class ParamModel
    {
        public string Url { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }
        public List<ParamModel> InnerModel { get; set; }
    }

}
