using System;
using System.IO;
using System.Text;

namespace LogException
{
    public static class ExceptionManager
    {
        public static void WriteExceptionToFile(Exception ex, string filePath)
        {
            Console.WriteLine("Hello World!");
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.WriteLine("Exception Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace +
                       "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
                }
            }
        }

        public static void WriteMessageToFile(string message, string filePath)
        {
            Console.WriteLine("Hello World!");
            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileStream, Encoding.UTF8))
                {
                    writer.WriteLine("Message :" + message + "<br/>" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                    writer.WriteLine(Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine);
                }
            }
        }
    }
}