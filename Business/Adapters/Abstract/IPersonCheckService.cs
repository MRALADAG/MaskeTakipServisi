﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Person person);
    }
}
