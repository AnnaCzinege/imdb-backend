﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repos
{
    class MockMovieLanguageRepository : IMovieLanguageRepository
    {
        public Task<List<int>> GetMovieLanguageIds(int id)
        {
            throw new NotImplementedException();
        }

    }
}