using Persistencia.DAL.Tabelas;
using Modelo.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Tabelas;

namespace Servico.Tabelas
{
    public class CategoriaServico
    {
        private CategoriaDal categoriaDAL = new CategoriaDal();

        public IQueryable<Categoria> ObterCategoriasClassificadasPorNome()
        {
            return categoriaDAL.ObterCategoriasClassificadasPorNome();
        }
    }
}
