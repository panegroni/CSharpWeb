using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_app_produit.Models
{
    public class Produits
    {
        //La liste des produits
        public List<Produit> listProduits;

        public Produits() {
            listProduits = new List<Produit>();
            /*Si le manager avait fonctionné
             * Manager m = Manager.Instance;
            listProduits = m.GetAllProduit();
             
             A la place, on instanci à la main*/
            addProduit(new Produit("R456","Poivre"));
            addProduit(new Produit("R457", "Sel"));
        }

        public void addProduit(Produit p)
        {
            listProduits.Add(p);
        }

        //Méthode permettant d'aller chercher un élément dans la liste grâce à sa référence.
        public Produit getByRef(String refe)
        {
            foreach (Produit p in listProduits)
            {
               if (p.Reference.Equals(refe))
                    return p;
            }
            return null;
        }

    }
}