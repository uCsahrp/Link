using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsLibrary.Models
{
    public class Justification : IJustification
    {
        public string Path { get; set; }
        public bool Approuve { get; set; }
        public Justification()
        {

        }

        public void Upload()
        {
            throw new NotImplementedException();
        }
    }
}
