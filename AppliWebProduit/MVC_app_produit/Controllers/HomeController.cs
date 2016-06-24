using MVC_app_produit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_app_produit.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private Produits model = new Produits();

        //Controller de l'ajout des produits
        public ActionResult Create()
        {
            return View("Create");
        }
        //Controller des details produit
        public ActionResult Details(String id)
        {
            return View("Details", model.getByRef(id));
        }
        //Controller de l'edition des produits (avant l'envoi du formulaire)
        [HttpGet]
        public ActionResult Edit(String id)
        {
            return View("Edit", model.getByRef(id));
        }
        //Controller de l'edition des produits (retour du formulaire)
        [HttpPost]
        public ActionResult Edit(String id, String unused)
        {
            if (ModelState.IsValid) {
                //Comme nous n'avons pas reussi à lier la base de données, nous avions testé les modification en direct sur le modèle instancié. 
                model.getByRef(id).Libelle = Request["Libelle"]??"";
                model.getByRef(id).Reference = Request["Reference"]??"";
            }
            return View("Home", model);
        }
        //Controller de base
        public ActionResult Index()
        {
            return View("Home",model);
        }

    }
}
