﻿using NineYi.BurgerShop.Burgers;
using NineYi.BurgerShop.IngredientFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NineYi.BurgerShop.BurgerFactories.FactoryMethods
{
    public interface IBurgerFactory
    {
        Burger Create(IIngredientFactory IngredientFactory);
    }
}
