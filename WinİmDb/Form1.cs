using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace WinİmDb
{
    public partial class Form1 : Form
    {

        SqlConnection Baglanti = new SqlConnection("server=DESKTOP-UA2FK0J\\SQLEXPRESS; Initial Catalog=WinİmDb;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSonuc_Click(object sender, EventArgs e)
        {
            lstSonuc.Items.Clear();

            WebClient wc = new WebClient();
            string result = wc.DownloadString("https://www.imdb.com/find?q=" + txtMovieName.Text);

            List<Movie> movies = new List<Movie>();

            string firstKey = "<table class=\"findList\">";
            string endKey = "</table>";

            int startIndex = result.IndexOf(firstKey);

            int endIndex = result.IndexOf(endKey, startIndex);

            result = result.Substring(startIndex, endIndex - startIndex);

            firstKey = "<td class=\"result_text\"> <a href=\"";
            endKey = "\" >";

            startIndex = result.IndexOf(firstKey) + firstKey.Length;
            endIndex = result.IndexOf(endKey, startIndex);

            while (startIndex > firstKey.Length)
            {
                Movie movie = new Movie();

                movie.Link = result.Substring(startIndex, endIndex - startIndex);

                firstKey = "\" >";
                endKey = "</a>";

                startIndex = result.IndexOf(firstKey, startIndex) + firstKey.Length;
                endIndex = result.IndexOf(endKey, startIndex);

                movie.Name = result.Substring(startIndex, endIndex - startIndex);

                firstKey = "(";
                endKey = ")";
                startIndex = result.IndexOf(firstKey, startIndex) + firstKey.Length;
                endIndex = result.IndexOf(endKey, startIndex);

                int year = 0;
                int.TryParse(result.Substring(startIndex, endIndex - startIndex), out year);
                movie.Year = year;

                firstKey = "<td class=\"result_text\"> <a href=\"";
                endKey = "\" >";
                startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                endIndex = result.IndexOf(endKey, startIndex);
                lstSonuc.Items.Add(movie);
            }
        }



        private void lstSonuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDirectors.Items.Clear();
            lstWriters.Items.Clear();
            lstStars.Items.Clear();
            if (Baglanti.State == ConnectionState.Closed)
            {
                Baglanti.Open();
            }
            SqlCommand commandcheck = new SqlCommand("SELECT * FROM Movie where Name='" + lstSonuc.SelectedItem.ToString() + "'", Baglanti);
            SqlDataReader rdrcheck = commandcheck.ExecuteReader();
            if (rdrcheck.Read())
            {
                Baglanti.Close();

                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                }

                SqlCommand command = new SqlCommand("SELECT * FROM Movie where Name='" + lstSonuc.SelectedItem.ToString() + "'", Baglanti);
                SqlDataReader rdr = command.ExecuteReader();

                while (rdr.Read())
                {
                    lblDescription.Text = rdr["Description"].ToString();
                    MoviePhoto.Load(rdr["Image"].ToString());
                }
                rdr.Close();
                Baglanti.Close();

                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                }
                SqlCommand commandDirectors = new SqlCommand("SELECT C.Name, M.Name , R.Name FROM Cast C , Movie M, MovieCastRole MCR,Role r WHERE C.Id = MCR.CastId AND M.Id = MCR.MovieId AND R.Id = MCR.RoleId AND R.ID = 1 AND M.Name='" + lstSonuc.SelectedItem.ToString() + "'", Baglanti);
                SqlDataReader rdrDirectors = commandDirectors.ExecuteReader();
                while (rdrDirectors.Read())
                {
                    lstDirectors.Items.Add(rdrDirectors["Name"].ToString());
                }
                rdrDirectors.Close();
                Baglanti.Close();

                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                }
                SqlCommand commandWriter = new SqlCommand("SELECT C.Name, M.Name , R.Name FROM Cast C , Movie M, MovieCastRole MCR,Role r WHERE C.Id = MCR.CastId AND M.Id = MCR.MovieId AND R.Id = MCR.RoleId AND R.ID = 2 AND M.Name='" + lstSonuc.SelectedItem.ToString() + "'", Baglanti);
                SqlDataReader rdrWriter = commandWriter.ExecuteReader();
                while (rdrWriter.Read())
                {
                    lstWriters.Items.Add(rdrWriter["Name"].ToString());
                }
                rdrWriter.Close();
                Baglanti.Close();

                if (Baglanti.State == ConnectionState.Closed)
                {
                    Baglanti.Open();
                }
                SqlCommand commandStars = new SqlCommand("SELECT C.Name, M.Name , R.Name FROM Cast C , Movie M, MovieCastRole MCR,Role r WHERE C.Id = MCR.CastId AND M.Id = MCR.MovieId AND R.Id = MCR.RoleId AND R.ID = 3 AND M.Name='" + lstSonuc.SelectedItem.ToString() + "'", Baglanti);
                SqlDataReader rdrStars = commandStars.ExecuteReader();
                while (rdrStars.Read())
                {
                    lstStars.Items.Add(rdrStars["Name"].ToString());
                }
                rdrStars.Close();
                Baglanti.Close();


            }
            else
            {

                Movie movie = (Movie)lstSonuc.SelectedItem;
                WebClient wc = new WebClient();
                string result = wc.DownloadString("https://www.imdb.com" + movie.Link);

                string firstKey = "<div class=\"summary_text\">";
                string endKey = "</div>";

                int startIndex = result.IndexOf(firstKey) + firstKey.Length;
                int endIndex = result.IndexOf(endKey, startIndex);
                result = result.Substring(startIndex, endIndex - startIndex).Trim();

                lblDescription.Text = result.ToString().Trim();

                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "<div class=\"poster\">";
                endKey = "</div>";
                startIndex = result.IndexOf(firstKey);
                endIndex = result.IndexOf(endKey, startIndex + firstKey.Length);
                result = result.Substring(startIndex + firstKey.Length, endIndex - startIndex);

                firstKey = "src=\"";
                endKey = "\" />";
                startIndex = result.IndexOf(firstKey);
                endIndex = result.IndexOf(endKey, startIndex + firstKey.Length);
                movie.Image = result.Substring(startIndex + firstKey.Length, endIndex - (startIndex + firstKey.Length)); // movie classın alanına ekledik
                MoviePhoto.Load(movie.Image);



                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "\"director\":";
                endKey = ",\n  \"";

                startIndex = result.IndexOf(firstKey);

                Cast cast = new Cast();

                if (startIndex > -1)
                {
                    endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "\"name\": \"";
                    endKey = "\"";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        cast.Name = result.Substring(startIndex, endIndex - startIndex);
                        lstDirectors.Items.Add(cast.Name);

                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }
                else
                {
                    lstDirectors.Items.Clear();
                }



                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "\"creator\":";
                endKey = ",\n  \"";

                startIndex = result.IndexOf(firstKey);

                if (startIndex > -1)
                {

                    endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "\"name\": \"";
                    endKey = "\"";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        cast.Name = result.Substring(startIndex, endIndex - startIndex);
                        lstWriters.Items.Add(cast.Name);
                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }
                else
                {
                    lstWriters.Items.Clear();
                }


                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "  \"actor\": [";
                endKey = ",\n  \"";

                startIndex = result.IndexOf(firstKey);

                if (startIndex > -1)
                {

                    endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "\"name\": \"";
                    endKey = "\"";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        cast.Name = result.Substring(startIndex, endIndex - startIndex);
                        lstStars.Items.Add(cast.Name);

                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }
                else
                {
                    lstStars.Items.Clear();
                }



                try
                {
                    Baglanti.Close();
                    if (Baglanti.State == ConnectionState.Closed)
                    {
                        Baglanti.Open();
                    }
                    SqlCommand komut = new SqlCommand("AddMovieAndMovieCastRole", Baglanti);
                    komut.CommandType = CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@Name", lstSonuc.SelectedItem.ToString());
                    komut.Parameters.AddWithValue("@Year", movie.Year);
                    komut.Parameters.AddWithValue("@Description", lblDescription.Text);
                    komut.Parameters.AddWithValue("@Image", movie.Image);
                    komut.Parameters.AddWithValue("@Link", movie.Link);
                    komut.ExecuteNonQuery();
                    Baglanti.Close();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    string msg = "Insert Error:";
                    msg += ex.Message;
                    throw new Exception(msg);
                }



                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "\"director\":";
                endKey = ",\n  \"";

                startIndex = result.IndexOf(firstKey);


                if (startIndex > -1)
                {
                    endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "\"name\": \"";
                    endKey = "\"";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        cast.Name = result.Substring(startIndex, endIndex - startIndex);
                        Baglanti.Open();
                        string IdSorgu = $"SELECT Id FROM Movie where Link = '{movie.Link}'";
                        SqlCommand getId = new SqlCommand(IdSorgu, Baglanti);
                        int Id = Convert.ToInt32(getId.ExecuteScalar().ToString());
                        SqlCommand komutCast = new SqlCommand("AddCastAndMovieCastRole", Baglanti);
                        komutCast.CommandType = CommandType.StoredProcedure;
                        komutCast.Parameters.AddWithValue("@Name", cast.Name);
                        komutCast.Parameters.AddWithValue("@CastPhoto", "Yönetmen Foto");
                        komutCast.Parameters.AddWithValue("@Bio", "Bio Acıklama");
                        komutCast.Parameters.AddWithValue("@MovieId", Id);
                        komutCast.Parameters.AddWithValue("@RoleId", 1);
                        komutCast.ExecuteNonQuery();
                        Baglanti.Close();

                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }
                else
                {
                    lstDirectors.Items.Clear();
                }




                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "\"creator\":";
                endKey = ",\n  \"";

                startIndex = result.IndexOf(firstKey);

                if (startIndex > -1)
                {

                    endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "\"name\": \"";
                    endKey = "\"";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        cast.Name = result.Substring(startIndex, endIndex - startIndex);

                        if (Baglanti.State == ConnectionState.Closed)
                        {
                            Baglanti.Open();
                        }
                        string IdSorgu = $"SELECT Id FROM Movie where Link = '{movie.Link}'";
                        SqlCommand getId = new SqlCommand(IdSorgu, Baglanti);
                        int Id = Convert.ToInt32(getId.ExecuteScalar().ToString());
                        SqlCommand komutCast = new SqlCommand("AddCastAndMovieCastRole", Baglanti);
                        komutCast.CommandType = CommandType.StoredProcedure;
                        komutCast.Parameters.AddWithValue("@Name", cast.Name);
                        komutCast.Parameters.AddWithValue("@CastPhoto", "Yönetmen Foto");
                        komutCast.Parameters.AddWithValue("@Bio", "Bio Acıklama");
                        komutCast.Parameters.AddWithValue("@MovieId", Id);
                        komutCast.Parameters.AddWithValue("@RoleId", 2);
                        komutCast.ExecuteNonQuery();
                        Baglanti.Close();
                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }
                else
                {
                    lstWriters.Items.Clear();
                }


                result = wc.DownloadString("https://www.imdb.com" + movie.Link);
                firstKey = "  \"actor\": [";
                endKey = ",\n  \"";

                startIndex = result.IndexOf(firstKey);

                if (startIndex > -1)
                {

                    endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "\"name\": \"";
                    endKey = "\"";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        cast.Name = result.Substring(startIndex, endIndex - startIndex);

                        if (Baglanti.State == ConnectionState.Closed)
                        {
                            Baglanti.Open();
                        }
                        string IdSorgu = $"SELECT Id FROM Movie where Link = '{movie.Link}'";
                        SqlCommand getId = new SqlCommand(IdSorgu, Baglanti);
                        int Id = Convert.ToInt32(getId.ExecuteScalar().ToString());
                        SqlCommand komutCast = new SqlCommand("AddCastAndMovieCastRole", Baglanti);
                        komutCast.CommandType = CommandType.StoredProcedure;
                        komutCast.Parameters.AddWithValue("@Name", cast.Name);
                        komutCast.Parameters.AddWithValue("@CastPhoto", "Yönetmen Foto");
                        komutCast.Parameters.AddWithValue("@Bio", "Bio Acıklama");
                        komutCast.Parameters.AddWithValue("@MovieId", Id);
                        komutCast.Parameters.AddWithValue("@RoleId", 3);
                        komutCast.ExecuteNonQuery();
                        Baglanti.Close();
                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }
                else
                {
                    lstStars.Items.Clear();
                }


            }


        }



        private void btnAltyazi_Click(object sender, EventArgs e)
        {

            Movie movie = (Movie)lstSonuc.SelectedItem;
            WebClient wc = new WebClient();

            if (lstSonuc.SelectedItem != null)
            {
                string result = wc.DownloadString("https://www.imdb.com" + movie.Link);

                string firstKey = "content=";
                string endKey = "mdot";

                int startIndex = result.IndexOf(firstKey);

                if (startIndex > -1)
                {
                    int endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "title/";
                    endKey = "?src=";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        movie.LinkWithoutTitle = result.Substring(startIndex, endIndex - startIndex);
                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }

                result = wc.DownloadString("https://turkcealtyazi.org/" + movie.LinkWithoutTitle);
                firstKey = "class=\"kal1\"";
                endKey = "</div>";

                startIndex = result.IndexOf(firstKey);

                if (startIndex > -1)
                {
                    int endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "href=\"";
                    endKey = "\" title";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        movie.SubtitlePageLink = result.Substring(startIndex, endIndex - startIndex);
                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }

                }

                try
                {
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://turkcealtyazi.org" + movie.SubtitlePageLink);

                    IWebElement altyaziindir = driver.FindElement(By.ClassName("altIndirButton"));
                    altyaziindir.Click();
                }
                catch
                {
                    MessageBox.Show("Altyazı Dosyası bulunamadı");
                }

            }
            else
            {
                MessageBox.Show("Lütfen bir Film seçin");
            }

        }




        private void btnFilmİndir_Click(object sender, EventArgs e)
        {

            Movie movie = (Movie)lstSonuc.SelectedItem;

            WebClient wc = new WebClient();

            if (lstSonuc.SelectedItem != null)
            {
                string result = wc.DownloadString("https://kickass.onl/usearch/" + txtMovieName.Text);

                string firstKey = "<div class=\"markeredBlock torType VideoType\">";
                string endKey = "</a>";

                int startIndex = result.IndexOf(firstKey);
                if (startIndex > -1)
                {
                    int endIndex = result.IndexOf(endKey, startIndex);
                    result = result.Substring(startIndex, endIndex - startIndex);

                    firstKey = "<a href=\"";
                    endKey = "\" class=\"cellMainLink\">";
                    startIndex = result.IndexOf(firstKey) + firstKey.Length;
                    endIndex = result.IndexOf(endKey, startIndex);

                    while (startIndex > firstKey.Length)
                    {
                        movie.TorrentLink = result.Substring(startIndex, endIndex - startIndex);
                        startIndex = result.IndexOf(firstKey, endIndex) + firstKey.Length;
                        endIndex = result.IndexOf(endKey, startIndex);
                    }
                }

                try
                {
                    IWebDriver driver = new ChromeDriver();
                    driver.Navigate().GoToUrl("https://kickass.onl" + movie.TorrentLink);

                    IWebElement filmindir = driver.FindElement(By.ClassName("iconButton"));
                    filmindir.Click();
                }
                catch
                {
                    MessageBox.Show("Film Dosyası bulunamadı");
                }

            }
            else
            {
                MessageBox.Show("Lütfen bir Film seçin");
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            Saat.Start();
        }

        private void Saat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm");
            lblSaniye.Text = DateTime.Now.ToString("ss");
            lblTarih.Text = DateTime.Now.ToString("MMM dd yyyy");
            lblGun.Text = DateTime.Now.ToString("dddd");
        }

        private void txtMovieName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
