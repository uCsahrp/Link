using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    class Secretaire : Profil, ISecretaire
    {
        public int MyProperty { get; set; }
    }
}
