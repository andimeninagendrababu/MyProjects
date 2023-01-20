using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.rep
{
    public interface empInterface1
    {
        List<Class1> GetAllEmployee();

        




        // string update(Empmodel em);


        string insert(empDetail em);
        
        string Bulkdelete(Class1 em);
        
        string DeleteEmp(int iD);
        string Update(empDetail em);
        string Bulkinsert(List<empDetail> em);
        //List<Class1> GetEmployeeByID(int id);
        empDetail GetEmployeeByID(int id);
    }

}
