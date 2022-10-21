using Business.Abstract;
using Core.Utilities.Results;
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
        public IResult AddRental(Rental rental)
        {
            throw new NotImplementedException();
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
    }
}
