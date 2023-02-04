using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult AddCarImage(IFormFile file,CarImage carImage);
        IResult UpdateCarImage(IFormFile file,CarImage carImage);
        IResult DeleteCarImage(int carImageId);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<List<CarImage>> GetCarImagesByCarId(int carId);
    }
}