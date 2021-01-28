using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Profil : User, IProfil
    {
        public string CIN { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Adresse { get; set; }
        public DateTime Naissance { get; set; }
        public int Phone { get; set; }
        public Profil()
        {

        }

        public void ChercherProfil()
        {
            throw new NotImplementedException();
        }
    }
}
