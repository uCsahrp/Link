using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Absence : IAbsence
    {
        public int Duree { get; set; }
        public bool Justification { get; set; }

        public Absence()
        {

        }

        public void CalculerDuree()
        {
            throw new NotImplementedException();
        }
    }
}
