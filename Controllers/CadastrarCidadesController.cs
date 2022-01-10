#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AgenciaExplorer.Models;

namespace AgenciaExplorer.Controllers
{
    public class CadastrarCidadesController : Controller
    {
        private readonly Context _context;

        public CadastrarCidadesController(Context context)
        {
            _context = context;
        }

        // GET: CadastrarCidades
        public async Task<IActionResult> Index()
        {
            return View(await _context.cadastrarCidades.ToListAsync());
        }

        // GET: CadastrarCidades/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastrarCidade = await _context.cadastrarCidades
                .FirstOrDefaultAsync(m => m.Id_Cidade == id);
            if (cadastrarCidade == null)
            {
                return NotFound();
            }

            return View(cadastrarCidade);
        }

        // GET: CadastrarCidades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastrarCidades/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id_Cidade,Nome_Cidade,Valor,Moeda")] CadastrarCidade cadastrarCidade)
        {
            _context.Add(cadastrarCidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: CadastrarCidades/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastrarCidade = await _context.cadastrarCidades.FindAsync(id);
            if (cadastrarCidade == null)
            {
                return NotFound();
            }
            return View(cadastrarCidade);
        }

        // POST: CadastrarCidades/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id_Cidade,Nome_Cidade,Valor,Moeda")] CadastrarCidade cadastrarCidade)
        {
            if (id != cadastrarCidade.Id_Cidade)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastrarCidade);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastrarCidadeExists(cadastrarCidade.Id_Cidade))
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
            return View(cadastrarCidade);
        }

        // GET: CadastrarCidades/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastrarCidade = await _context.cadastrarCidades
                .FirstOrDefaultAsync(m => m.Id_Cidade == id);
            if (cadastrarCidade == null)
            {
                return NotFound();
            }

            return View(cadastrarCidade);
        }

        // POST: CadastrarCidades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastrarCidade = await _context.cadastrarCidades.FindAsync(id);
            _context.cadastrarCidades.Remove(cadastrarCidade);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastrarCidadeExists(int id)
        {
            return _context.cadastrarCidades.Any(e => e.Id_Cidade == id);
        }
    }
}
