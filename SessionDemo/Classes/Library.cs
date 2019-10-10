using System;
using System.Web;
using System.Reflection;

namespace SessionDemo.Classes
{
    public static class Hybrid
    {
        public static void Save(string sssName, string value)
        {
            SSS.Save(sssName, value);
            Cookie.Save(sssName, value);
        }

        public static string Retrieve(string sssName)
        {
            string returnVal = SSS.Retrieve(sssName);       
            if ( returnVal == string.Empty)                 
            {
                returnVal = Cookie.Retrieve(sssName);       
                if (returnVal != string.Empty)              
                {
                    SSS.Save(sssName, returnVal);           
                }
            }
            return returnVal;
        }

        public static void Delete(string sssName)
        {
            SSS.Delete(sssName);
            Cookie.Delete(sssName);
        }

    }

    public static class Cookie
    {
        public static void Save(string sssName, string value)
        {
            HttpCookie httpCookie = new HttpCookie(sssName, value);
            httpCookie.Expires = DateTime.Now.AddYears(10);
            HttpContext.Current.Response.Cookies.Add(httpCookie);
        }
        public static string Retrieve(string sssName)
        {
            string returnVal = string.Empty;
            if (HttpContext.Current.Request.Cookies[sssName] != null)
            {
                returnVal = HttpContext.Current.Request.Cookies[sssName].Value;
            }
            return returnVal;
        }
        public static void Delete(string sssName)
        {
            HttpCookie httpCookie = new HttpCookie(sssName);
            httpCookie.Expires = DateTime.Now.AddSeconds(-1);
            HttpContext.Current.Response.Cookies.Add(httpCookie);
        }

    }
    public class SSS
    {
        public static string Name { get { return "Name"; } }
        public static string Team { get { return "Team"; } }
        public static string Direction { get { return "Direction"; } }

        public static void Save(string sssName,string value)
        {
            HttpContext.Current.Session[sssName] = value;
        }

        public static string Retrieve(string sssName)
        {
            return (HttpContext.Current.Session[sssName] == null ? string.Empty : HttpContext.Current.Session[sssName].ToString());
        }

        public static void Delete(string sssName)
        {
            HttpContext.Current.Session[sssName] = null;
        }

        public static void DisoseAll()
        {
            foreach (PropertyInfo pi in typeof(SSS).GetProperties())
            {
                HttpContext.Current.Session[pi.Name] = null;
            }
        }

    }
}