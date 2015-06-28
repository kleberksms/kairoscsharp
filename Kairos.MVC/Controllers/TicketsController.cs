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
    public class TicketsController : Controller
    {

        private readonly ITicketApplicationService _ticketApplicationService;

        public TicketsController(ITicketApplicationService ticketApplicationService)
        {
            _ticketApplicationService = ticketApplicationService;
        }


        // GET: Tickets
        public ActionResult Index()
        {
            Mapper.CreateMap<Ticket, TicketViewModel>();
            var ticketViewModel = Mapper.Map<IEnumerable<Ticket>, IEnumerable<TicketViewModel>>(_ticketApplicationService.GetAll());
            return View(ticketViewModel);
        }

        // GET: Tickets/Details/5
        public ActionResult Details(int id)
        {
            var ticket = _ticketApplicationService.GetById(id);
            var ticketViewModel = Mapper.Map<Ticket, TicketViewModel>(ticket);
            return View(ticketViewModel);
        }

        // GET: Tickets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tickets/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TicketViewModel ticket)
        {
            if (ModelState.IsValid)
            {
                var ticketDomain = Mapper.Map<TicketViewModel, Ticket>(ticket);
                _ticketApplicationService.Add(ticketDomain);
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        // GET: Tickets/Edit/5
        public ActionResult Edit(int id)
        {
            var ticket = _ticketApplicationService.GetById(id);
            var ticketViewModel = Mapper.Map<Ticket, TicketViewModel>(ticket);
            return View(ticketViewModel);
        }

        // POST: Tickets/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TicketViewModel ticket)
        {
            if (ModelState.IsValid)
            {
                var ticketDomain = Mapper.Map<TicketViewModel, Ticket>(ticket);
                _ticketApplicationService.Add(ticketDomain);
                return RedirectToAction("Index");
            }
            return View(ticket);
        }

        // GET: Tickets/Delete/5
        public ActionResult Delete(int id)
        {
            var ticket = _ticketApplicationService.GetById(id);
            var ticketViewModel = Mapper.Map<Ticket, TicketViewModel>(ticket);
            return View(ticketViewModel);
        }

        // POST: Tickets/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var ticket = _ticketApplicationService.GetById(id);
            _ticketApplicationService.Remove(ticket);
            return RedirectToAction("Index");
        }
    }
}
