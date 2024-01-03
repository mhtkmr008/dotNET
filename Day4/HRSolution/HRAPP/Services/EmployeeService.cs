using HRAPP.Entities;
using HRAPP.Repositories;
namespace HRAPP.Services;

public class EmployeeService:IEmployeeService{
   string fileName=@"C:\Users\mhtkm\OneDrive\Desktop\IACSD\DotNET\Day4\HRSolution\HRAPP\Employee.json";
    public List<Employee> GetAll(){
       List<Employee> employees=new List<Employee>();
       /*employees.Add(new Employee{Id=1, Name="Shivam"});
       employees.Add(new Employee{Id=2, Name="Chirag"});
       employees.Add(new Employee{Id=1, Name="Manisha"});
       employees.Add(new Employee{Id=1, Name="shailesh"});*/
       RepositoryManager mgr=new RepositoryManager();
       string fileName=@"C:\Users\mhtkm\OneDrive\Desktop\IACSD\DotNET\Day4\HRSolution\HRAPP\Employee.json";
       employees=mgr.DeSerialize(fileName);
       return employees;
    }
    public void GetById(int id){
      List<Employee>employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      employees=mgr.DeSerialize(fileName);
      foreach(Employee e in employees)
      {
         if(e.Id==id)
         {
            Console.WriteLine(e.Id+" "+e.Name+" "+e.Department+" "+e.Email);
            break;
         }
         else
         {
            Console.WriteLine("Please Enter Correct ID");
         }
      }

    }
    public void Insert(Employee emp)
    {
      List<Employee> employees=new List<Employee>();
      RepositoryManager mgr=new RepositoryManager();
      employees=mgr.DeSerialize(fileName);
      employees.Add(emp);
      mgr.Serialize(employees,fileName);
    }
      public void Update(int id){
         List<Employee>employees=new List<Employee>();
         RepositoryManager mgr=new RepositoryManager();
         employees=mgr.DeSerialize(fileName);
         foreach(Employee e in employees)
         {
            if(e.Id==id)
            {
               Console.WriteLine("Enter Employee Details");
               Console.WriteLine("Enter Name ,Department ,Email");
               Employee emp=new Employee(e.Id,Console.ReadLine(),Console.ReadLine(),Console.ReadLine());
               employees.Remove(e);
               employees.Add(emp);
               Console.WriteLine("Employee Updated");
               break;
            }
            else
            {
               Console.WriteLine("Please Enter Correct ID");
            }
         }
         mgr.Serialize(employees,fileName);
      }
      
      
      
      
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
               break;
            }
            else
            {
               Console.WriteLine("Employee id not Valid");
            }
         }
         mgr.Serialize(employees3,fileName);
      }

}