
using EMP.Group;
using Microsoft.EntityFrameworkCore;

var db=new GroupDbContext();

if(args.Length == 0)
{
    foreach(var D in db.Departments)
     Console.WriteLine("{0, -4}{1, 10}{2, 14}", D.Id,D.Dname, D.Loc);
}
else
{
    int d = int.Parse(args[0]);
    var Emp = db.Departments
                .Where(p => p.Id == d)
                .Include(p=>p.Employees)
                .FirstOrDefault();
    //if(EmpSalary != null)
        foreach(var entry in Emp.Employees)
            Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",entry.Id, entry.Ename, entry.EmpSalary,entry.EmpAge,entry.DepartmentId);
    
}