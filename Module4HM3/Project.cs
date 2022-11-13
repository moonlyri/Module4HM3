namespace Module4HM3;

public class Project
{
    public int ProjectId { get; set; }
    public string Name { get; set; }
    public decimal Budget { get; set; }
    public DateTime StartedDate { get; set; }
    public List<Title> Titles { get; set; } = new List<Title>();
    public List<Employee> Employees { get; set; } = new List<Employee>();
    public List<Office> Offices { get; set; } = new List<Office>();
    public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
}