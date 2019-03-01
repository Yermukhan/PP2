using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Task1
{
    public class Complex
    {
        public int real;
        public int imaginary;

        public Complex() { }
        public Complex(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;

        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Complex c = new Complex(5, 2);
            // Serialize(c);
            Deserialize();
            Console.ReadKey();


        }

        static void Serialize(Complex c)
        {
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer ser = new XmlSerializer(typeof(Complex));
            ser.Serialize(fs, c);
            fs.Close();

        }





        static void Deserialize()
        {

            FileStream fs = new FileStream("Data.Xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sep = new XmlSerializer(typeof(Complex));
            Complex c1 = sep.Deserialize(fs) as Complex;
            fs.Close();
            Console.WriteLine(c1.real);
        }


    }
}
       
    

