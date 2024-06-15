using Microsoft.AspNetCore.Mvc;
using MVC_Practice.Entites;
using MVC_Practice.ViewModels;


namespace MVC_Practice.Controllers
{
    public class ClientInfoController : Controller
    {
        private readonly CsharpUtangDatabaseContext _context;

        public ClientInfoController(CsharpUtangDatabaseContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var clients = _context.ClientInfos.Select(client => new ClientInfoViewModel
            {
                Id = client.Id,
                FirstName = client.FirstName,
                LastName = client.LastName,
                Address = client.Address,
                Birthday = client.Birthday,
                Occupation = client.Occupation
            }).ToList();

            

            return View(clients);
        }
    }
}
