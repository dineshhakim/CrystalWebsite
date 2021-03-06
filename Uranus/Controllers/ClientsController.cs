﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Controllers
{
    public class ClientsController : Controller
    {
        public readonly IClientService objClientService;
        public ClientsController(IClientService objclientService)
        {
            objClientService = objclientService;
        }

        // GET: Clients
        public ActionResult Index()
        {
           var clients= objClientService.GetAll();
            return View(clients);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
                
            return View();
        }

        // POST: Clients/Create
        [HttpPost]
        public ActionResult Create(Clients clients)
        {
            try
            {
                // TODO: Add insert logic here
                objClientService.Add(clients);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Clients/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Clients/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
