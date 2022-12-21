using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStudent;
internal class ListStu
{
    ArrayList arrStu = new ArrayList();
    public void addNewStu()
    {
        Student stu = new();
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("Bạn đang thực hiện thao tác thêm 1  sinh viên vào trong list");
        stu.insertStu();
        arrStu.Add(stu);
    }

    public void deleteStu()
    {
        Student stu = new();
        Console.WriteLine("Nhập tên sinh viên muốn xóa: ");
        stu.Name = Console.ReadLine();
        foreach (Student student in arrStu) { 

            if (arrStu.Contains(stu.Name))
            {
                arrStu.Remove(stu.Name);
            }
            else
            {
                Console.WriteLine("Không tìm thấy tên để xóa!!!!");
            }
        }
    }

    public void searchStu()
    {

    }

    public void updateStu()
    {
        
    } 

    public void showAllStu()
    {
        foreach (Student student in arrStu)
        {
            Console.WriteLine(student.ToString());
        }

    }

    public void sortStu()
    {

    }


}
