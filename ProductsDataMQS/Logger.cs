using System;
using System.IO;
using System.Windows.Forms;

namespace ProductsDataMQS
{
    class Logger
    {
        string logString = string.Empty;
        string filepath = string.Empty;
        string StrLogNameTime = string.Empty;
        DateTime logNameTime = DateTime.Now;

        public Logger() { }
        public void logGen(string message)
        {
            try
            {
                DateTime now = DateTime.Now;
                logString = "DB UPDATED: " + now.ToString() + " " + message;
                Application.DoEvents();
                filepath = @"log\dbUpdateRecord.txt";

                if (!File.Exists(filepath))
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath, FileMode.Create, FileAccess.Write)))
                    {
                        writer.WriteLine(logString);
                    }
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(new FileStream(filepath, FileMode.Append, FileAccess.Write)))
                    {
                        writer.WriteLine(logString);
                    }
                }
            }
            catch
            {
                MessageBox.Show("diretório e/ou arquivo não encontrados!!! - log\\dbUpdateRecord.txt");
            }
        }     
    }
}