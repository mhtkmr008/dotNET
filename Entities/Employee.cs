namespace HRAPP.Entities;

[Serializable]
public class Employee{
    public int Id{get;set;}
    public string Name{get;set;}

public Employee()
{
      this.Id=1;
    this.Name="mango";
}
public Employee(int id,string name)
{
    this.Id=id;
    this.Name=name;
}
}
