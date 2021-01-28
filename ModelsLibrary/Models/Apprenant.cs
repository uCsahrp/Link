using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Apprenant : Profil, IApprenant
    {
        public DateTime DateEntree { get; set; }
        public string Promotion { get; set; }

        public Apprenant()
        {

        }

        public void DeposerJustif()
        {
            throw new NotImplementedException();
        }
    }
}
