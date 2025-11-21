using BigCompanyAnalyzer.Service;

var parser = new EmployeeParser();

var employees= parser.Parse("Data/Sample_employees.csv");
var org= new OrganizationService();
var ceo = org.BuildHierarchy(employees);

var report = new ReportService();

console.WriteLine(""Underpaid Manager);
foreach(var r in report.GetUnderpaidManages(ceo))
  console.Writeline($"{r.Manager.FirstName} is underpaid by{r.Diffrence}");
