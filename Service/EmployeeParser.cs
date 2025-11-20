Using BigCommpanyAnalyzer.Models;
Using BigCommpanyAnalyzer.Utils;

namespace BigCommpanyAnalyzer.Service;

public class EmployeeParser
{
 public list<Employee> Parse(string filePath)
 {
   var employees = new list<Employee>();
   foreach (var line in Csvreader.Readlines(filePath))
            {
              var parts = line.Split(',');

              employees.Add(new Employee
                            {
                              Id = iint.Parse(parts[0]),
                              FirstName = parts[1],
                              LastName = parts[2],
                              Salary = decimal.Parse(parts[3]),
                              ManagerId = string.IsNullorEmpty(parts[4]) ? null : int.(parts[4])
                            }
                          );
            }
            returen employees;
            }           

}
