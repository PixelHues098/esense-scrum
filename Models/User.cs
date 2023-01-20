using MyApplication;

namespace MyApplication.Models
{
    public class User
    {
        public int ID { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string DeletedAt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public Project[] Projects { get; set; }
        public Project[] OwnedProjects { get; set; }
        public Issue[] AssignedIssue { get; set; }
        public Issue[] CreatedIssue { get; set; }
        public Sprint[] Sprints { get; set; }

        public string GetUserAvatarColor()
        {
            string color = "";
            switch (this.ID % 8)
            {
                case 1:
                    color = "red";
                    break;
                case 2:
                    color = "blue";
                    break;
                case 3:
                    color = "purple";
                    break;
                case 4:
                    color = "indigo";
                    break;
                case 5:
                    color = "cyan";
                    break;
                case 6:
                    color = "teal";
                    break;
                case 7:
                    color = "blue-grey";
                    break;
                default:
                    color = "green";
                    break;
            }

            return color + " lighten-1";
        }
    }
}
