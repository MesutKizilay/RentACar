using Business.Abstract;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
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

        [ValidationAspect(typeof(CarValidator))]
        public IResult AddCar(Car car)
        {

            _carDal.Add(car);
            return new SuccessResult("Ürün başarıyla eklendi");
        }

        public IResult DeleteCar(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult();
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), "Ürünler başarıyla listelendi");
        }

        public IDataResult<Car> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.ColorId == colorId));
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<Car> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(x => x.BrandId == brandId));
        }

        public IResult UpdateCar(Car car)
        {
            return new SuccessResult();
        }
    }
}