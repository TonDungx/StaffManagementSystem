using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StaffManagementSystem.Data;
using StaffManagementSystem.Models;

namespace StaffManagementSystem.Controllers
{
    public class ShiftSwapsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShiftSwapsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: ShiftSwaps
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.ShiftSwaps.Include(s => s.Employee);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: ShiftSwaps/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shiftSwap = await _context.ShiftSwaps
                .Include(s => s.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shiftSwap == null)
            {
                return NotFound();
            }

            return View(shiftSwap);
        }

        // GET: ShiftSwaps/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id");
            return View();
        }

        // POST: ShiftSwaps/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EmployeeId,RequestedShiftId,ProposedShiftId,IsApproved,RequestDate")] ShiftSwap shiftSwap)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shiftSwap);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", shiftSwap.EmployeeId);
            return View(shiftSwap);
        }

        // GET: ShiftSwaps/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shiftSwap = await _context.ShiftSwaps.FindAsync(id);
            if (shiftSwap == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", shiftSwap.EmployeeId);
            return View(shiftSwap);
        }

        // POST: ShiftSwaps/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EmployeeId,RequestedShiftId,ProposedShiftId,IsApproved,RequestDate")] ShiftSwap shiftSwap)
        {
            if (id != shiftSwap.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shiftSwap);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShiftSwapExists(shiftSwap.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Employees, "Id", "Id", shiftSwap.EmployeeId);
            return View(shiftSwap);
        }

        // GET: ShiftSwaps/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shiftSwap = await _context.ShiftSwaps
                .Include(s => s.Employee)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (shiftSwap == null)
            {
                return NotFound();
            }

            return View(shiftSwap);
        }

        // POST: ShiftSwaps/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shiftSwap = await _context.ShiftSwaps.FindAsync(id);
            if (shiftSwap != null)
            {
                _context.ShiftSwaps.Remove(shiftSwap);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShiftSwapExists(int id)
        {
            return _context.ShiftSwaps.Any(e => e.Id == id);
        }
    }
}
