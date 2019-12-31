using System;
using System.IO;
using System.Windows.Forms;

namespace OnlineBookStore
{
    public class Logger
    {
        public static void logger(string ItemInfo)
        {
            Customer customer = Customer.GetInstance();
            string path = Application.StartupPath + @"/Log.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", "Username", "Item Info", "Date", "Time"));
                    sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", customer.Name, ItemInfo, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
                }
            }

            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(string.Format("{0,-25} {1,-50} {2,-15} {3,-15}", customer.Name, ItemInfo, DateTime.Now.ToShortDateString(), DateTime.Now.ToLongTimeString()));
            }
        }
    }
}