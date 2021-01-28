using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Classe : IClasse
    {
        public string Libelle { get; set; }
        public List<IApprenant> apprenants;
        public Classe()
        {
            apprenants = new List<IApprenant>();
        }

        public void CreerGroupes()
        {
            throw new NotImplementedException();
        }
    }
}
