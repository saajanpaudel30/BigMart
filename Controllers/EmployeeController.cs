﻿using System.Collections.Generic;
using System.Linq;
using SuperMarket.Data;
using SuperMarket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using System;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace SuperMarket.Controllers
{
    public class EmployeeController:Controller
    {
        private superMarketDbContext dbContext;
        IWebHostEnvironment _env;
        //IHostingEnvironment _env;

        public EmployeeController(superMarketDbContext _dbcontext, IWebHostEnvironment env)
        {
            dbContext = _dbcontext;
            _env = env;
        }
        public IActionResult Index()
        {
            //List<employeeModel> employees = dbContext.employee.Where(a=>a.name == "fdsaf" && a.address== "fdasf").ToList();
            //List<employeeModel> employees = dbContext.employee.OrderByDescending(a => a.name).ToList();
            //List<employeeModel> employees = dbContext.employee.OrderBy(a => a.emp_id).ToList();
            var query = from e in dbContext.employee
                        join l in dbContext.empLevel
                        on e.emp_lvl equals l.lvl_id into level
                        from l in level.DefaultIfEmpty()
                        select new employeeModel
                        {
                            emp_id = e.emp_id,
                            name = e.name,
                            address = e.address,
                            salary = e.salary,
                            levels = l.levels,
                            photo = e.photo
                        };
            List<employeeModel> employees = query.ToList();
            return View(employees);
        }

        public IActionResult Details(int id)
        {
            employeeModel employees = dbContext.employee.Find(id);
            return View(employees);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.eLvlList = new SelectList(dbContext.empLevel, "lvl_id", "levels");
            return View();
        }

        [HttpPost]
        public IActionResult Add([FromForm]employeeModel newemployee)
        {
            string rootPath = _env.WebRootPath;
            string uploadName = newemployee.UploadImage.FileName;
            string fileName = Guid.NewGuid().ToString()+uploadName;
            string uploadPath = rootPath + "/imgs/" + fileName;
            newemployee.photo = fileName;

            using (var filestream = new FileStream(uploadPath, FileMode.Create))
            {
                newemployee.UploadImage.CopyTo(filestream);
            }

            if (ModelState.IsValid)
            {
            dbContext.employee.Add(newemployee);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
            }
            return View(newemployee);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            employeeModel employees = dbContext.employee.Find(id);
            return View(employees);
        }

        [HttpPost]
        public IActionResult Edit([FromForm]employeeModel editemployee)
        {
            if (ModelState.IsValid)
            {
                dbContext.employee.Update(editemployee);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(editemployee);
        }

        public IActionResult Delete(int id)
        {
            employeeModel employees = dbContext.employee.Find(id);
            dbContext.employee.Remove(employees);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
