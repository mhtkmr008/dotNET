namespace HRAPP.Entities;

[Serializable]
public class Employee{
    public int Id{get;set;}
    public string Name{get;set;}
    public string Department{get;set;}
    public string Email{get;set;}

    public Employee(int id,string name,string department,string email)
    {
        this.Id=id;
        this.Name=name;
        this.Department=department;
        this.Email=email;
    }
}
