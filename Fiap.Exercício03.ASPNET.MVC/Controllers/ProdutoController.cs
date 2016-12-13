using Fiap.Exercício03.ASPNET.MVC.Models;
using Fiap.Exercício03.ASPNET.MVC.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap.Exercício03.ASPNET.MVC.Controllers
{
   
    public class ProdutoController : Controller
    {
        private UnitsOfWork _unit = new UnitsOfWork();
        // GET: Produto
        public ActionResult Cadastro()
        {
            return View();
        }

        public ActionResult Listar()
        {
            
            return View(_unit.ProdutoRepository.Listar());
        }

        [HttpPost]
        public ActionResult Cadastro(Produto produto)
        {
            _unit.ProdutoRepository.Cadastrar(produto);
            _unit.Save();
            return View();
        }
    }
}