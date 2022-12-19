using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codes_In_Ebooks;
internal class Code_Snippetes
{
    public void Snipp13_page62()
    {
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding= Encoding.Unicode;
        string name;
        Console.WriteLine("Enter Your Name: ");
        name = Console.ReadLine();
        Console.WriteLine("You are {0}", name);
    }

    public void Snipp14_page63()
    { 
        Console.InputEncoding = Encoding.Unicode;
        Console.OutputEncoding = Encoding.Unicode;
        string cusName;
        double loanAmount;
        float interest = 0.09f;
        double interestAmount = 0;
        double totalAmount = 0;
        Console.WriteLine("Enter the name of Customer: ");
        cusName = Console.ReadLine();
        Console.WriteLine("Enter loan amount: ");
        loanAmount = Convert.ToDouble(Console.ReadLine());
        interestAmount = interest * loanAmount;
        totalAmount = interestAmount + interestAmount;
        Console.WriteLine("-------------------------------");
        Console.WriteLine("The name of Customer: {0}",cusName);
        Console.WriteLine("Loan Amount: ${0:#,###.#0} \nInterest Rate: {1:0#%} \nInterest Amount: ${2:#,###.#0}", loanAmount, interest, interestAmount);
        Console.WriteLine("Total amount to paid: ${0:#,###.#0}", totalAmount);

    }

    public void Snipp21_page72()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Date is: {0:ddd, dd/MM/yyyy}", date); // ddd is character day ( ex: 19/12 is Mon), dd is number day ( ex: today is 19/12), MM is month, yyyy is year
        Console.WriteLine("Time is: {0:hh:mm:tt}", date);
        Console.WriteLine("24 Hours is: {0:hh:mm}",date);
        Console.WriteLine("Time with second is {0:hh:mm:ss:tt}", date);
        Console.WriteLine("Day of month: {0:m}", date);
        Console.WriteLine("Year is: {0:yyyy}", date);
        
    }

}
