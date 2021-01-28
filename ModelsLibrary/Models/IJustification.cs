namespace ModelsLibrary.Models
{
    public interface IJustification
    {
        bool Approuve { get; set; }
        string Path { get; set; }
        public void Upload();
    }
}