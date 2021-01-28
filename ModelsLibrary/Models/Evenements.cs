using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Evenements : IEvenements
    {
        public DateTime StartAt { get; set; }

        public DateTime EndAt { get; set; }

        public string Subject { get; set; }
        public Evenements()
        {

        }

        public void AjouterEvenement()
        {
            throw new NotImplementedException();
        }
    }
}
