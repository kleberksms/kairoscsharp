using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Kairos.Application.Interfaces;
using Kairos.Domain.Entities;
using Kairos.MVC.ViewModels;

namespace Kairos.MVC.Controllers
{
    public class PrioritiesController : Controller
    {
        private readonly IPriorityApplicationService _priorityApplicationService;

        public PrioritiesController(IPriorityApplicationService priorityApplicationService)
        {
            _priorityApplicationService = priorityApplicationService;
        }

        // GET: Priorities
        public ActionResult Index()
        {
            Mapper.CreateMap<Priority, PriorityViewModel>();
            var priorityViewModel = Mapper.Map<IEnumerable<Priority>, IEnumerable<PriorityViewModel>>(_priorityApplicationService.GetAll());
            return View(priorityViewModel);
        }

        // GET: Priorities/Details/5
        public ActionResult Details(int id)
        {
            var priority = _priorityApplicationService.GetById(id);
            var priorityViewModel = Mapper.Map<Priority, PriorityViewModel>(priority);
            return View(priorityViewModel);
        }

        // GET: Priorities/Create
        public ActionResult Create()
        {
            ViewBag.PriorityId = new SelectList(_priorityApplicationService.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Priorities/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PriorityViewModel priority)
        {
            if (ModelState.IsValid)
            {
                var priorityDomain = Mapper.Map<PriorityViewModel, Priority>(priority);
                _priorityApplicationService.Add(priorityDomain);
                return RedirectToAction("Index");
            }
            return View(priority);
        }

        // GET: Priorities/Edit/5
        public ActionResult Edit(int id)
        {
            var priority = _priorityApplicationService.GetById(id);
            var priorityViewModel = Mapper.Map<Priority, PriorityViewModel>(priority);
            return View(priorityViewModel);
        }

        // POST: Priorities/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PriorityViewModel priority)
        {
            if (ModelState.IsValid)
            {
                var priorityDomain = Mapper.Map<PriorityViewModel, Priority>(priority);
                _priorityApplicationService.Add(priorityDomain);
                return RedirectToAction("Index");
            }
            return View(priority);
        }

        // GET: Priorities/Delete/5
        public ActionResult Delete(int id)
        {
            var priority = _priorityApplicationService.GetById(id);
            var priorityViewModel = Mapper.Map<Priority, PriorityViewModel>(priority);
            return View(priorityViewModel);
        }

        // POST: Priorities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var priority = _priorityApplicationService.GetById(id);
            _priorityApplicationService.Remove(priority);
            return RedirectToAction("Index");
        }
 
    }
}
