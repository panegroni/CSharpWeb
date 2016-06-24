using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_app_produit.Models
{
    //POJO utilisé car pas de liaison à la base de données établie
    public class Produit
    {
        private string reference;
        private string libelle;

        public string Reference { get; set; }
        public string Libelle { get; set; }

        public Produit(string refe, string lib){
            Reference = refe;
            Libelle = lib;
        }

    }
}