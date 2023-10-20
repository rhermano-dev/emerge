﻿using ASI.Basecode.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASI.Basecode.Data.Interfaces
{
    public interface ICarRepository
    {
        public IQueryable<CarModel> RetrieveAll();

        void CreateCar(CarModel carModel);
    }
}
