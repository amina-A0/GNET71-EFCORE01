using System;
using System.Collections.Generic;
using System.Text;

namespace Efcore_Ass1
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ISBN { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int NumberOfPages { get; set; }
        public int PublicationYear { get; set; }
        public bool InStock { get; set; }
    }
}
