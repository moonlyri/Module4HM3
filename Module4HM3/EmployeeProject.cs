namespace Module4HM3;

public class EmployeeProject
{
    public int EmployeeProjectId { get; set; }
    public decimal Rate { get; set; }
    public DateTime StartedDate { get; set; }
    public int EmployeeId { get; set; }
    public int ProjectId { get; set; }
    public Project Project { get; set; }
}