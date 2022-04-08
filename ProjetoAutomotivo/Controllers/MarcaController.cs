using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgenciaAutomotiva.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaAutomotiva.Controllers
{
    public class MarcaController : Controller
    {
        private static Marca _marca = new Marca();

        // GET: Marca
        public ActionResult Index()
        {
            return View(_marca.marcas);
        }

        // GET: Marca/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Marca/Criar
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Marca/Criar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Criar(IFormCollection collection)
        {
            try
            {
                MarcaModel marca = new MarcaModel
                (
                    Convert.ToInt32(collection["id"]),
                    collection["nome"].ToString(),
                    (MarcaModel.Status)Enum.Parse(typeof(MarcaModel.Status), collection["status"], true)
                );

                _marca.adicionarMarca(marca);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Marca/Editar/5
        public ActionResult Editar(int id)
        {
            return View(_marca.getMarca(id));
        }

        // POST: Marca/Editar/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Editar(IFormCollection collection)
        {
            try
            {
                MarcaModel marca = new MarcaModel
                (
                    Convert.ToInt32(collection["id"]),
                    collection["nome"].ToString(),
                    (MarcaModel.Status)Enum.Parse(typeof(MarcaModel.Status), collection["status"], true)
                );

                _marca.atualizarMarca(marca);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Marca/Excluir/5
        public ActionResult Excluir(int id)
        {
            //_marca.excluirMarca(id);
            return View(_marca.getMarca(id));
        }

        // POST: Marca/Excluir/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Excluir(int id, IFormCollection collection)
        {
            try
            {
                _marca.excluirMarca(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
