using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcMovieRepo.Models;
using mvcMovieRepositoryDotnet.Services.ServiceContracts;

namespace mvcMovieRepositoryDotnet.Controllers
{
    public class membershipTypesController : Controller
    {
        private readonly IMembershipTypeService _membershipTypeService;

        public membershipTypesController(IMembershipTypeService membershipTypeService)
        {
            _membershipTypeService = membershipTypeService;
        }

        // GET: membershipTypes
        public async Task<IActionResult> Index()
        {
            var membershipTypes = await _membershipTypeService.GetMemebershipTypesAsync();
            return View(membershipTypes);
        }

        // GET: membershipTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membershipType = await _membershipTypeService.GetMemebershipTypeByIdAsync(id.Value);
            if (membershipType == null)
            {
                return NotFound();
            }

            return View(membershipType);
        }

        // GET: MembershipTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MembershipTypes/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] MembershipType membershipType)
        {
            if (ModelState.IsValid)
            {
                membershipType.Id = Guid.NewGuid();
                await _membershipTypeService.AddMemebershipTypeAsync(membershipType);
                return RedirectToAction(nameof(Index));
            }
            return View(membershipType);
        }

        // GET: membershipTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membershipType = await _membershipTypeService.GetMemebershipTypeByIdAsync(id.Value);
            if (membershipType == null)
            {
                return NotFound();
            }

            return View(membershipType);
        }

        // POST: membershipTypes/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Name,Description")] MembershipType membershipType)
        {
            if (id != membershipType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _membershipTypeService.UpdateMemebershipTypeAsync(membershipType);
                }
                catch (Exception)
                {
                    if (await _membershipTypeService.GetMemebershipTypeByIdAsync(membershipType.Id) == null)
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
            return View(membershipType);
        }

        // GET: membershipTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var membershipType = await _membershipTypeService.GetMemebershipTypeByIdAsync(id.Value);
            if (membershipType == null)
            {
                return NotFound();
            }

            return View(membershipType);
        }

        // POST: membershipTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            await _membershipTypeService.DeleteMemebershipTypeAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
