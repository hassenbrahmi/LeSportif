using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeSportif.Model
{
    [Table("Sportifs")]
    class Sportifs
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        [Key, Column(Order = 2)]
        [MaxLength(50)]
        public string Identifiant{ get; set; }

        [MaxLength(50)]
        public string Nom { get; set; }

        [MaxLength(50)]
        public string Prenom { get; set; }

        [Column(TypeName = "Date")]
        public DateTime date_Naissance { get; set; }
        [MaxLength(50)]
        public string Genre { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
