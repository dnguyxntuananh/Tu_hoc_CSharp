using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent;
internal class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }

    public Student() { }
    public Student(int id, string name, bool gender, DateTime dob)
    {
        Id = id;
        Name = name;
        Gender = gender;
        Dob = dob;
    }

    public void insertStu()
    {
        Console.WriteLine("ID sinh viên: ");
        Id = int.Parse(Console.ReadLine());
        Console.WriteLine("Tên sinh viên: ");
        Name = Console.ReadLine();
        Console.WriteLine("Giới tính của sinh viên ( true là nam, false là nữ): ");
        Gender = bool.Parse(Console.ReadLine());
        Console.WriteLine("Ngày sinh của sinh viên: ");
        Dob = DateTime.Parse(Console.ReadLine());
    }

    public override string ToString()
    {
        return "ID: " + Id + "Full Name: " + Name + "Gender: " + Gender + "Date of Birth: " + Dob;
    }
}

