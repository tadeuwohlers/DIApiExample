using Microsoft.AspNetCore.Mvc;

namespace DIApiExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly IService _service;
        private readonly WorkerSerice _execService;
        public HomeController(IService service, WorkerSerice execService)
        {
            _service = service;
            _execService = execService;
        }

        [HttpGet]
        public string Get()
        {
            var textService = _service.ReturnValue();
            var textoExecService = _execService.ReturnServiceValue();
            return $"Servico: {textService} - ExecutaServico: {textoExecService}";
        }
    }
}