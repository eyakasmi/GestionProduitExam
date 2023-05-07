using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Examen.ApplicationCore.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.Web.Controllers
{
    public class ProduitController : Controller
    {

        IProduitService ps;
        ICategorieService categorieService;


        public ProduitController(IProduitService ps , ICategorieService categorieService)
        {
            this.ps = ps;
            this.categorieService=  categorieService;
        }

        // GET: ProduitController
        public ActionResult Index()
        {
            return View(ps.GetAll());
        }

       

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            ViewBag.CategorieList = new SelectList(categorieService.GetAll(), "Id", "Nom");
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Produit produit)
        {
            try
            {
                ps.Add(produit);
                ps.Commit();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        
        // Post: CagnotteController/Index
        [HttpPost]
        public ActionResult Index(string filter)
        {
            var list = ps.GetAll();
            if (!String.IsNullOrEmpty(filter))
            {
                list = list.Where(p => p.Nom.ToString().Equals(filter)).ToList();
            }
            return View(list);
        }


        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
