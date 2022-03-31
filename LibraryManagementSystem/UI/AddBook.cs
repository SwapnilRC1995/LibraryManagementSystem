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

namespace LibraryManagementSystem.UI
{
    public partial class AddBook : Form
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

        private string[] categories = {"Adventure", "Fantasy", "Sci-Fi", "Mystery", "Thriller", "Romance", "Contemporary", "Dystopian", "Horror", "Education", "History"};

        private BookService BookService = new BookService();
        private CountService CountService = new CountService();

        public AddBook()
        {
            InitializeComponent();
            categories.ToList().ForEach((category) =>
            {
                CategoryCB.Items.Add(category);
            });
            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBtn_Click(object sender, EventArgs e)
        {
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

        private void IsbnTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Isbn = IsbnTB.Text;
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

        private void TitleTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Title = TitleTB.Text;
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
            catch(FormatException)
            {
                Result.Text = "Count should be a numeric value";
            }
        }

        private void PublisherTB_TextChanged(object sender, EventArgs e)
        {
            Result.Text = string.Empty;
            Publisher = PublisherTB.Text;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(Isbn) && !string.IsNullOrWhiteSpace(Title)
                && !string.IsNullOrWhiteSpace(Description) && !string.IsNullOrWhiteSpace(Type)
                && !string.IsNullOrWhiteSpace(Publisher) && !string.IsNullOrWhiteSpace(Author)
                && !string.IsNullOrWhiteSpace(Category) && Price != 0 && Count != 0)
            {
                try
                {
                    int BookId = BookService.addBook(Isbn, Title, Description, Type, Publisher, Author, Category, Price);
                    CountService.addCount(BookId, Count);
                    this.ResetBtn_Click(sender, e);
                    Result.Text = "Book has been entered successfully.";
                }
                catch
                {
                    Result.Text = "Oops! Book details could not be inserted.";
                }
                
            }
        }
    }
}
