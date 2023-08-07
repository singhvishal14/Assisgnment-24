using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConAppAssisgnment24
{
    internal class Program
    {
        static void Main(string[] args) { 
            //Employee employee = new Employee();
            //Console.WriteLine("Enter Emp ID: ");
            //employee.Id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter FirstName");
            //employee.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter Last Name");
            //employee.LastName = Console.ReadLine();
            //Console.WriteLine("Enter Salary");
            //employee.Salary=double.Parse(Console.ReadLine());
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            //using (TextWriter writer = new StreamWriter("D:\\Angular Self paced\\Assisgnment\\ConAppAssisgnment24\\Emp.xml"))
            //{
            //    serializer.Serialize(writer, employee);
            //};
            using (TextReader reader = new StreamReader("D:\\Angular Self paced\\Assisgnment\\ConAppAssisgnment24\\Emp.xml"))
            {
                Employee deserializedPerson = (Employee)serializer.Deserialize(reader);
                Console.WriteLine($"ID:{deserializedPerson.Id}\nFirst Name:{deserializedPerson.FirstName}\nLast Name:{deserializedPerson.LastName}\nSalary:{deserializedPerson.Salary}");
            };
            Console.WriteLine("XMl Serialization Done");


            // string path = "D:\\Angular Self paced\\Assisgnment\\ConAppAssisgnment24\\Emp.bin";
            //FileStream stream = new FileStream(path, FileMode.Create);

            //BinaryFormatter bf = new BinaryFormatter();
            //bf.Serialize(stream, employee);
            // FileStream stream = new FileStream(path, FileMode.Open);
            // BinaryFormatter bf = new BinaryFormatter();

            //.Serialize(stream);
            //Console.WriteLine("File Created Succesfully");
            //Employee employee = (Employee)bf.Deserialize(stream);



            //Console.WriteLine("Emp ID: "+employee.Id);
            // Console.WriteLine("Emp FName "+employee.FirstName);
            //Console.WriteLine("Emp lname " + employee.LastName );
            //Console.WriteLine("Emp Sal "+employee.Salary);
            //Console.WriteLine("Perfom Succesfully");

            //stream.Close();
            Console.ReadKey();

            




        }
    }
}
