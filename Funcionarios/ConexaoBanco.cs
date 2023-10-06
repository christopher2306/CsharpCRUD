using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    static class ConexaoBanco
    {       
                //Iniciando a conexão com o banco de dados 

                private const string servidor = "localhost";
                private const string bancoDados = "dbFuncionarios";
                private const string usuario = "root";
                private const string senha = "";

                static public string bancoServidor = $"server={servidor}; user id={usuario};database={bancoDados};password={senha}";

     }
}
