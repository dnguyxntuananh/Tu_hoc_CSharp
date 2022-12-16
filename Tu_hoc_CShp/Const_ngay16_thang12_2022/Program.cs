// hằng số
//const int doSoi = 100;
//const int doDong = 0;
//const double pi = 3.14;

//Console.WriteLine("Do soi cua da la: {0}",doSoi);
//Console.WriteLine("Do dong cua da la: {0}", doDong);
//Console.WriteLine("gia tri cua pi la: {0}", pi);
//Console.ReadKey();
// khi dùng hằng số ( const ) thì không đổi trong suốt quá trình, nên không được đổi giá trị hằng qua các biến gán

//-------------------------------------------------------------
// các phép toán
// cho người dùng nhập vào 2 giá trị x, y

int x, y;

Console.WriteLine("nhap x: ");
x = int.Parse(Console.ReadLine());
Console.WriteLine("nhap y: ");
y = int.Parse(Console.ReadLine());

Console.WriteLine("moi nhap dau cua phep tinh");
string dau = Console.ReadLine();
switch(dau)
{
    case "+": Console.WriteLine(x + y); ; break;
    case "-": Console.WriteLine(x - y); ; break;
    case "*": Console.WriteLine(x * y); ; break;
    case "/": Console.WriteLine(x / y); ; break;
    case "%": Console.WriteLine(x % y); ; break;
    default : Console.WriteLine("vui long nhap lai"); ; break;
}    