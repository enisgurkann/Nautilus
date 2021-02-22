using System;
using System.ComponentModel.DataAnnotations;

namespace Nautilus.Core.Domain
{
    public class Jobs
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate  { get; set; }
        public DateTime LastExecDate { get; set; }

    }
}
