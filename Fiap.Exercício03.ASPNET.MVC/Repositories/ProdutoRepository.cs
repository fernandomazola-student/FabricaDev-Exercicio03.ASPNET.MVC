using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap.Exercício03.ASPNET.MVC.Models;
using System.Data.Entity;

namespace Fiap.Exercício03.ASPNET.MVC.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {

        private PortalContext _context;
        //Construtor
        public ProdutoRepository(PortalContext context)
        {
            _context = context;
        }
        public void Atualizar(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
        }

        public ICollection<Produto> BuscarPor(Expression<Func<Produto, bool>> predicate)
        {
            return _context.Produtoes.Where(predicate).ToList();
        }

        public Produto BuscarPorId(int produtoId)
        {
            return _context.Produtoes.Find(produtoId);
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtoes.Add(produto);
        }

        public void Deletar(int produtoId)
        {
            Produto produto = _context.Produtoes.Find(produtoId);
            _context.Produtoes.Remove(produto);
        }

        public IEnumerable<Produto> Listar()
        {
            return _context.Produtoes.ToList();
        }
    }
}