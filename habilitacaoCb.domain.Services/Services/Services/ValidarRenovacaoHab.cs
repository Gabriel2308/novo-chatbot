using Habilitacao.Infra.Data.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace habilitacaoCb.domain.Services.Services.Services
{
    public class ValidarRenovacaoHab
    {
        private readonly IHabilitacaoRepository _habilitacaoRepository;

        public ValidarRenovacaoHab(IHabilitacaoRepository habilitacaoRepository)
        {
            _habilitacaoRepository = habilitacaoRepository;
        }

        public Object validarRenovacaoHab(string cpf, int codigoServico, int tipoDocumento, string numDocumento, string digito, string orgaoEmissor, string ufEmissao)
        {
            var validarRenovacao = _habilitacaoRepository.validarRenovacaoHab(cpf, codigoServico, tipoDocumento, numDocumento, digito, orgaoEmissor, ufEmissao);
        }
    }
}
