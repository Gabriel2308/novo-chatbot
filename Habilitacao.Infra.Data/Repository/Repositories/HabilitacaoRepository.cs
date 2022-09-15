using System;
using System.Collections.Generic;
using System.Text;
using agendamento.Infra.Data.DbConfig;
using habilitacao.Infra.Data.Entities;
using Habilitacao.Infra.Data.DbConfig.SoftwareAG.EntireX.NETWrapper.Generated.CallNat;

namespace Habilitacao.Infra.Data.Repository.Repositories
{
    public class HabilitacaoRepository
    {
        public DetalhesValidacaoHab validarRenovacaoHab(string cpf, decimal pCodigoServico, int tipoDocumento, string numDocumento, string digito, string orgaoEmissor, string ufEmissao)
        {
            DetalhesValidacaoHab detalhesHabilitacao = new DetalhesValidacaoHab();

            CallNat callNat = new CallNat();
            callNat.service = Entirex.getNewEolService("DET99998", "SECRETA");

            #region Inicializar os parâmetros
            decimal pCpf = Convert.ToDecimal(cpf);
            decimal pTipoIden = tipoDocumento;
            string pIdent = numDocumento;
            string pDigito = digito;
            string pOrgao = orgaoEmissor;
            string pUf = ufEmissao;
            string pCategoria = "";
            string pRequer = "";
            string pNomeCandidato = "";
            decimal pProcessoAberto = 0;
            string pTipoProcesso = ""; //  F-FISICO, V-VIRTUAL
            string pNomePaiParameter = "";
            string pNomeMaeParameter = "";
            decimal pSexoParameter = 0; // 1-MASCULINO, 2-FEMININO
            decimal pEscolaridadeParameter = 0; // 1-FUNDAMENTAL INCOMPLETO, 2-FUNDAMENTAL COMPLETO, 3-MEDIO INCOMPLETO, 4- MEDIO COMPLETO, 5-SUPERIOR INCOMPLETO, 6-SUPERIOR COMPLETO
            string pLocalidadeNascParameter = "";
            string pUfNaturalidadeParameter = "";
            decimal pNacionalidadeParameter = 0; // 1-BRASILEIRO, 2-BRASILEIRO NATURALIZADO, 3-ESTRANGEIRO
            decimal pProvaCursoRenovacao = 0; // 1 - JA POSSUI, 9 - NÃO POSSUI
            string pDeficienciaFisica = ""; // NAO CONSIDERAR VISAO MONOCULAR
            decimal pDataNascimentoParameter = 0;
            string pUfPrimHabParameter = "";
            decimal pDataPrimHabParameter = 0;
            string pDataValidadeCnh = "";
            string pDataExameValido = "";
            string pFlagCnhDefinitiva = "";
            string pTransfJurisdicao = "";
            string pAtividadeRemunerada = "";
            string pRgDifereBinco = "";
            decimal pContProcessosSuspensao = 0;
            string nomeSocialParm = "";
            string filiacaoAfetiva1Parm = "";
            string filiacaoAfetiva2Parm = "";
            string vExxMensagem = "";
            decimal vExxErro = 0;

            decimal pRegistro = 0;
            #endregion

            try
            {
                callNat.S53it001(pCpf, pCodigoServico,
                    out pCategoria, out pRequer, out pNomeCandidato, out pProcessoAberto, out pTipoProcesso, out pNomePaiParameter,
                    out pNomeMaeParameter, out pSexoParameter, out pEscolaridadeParameter, out pLocalidadeNascParameter,
                    out pUfNaturalidadeParameter, out pNacionalidadeParameter, out pProvaCursoRenovacao,
                    out pDeficienciaFisica, ref pTipoIden, ref pIdent, ref pDigito, ref pOrgao, ref pUf,
                    out pDataNascimentoParameter, out pUfPrimHabParameter, out pDataPrimHabParameter,
                    out pDataValidadeCnh, out pDataExameValido, out pFlagCnhDefinitiva, ref pTransfJurisdicao,
                    out pAtividadeRemunerada, out pRgDifereBinco, out pContProcessosSuspensao, out pRegistro, ref nomeSocialParm, ref filiacaoAfetiva1Parm, ref filiacaoAfetiva2Parm, out vExxErro, out vExxMensagem);

                detalhesHabilitacao.vExxErro = vExxErro.ToString().Trim();
                detalhesHabilitacao.vExxMensagem = vExxMensagem.ToString().Trim();

                detalhesHabilitacao.categoria = pCategoria.ToString().Trim();
                detalhesHabilitacao.requer = pRequer.ToString().Trim();
                detalhesHabilitacao.nomeCandidato = pNomeCandidato.ToString().Trim();
                detalhesHabilitacao.nomePai = pNomePaiParameter.ToString().Trim();
                detalhesHabilitacao.nomeMae = pNomeMaeParameter.ToString().Trim();
                detalhesHabilitacao.sexo = pSexoParameter.ToString().Trim();
                detalhesHabilitacao.escolaridade = pEscolaridadeParameter.ToString().Trim();
                detalhesHabilitacao.localidadeNasc = pLocalidadeNascParameter.ToString().Trim();
                detalhesHabilitacao.ufNaturalidade = pUfNaturalidadeParameter.ToString().Trim();
                detalhesHabilitacao.nacionalidade = pNacionalidadeParameter.ToString().Trim();
                detalhesHabilitacao.deficienciaFisica = pDeficienciaFisica.ToString().Trim();
                detalhesHabilitacao.dataNascimento = pDataNascimentoParameter.ToString().Trim();
                detalhesHabilitacao.ufPrimeiraCnh = pUfPrimHabParameter.ToString().Trim();
                detalhesHabilitacao.dataPrimeiraCnh = pDataPrimHabParameter.ToString().Trim();
                detalhesHabilitacao.dataValidadeCnh = pDataValidadeCnh.ToString().Trim();
                detalhesHabilitacao.dataExameValido = pDataExameValido.ToString().Trim();
                detalhesHabilitacao.flagCnhDefinitiva = pFlagCnhDefinitiva.ToString().Trim();
                detalhesHabilitacao.atividadeRemunerada = pAtividadeRemunerada.ToString().Trim();
                detalhesHabilitacao.registro = pRegistro.ToString().Trim();


                detalhesHabilitacao.excecoes.provaCursoRenovacao = pProvaCursoRenovacao.ToString().Trim();
                detalhesHabilitacao.excecoes.transfJurisdicao = pTransfJurisdicao.ToString().Trim();
                detalhesHabilitacao.excecoes.contProcessosSuspensao = pContProcessosSuspensao.ToString().Trim();
                detalhesHabilitacao.excecoes.processoAberto = pProcessoAberto.ToString().Trim();
                detalhesHabilitacao.excecoes.tipoProcessoAberto = pTipoProcesso.ToString().Trim();
                detalhesHabilitacao.excecoes.rgDifereBinco = pRgDifereBinco.ToString().Trim();
                detalhesHabilitacao.excecoes.possuiBiometria = "";
                detalhesHabilitacao.excecoes.possuiBloqueio = "";


            }
            catch (Exception ex)
            {
                throw ex;
            }

            if (detalhesHabilitacao.vExxMensagem == null)
            {
                detalhesHabilitacao.vExxErro = "1";
                detalhesHabilitacao.vExxMensagem = "O SERVIÇO ESTÁ INDISPONÍVEL NO MOMENTO, POR FAVOR VOLTE NOVAMENTE MAIS TARDE OU ENTRE EM CONTATO COM NOSSA EQUIPE DE ATENDIMENTO.";
            }

            return detalhesHabilitacao;
        }
    }

}
