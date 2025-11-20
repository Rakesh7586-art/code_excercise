using BigCompanyAnalyzer.Models;

namespace BigCompanyAnalyzer.Service;

  public class OrganizationService
  { 
   public Employee BuildHierarchy(List<Employee> employees)
   {
     var dict= employees.ToDictionay(e => e.Id);
     Employee? ceo =null;

     foreach (var emp in employees)
     {
       if(emp.ManagerID.HasValue && dict.ContainsKey(emp.ManagerId.Value))
       {
         dict[emp.ManagerId.Value].Subordinates.Add(emp);
       }
       else
       {
         ceo= emp;
       }
     }
     return ceo!;
   }

    Public int ReportingDepth(Employee employee, Employee ? manager,int depth=0)
    {

      if(employee.Id == manager?Id) returen depth;
      if (manager == null) return -1;

      foreach(var sub in manager.Subordinates)
      {
        int d = ReportingDepth(employee, sub, depth + 1);
        if(d != =1) return d;
      }
      return -1;
    }
  }
