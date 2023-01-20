using MyApplication;

namespace MyApplication.Models
{
    public class Swimlane
    {
        public int ID { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string DeletedAt { get; set; }
        public string Name { get; set; }
        public int Position { get; set; }
        public int ProjectID { get; set; }
        public Issue[] Issues { get; set; }
    }
}
