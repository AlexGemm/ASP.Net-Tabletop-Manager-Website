using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DnDWebsite.Data;
using DnDWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace DnDWebsite.Controllers
{
    public class StatblocksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public StatblocksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Statblocks
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var model = await _context.Statblock
                            .Where(a => a.ApplicationUser.Id == HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value)
                            .ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> SearchItems()
        {
            return View();
        }

        public async Task<IActionResult> ShowSearchResults(String SearchPhrase)
        {
            //Return a list from index where 
            return View("Index", await _context.Statblock.Where(j => j.Name.Contains(SearchPhrase) && j.ApplicationUser.Id == HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value).ToListAsync());
        }

        // GET: Statblocks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Statblocks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,AC,Shield,Health,Speed,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,SavingThrows,Resistances,Immunities,Vulnerabilities,ConditionImmunities,Senses,Skills,Languages,BasicAttacks,NonSpellAbilities,Passives,LegendaryActions,SpellCasting,ExtraNotes")] Statblock statblock)
        {
            if (ModelState.IsValid)
            {
                var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

                ApplicationUser applicationUser = await _userManager.GetUserAsync(User);

                statblock.ApplicationUser = applicationUser;

                _context.Add(statblock);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(statblock);
        }

        // GET: Statblocks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statblock = await _context.Statblock.FindAsync(id);
            if (statblock == null)
            {
                return NotFound();
            }
            return View(statblock);
        }

        // POST: Statblocks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,AC,Shield,Health,Speed,Strength,Dexterity,Constitution,Intelligence,Wisdom,Charisma,SavingThrows,Resistances,Immunities,Vulnerabilities,ConditionImmunities,Senses,Skills,Languages,BasicAttacks,NonSpellAbilities,Passives,LegendaryActions,SpellCasting,ExtraNotes")] Statblock statblock)
        {
            if (id != statblock.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(statblock);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatblockExists(statblock.Id))
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
            return View(statblock);
        }

        // GET: Statblocks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var statblock = await _context.Statblock
                .FirstOrDefaultAsync(m => m.Id == id);
            if (statblock == null)
            {
                return NotFound();
            }

            return View(statblock);
        }

        // POST: Statblocks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var statblock = await _context.Statblock.FindAsync(id);
            _context.Statblock.Remove(statblock);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatblockExists(int id)
        {
            return _context.Statblock.Any(e => e.Id == id);
        }
    }
}
