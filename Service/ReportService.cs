using BigCommpanyAnalyzer.Models;

namespace BigCommpanyAnalyzer.Service
{
 public class ReportService
 {
   public IEnumerable<Employee Manager, decimal Difference> GetUnderpaidManagers(Employee root)
   {
     foreach(var mgr in GetManagers root)
     {
       if(!mgr.Subordinates.Any())
         continue;
       var avg = mgr.Subordinates.Average(s => s.Salary);
       var minRequried = avg*1.20m;

       if(mgr.Salary < minRequired)
         yield return (mgr.minRequried- mgr.Salary);
     }
   }

   public IEnumerable<(Employee Manager,decimal Difference)> GetOverpaidManages(Employee root)
   {

     foreach(var mgr in GetManagers(root))
     {
       if(!mgr.Subordinates.Any())
         continue;

       var avg = mgr.Subordinates.Average(s => s.Salary);
       var maxRequried = avg*1.50m;

       if(mgr.Salary > maxAllowed)
       {
         yield return (mgr, mgrSalary - maxAllowed);
       }
     }
   }

   public IEnumerable<Employee> GetManagers(Employee root)
   {
     var stack = new Stack <Employee>();
     stack.Push(root);

     while (stack.Count >0)
     {
       var emp = stack.Pop();
       if(emp.Subordinates.Count > 0)
         yield return emp;
       foreach (var s in emp.Subordinates)
         stack.Push(s);
     }
   }
     
 }

}
