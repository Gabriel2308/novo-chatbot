using System;

namespace habilitacao.Infra.Data.Entities
{
    public class DetalhesValidacaoHab
    {
        public string vExxErro { get; set; }
        public string vExxMensagem { get; set; }
        public string categoria { get; set; }
        public string requer { get; set; }
        public string nomeCandidato { get; set; }
        public string nomeSocial { get; set; }
        public string nomePai { get; set; }
        public string nomeMae { get; set; }
        public string filiacaoAfetiva1 { get; set; }
        public string filiacaoAfetiva2 { get; set; }
        public string sexo { get; set; }
        public string escolaridade { get; set; }
        public string localidadeNasc { get; set; }
        public string ufNaturalidade { get; set; }
        public string nacionalidade { get; set; }
        public string deficienciaFisica { get; set; }
        public string dataNascimento { get; set; }
        public string ufPrimeiraCnh { get; set; }
        public string dataPrimeiraCnh { get; set; }
        public string dataValidadeCnh { get; set; }
        public string dataExameValido { get; set; }
        public string flagCnhDefinitiva { get; set; }
        public string atividadeRemunerada { get; set; }
        public string registro { get; set; }

        public ExcecoesValidacao excecoes { get; set; }

        public DetalhesValidacaoHab()
        {
            this.excecoes = new ExcecoesValidacao();
        }
    }

    public class ExcecoesValidacao
    {
        public string contProcessosSuspensao { get; set; }
        public string provaCursoRenovacao { get; set; }
        public string transfJurisdicao { get; set; }
        public string possuiBloqueio { get; set; }
        public string possuiBiometria { get; set; }
        public string possuiCertificado { get; set; }
        public string flagAproveitamentoExames { get; set; }
        public string categoriaRebaixamento { get; set; }
        public string processoAberto { get; set; }
        public string tipoProcessoAberto { get; set; }
        public string rgDifereBinco { get; set; }
    }
}
