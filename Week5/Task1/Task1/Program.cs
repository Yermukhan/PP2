using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;


namespace Task1
{
    public class Workers
    {
          public string name;
          public string iq;
          public int age;

          public Workers() { }
          public Workers(string name, string iq, int age)
        {
            this.name = name;
            this.iq = iq;
            this.age = age;
        }
    }

    class Program
    {

            static void Main(string[] args)
        {
            Workers w = new Workers("Yerma", "Rabota", 19);
            Console.WriteLine(w.name + " " + w.iq + " " + w.age);
            Console.ReadKey();
            //Serialize(w);
              Deserialize(w);
            
            

        }

             /*static void Serialize(Workers Worker)
        {
            FileStream fs = new FileStream("Data.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer ser = new XmlSerializer(typeof(Workers));
            ser.Serialize(fs, Worker);
            
             }
             */
             

            /*static void Deserialize(Workers Worker)
        {
            FileStream fs = new FileStream("Data.Xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sep = new XmlSerializer(typeof(Workers));
            Worker = sep.Deserialize(fs) as Workers;
            fs.Close();
        }
        */
        static void Deserialize(Workers Worker)
        {
            FileStream fs = new FileStream("Data.Xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer sep = new XmlSerializer(typeof(Workers));
            Worker = sep.Deserialize(fs) as Workers;
            fs.Close();
        }
      }
       }
    

