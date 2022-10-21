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
    public class ColorManager : IColorService
    {
        public IResult AddColor(Color color)
        {
            throw new NotImplementedException();
        }

        public IResult DeleteColor(Color color)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult UpdateColor(Color color)
        {
            throw new NotImplementedException();
        }
    }
}
