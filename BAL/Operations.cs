using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;
using BEL;

namespace BAL
{
    //This class Includes all the db Queries.
    public class Operations
    {
        public Dbconnection db = new Dbconnection();
        public Information info = new Information();

        public System.Data.DataTable FormLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where userId = '" + info.userId + "'and password = '" + info.password + "'";
            return db.ExeReader(cmd);
        }

        //insert Book
        public int insertBook(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books (bookId,bookName,authorName,publicationYear,quantity,bookImage) values ('"+info.bookId+"','"+info.bookName+"','"+info.authorName+"','"+info.publicationYear+"','"+info.quantity+"',@images)";
            cmd.Parameters.Add(new SqlParameter ("@images",info.images));
            return db.ExeNonQuery(cmd);
        }

        // view book data gird view
        public DataTable ViewBooks(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select bookId , bookName , authorName , publicationYear , quantity , bookImage  from books";
            return db.ExeReader(cmd);
        }
        //update book
        public int updateBook(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update books SET  bookName = @a2, authorName = @a3, publicationYear = @a4, quantity = @a5 where bookId = @a1";
            cmd.Parameters.Add(new SqlParameter ("@a1",info.bookId));
            cmd.Parameters.Add(new SqlParameter("@a2", info.bookName));
            cmd.Parameters.Add(new SqlParameter("@a3", info.authorName));
            cmd.Parameters.Add(new SqlParameter("@a4", info.publicationYear));
            cmd.Parameters.Add(new SqlParameter("@a5", info.quantity));
           // cmd.Parameters.Add(new SqlParameter ("@img",info.images));
            return db.ExeNonQuery(cmd);
        }
        //update book picture
        public int updatePictures(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update books SET bookImage = @imgs where bookId = '"+info.bookId+"'";
           // cmd.Parameters.Add(new SqlParameter("@b1", info.bookId));
            cmd.Parameters.Add(new SqlParameter("@imgs", info.images));
            return db.ExeNonQuery(cmd);
        }
        //Delete book
        public int deleteBook(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from books where bookId = '" + info.bookId + "'";
            return db.ExeNonQuery(cmd);
        }

        // insert into librarian 
        public int inserLibrarian(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into librarian (librarianId,librarianName,librarianGender,librarianDOB,librarianAddress,librarianEmail,librarianPhone,librarianSalary,librarianImage) values ('"+info.librarianId+"','"+info.librarianName+"','"+info.librarianGender+"','"+info.librarianDOB+"','"+info.librarianAddress+"','"+info.librarianEmail+"','"+info.librarianPhone+"','"+info.librarianSalary+"',@images)";
            cmd.Parameters.Add(new SqlParameter("@images",info.librarianImage));
            return db.ExeNonQuery(cmd);
        }

