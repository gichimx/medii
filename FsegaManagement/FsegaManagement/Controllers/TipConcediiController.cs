using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FsegaManagement.Data;
using AutoMapper;
using FsegaManagement.Models;
using FsegaManagement.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace FsegaManagement.Controllers
{
    [Authorize(Roles = "Admin")]
    public class TipConcediiController : Controller
    {
        private readonly IManagementTypeRepo managementTypeRepo;
        private readonly IMapper mapper;
        public TipConcediiController(IManagementTypeRepo managementTypeRepo, IMapper mapper)
        {
            this.managementTypeRepo = managementTypeRepo;
            this.mapper = mapper;
        }

        // GET: TipConcedii
        public async Task<IActionResult> Index()
        {

            var tipConcedii = mapper.Map<List<TipConcediuViewModel>>(await managementTypeRepo.GetAllAsync());
              return View(tipConcedii);
        }

        // GET: TipConcedii/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var tipConcediu = await managementTypeRepo.GetAsync(id);
            if (tipConcediu == null)
            {
                return NotFound();
            }
            var tipConcediuViewModel = mapper.Map<TipConcediuViewModel>(tipConcediu);
            return View(tipConcediuViewModel);
        }

        // GET: TipConcedii/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TipConcedii/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TipConcediuViewModel tipConcediuViewModel)
        {
            if (ModelState.IsValid)
            {
                var tipConcediu = mapper.Map<TipConcediu>(tipConcediuViewModel);
                await managementTypeRepo.AddAsync(tipConcediu);
                return RedirectToAction(nameof(Index));
            }
            return View(tipConcediuViewModel);
        }

        // GET: TipConcedii/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            var tipConcediu = await managementTypeRepo.GetAsync(id);
            if (tipConcediu == null)
            {
                return NotFound();
            }
            var tipConcediuViewModel = mapper.Map<TipConcediuViewModel>(tipConcediu);
            return View(tipConcediuViewModel);
        }

        // POST: TipConcedii/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TipConcediuViewModel tipConcediuViewModel)
        {
            if (id != tipConcediuViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var tipConcediu = mapper.Map<TipConcediu>(tipConcediuViewModel);
                    await managementTypeRepo.UpdateAsync(tipConcediu);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await managementTypeRepo.Exists(tipConcediuViewModel.Id))
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
            return View(tipConcediuViewModel);
        }

        // POST: TipConcedii/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await managementTypeRepo.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
