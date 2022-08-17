using Microsoft.AspNetCore.Mvc;
using Exerc01_CadastroCliente.Data;

namespace Exerc01_CadastroCliente.Controllers
{
    public class ClienteController : Controller
    {
        private readonly AppCont _appCont;

        public ClienteController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allTasks = _appCont.Cliente.ToList();
            return View(allTasks);
        }
    }
}
