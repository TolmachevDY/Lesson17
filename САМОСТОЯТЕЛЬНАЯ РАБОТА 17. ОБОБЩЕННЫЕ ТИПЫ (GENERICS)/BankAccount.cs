using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace САМОСТОЯТЕЛЬНАЯ_РАБОТА_17.ОБОБЩЕННЫЕ_ТИПЫ__GENERICS_
{
    /*Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  Класс должен быть объявлен как обобщенный. 
    Универсальный параметр T должен определять тип номера счета. Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.*/
    class BankAccount<T>//создаем обобщенный класс
    {
        T Score { get; set; }//создаем параметр с универсальным типом данных
        double Balance { get; set; }
        string FullName { get; set; }

        public void Input()//создаем метод для заполнения данных
        {
            Console.WriteLine("Введите номер счета");
            Score = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));//приводим введенное значение к универсальному типу данных
            Console.WriteLine("Введите баланс");
            Balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО");
            FullName = Console.ReadLine();
        }
        public string GetInfo()//создаем метод для чтения данных
        {
            return $"{FullName} н/с:{Score} баланс:{Balance:f2} ";
        }
    }
}
