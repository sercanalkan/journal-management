using System;

namespace JournalManagement.Models
{
    public class BaseModel
    {
        public string Id { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}