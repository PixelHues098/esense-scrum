using MyApplication;
using static EnhancedMergeSort.EnhancedMergeSort;

namespace MyApplication.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string? CreatedAt { get; set; }
        public string? UpdatedAt { get; set; }
        public string? DeletedAt { get; set; }
        public string? Name { get; set; }
        public string? Desc { get; set; }
        public string? Key { get; set; }
        public string? Type { get; set; }
        public int? OwnerId { get; set; }
        public int? ActiveSprint { get; set; }
        public User[]? Members { get; set; }
        public Issue[]? Issues { get; set; }
        public Sprint[]? Sprints { get; set; }
        public Swimlane[]? Swimlanes { get; set; }
        public Epic[]? Epics { get; set; }

        public List<Sprint> GetSprintList(bool isDone)
        {
            try
            {
                List<Sprint> sprintList = new List<Sprint>();
                foreach (var sprint in this.Sprints)
                {
                    if (isDone == sprint.IsDone)
                    {
                        sprintList.Add(sprint);
                    }
                }

                return sprintList;
            }
            catch (System.Exception)
            {
                return new List<Sprint>();
            }
        }

        public List<Swimlane> GetOrderedSwimlaneList()
        {
            try
            {
                List<Swimlane> swimlaneList = new List<Swimlane>();
                List<int> positions = new();
                List<int> sortedPosition = new();
                foreach (var swimlane in this.Swimlanes)
                {
                    swimlaneList.Add(swimlane);
                    positions.Add(swimlane.Position);
                }

                return swimlaneList;
            }
            catch (System.Exception)
            {
                return new List<Swimlane>();
            }
        }

        public List<User> GetUserList()
        {
            try
            {
                List<User> userList = new List<User>();
                foreach (var sprint in this.Members)
                {
                    userList.Add(sprint);
                }

                return userList;
            }
            catch (System.Exception)
            {
                return new List<User>();
            }
        }

        public List<Epic> GetEpicList()
        {
            try
            {
                List<Epic> epicList = new List<Epic>();
                foreach (var epic in this.Epics)
                {
                    epicList.Add(epic);
                }

                return epicList;
            }
            catch (System.Exception)
            {
                return new List<Epic>();
            }
        }

        public List<Epic> GetNameSortedEpicList()
        {
            try
            {
                List<KeyValuePair<int, int>> epicList = new();
                Dictionary<int, Epic> epicDict = new();
                List<Epic> sortedEpicList = new();
                foreach (var epic in this.Epics)
                {
                    epicList.Add(new KeyValuePair<int, int>(Convert.ToInt32(epic.ID), Convert.ToInt32(epic.Name.ToCharArray()[0])));
                    epicDict.Add(Convert.ToInt32(epic.ID), epic);
                }

                var epicListArr = epicList.ToArray();
                sortPair(epicListArr);

                foreach (var epic in epicListArr)
                {
                    sortedEpicList.Add(epicDict[epic.Key]);
                }

                return sortedEpicList;
            }
            catch (System.Exception)
            {
                return new List<Epic>();
            }
        }

        public DateTime GetEarliestEpic()
        {
            DateTime earliestEpic = DateTime.MaxValue;
            foreach (var epic in this.Epics)
            {
                if (earliestEpic > DateTime.Parse(epic.StartDate))
                {
                    earliestEpic = DateTime.Parse(epic.StartDate);
                }
            }

            return earliestEpic;
        }

        public List<Issue> GetActiveProjectIssues()
        {
            try
            {
                List<Issue> issueList = new List<Issue>();
                foreach (var issue in this.Issues)
                {
                    if (issue.SprintId == this.ActiveSprint)
                    {
                        issueList.Add(issue);
                    }
                }

                return issueList;
            }
            catch (System.Exception)
            {
                return new List<Issue>();
            }
        }
    }
}
