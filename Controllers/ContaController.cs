using BancoEveris.Model;
using BancoEveris.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BancoEveris.Controllers
{
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {
        private ContaService _service = new ContaService();

        [HttpGet]
        public IEnumerable<Conta> Lista()
        {
            return _service.Lista();
        }
    }
}
