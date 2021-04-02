using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasAnotacoesSqlLite.Conexao
{
    public class ConexaoBanco
    {
        public static string Diretorio => "C:\\BancoDados\\banco_dados.sqlite";
        public static SQLiteConnection sqliteConnection;

        public static SQLiteConnection DbConnection()
        {
            sqliteConnection = new SQLiteConnection($"Data Source={Diretorio}; Version=3;");
            sqliteConnection.Open();
            return sqliteConnection;
        }

        public static void CriarBancoSQLite()
        {
            try
            {
                SQLiteConnection.CreateFile(@"c:\dados\Cadastro.sqlite");
            }
            catch
            {
                throw;
            }
        }
    }
}