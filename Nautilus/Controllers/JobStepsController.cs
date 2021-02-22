using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nautilus;
using Nautilus.Core.Domain;

namespace Nautilus.Controllers
{
    public class JobStepsController : Controller
    {
        private readonly DataContext _context;

        public JobStepsController(DataContext context)
        {
            _context = context;
        }

        // GET: JobSteps
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobSteps.ToListAsync());
        }
        public async Task<IActionResult> JobIndex(int? id)
        {
            return View("Index",await _context.JobSteps.Where(s=> s.JobId == id).ToListAsync());
        }
        // GET: JobSteps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSteps = await _context.JobSteps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSteps == null)
            {
                return NotFound();
            }

            return View(jobSteps);
        }

        // GET: JobSteps/Create
        public IActionResult Create(int id)
        {
            JobSteps steps = new JobSteps();
            steps.JobId = id;
            return View(steps);
        }

        // POST: JobSteps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JobId,Title,SourceType,SourceConnection,TargetType,TargetConnection")] JobSteps jobSteps)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobSteps);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobSteps);
        }

        // GET: JobSteps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSteps = await _context.JobSteps.FindAsync(id);
            if (jobSteps == null)
            {
                return NotFound();
            }
            return View(jobSteps);
        }

        // POST: JobSteps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JobId,Title,SourceType,SourceConnection,TargetType,TargetConnection")] JobSteps jobSteps)
        {
            if (id != jobSteps.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobSteps);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobStepsExists(jobSteps.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(jobSteps);
        }

        // GET: JobSteps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSteps = await _context.JobSteps
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSteps == null)
            {
                return NotFound();
            }

            return View(jobSteps);
        }

        // POST: JobSteps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobSteps = await _context.JobSteps.FindAsync(id);
            _context.JobSteps.Remove(jobSteps);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobStepsExists(int id)
        {
            return _context.JobSteps.Any(e => e.Id == id);
        }
    }
}
