using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DemoLib.Commands;
using DemoLib.Models;
using DemoLib.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    public class PersonController : Controller
    {
        private readonly IMediator Mediator;

        public PersonController(IMediator mediator)
        {
            Mediator = mediator;
        }

        [HttpGet]
        public async Task<List<PersonModel>> Get()
        {
            return await Mediator.Send(new GetPersonListQuery());
        }
        // GET: Person
        public ActionResult Index()
        {
            return View();
        }

        // GET: Person/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Person/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Person/Create
        [HttpPost]

        public async Task<PersonModel> Post([FromBody] PersonModel value)
        {
            var model = new InsertPersonCommand(value.FirstName, value.LastName);
            return await Mediator.Send(model);
        }

        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Person/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Person/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Person/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}