using Modele.Entite;
using Modele.Entite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBusinessLayer.Queries
{
    //Classe permettant d'effectuer des commandes sur les produits en base
    class ProduitQuery
    {
        private readonly Contexte _contexte = null;

        public ProduitQuery(Contexte contexte)
        {
            _contexte = contexte;
        }

        //Return une liste de tout les produits présents dans la base de données
        public List<Produit> GetAll()
        {
            return _contexte.Produits.ToList();
        }
    }
}
