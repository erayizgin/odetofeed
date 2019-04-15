﻿using OdeToFeed.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OdeToFeed.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant Get(int id);
        Restaurant Add(Restaurant restaurant);
    }
}
