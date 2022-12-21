// tạo mảng
using ManageStudent;
using System.Collections;
using System.Text;

ListStu list = new();
Console.InputEncoding = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;
bool check = true;
while (true) {
// tạo menu
Console.WriteLine("-----------------MENU----------------------");
Console.WriteLine("1 để thêm sinh viên vào danh sách");
Console.WriteLine("2 để xóa một sinh viên ra khỏi danh sách");
Console.WriteLine("3 để tìm kiếm thông tin  sinh viên từ list");
Console.WriteLine("4 để cập nhật thông tin sinh dựa vào id sinh viên");
Console.WriteLine("5 để hiển thị toàn bộ thông tin của tất cả sinh viên");
Console.WriteLine("6 để sắp xếp lại thông tin sinh viên theo id sinh viên ( DESC )");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("CHỌN THAO TÁC MÀ BẠN MUỐN THỰC HIỆN");
int thaotac = int.Parse(Console.ReadLine());
switch (thaotac)
{
    case 1: list.addNewStu(); break;
    case 2: list.deleteStu(); break;
    case 5: list.showAllStu(); break;
    default : Console.WriteLine("Nhập sai rồi, vui lòng nhập lại");break;
}
}

