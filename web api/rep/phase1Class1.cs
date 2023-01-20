using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication4.Models;

namespace WebApplication4.rep
{
    public class phase1Class1 : phase1Interface1
    {
        employeeEntities emp = new employeeEntities();
        public List<phase1> empList = new List<phase1>();

        

        public List<phase1Model> GetAllDetails()
        {
            List<phase1Model> empList = null;
            empList =emp.phase1.Select(s=> new phase1Model()
            {
                Sl_No= s.Sl_No,
                Hotel= s.Hotel,
                Arrival= s.Arrival,
                Departure= s.Departure,
                Type= s.Type,
                Guests= s.Guests,
                price= s.price,
            }).ToList<phase1Model>();
            return empList;
        }

        public string insert(phase1 em)
        {
            var abc = emp.phase1.Where(i => i.Sl_No == em.Sl_No).FirstOrDefault();
            if (abc == null)
            {

                emp.phase1.Add(new phase1()

                {
                    Sl_No=em.Sl_No,
                    Hotel=em.Hotel,
                    Arrival=em.Arrival,
                    Departure=em.Departure,
                    Type=em.Type,
                    Guests=em.Guests,
                    price=em.price,

                    

                });


            }
            else {
                abc.Sl_No = em.Sl_No;
                abc.Hotel = em.Hotel;
                abc.Arrival = em.Arrival;
                abc.Departure = em.Departure;
                abc.Type = em.Type;
                abc.Guests = em.Guests;
                abc.price = em.price;

            }
            emp.SaveChanges();
            emp.Dispose();
            return "Inserted";
        }

        public string Update(phase1 em)
        {
            var abc = emp.phase1.Where(u => u.Sl_No == em.Sl_No).FirstOrDefault();
            if (abc != null)
            {
                abc.Sl_No= em.Sl_No;
                abc.Hotel= em.Hotel;
                abc.Arrival= em.Arrival;
                abc.Departure= em.Departure;
                abc.Type= em.Type;
                abc.Guests= em.Guests;
                abc.price= em.price;
           
            }
            emp.SaveChanges();
            return "Updated";
        }

        public string Delete(int Sl_No)
        {
            phase1 edf = emp.phase1.Where(emp => emp.Sl_No == Sl_No).Single<phase1>();
            if (edf != null)
            {
                emp.phase1.Remove(edf);
            }
            emp.SaveChanges();
            return " Sucessfully Deleted ";

        }
    }
}