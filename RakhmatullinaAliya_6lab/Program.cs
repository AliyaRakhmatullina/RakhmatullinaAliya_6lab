using RakhmatullinaAliya_6lab.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RakhmatullinaAliya_6lab.Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            //банковского счета(использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            //доступа к данным – заполнения и чтения.Создать объект класса, заполнить его поля и
            //вывести информацию об объекте класса на печать.

            BankAccount account = new BankAccount();
            account.SetAccountNumber("1234567890");
            account.SetBalance(1500.75m);
            account.SetAccountType(BankAccount.AccountType.Savings);
            account.DisplayInfo();


            //Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            //номер счета генерировался сам и был уникальным.Для этого надо создать в классе
            //статическую переменную и метод, который увеличивает значение этого переменной.
            BankAccount account1 = new BankAccount();
            account1.SetBalance(1500.75m);
            account1.SetAccountType(BankAccount.AccountType.Savings);
            BankAccount account2 = new BankAccount();
            account2.SetBalance(2000.50m);
            account2.SetAccountType(BankAccount.AccountType.Checking);
            account1.DisplayInfo();
            account2.DisplayInfo();



            //Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
            //высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            //предусмотреть методы для заполнения полей и получения значений полей для печати.
            //Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            //квартир на этаже и т.д.Предусмотреть возможность, чтобы уникальный номер здания
            //генерировался программно.Для этого в классе предусмотреть статическое поле, которое бы
            //хранило последний использованный номер здания, и предусмотреть метод, который
            //увеличивал бы значение этого поля.
            
            Building building1 = new Building();
            building1.SetHeight(30.0);
            building1.SetFloors(10);
            building1.SetApartments(100);
            building1.SetEntrances(2);

           
            Building building2 = new Building();
            building2.SetHeight(50.0);
            building2.SetFloors(15);
            building2.SetApartments(200);
            building2.SetEntrances(4);

          
            building1.DisplayInfo();
            Console.WriteLine($"Floor Height: {building1.CalculateFloorHeight()} meters");
            Console.WriteLine($"Apartments per Entrance: {building1.CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Apartments per Floor: {building1.CalculateApartmentsPerFloor()}");

            Console.WriteLine();

            building2.DisplayInfo();
            Console.WriteLine($"Floor Height: {building2.CalculateFloorHeight()} meters");
            Console.WriteLine($"Apartments per Entrance: {building2.CalculateApartmentsPerEntrance()}");
            Console.WriteLine($"Apartments per Floor: {building2.CalculateApartmentsPerFloor()}");

        }

    }


    


    
    
}
