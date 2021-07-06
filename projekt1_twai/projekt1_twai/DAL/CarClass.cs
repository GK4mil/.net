using projekt1_twai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt1_twai.DAL
{
    public class CarClass
    {
        private CarContext cc = new CarContext();


        public bool Update(Car c)
        {
            var result = cc.c.FirstOrDefault(a => a.ID == c.ID);
            if(result!=null)
            {
                result.kolor = c.kolor;
                result.Marka = c.Marka;
                result.Model = c.Model;
                result.Paliwo = c.Paliwo;
                result.Poj = c.Poj;
                result.Rok = c.Rok;
                cc.SaveChanges();
                return true;
            }
            return false;
        }

        public Car GetItem(int id)
        {
            var result = cc.c.FirstOrDefault(a => a.ID == id);
            if (result != null)
            {
                return result;
            }
            else
                return null;
           
        }

        public List<Car> GetList()
        {
            return cc.c.ToList();
        }

        public void Add(Car c)
        {
            cc.c.Add(c);
            cc.SaveChanges();
        }

        public bool Del(int id)
        {
            Car it = GetItem(id);
            if(it!=null)
            {
                cc.c.Remove(it);
                cc.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
