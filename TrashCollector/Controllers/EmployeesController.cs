﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Data;
using TrashCollector.Models;

namespace TrashCollector.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeesController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        // GET: Employees
        public async Task<IActionResult> Index()
        {
            Employee employee = new Employee();

            employee.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

            var employeeInDb = _context.Employees.Where(e=>e.IdentityUserId == employee.IdentityUserId).FirstOrDefault();
            var Customers = _context.Customer.Where(c => c.Address.ZipCode == employeeInDb.ZipCode).OrderBy(x => x.PickupDay).ToList();

            return View(Customers);
        }
        
        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }
            
            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            Employee employee = new Employee();
            
            return View(employee);
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employee.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                _context.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Customers");
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Employee employee, Customer customer)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    employee.IdentityUserId = this.User.FindFirstValue(ClaimTypes.NameIdentifier);

                    var employeeInDb = _context.Customer.Where(c => c.Id == employee.Id).Single();
                    employeeInDb.FirstName = customer.FirstName;
                    employeeInDb.LastName = customer.LastName;
                    employeeInDb.PickupDay = customer.PickupDay;
                    employeeInDb.StartDate = customer.StartDate;
                    employeeInDb.EndDate = customer.EndDate;
                    employeeInDb.OneTimePickUp = customer.OneTimePickUp;
                    employeeInDb.Address = customer.Address;
                    employeeInDb.AccountBalance = customer.AccountBalance;

                    _context.SaveChanges();
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", "Customers");
            }
            ViewData["IdentityUserId"] = new SelectList(_context.Users, "Id", "Id", employee.IdentityUserId);
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Include(e => e.IdentityUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await _context.Employees.FindAsync(id);
            _context.Employees.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }

        // GET: Employees/Edit/5

        // POST: Employees/Confirm Pickup/5

        [HttpPost]
        public async Task<IActionResult> ConfirmPickup(int id, Customer customer, Employee employee)
        {
            Customer customerToUpdate;
            customerToUpdate = _context.Customer.Find(id);
            
            //here

            if (ModelState.IsValid)
            {
                try
                {
                    //customerToUpdate.FirstName;
                   
                        customerToUpdate.AccountBalance += 10;
                    
                    //here
                    _context.SaveChanges();
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return RedirectToAction("Employee", "Index");
                }
                return RedirectToAction("Employee", "Index");
            }

            return RedirectToAction("Employee", "Index");
        }

        
    }
}
