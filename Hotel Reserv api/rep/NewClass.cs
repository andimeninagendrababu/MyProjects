using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.rep
{

   
    public class NewClass : empInterface1
    {
        employeeEntities emp = new employeeEntities();
        public List<empDetail> empList = new List<empDetail>();
        

        List<Class1> empInterface1.GetAllEmployee()
        {
            List<Class1> empList = null;
            empList = emp.empDetails.Select(s => new Class1()
            {
                ID = s.ID,
                fname = s.fname,
                lname = s.lname,
                phoneNo = s.phoneNo,
                city = s.city,



            }).ToList<Class1>();
            return empList;
        }





        public string insert(empDetail em)
        {
            var abc = emp.empDetails.Where(i => i.ID == em.ID).FirstOrDefault();
            if (abc == null)
            {

                emp.empDetails.Add(new empDetail()

                {
                    ID = em.ID,
                    fname = em.fname,
                    lname = em.lname,
                    phoneNo = em.phoneNo,

                    city = em.city,

                });


            }
            emp.SaveChanges();

            return "Inserted";
        }

        string empInterface1.Bulkinsert(List<empDetail> em)
        {
            foreach (empDetail ins in em)
            {

                var abc = emp.empDetails.Where(i => i.ID == ins.ID).FirstOrDefault();
                if (abc == null)
                {
                    emp.empDetails.Add(new empDetail
                    {
                        ID = ins.ID,
                        fname = ins.fname,
                        lname = ins.lname,
                        phoneNo = ins.phoneNo,
                        city = ins.city,



                    });

                }
                emp.SaveChanges();

            }
            return "Bulk inserted";
        }

        public string Bulkdelete(Class1 em)
        {
            throw new NotImplementedException();
        }



        public string Update(empDetail em)
        {
            var abc = emp.empDetails.Where(u => u.ID == em.ID).FirstOrDefault();
            if (abc != null)
            {
                abc.ID = em.ID;
                abc.fname = em.fname;
                abc.lname = em.lname;
                abc.phoneNo = em.phoneNo;
                abc.city = em.city;


            }
            emp.SaveChanges();
            return "Updated";
        }



        public string DeleteEmp(int ID)
        {
            empDetail edf = emp.empDetails.Where(emp => emp.ID == ID).Single<empDetail>();
            if (edf != null)
            {
                emp.empDetails.Remove(edf);
            }
            emp.SaveChanges();
            return " Sucessfully Deleted ";

        }


        //  List<Class1> empInterface1.GetEmployeeByID(int id)
        // {
        //    var em = emp.empDetails.Where(n => n.ID == id).Select(s => new Class1()
        //    {
        //     ID = s.ID,
        //    fname = s.fname,
        //     lname=s.lname,

        //    phoneNo = s.phoneNo,
        //    city = s.city,

        //}).ToList<Class1>();

        //   return em;

        //  }


        empDetail empInterface1.GetEmployeeByID(int ID)
        {

            var emplist = emp.empDetails.FirstOrDefault(a => a.ID == ID);
            return emplist;
        }
        //Customer CustomerInterface1.GetById(int CustomerId)
        //{
        //    var emplist = sx.Customers.FirstOrDefault(s => s.CustomerId == CustomerId);
        //    return emplist;
        //}



    }

   
}