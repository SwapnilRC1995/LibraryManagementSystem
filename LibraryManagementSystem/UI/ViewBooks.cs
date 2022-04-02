using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using LibraryManagementSystem.Service;
using LibraryManagementSystem.Entity;

namespace LibraryManagementSystem.UI
{
    public partial class ViewBooks : Form
    {
        private string Isbn;
        private decimal Price;
        private string Title;
        private string Description;
        private string Type;
        private string Publisher;
        private string Author;
        private string Category;
        private int Count;

        private int selectedID;

        private string[] categories = { "Adventure", "Fantasy", "Sci-Fi", "Mystery", "Thriller", "Romance", "Contemporary", "Dystopian", "Horror", "Education", "History" };

        private BookService BookService = new BookService();
        private CountService CountService = new CountService();

        public ViewBooks()
        {
            InitializeComponent();
            categories.ToList().ForEach((category) =>
            {
                CategoryCB.Items.Add(category);
            });
        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            List<BOOK> Books = BookService.getAllBooks();
            BookDetails.DataSource = Books;
        }

        private void IsbnTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Isbn = IsbnTB.Text;
        }

        private void TitleTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Title = TitleTB.Text;
        }

        private void PriceTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                Price = decimal.Parse(PriceTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Price should be a numeric value";
            }
        }

        private void DescriptionTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Description = DescriptionTB.Text;
        }

        private void TypeHardCover_CheckedChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Type = "Hardcover";
        }

        private void TypeSoftCover_CheckedChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Type = "Softcover";
        }

        private void AuthorTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Author = AuthorTB.Text;
        }

        private void PublisherTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Publisher = PublisherTB.Text;
        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Category = CategoryCB.Text;
        }

        private void CountTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            try
            {
                Count = int.Parse(CountTB.Text);
            }
            catch (FormatException)
            {
                Result.Text = "Count should be a numeric value";
            }
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            selectedID = 0;
            IsbnTB.Text = string.Empty;
            PriceTB.Text = string.Empty;
            TitleTB.Text = string.Empty;
            DescriptionTB.Text = string.Empty;
            TypeHardCover.Checked = false;
            TypeSoftCover.Checked = false;
            AuthorTB.Text = string.Empty;
            PublisherTB.Text = string.Empty;
            CategoryCB.SelectedText = string.Empty;
            CategoryCB.SelectedItem = null;
            CountTB.Text = string.Empty;
            Result.Text = string.Empty;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (selectedID != 0 && !string.IsNullOrWhiteSpace(Isbn) && !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description) && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Publisher) && !string.IsNullOrWhiteSpace(Author)
                && !string.IsNullOrWhiteSpace(Category) && Price != 0 && Count != 0)
            {
                try
                {
                    BookService.updateBook(selectedID, Isbn, Title, Description, Type, Publisher, Author, Category, Price);
                    CountService.updateTotalCount(selectedID, Count);
                    this.CancelBtn_Click(sender, e);
                    Result.Text = "The book has been updated successfully.";
                }
                catch
                {
                    Result.Text = "Oops! Book update unsuccessful";
                }
            }
            else
            {
                Result.Text = "Oops! Fields cannot be left blank.";
            }
                
        }

        private void BookDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && BookDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                selectedID = int.Parse(BookDetails.Rows[e.RowIndex].Cells[0].Value.ToString());
                BOOK Book = BookService.getBookById(selectedID);

                IsbnTB.Text = Book.ISBN;
                TitleTB.Text = Book.TITLE;
                PriceTB.Text = Book.PRICE+"";
                DescriptionTB.Text = Book.DESCRIPTION;
                if (Book.TYPE.Equals("Hardcover"))
                {
                    TypeHardCover.Select();
                }
                else if(Book.TYPE.Equals("Softcover"))
                {
                    TypeSoftCover.Select();
                }
                PublisherTB.Text = Book.PUBLISHER;
                AuthorTB.Text = Book.AUTHOR;
                if (categories.Contains(Book.CATEGORY))
                {
                    CategoryCB.Text = Book.CATEGORY;
                }
                else
                {
                    CategoryCB.Text = "Others";
                }
                

                CountTB.Text = CountService.getTotalCount(selectedID)+"";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
