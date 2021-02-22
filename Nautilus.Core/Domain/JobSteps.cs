using Nautilus.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Nautilus.Core.Domain
{
    public class JobSteps
    {
        [Key]
        public int Id { get; set; }
        public int JobId { get; set; }
        public string Title { get; set; }

        public ServisType SourceType { get; set; }
        public string SourceConnection { get; set; }


        public ServisType TargetType { get; set; }
        public string TargetConnection { get; set; }


    }
}
