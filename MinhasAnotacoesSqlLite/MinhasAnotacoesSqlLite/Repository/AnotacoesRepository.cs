using MinhasAnotacoesSqlLite.Classe;
using MinhasAnotacoesSqlLite.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasAnotacoesSqlLite.Repository
{
    public class AnotacoesRepository : ConexaoBanco
    {    
        public static void CriarTabelaSQlite()
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS Clientes(id int, Nome Varchar(50), email VarChar(80))";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obterTodasAnotacoes()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT * FROM tb_cadastrar_anotacoes";
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataTable obterAnotacoes(Anotacoes anotacoes, string idAnotacao)
        {
            string sql = string.Empty;

            if (string.IsNullOrEmpty(idAnotacao))
            {
                sql = $"SELECT * FROM tb_cadastrar_anotacoes Where titulo LIKE '%{anotacoes.Titulo}%'";
            }
            else
            {
                sql = $"SELECT * FROM tb_cadastrar_anotacoes Where id = {idAnotacao}";
            }

            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, DbConnection());
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool cadastrarAnotacoes(Anotacoes anotacoes)
        {
            try
            {
                using (var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = $"INSERT INTO tb_cadastrar_anotacoes VALUES(null, @Titulo, @Tipo, @Descricao)";
                    cmd.Parameters.AddWithValue("@Titulo", anotacoes.Titulo);
                    cmd.Parameters.AddWithValue("@Tipo", anotacoes.Tipo);
                    cmd.Parameters.AddWithValue("@Descricao", anotacoes.Descricao);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void Update(Anotacoes anotacoes)
        {
            //try
            //{
            //    using (var cmd = new SQLiteCommand(DbConnection()))
            //    {
            //        if (anotacoes.Id != null)
            //        {
            //            cmd.CommandText = "UPDATE Clientes SET Nome=@Nome, Email=@Email WHERE Id=@Id";
            //            cmd.Parameters.AddWithValue("@Id", anotacoes.Id);
            //            cmd.Parameters.AddWithValue("@Nome", anotacoes.Nome);
            //            cmd.Parameters.AddWithValue("@Email", anotacoes.Email);
            //            cmd.ExecuteNonQuery();
            //        }
            //    };
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }

        public static void Delete(int Id)
        {
            try
            {
                using (var cmd = new SQLiteCommand(DbConnection()))
                {
                    cmd.CommandText = "DELETE FROM Clientes Where Id=@Id";
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
