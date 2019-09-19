using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.ProxyPattern
{
    class BookParserProxy : IBookParser
    {
        BookParser bookParser;
        string bookContent;
        public BookParserProxy(string bookContent)
        {
            this.bookContent = bookContent;
        }
        private void CreateInstance()
        {
            if (this.bookParser == null)
                this.bookParser = new BookParser(this.bookContent);

        }
        public int NoOfPages
        {
            get
            {
                CreateInstance();
                return this.bookParser.NoOfPages;
            }
        }

        public int NoOfWords
        {
            get
            {
                CreateInstance();
                return this.bookParser.NoOfWords;
            }
        }
    }
}
