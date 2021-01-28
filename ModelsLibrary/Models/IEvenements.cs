using System;

namespace ModelsLibrary.Models
{
    public interface IEvenements
    {
        DateTime EndAt { get; set; }
        DateTime StartAt { get; set; }
        string Subject { get; set; }
    }
}