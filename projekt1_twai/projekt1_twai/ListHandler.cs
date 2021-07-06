using projekt1_twai.DAL;
using projekt1_twai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace projekt1_twai
{
    /// <summary>
    /// Opis podsumowujący dla ListHandler
    /// </summary>
    public class ListHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "tekst/zwykły";
            context.Response.Write(GenerujListe());
        }

        public String GenerujListe()
        {
            CarClass cc = new CarClass();
            List<Car> c = cc.GetList();
            String result = "";
            foreach (Car a in c)
            {
                result += a.ID + " ";
                result += a.Marka + " ";
                result += a.Model + " ";
                result += a.Rok + " ";
                result += a.Poj + " ";
                result += a.Paliwo + " ";
                result += a.kolor + " ";
                result += Environment.NewLine;
            }

            return result;
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}