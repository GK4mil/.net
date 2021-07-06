using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace projekt1_twai.Models
{
    public class Car:CarPrimary
    {
       
        [Required(ErrorMessage = "Proszę podać Markę pojazdu!")]
        public String Marka { get; set; }

        [Required(ErrorMessage = "Proszę podać Model pojazdu!")]
        public String Model { get; set; }

        [Required(ErrorMessage = "Proszę podać pojemność silnika!")]
        [Range(0, 100000, ErrorMessage = "Pojemność silnika nie może być wartością ujemna")]
        public int Poj { get; set; }

        public String Paliwo { get; set; }

        [Required(ErrorMessage = "Proszę podać rok produkcji!")]
        [Range(0, 3000, ErrorMessage = "Rok produkcji nie może być wartością ujemna")]
        public int Rok { get; set; }

        [Required(ErrorMessage = "Proszę podać cenę pojazdu!")]
        [Range(0, 99999999, ErrorMessage = "Cena nie może być wartością ujemna")]
        public float Cena { get; set; }

        [Required(ErrorMessage = "Proszę podać kolor karoserii!")]
        public String kolor { get; set; }


    }
}