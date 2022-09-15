using SoftwareAG.EntireX.NETWrapper.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace agendamento.Infra.Data.DbConfig
{
    public class Entirex
    {
#if DEBUG

        // *** Definições referente aos serviços de EntireX Broker no ambiente de Produção
        const string _entirexBrokerAddress = "producao.detran.gov-se";
        const string _entirexBrokerPort = "1971";
        const int _entirexBrokerDefaultTimeout = 10;

        const string _entirexServiceClass = "RPC";
        const string _entirexServiceDefaultServer = "SRVWS";
        const string _entirexServiceName = "CALLNAT";

        const string _entirexNaturalDefaultLibrary = "DETRAN";
        const string _entirexNaturalDefaultUser = "DET99998";
        const string _entirexNaturalDefaultPassword = "SECRETA";

        //// *** Definições referente aos serviços de EntireX Broker no ambiente de DESENVOLVIMENTO
        //const string _entirexBrokerAddress = "homologacao.detran.gov-se"; // ;"producao.detran.gov-se"
        //const string _entirexBrokerPort = "1971";
        //const int _entirexBrokerDefaultTimeout = 20;

        //const string _entirexServiceClass = "RPC";
        //const string _entirexServiceDefaultServer = "SRDSW"; //"SRDSW"; -  SRDSW | Homologação - SRVWS | Produção
        //const string _entirexServiceName = "CALLNAT";

        //const string _entirexNaturalDefaultLibrary = "DETRAN";
        //const string _entirexNaturalDefaultUser = "DET99998";
        //const string _entirexNaturalDefaultPassword = "SECRETA";


#else

        // *** Definições referente aos serviços de EntireX Broker no ambiente de Produção
        const string _entirexBrokerAddress = "producao.detran.gov-se";
        const string _entirexBrokerPort = "1971";
        const int _entirexBrokerDefaultTimeout = 10;

        const string _entirexServiceClass = "RPC";
        const string _entirexServiceDefaultServer = "SRVWS";
        const string _entirexServiceName = "CALLNAT";

        const string _entirexNaturalDefaultLibrary = "DETRAN";
        const string _entirexNaturalDefaultUser = "DET99998";
        const string _entirexNaturalDefaultPassword = "SECRETA";

#endif


        public static string getBrokerAddresss()
        {
            return _entirexBrokerAddress + ":" + _entirexBrokerPort;
        }

        public static string getServiceTrinity()
        {
            return _entirexServiceClass + "/" + _entirexServiceDefaultServer + "/" + _entirexServiceName;
        }
        public static string getServiceTrinity(string serverName)
        {
            return _entirexServiceClass + "/" + serverName + "/" + _entirexServiceName;
        }

        public static string getDefaultLibraryName()
        {
            return _entirexNaturalDefaultLibrary;
        }

        public static Service getNewEolService()
        {
            Service returnService = new Service(new Broker(getBrokerAddresss()), getServiceTrinity(), getDefaultLibraryName());
            returnService.NaturalLogon = true;
            returnService.Timeout = _entirexBrokerDefaultTimeout;
            returnService.UserIDAndPassword(_entirexNaturalDefaultUser, _entirexNaturalDefaultPassword);
            return returnService;
        }

        public static Service getNewEolService(string userName, string userPassword)
        {
            Service returnService = new Service(new Broker(getBrokerAddresss()), getServiceTrinity(), getDefaultLibraryName());
            returnService.NaturalLogon = true;
            returnService.Timeout = _entirexBrokerDefaultTimeout;
            returnService.UserIDAndPassword(userName, userPassword);
            return returnService;
        }

        public static Service getNewEolService(string userName, string userPassword, string serverName)
        {
            Service returnService = new Service(new Broker(getBrokerAddresss()), getServiceTrinity(serverName), getDefaultLibraryName());
            returnService.NaturalLogon = true;
            returnService.Timeout = _entirexBrokerDefaultTimeout;
            returnService.UserIDAndPassword(userName, userPassword);
            return returnService;
        }
    }
}
