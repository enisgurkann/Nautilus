using Nautilus.Core.Domain;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nautilus.Data
{
    public class JobService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<Jobs[]> GetJobs()
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new Jobs
            {
            }).ToArray());
        }
    }
}
