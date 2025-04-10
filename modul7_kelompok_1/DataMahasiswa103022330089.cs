using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa103022330089
{
    public class Address() {
        public String streetAddress;
        public String city;
        public String state;
    }


    public class Identity103022330089()
	{
        public String firstName;
        public String lastName;
        public String gender;
        public int age;
        public Address address;
    }

    public class MataKuliah
    {
        public string code;
        public string name;
    }
    public class Courses() 
    {
        public MataKuliah[] courses;
    }

    public void readJSON()
    {
        var dataJson = File.ReadAllText("../../../jurnal7_1_103022330089.json");
        
        var id = JsonSerializer.Deserialize<Identity103022330089>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        var jadwal = JsonSerializer.Deserialize<Courses>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Nama: {0} {1}", id.firstName, id.lastName);
        Console.WriteLine("Jenis: {0}", id.gender);
        Console.WriteLine("Umur:  {0}", id.age);
        Console.WriteLine("Alamat: {0}, {1}, {2}", id.address.streetAddress, id.address.city, id.address.state);


        for (int i = 0; i < jadwal.courses.Length; i++)
        {
            Console.WriteLine("MK {0} {1} - {2}", i + 1, jadwal.courses[i].code, jadwal.courses[i].name);
        }
    }

}
