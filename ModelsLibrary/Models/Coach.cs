using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Coach : Profil, ICoach
    {
        public int MyProperty { get; set; }
    }
}
