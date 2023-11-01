﻿using ProjectAngular.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectAngular.Services
{
    public interface IPositionsService
    {
        Task<IEnumerable<Position>> GetPositionsList();
    }
}