        // insert into login librarian.
        public int insertIntoLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login (userId,password,status) values ('"+info.librarianId+"','"+info.password+"','"+info.stat+"')";
            return db.ExeNonQuery(cmd);
        }

        // table for librarian view.
        public DataTable ViewLibrarian(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select librarianId , librarianName , librarianGender , librarianDOB , librarianAddress , librarianEmail, librarianPhone, librarianSalary, librarianImage  from librarian";
            return db.ExeReader(cmd);
        }

        

        // update Librarian info
        public int updateLibrarian(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE librarian SET librarianName = @a1, librarianGender = @a2, librarianDOB = @a3, librarianAddress = @a4, librarianEmail = @a5, librarianPhone = @a6, librarianSalary = @a7 where librarianId = '" + info.librarianId + "'";
            cmd.Parameters.Add(new SqlParameter("@a1", info.librarianName));
            cmd.Parameters.Add(new SqlParameter("@a2", info.librarianGender));
            cmd.Parameters.Add(new SqlParameter("@a3", info.librarianDOB));
            cmd.Parameters.Add(new SqlParameter("@a4", info.librarianAddress));
            cmd.Parameters.Add(new SqlParameter("@a5", info.librarianEmail));
            cmd.Parameters.Add(new SqlParameter("@a6", info.librarianPhone));
            cmd.Parameters.Add(new SqlParameter("@a7", info.librarianSalary));
            return db.ExeNonQuery(cmd);
        }
        //update librarian picture
        public int updateLibrarianPictures(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update librarian SET librarianImage = @imgss where librarianId = '" + info.librarianId + "'";
            cmd.Parameters.Add(new SqlParameter("@imgss", info.librarianImage));
            return db.ExeNonQuery(cmd);
        }

        //delete Librarian
        public int deleteLibrarian(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from librarian where librarianId = '" + info.librarianId + "'";
            return db.ExeNonQuery(cmd);
        }
        // delete from login 
        public int deleteFromLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from login where userId = '" + info.librarianId + "'";
            return db.ExeNonQuery(cmd);
        }

        // insert students
        public int insertStudent(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into student (studentId,studentName,studentGender,studentDOB,studentAddress,studentEmail,studentPhone,studentImage) values ('"+info.studentId+"','"+info.studentName+"','"+info.studentGender+"','"+info.studentDOB+"','"+info.studentAddress+"','"+info.studentEmail+"','"+info.studentPhone+"',@images)";
            cmd.Parameters.Add(new SqlParameter("@images", info.studentImage));
            return db.ExeNonQuery(cmd);
        }
        //insert into login for student
        public int insertIntoStudentLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into login (userId,password,status) values ('" + info.studentId + "','" + info.password + "','" + info.stat + "')";
            return db.ExeNonQuery(cmd);
        }
        // view student
        public DataTable ViewStudent(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from student";
            return db.ExeReader(cmd);
        }
        
        // update student
        public int updateStudent(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update student SET studentName = @a1, studentGender = @a2, studentDOB = @a3, studentAddress = @a4, studentEmail = @a5, studentPhone = @a6 where studentId = '"+info.studentId+"'";
            cmd.Parameters.Add(new SqlParameter("@a1", info.studentName));
            cmd.Parameters.Add(new SqlParameter("@a2", info.studentGender));
            cmd.Parameters.Add(new SqlParameter("@a3", info.studentDOB));
            cmd.Parameters.Add(new SqlParameter("@a4", info.studentAddress));
            cmd.Parameters.Add(new SqlParameter("@a5", info.studentEmail));
            cmd.Parameters.Add(new SqlParameter("@a6", info.studentPhone));
            return db.ExeNonQuery(cmd);
        }
        // update student pic
        public int updateStudentPictures(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update student SET studentImage = @imgsss where studentId = '" + info.studentId + "'";
            cmd.Parameters.Add(new SqlParameter("@imgsss", info.studentImage));
            return db.ExeNonQuery(cmd);
        }
        //student delete 
        public int deleteStudent(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from student where studentId = '" + info.studentId + "'";
            return db.ExeNonQuery(cmd);
        }
        //delete from login student
        public int deleteStudentLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from login where userId = '" + info.studentId + "'";
            return db.ExeNonQuery(cmd);
        }
        //update in login form
        public int updateInLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update login SET password = @a1 where userId = '"+info.userId+"'";
            cmd.Parameters.Add(new SqlParameter("@a1", info.password));
            return db.ExeNonQuery(cmd);
        }

        // insert in borrowInfo
        public int insertIntoBorrowInfo(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into borrowInfo (borrowId,studentId,bookId,borrowDate,returnDate) values ('"+info.borrowId+"','" + info.studentId + "','" + info.bookId + "','" + info.borrowDate + "','"+info.returnDate+"')";
            return db.ExeNonQuery(cmd);
        }
        //after borrowing decrease books quantity
        public int updateBookBorrow(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update books set quantity = quantity-@a1 where bookId = '"+info.bookId+"'";
            cmd.Parameters.Add(new SqlParameter("@a1", info.qty));
            return db.ExeNonQuery(cmd);
        }
        // table view for borrowbook
        public DataTable ViewBorrow(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select borrowId, studentId, bookId , borrowDate, returnDate from borrowInfo";
            return db.ExeReader(cmd);
        }
        // Delete from borrow after return book.
        public int deleteFromBorrowInfo(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from borrowInfo where borrowId = '" + info.borrowId + "'";
            return db.ExeNonQuery(cmd);
        }
        //Increasing book after return
        public int updateBookReturn(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update books set quantity = quantity+@a1 where bookId = '" + info.bookId + "'";
            cmd.Parameters.Add(new SqlParameter("@a1", info.qty));
            return db.ExeNonQuery(cmd);
        }
        //Fees Record
        public int InsertintoFees(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into feesTable (studentId,returnDate,fees) values ('" + info.studentId + "','" + info.orginalReturnDate + "','"+info.fees+"')";
            return db.ExeNonQuery(cmd);
        }
        //Cancel Member ship
        public int updateLogin(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update login set status = @a1 where userId = '" + info.studentId + "'";
            cmd.Parameters.Add(new SqlParameter("@a1", 3));
            return db.ExeNonQuery(cmd);
        }
        //active user
        public int activeStudent(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update login set status = @a1 where userId = '" + info.userId + "'";
            cmd.Parameters.Add(new SqlParameter("@a1", 2));
            return db.ExeNonQuery(cmd);
        }
        // deletefrom fees
        public int deleteFromFees(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Delete from feesTable where studentId = '" + info.userId + "'";
            return db.ExeNonQuery(cmd);
        }



        public DataTable updateActive(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where userId = '" + info.userId + "'";
            return db.ExeReader(cmd);
        }

        public int deactivateUser(Information info)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update login set status = @a1 where userId = '" + info.userId + "'";
            cmd.Parameters.Add(new SqlParameter("@a1", 3));
            return db.ExeNonQuery(cmd);
        }
    }
}
