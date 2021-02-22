using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nautilus.Core.Domain
{
    public class JobStepParams
    {
        [Key]
        public int Id { get; set; }
        public int JobId { get; set; }

        public string SourceColumnName { get; set; }
        public string TargetColumnName { get; set; }


        public bool IsManuel { get; set; }
        public string ManuelValue { get; set; }


    }
}
