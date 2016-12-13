using Fiap.Exercício03.ASPNET.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Exercício03.ASPNET.MVC.Repositories
{
    public interface IProdutoRepository
    {


        IEnumerable<Produto> Listar();
        Produto BuscarPorId(int produtoId);
        void Cadastrar(Produto produto);
        void Deletar(int produtoId);
        void Atualizar(Produto produto);
        ICollection<Produto>BuscarPor(Expression<Func<Produto, bool>> predicate);
    }
}
