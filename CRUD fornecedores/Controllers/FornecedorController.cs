using CRUD_fornecedores.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace CRUD_fornecedores.Controllers
{
    public class FornecedorController : Controller
    {
        private static List<Fornecedor> fornecedores = new List<Fornecedor>();

        public IActionResult Index()
        {
            return View(fornecedores);
        }

        //CREATE
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                fornecedor.Id = fornecedores.Count + 1;
                fornecedores.Add(fornecedor);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        //Update
        public IActionResult Edit(int id)
        {
            var fornecedor = fornecedores.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null) return NotFound();
            return View(fornecedor);
        }
        //Update salva as Alterações
        [HttpPost]
        public IActionResult Edit(Fornecedor fornecedor)
        {
            var original = fornecedores.FirstOrDefault(f => f.Id == fornecedor.Id);
            original.Name = fornecedor.Name;
            original.Produto = fornecedor.Produto;
            original.Email = fornecedor.Email;
            original.CNPJ = fornecedor.CNPJ;

            return RedirectToAction(nameof(Index));

        }

        //Delete
        public ActionResult Delete(int id)
        {
            var fornecedor = fornecedores.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null) return NotFound();
            return View(fornecedor);
        }

        //Delete- remove do banco
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var fornecedor = fornecedores.FirstOrDefault(f => f.Id == id);
            if (fornecedor != null)
            {
                fornecedores.Remove(fornecedor);
            }
            return RedirectToAction(nameof(Index));
        }

        //Detalhes
        public ActionResult Details(int id) 
        {
            var fornecedor = fornecedores.FirstOrDefault(f => f.Id == id);
            if (fornecedor == null) return NotFound();
            return View(fornecedor);
        }
    }
}

