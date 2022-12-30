using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public static class logger
    {
        public static void Writelog(string message)
        {
            string logPath = @"C:\Users\2101811\Downloads\logger.txt";
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now} : {message}");

            }
        }
    }
}
