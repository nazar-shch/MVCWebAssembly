using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCClientWebAssembly.BookApp.Core
{
    public class BookResponse
    {
        public List<Book> Content { get; set; }
        public Pageable Pageable { get; set; }
        public bool Last { get; set; }
        public int TotalElements { get; set; }
        public int TotalPages { get; set; }
        public int Size { get; set; }
        public int Number { get; set; }
        public Sort Sort { get; set; }
        public bool First { get; set; }
        public int NumberOfElements { get; set; }
        public bool Empty { get; set; }
    }
}
