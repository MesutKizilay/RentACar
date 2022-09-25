﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void AddCar(Car car)
        {
            if(car.Description.Length>=2&&car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("olmadı");
            }
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public Car GetCarByColorId(int colorId)
        {
            return _carDal.Get(x => x.ColorId == colorId);
        }

        public Car GetCarsByBrandId(int brandId)
        {
            return _carDal.Get(x=>x.BrandId == brandId);
        }
    }
}