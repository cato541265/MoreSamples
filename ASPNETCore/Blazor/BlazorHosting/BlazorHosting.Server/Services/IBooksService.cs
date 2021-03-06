﻿using BlazorHosting.Shared;
using System.Collections.Generic;

namespace BlazorHosting.Server.Services
{
    public interface IBooksService
    {
        Book AddBook(Book book);
        IEnumerable<Book> GetBooks();
        Book GetBook(int id);
        void UpdateBook(Book book);
    }
}