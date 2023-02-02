using Business.Abstract;
using Business.Constant;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        IFileHelper _fileHelper;

        public CarImageManager(ICarImageDal carImageDal,IFileHelper fileHelper)
        {
            _carImageDal = carImageDal;
            _fileHelper = fileHelper;
        }

        public IResult AddCarImage(IFormFile file,CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfNumberOfImageOfCar(carImage.CarId));
            if (result!=null)
            {
                return new ErrorResult(result.Message);
            }
            carImage.ImageDate = DateTime.Now;
            carImage.ImagePath = _fileHelper.GetFilePath(file);
            _fileHelper.Upload(file);
            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.AddedNewImage);
        }

        public IResult DeleteCarImage(int carImageId)
        {
            var carImageToBeDeleted=_carImageDal.Get(c=>c.CarImageId==carImageId);
            _fileHelper.Delete(carImageToBeDeleted.ImagePath);
            _carImageDal.Delete(carImageToBeDeleted);
            return new SuccessResult(Messages.DeletedImage);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateCarImage(CarImage carImage)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfNumberOfImageOfCar(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count;
            if (result>5)
            {
                return new ErrorResult(Messages.ImageLimitExceded);
            }
            return new SuccessResult();
        } 
    }
}