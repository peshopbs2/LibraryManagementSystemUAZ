﻿using LibraryManagementSystemUAZ.Data.Interfaces;
using LibraryManagementSystemUAZ.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemUAZ.Data.Repositories.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        Task<IEnumerable<Author>> GetAuthorsByBookAsync(int bookId);
    }
}