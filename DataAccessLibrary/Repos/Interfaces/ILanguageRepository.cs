﻿using DataAccessLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataAccessLibrary.Repos.Interfaces
{
    public interface ILanguageRepository : IGenericRepository<Language>
    {
        Task<List<string>> GetLanguages(List<int> movieLanguageIds);

        Task<bool> IsNameExist(string name);

        Task<int> GetIdByName(string name);
    }
}
