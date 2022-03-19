using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var simpleDataBase = new SimpleDataBase<int>();
            simpleDataBase.AddNewData(12);
            simpleDataBase.AddNewData(34);
            simpleDataBase.AddNewData(56);
            simpleDataBase.PrintAllData();
        }
    }
}