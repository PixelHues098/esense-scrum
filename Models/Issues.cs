using MyApplication;

namespace MyApplication.Models
{
    public class Issue
    {
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
        public string? DeletedAt { get; set; }

        public string? ID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; init; }
        public string? Type { get; init; }
        public string? Priority { get; init; }
        public int? Points { get; init; }
        public int? AssigneeId { get; init; }
        public int? CreatorId { get; init; }
        public int? ProjectId { get; init; }
        public int? SwimlaneId { get; init; }
        public int? SprintId { get; init; }
        public int? EpicId { get; init; }

        public string GetIssueIconByType()
        {
            string issueTypeIcon = "";
            switch (this.Type)
            {
                case "bugfix":
                    issueTypeIcon = MudBlazor.Icons.Outlined.BugReport;
                    break;
                case "epic":
                    issueTypeIcon = MudBlazor.Icons.Outlined.BubbleChart;
                    break;
                case "story":
                    issueTypeIcon = MudBlazor.Icons.Outlined.Settings;
                    break;
                case "task":
                    issueTypeIcon = MudBlazor.Icons.Outlined.Bookmarks;
                    break;
                default:
                    issueTypeIcon = MudBlazor.Icons.Outlined.Bookmarks;
                    break;
            }

            return issueTypeIcon;
        }

        public string GetIssueColorByType()
        {
            string issueTypeColor = "";
            switch (this.Type)
            {
                case "bugfix":
                    issueTypeColor = "red-text text-lighten-1";
                    break;
                case "epic":
                    issueTypeColor = "purple-text text-lighten-1";
                    break;
                case "story":
                    issueTypeColor = "blue-text text-lighten-1";
                    break;
                case "task":
                    issueTypeColor = "green-text text-lighten-1";
                    break;
                default:
                    issueTypeColor = "green-text text-lighten-1";
                    break;
            }

            return issueTypeColor;
        }

        public string GetPriorityIcon()
        {
            string priorityIcon = "";
            switch (this.Priority)
            {
                case "very low":
                    priorityIcon = MudBlazor.Icons.Filled.KeyboardDoubleArrowDown;
                    break;
                case "low":
                    priorityIcon = MudBlazor.Icons.Filled.KeyboardArrowDown;
                    break;
                case "neutral":
                    priorityIcon = MudBlazor.Icons.Material.Filled.DragHandle;
                    break;
                case "high":
                    priorityIcon = MudBlazor.Icons.Filled.KeyboardArrowUp;
                    break;
                case "very high":
                    priorityIcon = MudBlazor.Icons.Filled.KeyboardDoubleArrowUp;
                    break;
                default:
                    priorityIcon = "green-text text-lighten-1";
                    break;
            }

            return priorityIcon;
        }

        public string GetPriorityIconColor()
        {
            string baseIconClass = "grey-text lighten-1 text-lighten-5 rounded-lg";
            string priorityIconColor = "";
            switch (this.Priority)
            {
                case "very low":
                    priorityIconColor = "teal";
                    break;
                case "low":
                    priorityIconColor = "blue";
                    break;
                case "neutral":
                    priorityIconColor = "purple";
                    break;
                case "high":
                    priorityIconColor = "orange";
                    break;
                case "very high":
                    priorityIconColor = "red";
                    break;
                default:
                    priorityIconColor = "green-text text-lighten-1";
                    break;
            }

            return baseIconClass + " " + priorityIconColor;
        }

    }
}
