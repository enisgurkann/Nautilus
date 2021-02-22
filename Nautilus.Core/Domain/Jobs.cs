using Nautilus.Core.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace Nautilus.Core.Domain
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }


        public ServisType SourceType { get; set; }
        public string SourceConnection { get; set; }


        public ServisType TargetType { get; set; }
        public string TargetConnection { get; set; }

        public DateTime CreatedDate  { get; set; }
        public DateTime LastExecDate { get; set; }

    }
}
