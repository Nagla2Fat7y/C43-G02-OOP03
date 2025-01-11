using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EBook: Book
    {
        private double fileSize;

        public double FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }

        public EBook(string title, string author, string isbn, double fileSize)
            : base(title, author, isbn)
        {
            this.fileSize = fileSize;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"File Size: {FileSize} MB");
        }
    }
}
