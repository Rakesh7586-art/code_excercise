using Xunit;
using BigCompanyAnalyzer.Model;
using BigCompanyAnalyzer.Service;

public class OrganizationServiceTests
{

  [Fact]

  public void BuildHierarchy_ShouldIdentityCEO()
  {
    var employees = new List<Employee>
    {
      New Employee {Id =1 ,FirstName="Test1", MangersId=null},
      New Employee {Id =2 ,FirstName="Test2", MangersId=1}
    };
    var service =new OrganizationService();
    var ceo= service.BuildHierarchy(employees);

    Assert.Equal(1,ceo.Id);
    Assert.Single(ceo.Subrdinates);
  }
}
