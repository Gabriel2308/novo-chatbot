using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace habilitacaoCb.Services.RestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HabilitacaoController : ControllerBase
    {
        private readonly ILogger<HabilitacaoController> _logger;

        public HabilitacaoController(ILogger<HabilitacaoController> logger)
        {
            _logger = logger;
        }

        [HttpPost("validarRenovacao/{cpf}/{tipoDocumento}/{numDocumento}/{digito}/{orgaoEmissor}/{ufEmissao}")]
        public ActionResult validarRenovacao(string cpf, int tipoDocumento, string numDocumento, string digito, string orgaoEmissor, string ufEmissao)
        {
            return Ok();
        }
    }
}
