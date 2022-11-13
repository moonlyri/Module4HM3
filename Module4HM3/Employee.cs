using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
namespace Module4HM3;

public class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HiredDate { get; set; }
    public DateOnly DateOfBirth { get; set; }
    public int OfficeId { get; set; }
    public int TitleId { get; set; }
    public Project Project { get; set; }
    public int ProjectId { get; set; }
}