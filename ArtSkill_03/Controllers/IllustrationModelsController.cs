#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ArtSkill_03.Data;
using ArtSkill_03.Models;

namespace ArtSkill_03.Controllers
{
    public class IllustrationModelsController : Controller
    {
        private readonly ArtSkill_03Context _context;

        public IllustrationModelsController(ArtSkill_03Context context)
        {
            _context = context;
        }

        // GET: IllustrationModels
        public async Task<IActionResult> Index(string searchString)
        {
            var illustrations = from m in _context.IllustrationModel
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                illustrations = illustrations.Where(s => s.Name!.Contains(searchString));
            }

            return View(await illustrations.ToListAsync());
        }
        public async Task<IActionResult> List(string searchString)
        {
            var illustrations = from m in _context.IllustrationModel
                                select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                illustrations = illustrations.Where(s => s.Name!.Contains(searchString));
            }

            return View(await illustrations.ToListAsync());
        }
        // GET: IllustrationModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illustrationModel = await _context.IllustrationModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (illustrationModel == null)
            {
                return NotFound();
            }

            return View(illustrationModel);
        }

        // GET: IllustrationModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: IllustrationModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,shortDesc,longDesc,ReleaseDate,Category,img,Price")] IllustrationModel illustrationModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(illustrationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(illustrationModel);
        }

        // GET: IllustrationModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illustrationModel = await _context.IllustrationModel.FindAsync(id);
            if (illustrationModel == null)
            {
                return NotFound();
            }
            return View(illustrationModel);
        }

        // POST: IllustrationModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,shortDesc,longDesc,ReleaseDate,Category,img,Price")] IllustrationModel illustrationModel)
        {
            if (id != illustrationModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(illustrationModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IllustrationModelExists(illustrationModel.Id))
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
            return View(illustrationModel);
        }

        // GET: IllustrationModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var illustrationModel = await _context.IllustrationModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (illustrationModel == null)
            {
                return NotFound();
            }

            return View(illustrationModel);
        }

        // POST: IllustrationModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var illustrationModel = await _context.IllustrationModel.FindAsync(id);
            _context.IllustrationModel.Remove(illustrationModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IllustrationModelExists(int id)
        {
            return _context.IllustrationModel.Any(e => e.Id == id);
        }
    }
}
