﻿using System;

public class Mahasiswa
{
    public string Nama { get; set; }
    public string NIM { get; set; }

    public List<string> Course { get; set; }

    public int Year { get; set; }

    public Mahasiswa(string Nama, string NIM, List<string> course, int year)
    {
        this.Nama = Nama;
        this.NIM = NIM;
        this.Course = course;
        this.Year = year;
    }
}