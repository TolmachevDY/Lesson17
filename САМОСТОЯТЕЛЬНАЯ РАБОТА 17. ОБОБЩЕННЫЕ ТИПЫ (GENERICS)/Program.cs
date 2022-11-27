using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace САМОСТОЯТЕЛЬНАЯ_РАБОТА_17.ОБОБЩЕННЫЕ_ТИПЫ__GENERICS_
{
    class Program
    {
        /*Создать  несколько экземпляров класса, параметризированного различными типам. 
        Заполнить его поля и вывести на экран информацию об экземпляре класса.*/
        static void Main(string[] args)
        {
            BankAccount<int> bankAccount1 = new BankAccount<int>();//создаем экземпляр класса, параметрезированного типом данных int 
            bankAccount1.Input();//на экземпляре класса вызываем метод заполнения данных 
            Console.WriteLine(bankAccount1.GetInfo());//выводим на консоль данные, считанные методом из класса
            BankAccount<string> bankAccount2 = new BankAccount<string>();//создаем экземпляр класса, параметрезированного типом данных string 
            bankAccount2.Input();//на экземпляре класса вызываем метод заполнения данных
            Console.WriteLine(bankAccount2.GetInfo());//выводим на консоль данные, считанные методом из класса
            Console.ReadKey();
        }
    }
}
