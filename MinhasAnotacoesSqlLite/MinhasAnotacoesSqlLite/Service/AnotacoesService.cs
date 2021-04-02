using MinhasAnotacoesSqlLite.Classe;
using MinhasAnotacoesSqlLite.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhasAnotacoesSqlLite.Service
{
    public class AnotacoesService
    {
        AnotacoesRepository anotacoesRepository = new AnotacoesRepository();

        public DataTable obterAnotacoes(Anotacoes anotacoes, string idAnotacao)
        {
            return anotacoesRepository.obterAnotacoes(anotacoes, idAnotacao);
        }

        public bool cadastrarAnotacoes(Anotacoes anotacoes)
        {
            return anotacoesRepository.cadastrarAnotacoes(anotacoes);
        }
    }
}
