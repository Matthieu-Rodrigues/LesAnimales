using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LesAnimales.Models
{
    public class Offre
    {
        private int id;
        private string titre;
        private string description;
        private string photo;
        private double prix;

        public string Titre { get; set; }
        public string Description { get; set; }

        public string Photo { get; set; }

        public double Prix { get; set; }

    }
}
