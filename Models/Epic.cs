using MyApplication;

namespace MyApplication.Models
{
    public class Epic
    {
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
        public string? DeletedAt { get; set; }

        public int? ID { get; set; }
        public string? Name { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public int? ProjectId { get; init; }
        public Issue[]? Issues { get; set; } = new Issue[0];

        public string GetEpicColor()
        {
            string epicTypeColor = "";
            switch (this.ID % 5)
            {
                case 0:
                    epicTypeColor = "red lighten-1";
                    break;
                case 1:
                    epicTypeColor = "purple lighten-1";
                    break;
                case 2:
                    epicTypeColor = "blue lighten-1";
                    break;
                case 3:
                    epicTypeColor = "green lighten-1";
                    break;
                case 4:
                    epicTypeColor = "orange lighten-1";
                    break;
                default:
                    epicTypeColor = "green lighten-1";
                    break;
            }

            return epicTypeColor;
        }

        public int GetEpicDuration()
        {
            try
            {
                return Convert.ToInt32((DateTime.Parse(this.EndDate) - DateTime.Parse(this.StartDate)).TotalDays);
            }
            catch (System.Exception)
            {
                return 0;
            }
        }
    }
}
