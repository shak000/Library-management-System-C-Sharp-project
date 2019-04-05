using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BEL
{
    public class Information
    {
        //This class used to create variables to make all operations

        //login information.
        public string userId { get; set; }
        public string password { get; set; }
        public int status { get; set; }
        public string validity { get; set; }

        //book information
        public string bookId { get; set; }
        public string bookName { get; set; }
        public string authorName { get; set; }
        public int publicationYear { get; set; }
        public int quantity { get; set; }
        public byte[] images = null;
        public byte[] pictures = null;

        //Librarian Information
        public string librarianId { get; set; }
        public string librarianName { get; set; }
        public string librarianGender { get; set; }
        public string librarianDOB { get; set; }
        public string librarianAddress { get; set; }
        public string librarianEmail { get; set; }
        public long librarianPhone { get; set; }
        public double librarianSalary { get; set; }
        public byte[] librarianImage { get; set; }
        public int stat { get; set; }
        
        //Students Information
        public string studentId { get; set; }
        public string studentName { get; set; }
        public string studentGender { get; set; }
        public string studentDOB { get; set; }
        public string studentAddress { get; set; }
        public string studentEmail { get; set; }
        public long studentPhone { get; set; }
        public byte[] studentImage { get; set; }
        
        //borrow information
        public string borrowId { get; set; }
        //public string borrowId { get; set; }
        //public string borrowId { get; set; }
        public string borrowDate { get; set; }
        public string returnDate { get; set; }
        public int qty { get; set; }
        public string orginalReturnDate { get; set; }

        //fees information
        public int feesId { get; set; }
        public double fees { get; set; }

    }
}
