using System;

namespace ModelsLibrary.Models
{
    public interface IApprenant
    {
        DateTime DateEntree { get; set; }
        string Promotion { get; set; }

        public void DeposerJustif();
    }
}