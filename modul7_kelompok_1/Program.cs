
﻿class Program
{
    public static void Main(string[] args)
    {
        DataMahasiswa103022330089 data = new DataMahasiswa103022330089();
        TeamMembers103022330089 anggota = new TeamMembers103022330089();
        anggota.ReadJSON();
        data.readJSON();
    }
}