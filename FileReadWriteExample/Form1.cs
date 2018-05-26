using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileReadWriteExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWriteRead_Click(object sender, EventArgs e)
        {
            //StreamWriter writeToFile = File.CreateText("C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt");
            //string a = txtBoxWrite.Text;
            //writeToFile.WriteLine(a);
            //writeToFile.Close();

            //writeFile(txtBoxWrite.Text, "C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt");

            //lblReadFile.Text = readFile("C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt");

            FileWrite fWrite = new FileWrite();
            fWrite.fileContent = txtBoxWrite.Text;
            fWrite.filePath = "C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt";
            // fWrite.writeFile(txtBoxWrite.Text, "C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt");
            fWrite.writeFile();
            FileRead fRead = new FileRead();
            lblReadFile.Text = fRead.readFile("C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt");
            
        }
        //public void writeFile(string fileContent, string filePath)
        //{
        //    StreamWriter writeToFile = File.CreateText(filePath);
        //    string a = fileContent;
        //    writeToFile.WriteLine(a);
        //    writeToFile.Close();
        //}
        //public string readFile(string filePath)
        //{
        //    StreamReader ReadFromFile = new StreamReader(filePath);
        //    string b = ReadFromFile.ReadLine();
        //    return b;

        //}
        private void btnDelete_Click(object sender, EventArgs e)
        {
            FileDeleteLogs fDelete = new FileDeleteLogs();
            fDelete.filePath = @"C:/Users/pavan/Desktop/NewRandom/WriteAndReadFile.txt";
            fDelete.deleteLogs();
        }
    }
    public class FileWrite
    {
        public string filePath;
        public string fileContent;
        public void writeFile()
        {
            StreamWriter writeToFile = File.AppendText(filePath);
            string a = fileContent;
            writeToFile.WriteLine(a);
            writeToFile.Close();
        }
    }
    public class FileRead
    {
        string filePath;
        public string readFile(string filePath)
        {
            StreamReader ReadFromFile = new StreamReader(filePath);
            string b = ReadFromFile.ReadLine();
            ReadFromFile.Close();
            return b;

        }
    }

    public class FileDeleteLogs
    {
        public string filePath;
        public void deleteLogs()
        {
            File.Delete(filePath);
        }
    }
}
        

        

