﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Data;
using AutoMapper;
using LeaveManagement.Models;
using LeaveManagement.Contracts;
using Microsoft.AspNetCore.Authorization;
using LeaveManagement.Constants;

namespace LeaveManagement.Controllers
{
    [Authorize(Roles =Roles.Administrator)]
    public class LeaveTypesController : Controller
    {
        
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;

        public LeaveTypesController(ILeaveTypeRepository  leaveTypeRepository, IMapper mapper)
        {
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
        }

        // GET: LeaveTypes
        public async Task<IActionResult> Index()
        {
            var leaveTypes = mapper.Map<List<LeaveTypeVM>>(await leaveTypeRepository.GetAllAsync());

            return View(leaveTypes);

        }

        // GET: LeaveTypes/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            /// moved to GenericRepository
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var leaveType = await _context.LeaveTypes.FindAsync(id);
            
            var leaveType = await leaveTypeRepository.GetAsync(id);

            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);

            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LeaveTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LeaveTypeVM leaveTypeVM)
        {
            if (ModelState.IsValid)
            {
                var leaveType = mapper.Map<LeaveType>(leaveTypeVM);
                //_context.Add(leaveType);
                //await _context.SaveChangesAsync();
                await leaveTypeRepository.AddAsync(leaveType);
                return RedirectToAction(nameof(Index));

            }
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {


            var leaveType = await leaveTypeRepository.GetAsync(id);
            if (leaveType == null)
            {
                return NotFound();
            }
            var leaveTypeVM = mapper.Map<LeaveTypeVM>(leaveType);

            return View(leaveTypeVM);
        }

        // POST: LeaveTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LeaveTypeVM leaveTypeVM)
        {
            if (id != leaveTypeVM.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var leaveType = mapper.Map<LeaveType>(leaveTypeVM);

                    //_context.Update(leaveType);
                    //await _context.SaveChangesAsync();
                    await leaveTypeRepository.UpdateAsync(leaveType);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!await leaveTypeRepository.Exists(leaveTypeVM.Id))
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
            return View(leaveTypeVM);
        }

        // GET: LeaveTypes/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var leaveType = await _context.LeaveTypes
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (leaveType == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(leaveType);
        //}

        // POST: LeaveTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           // var leaveType = await _context.LeaveTypes.FindAsync(id);
            //_context.LeaveTypes.Remove(leaveType);
            //await _context.SaveChangesAsync();
            
            await leaveTypeRepository.DeleteAsync(id);

            return RedirectToAction(nameof(Index));
        }

        //private async Task<bool> LeaveTypeExists(int id)
        //{
        //    //   return _context.LeaveTypes.Any(e => e.Id == id);
        //    return await leaveTypeRepository.Exists(id);


        //}
    }
}
