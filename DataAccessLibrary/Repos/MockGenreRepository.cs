﻿using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repos
{
    public class MockGenreRepository : IGenreRepository
    {
        public Task<List<string>> GetGenres(List<int> movieGenreIds)
        {
            throw new NotImplementedException();
        }
    }
}