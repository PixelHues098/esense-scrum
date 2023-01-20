using MyApplication;

namespace MyApplication.Models
{
    public class Sprint
    {
        public int? ID { get; set; }
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
        public string? DeletedAt { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
        public bool IsDone { get; set; }
        public int? ProjectID { get; set; }
        public int? CreatorID { get; set; }
        public Issue[]? Issues { get; set; } = new Issue[0];

        public int? GetTotalPoints()
        {
            int? totalPoints = 0;
            if (!(this.Issues is null))
            {
                foreach (var issues in this.Issues)
                {
                    totalPoints += issues.Points;
                }
            }
            return totalPoints;
        }

        public int GetSprintDays()
        {
            int sprintDays = 0;
            if (!(this.StartDate is null) && !(this.EndDate is null))
            {
                string startDateStr = this.StartDate.Split("T")[0];
                string endDateStr = this.EndDate.Split("T")[0];

                DateTime startDate = DateTime.Parse(startDateStr, System.Globalization.CultureInfo.CurrentCulture);
                DateTime endDate = DateTime.Parse(endDateStr, System.Globalization.CultureInfo.CurrentCulture);

                sprintDays = Convert.ToInt32((endDate - startDate).TotalDays);
            }

            return sprintDays;
        }
    }
}
