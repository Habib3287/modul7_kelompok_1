using System;
using System.Text.Json;

using System.IO;
class DataMahasiswa103022330068
{
    public class Address
    {
        public string streetAddress;
        public string city;
        public string state;
        public Address(string streetAddress, string city, string state) {
            this.streetAddress = streetAddress;
            this.city = city;
            this.state = state;
        }
    }
    public class courses
    {
        public string courseName;
        public string courseCode;
        public courses(string courseName, string courseCode)
        {
            this.courseName = courseName;
            this.courseCode = courseCode;
        }
    }
    public class Mahasiswa
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public Address address;
        public courses[] course; 

        public Mahasiswa(string firstName, string lastName, string gender, int age, Address address, courses[] course)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.gender = gender;
            this.age = age;
            this.address = address;
            this.course = course;
        }
    }
    
    public void readJson()
    {
        var dataJson = File.ReadAllText("../../../jurnal7_1_103022330068.json");
        Mahasiswa mahasiswa = JsonSerializer.Deserialize<Mahasiswa>(dataJson, new JsonSerializerOptions { IncludeFields = true});

        Console.WriteLine("Data Mahasiswa: ");
        Console.WriteLine("Nama Depan: " + mahasiswa.firstName);
        Console.WriteLine(" Nama Belakang" + mahasiswa.lastName);
        Console.WriteLine("gender: " + mahasiswa.gender);
        Console.WriteLine("age: " + mahasiswa.age);
        Console.WriteLine("\naddress: ");
        Console.WriteLine("Jalan: " + mahasiswa.address.streetAddress);
        Console.WriteLine("Kota: " + mahasiswa.address.city);
        Console.WriteLine("Provinsi: " + mahasiswa.address.state);
        Console.WriteLine("\nCourse: ");
        for (int i = 0; i < mahasiswa.course.Length; i++)
        {
            Console.WriteLine("Course Name: " + mahasiswa.course[i].courseName + "Course Code: " + mahasiswa.course[i].courseCode);
        }
    }
  
}
