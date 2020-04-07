﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repos
{
    public interface IMovieLanguageRepository
    {
        Task<List<int>> GetMovieLanguageIds(int id);
    }
}