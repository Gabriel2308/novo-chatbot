using habilitacao.Infra.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Habilitacao.Infra.Data.Repository.IRepositories
{
    public interface IHabilitacaoRepository
    {
        DetalhesValidacaoHab validarRenovacaoHab(string cpf, decimal pCodigoServico, int tipoDocumento, string numDocumento, string digito, string orgaoEmissor, string ufEmissao);
    }
}
