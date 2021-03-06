﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB191010.Models
{
    public class Ugyfel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "A név megadása kötelező!")]
        [StringLength(50)]
        [Display(Name = "Név")]
        public string Nev { get; set; }
        [Display(Name = "Születésnap")]
        [Min18EvesHaElofizeto]
        public DateTime? SzuletesiDatum { get; set; }
        [Display(Name = "Feliratkozik a hírlevélre?")]
        public bool HirlevelFeliratkozas { get; set; }
        public ElofizetesTipus ElofizetesTipus { get; set; }


        [Display(Name = "Előfizetés típusa:")]
        [Required(ErrorMessage = "Válassz előfizetés típust!")]
        public int ElofizetesTipusId { get; set; }

        public static readonly int Ismeretlen = 0;
        public static readonly int Nincs = 1;
    }
}