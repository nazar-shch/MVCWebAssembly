using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClientWebAssembly.BookApp.Core
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }

    public class Pageable
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public Sort Sort { get; set; }
        public int Offset { get; set; }
        public bool Unpaged { get; set; }
        public bool Paged { get; set; }
    }

    public class Sort
    {
        public bool Empty { get; set; }
        public bool Sorted { get; set; }
        public bool Unsorted { get; set; }
    }
}
