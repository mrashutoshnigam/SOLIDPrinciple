using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    class BookParser : IBookParser
    {
        string book;
        //Assume this is an expensive operation;
        public BookParser(string bookContent)
        {
            this.book = bookContent;
        }
        public int NoOfPages { get => book.Length / 50; }
        public int NoOfWords { get => book.Split(new char[] { ' ', '.' }).Length; }
    }
}