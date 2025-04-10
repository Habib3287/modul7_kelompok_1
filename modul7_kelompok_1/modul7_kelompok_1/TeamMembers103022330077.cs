using System.Text.Json;

public class TeamMembers103022330077
{
	public class Members
	{
		public List Menbers<Members>memberList { get; set; };
		public string namaBelakang { get; set; };
		public string namaDepan { get; set; };
		public string nim { get; set; };
		public string gender { get; set; };
		public int umur { get; set; };
	}
    public void readJson()
    {
        string json = File.ReadAllText("DataMahasiswa.json");
        DataMahasiswa_103022330077 data = JsonSerializer.Deserialize<TeamMembers103022330077>(json);
        foreach (var member in data.Members)
        {
            console.writeLine($"Nama: {member.namaDepan} {member.namaBelakang}");
            console.writeLine($"NIM: {member.nim}");
            console.writeline($"age:{member.age}");
            console.writeLine($"gender{member.gender}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            TeamMembers103022330077 data = new TeamMembers103022330077();
            data.readJson();
        }
    }
}
