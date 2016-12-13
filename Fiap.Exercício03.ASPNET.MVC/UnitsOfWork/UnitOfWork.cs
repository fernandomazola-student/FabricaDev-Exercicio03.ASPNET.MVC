using Fiap.Exercício03.ASPNET.MVC.Models;
using Fiap.Exercício03.ASPNET.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap.Exercício03.ASPNET.MVC.UnitOfWork
{
    public class UnitsOfWork : IDisposable
    {
        private PortalContext _context = new PortalContext();
        private IProdutoRepository _produtoRepository;

        public IProdutoRepository ProdutoRepository
        {
            get
            {
                if (_produtoRepository == null)
                {
                    _produtoRepository = new
                    ProdutoRepository(_context);
                }
                return _produtoRepository;
            }
        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}