using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace Habilitacao.Infra.Data.DbConfig
{
    class ConexaoSQL
    {
        //protected -> somente pode ser acessado por herança
        protected SqlConnection sqlConnection;    //conexão com o banco de dados
        protected SqlCommand sqlCommand;       //executar comandos SQL
        protected SqlDataReader sqlDataReader;     //Ler dados de consultas 
        protected SqlTransaction sqlTransaction;    //Transações em banco de dados (commit/rollback)

        //declarar os metodos..
        protected void OpenConnection(string strConnect) //conexão...
        {
            sqlConnection.ConnectionString = strConnect;
            sqlConnection.Open(); //conexão aberta!
        }

        protected void CloseConnection() //desconectar...
        {
            sqlConnection.Close(); //conexão fechada!
        }
    }
}
