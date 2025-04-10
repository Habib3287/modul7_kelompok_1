using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;

public class TeamMembers103022330089
{
    public class Member
    {
        public string firstName;
        public string lastName;
        public string gender;
        public int age;
        public string nim;
    }

    public class MemberList
    {
        public List<Member> members;
    }

    public void ReadJSON()
    {
        string dataJson = File.ReadAllText("../../../jurnal7_2_103022330089.json");

         var id = JsonSerializer.Deserialize<MemberList>(dataJson, new JsonSerializerOptions { IncludeFields = true });

        Console.WriteLine("Team Member List:");
        int i = 1;
        foreach (Member m in id.members)
        {
            Console.WriteLine($"{m.nim} - {m.firstName} {m.lastName} ({m.age} - {m.gender})");
        }
    }
}