using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetEntite.Entities
{
    public class Categorie
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Libelle { get; set; }

        [Required]
        public bool Actif { get; set; }

        public ICollection<Produit> Produits { get; set; }

    }
}
