using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Groupe : Classe, IGroupe
    {
        public string GroupeLibelle { get; set; }
        public string Section { get; set; }
        public List<IApprenant> Apprenants;
        public Groupe()
        {
            Apprenants = new List<IApprenant>();
        }
    }
}
