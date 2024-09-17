﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeSportif.Model
{
    [Table("NatureSport")]
    class NatureSport
    {
        [Key, Column(Order = 1)]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Intitule { get; set; }
    }
}
