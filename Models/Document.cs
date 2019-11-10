namespace Instagram.Models
{
    public enum DocumentType
    {
        Image,
        Video
    }

    public class Document
    {
        public int Id { get; set; }
        public DocumentType SourceType { get; set; }
        public byte[] Source { get; set; }
    }
}
