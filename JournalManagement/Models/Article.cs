namespace JournalManagement.Models
{
    public class Article : BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }
}