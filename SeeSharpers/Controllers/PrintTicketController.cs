using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SeeSharpers.Data;
using SeeSharpers.Models;
using static System.Console;

namespace SeeSharpers.Controllers
{
    public class PrintTicketController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrintTicketController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }

        public async Task<IActionResult> Index1()
        {
            return View();
        }

        public async Task<IActionResult> Index2()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder(int? inputCode)
        {
            if (inputCode == null) return View("Index1");
            /*var order = await _context.Orders.FindAsync(inputCode);*/

            try
            {
                var order = _context.Orders.Single(a => a.Code == inputCode);
                ViewData["Order"] = order;

                return View(order);
            }
            catch (Exception e)
            {

                return View("Index2");
            }
           
            /*.Where(s => s.Code!.Equals(inputCode));*/




        }

        /*public async Task<IActionResult> PrintTickets(int? Id)
        {
            var order = await _context.Orders.FindAsync(Id);
            if (order == null) return View("Error")
                List<Ticket> tickets = 
        }*/
    }
}
