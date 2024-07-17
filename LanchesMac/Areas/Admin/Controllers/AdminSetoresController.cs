using rginfra.Context;
using rginfra.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace rginfra.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class AdminSetoresController : Controller
    {
        private readonly AppDbContext _context;

        public AdminSetoresController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Admin/AdminSetores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Setores.ToListAsync());
        }

        // GET: Admin/AdminSetores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _context.Setores
                .FirstOrDefaultAsync(m => m.SetorId == id);
            if (setor == null)
            {
                return NotFound();
            }

            return View(setor);
        }

        // GET: Admin/AdminSetores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/AdminSetores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SetorId,DescricaoSetor,Ativo")] Setor setor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(setor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(setor);
        }

        // GET: Admin/AdminSetores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _context.Setores.FindAsync(id);
            if (setor == null)
            {
                return NotFound();
            }
            return View(setor);
        }

        // POST: Admin/AdminSetores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("setorId,setorNome,Descricao")] Setor setor)
        {
            if (id != setor.SetorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(setor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!setorExists(setor.SetorId))
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
            return View(setor);
        }

        // GET: Admin/AdminSetores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var setor = await _context.Setores
                .FirstOrDefaultAsync(m => m.SetorId == id);
            if (setor == null)
            {
                return NotFound();
            }

            return View(setor);
        }

        // POST: Admin/AdminSetores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var setor = await _context.Setores.FindAsync(id);
            _context.Setores.Remove(setor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool setorExists(int id)
        {
            return _context.Setores.Any(e => e.SetorId == id);
        }
    }
}
