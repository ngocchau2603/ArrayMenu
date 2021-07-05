using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstNumber = new List<int>();
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu(lstNumber);
            }
        }
        private static bool MainMenu(List<int> lstNumber)
        {
            var program = new Program();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Nhap mang");
            Console.WriteLine("2) Sap xep giam dan");
            Console.WriteLine("3) Thong tin mang goc");
            Console.WriteLine("4) Phan tu lon nhat/nho nhat");
            Console.WriteLine("5) Tong va trung binh cac so chan");
            Console.WriteLine("6) So luong phan tu co gia tri lon nhat");
            Console.WriteLine("7) Exit");
            switch (Console.ReadLine())
            {
                case "1":
                    program.AddInfo(lstNumber);
                    return true;
                case "2":
                    program.OrderDesc(lstNumber);
                    return true;
                case "3":
                    program.PrintOrigin(lstNumber);
                    return true;
                case "4":
                    program.PrintMaxMin(lstNumber);
                    return true;
                case "5":
                    program.CalculateEven(lstNumber);
                    return true;
                case "6":
                    program.CountMax(lstNumber);
                    return true;
                case "7":
                    return false;
                default:
                    return true;
            }
        }
        private void OrderDesc(List<int> lstNumber)
        {
            lstNumber = lstNumber.OrderByDescending(x => x).ToList();
            Console.WriteLine(string.Join(" ", lstNumber));
        }
        private void PrintOrigin(List<int> lstNumber)
        {
            Console.WriteLine(string.Join(" ", lstNumber));
        }
        private void PrintMaxMin(List<int> lstNumber)
        {
            Console.WriteLine($"So lon nhat: {lstNumber.Max()}, So nho nhat: {lstNumber.Min()}");
        }
        private void CalculateEven(List<int> lstNumber) {
            var listNumberEven = lstNumber.Where(x => x % 2 == 0).ToList();
            var tong = listNumberEven.Sum();
            var trungBinh =(double)tong / listNumberEven.Count();
            Console.WriteLine($"Tong so chan: {tong}, Trung binh cong: {trungBinh}");
        }
        private void CountMax(List<int> lstNumber)
        {
            var max = lstNumber.Max();
            var countMax = lstNumber.Count(x => x == max);
            Console.WriteLine($"So lon nhat: {max}, So luong: {countMax}");
        }
        private void AddInfo(List<int> lstNumber)
        {
            Console.WriteLine("1) Nhap chieu dai mang: ");
            var doDai = Console.ReadLine();
            if (Int32.TryParse(doDai, out int iDoDai))
            {
                for (int i = 0; i < iDoDai; i++)
                {
                    var newNumber = Console.ReadLine();
                    lstNumber.Add(Convert.ToInt32(newNumber));
                }
            }
        }
    }
}
