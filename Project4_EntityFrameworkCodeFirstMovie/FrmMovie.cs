using Project4_EntityFrameworkCodeFirstMovie.DAL.Context;
using Project4_EntityFrameworkCodeFirstMovie.DAL.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project4_EntityFrameworkCodeFirstMovie
{
    public partial class FrmMovie : Form
    {
        public FrmMovie()
        {
            InitializeComponent();
        }
        MovieContext context=new MovieContext();

        void CategoryList()
        {
            var values = context.Categories.ToList();
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = values;
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            var values =context.Movies.ToList();
            dataGridView1.DataSource = values;
        }

        private void FrmMovie_Load(object sender, EventArgs e)
        {
            CategoryList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Movie movie = new Movie();
            movie.MovieTitle=txtMovieName.Text;
            movie.Duration=int.Parse(txtDuration.Text);
            movie.AirDate=DateTime.Parse( mtxtAddedDate.Text);
            movie.CategoryId=int.Parse(cmbCategory.Text);
            movie.Description=txtDescription.Text;
            context.Movies.Add(movie);
            context.SaveChanges();
            MessageBox.Show("Film eklendi");
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtMovieId.Text);
            var values = context.Movies.Find(id);
            context.Movies.Remove(values);
            context.SaveChanges();
            MessageBox.Show("Film Silindi.");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var values=context.Movies.Where(x=>x.MovieTitle==txtMovieName.Text).ToList();
            dataGridView1.DataSource = values;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id=int.Parse(txtMovieId.Text);
            var values = context.Movies.Find(id);
            values.Duration = int.Parse(txtDuration.Text);
            values.MovieTitle=txtMovieName.Text;
            values.AirDate = DateTime.Parse(mtxtAddedDate.Text);
            values.CategoryId=int.Parse(cmbCategory.Text);
            values.Description = txtDescription.Text;
            context.SaveChanges();
            MessageBox.Show("Film Güncellendi");
        }

        private void btnListWithCategory_Click(object sender, EventArgs e)
        {
            var values=context.Movies
                        .Join(context.Categories,
                        movie=>movie.CategoryId,
                        category=>category.CategoryId,
                        (movie, category) => new
                        {
                            MovieId=movie.MovieId,
                            Movietitle=movie.MovieTitle,
                            Description=movie.Description,
                            Duration=movie.Duration,
                            CategoryName=category.CategoryName

                        }).ToList();
            dataGridView1.DataSource = values;
        }
    }
}
