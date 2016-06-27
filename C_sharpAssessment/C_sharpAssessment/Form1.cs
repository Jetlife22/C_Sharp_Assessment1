using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharpAssessment
{
    public partial class Form1 : Form
    {
        public static int numberOfBooks = 0;


        public Form1()
        {
            InitializeComponent();
            bookList.Add(book1);
            bookList.Add(book2);
            bookList.Add(book3);
            bookList.Add(book4);
            bookList.Add(book5);

        }


        //declared the list as a public static, so it can be used in the class without the need to be instantiated via another method below
        public static List<Book> bookList = new List<Book>();

        Book book1 = new Book("title1", "author1", "ISBN1", 1);
        Book book2 = new Book("title2", "author2", "ISBN2", 2);
        Book book3 = new Book("title3", "author3", "ISBN3", 3);
        Book book4 = new Book("title4", "author4", "ISBN4", 4);
        Book book5 = new Book("title5", "author5", "ISBN5", 5);


        //the DISPLAY button
        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Book b in bookList)
            {
                textBox1.Text = bookList[0].Title;
                textBox2.Text = bookList[0].Author;
                textBox3.Text = bookList[0].ISBN;
                textBox4.Text = (bookList[0].Price).ToString();
                BackColor = Color.Azure;
            }
        }

        //the NEXT button
        private void button2_Click(object sender, EventArgs e)
        {
            //if the index nuber assigned is smaller than the booklist count,
            if (numberOfBooks < bookList.Count - 1)
            {
                //increment number of books index by 1, and asign number to the array position of the booklist items
                    numberOfBooks += 1;
                    textBox1.Text = bookList[numberOfBooks].Title;
                    textBox2.Text = bookList[numberOfBooks].Author;
                    textBox3.Text = bookList[numberOfBooks].ISBN;
                    textBox4.Text = (bookList[numberOfBooks].Price).ToString();
            }
        }
        
        //the PREVIOUS button
        private void previousButton_Click(object sender, EventArgs e)
        {
            //same statement as above for the next button, but with a decrement
            if (numberOfBooks > 0)
            {
                numberOfBooks -= 1;
                textBox1.Text = bookList[numberOfBooks].Title;
                textBox2.Text = bookList[numberOfBooks].Author;
                textBox3.Text = bookList[numberOfBooks].ISBN;
                textBox4.Text = (bookList[numberOfBooks].Price).ToString();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            
        }
    }


    //created a public class Book, available to be accessed by other classes wthin the project
    public class Book
    {

        ////declared private string variables/fields
        public string title;
        public string author;
        public string isbn;
        public int price;



        public Book(string Title, string Author, string ISBN, int Price)
        {
            title = Title;
            author = Author;
            isbn = ISBN;
            price = Price;

            
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public string ISBN
        {
            get
            {
                return isbn;
            }
            set
            {
                isbn = value;
            }

        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }

        }


    }

}
