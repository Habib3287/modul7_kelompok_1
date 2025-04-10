using System.Text.json;
using static DataMahasiswa_103022330077
public class DataMahasiswa_103022330077
{
	public class Address
    {
        public string jalan { get; set; };
        public string kota { get; set; };
        public string provinsi { get; set; };
    }
	public class Course
    {
        public string fakultas { get; set; };
        public string kode { get; set; };
    }

    public class DataMahasiswa
    {
        public List Course <Course> courseList { get; set; };
        public string depan {get;set;};
        public string belakang { get; set; };
        public long nim { get; set; };
	}
	public void readJson()
	{
		string json = File.ReadAllText("DataMahasiswa.json");
		DataMahasiswa_103022330077 data = JsonSerializer.Deserialize<DataMahasiswa_103022330077>(json);
		Console.WriteLine($"Nama: {data.nama.depan} {data.nama.belakang}");
		Console.WriteLine($"NIM: {data.nim}");
		Console.WriteLine($"Course: {data.CourseList}");
        Console.WriteLine($"Alamat: {data.alamat.jalan}, {data.alamat.kota}, {data.alamat.provinsi}");

    }
	class Program
	{
        static void Main(string[] args)
        {
            DataMahasiswa_103022330077 data = new DataMahasiswa_103022330077();
            data.readJson();
        }
    }
}
