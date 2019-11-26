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
        
        public Offre(int id, string titre, string description, string photo, double prix)
        {
            this.id = id;
            this.titre = titre;
            this.description = description;
            this.photo = photo;
            this.prix = prix;
        }
        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                this.titre = value;
            }
        }
        public string Description
        {

            get
            {
                return description;
            }
            set
            {
                this.description = value;
            }
        }

        public string Photo
        {
            get
            {
                return photo;
            }
            set
            {
                this.photo = value;
            }
        }

        public double Prix
        {
            get
            {
                return prix;
            }
            set
            {
                this.prix = value;
            }
        }

    }
}