﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    interface IAuthorService
    {
        Task<List<Author>> GetAuthors();
        Task<Author> GetAuthorById(string authorId);
        Task<bool> SaveAuthor(Author author);
        Task<bool> DeleteAuthor(string authorId);
    }
}
