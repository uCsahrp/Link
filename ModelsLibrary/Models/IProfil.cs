using System;

namespace ModelsLibrary.Models
{
    public interface IProfil
    {
        string Adresse { get; set; }
        string CIN { get; set; }
        DateTime Naissance { get; set; }
        string Nom { get; set; }
        int Phone { get; set; }
        string Prenom { get; set; }
    }
}