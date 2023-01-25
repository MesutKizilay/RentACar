using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());
            Type type = typeof(CarManager);
            CarManager x = (CarManager)Activator.CreateInstance(type,new EfCarDal());
            //var x = Activator.CreateInstance(typeof(CarManager),new EfCarDal());
            Console.WriteLine(x);
            var methods=x.GetType().GetMethods();
            foreach (var item in methods)
            {
                Console.WriteLine("Methot adı: {0}",item.Name);
                //foreach (var parameter in item.GetParameters())
                //{
                //    Console.WriteLine("Parametre adı: {0}",parameter.Name);
                //}
            }
            //GetAll();
            //GetCarDetails();
        }
        private static void GetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "," + car.DailyPrice);
                }
            }
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "," + car.BrandName + "," + car.ColorName + "," + car.DailyPrice);
                }
            }
        }
    }
}