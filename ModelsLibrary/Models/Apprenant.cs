using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Apprenant : IApprenant
    {
        public DateTime DateEntree { get; set; }
        public string Promotion { get; set; }

    }
}
