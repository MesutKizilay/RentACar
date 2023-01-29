using Business.Abstract;
using Business.Constant;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;
        ICarService _carService;

        public RentalManager(IRentalDal rentalDal, ICarService carService)
        {
            _rentalDal = rentalDal;
            _carService = carService;
        }

        public IResult AddRental(Rental rental)
        {
            var result = BusinessRules.Run(CheckIfCanTheCarRent(rental.CarId));

            if(result != null)
            {
                return new ErrorResult(result.Message);
            }

            rental.IsTheCarReturnBack = false;
            rental.RentDate=DateTime.Now;

            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentIsSucceed);
        }

        public IResult DeleteRental(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateRental(Rental rental)
        {
            throw new NotImplementedException();
        }

        private IResult CheckIfCanTheCarRent(int carId)
        {
            var result = _rentalDal.GetAll(r => r.IsTheCarReturnBack == false && r.CarId == carId).Any();
            if (result)
            {
                return new ErrorResult(Messages.TheCarCanNotBeRented);
            }
            return new SuccessResult();
        }
    }
}