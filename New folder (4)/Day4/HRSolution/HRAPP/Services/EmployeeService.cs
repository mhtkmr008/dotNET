using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService:IEmployeeService{
   string fileName=@"D:\Employee.json";
    public List<Employee> GetAll(){
       List<Employee> employees=new List<Employee>();
       /*employees.Add(new Employee{Id=1, Name="Shivam"});
       employees.Add(new Employee{Id=2, Name="Chirag"});
       employees.Add(new Employee{Id=1, Name="Manisha"});
       employees.Add(new Employee{Id=1, Name="shailesh"});*/
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"D:\Employee.json";
       employees=mgr.DeSerialize(fileName);
       return employees;
    }
    public void GetById(int id){

    }
    public void Insert(Employee emp)
    {
      List<Employee> employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      employees=mgr.DeSerialize(fileName);
      employees.Add(emp);
      mgr.Serialize(employees,fileName);
    }
      public void Update(Employee emp){}
      public void Delete(int id){
         List<Employee> employees3=new List<Employee>();
         RepositoryManager mgr=new RepositoryManager();
         employees3=mgr.DeSerialize(fileName);
         foreach(Employee e in employees3)
         {
            if(e.Id==id)
            {
               employees3.Remove(e);
               Console.WriteLine("Employee removed");
            }
            else
            {
               Console.WriteLine("Employee id not Valid");
            }
         }
         mgr.Serialize(employees3,fileName);
      }

}