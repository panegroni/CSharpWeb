using DotNetBusinessLayer.Queries;
using Modele.Entite;
using Modele.Entite.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetBusinessLayer
{
    class Manager
    {
        Contexte contexte;
        //private readonly Contexte contexte;
        private static Manager _businessManager = null;


        /// <summary> 
        /// Constructeur, initialisation du contexte EF 
        /// </summary> 
        private Manager()
        {
            contexte = new Contexte();
        }


        /// <summary> 
        /// Récupérer l'instance du pattern Singleton 
        /// </summary> 
        public static Manager Instance
        {
            get
            {
                if (_businessManager == null)
                    _businessManager = new Manager();
                return _businessManager;
            }
        }

        /// <summary> 
        /// Récupérer une liste de produit en base 
        /// </summary> 
        /// <returns>Liste de Produit</returns> 
        public List<Produit> GetAllProduit()
        {
           ProduitQuery pq = new ProduitQuery(contexte);
           return pq.GetAll();
        } 
    }
}
