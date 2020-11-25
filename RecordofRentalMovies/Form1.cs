using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordofRentalMovies
{
    public partial class Form1 : Form
    {

        //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\Documents\ourdata.mdf;Integrated Security=True;Connect Timeout=30;");


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Mydata.mdf;Integrated Security=True;Connect Timeout=30;");
        SqlCommand cmd;
        SqlDataAdapter adapt;
        //ID variable used in Updating and Deleting Record
        int ID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CustName_Click(object sender, EventArgs e)
        {

            if (CTID.Text != "" && CTName.Text != "" && CTLastName.Text != "" && CTAddress.Text != "" && CTPhone.Text != "")
            {
                cmd = new SqlCommand("insert into Custmer(CustmerId,Firstname,Lastname,Address,Phoneno) values(@cid,@firstname,@lastname,@address,@phoneno)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@cid", CTID.Text);
                cmd.Parameters.AddWithValue("@firstname", CTName.Text);
                cmd.Parameters.AddWithValue("@lastname", CTLastName.Text);
                cmd.Parameters.AddWithValue("@address", CTAddress.Text);
                cmd.Parameters.AddWithValue("@phoneno", CTPhone.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayCData();
                ClearData();
                MessageBox.Show("Record Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }



        }

        private void CustUpdate_Click(object sender, EventArgs e)
        {
            if (CTID.Text != "" && CTName.Text != "" && CTLastName.Text != "" && CTAddress.Text != "" && CTPhone.Text != "")
            {
                cmd = new SqlCommand("update Custmer set CustmerId=@cid,Firstname=@firstname,Lastname=@lastname,Address=@address,Phoneno=@phoneno where CustmerId=@cid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@cid", CTID.Text);
                cmd.Parameters.AddWithValue("@firstname", CTName.Text);
                cmd.Parameters.AddWithValue("@lastname", CTLastName.Text);
                cmd.Parameters.AddWithValue("@address", CTAddress.Text);
                cmd.Parameters.AddWithValue("@phoneno", CTPhone.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayCData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }


        private void CustDelete_Click(object sender, EventArgs e)
        {
            if (CTID.Text != "")
            {
                cmd = new SqlCommand("delete from Custmer where CustmerId=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", CTID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayCData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void DisplayCData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Custmer", con);
            adapt.Fill(dt);
            CustGrid.DataSource = dt;
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayCData();
            DisplayMData();
            DisplayRData();
        }

        private void ClearData()
        {
            CTID.Text = "";
            CTName.Text = "";
            CTLastName.Text = "";
            CTAddress.Text = "";
            CTPhone.Text = "";
            MVSID.Text = "";
            MVSTitle.Text = "";
            MVSRating.Text = "";
            MVSGenre.Text = "";
            MVSCost.Text = "";
            MVSCopies.Text = "";
            MVSPlot.Text = "";
            MVSReleaseDate.Text = "";
            RMId.Text = "";
            RMVId.Text = "";
            RCustId.Text = "";
            RIDate.Text = "";
            RRDate.Text = "";
        }


        private void MVSInsert_Click(object sender, EventArgs e)
        {
            if (MVSID.Text != "" && MVSTitle.Text != "" && MVSRating.Text != "" && MVSGenre.Text != "" && MVSCost.Text != "" && MVSCopies.Text != "" && MVSPlot.Text != "" && MVSReleaseDate.Text != "")
            {
                cmd = new SqlCommand("insert into Movie(MovieId,Title,Rating,Genre,Cost,Copies,Plot,RelaseDate) values(@mid,@mtitle,@mrating,@mgenre,@mcost,@mcopies,@mplot,@mrelase)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@mid", MVSID.Text);
                cmd.Parameters.AddWithValue("@mtitle", MVSTitle.Text);
                cmd.Parameters.AddWithValue("@mrating", MVSRating.Text);
                cmd.Parameters.AddWithValue("@mgenre", MVSGenre.Text);
                cmd.Parameters.AddWithValue("@mcost", MVSCost.Text);
                cmd.Parameters.AddWithValue("@mcopies", MVSCopies.Text);
                cmd.Parameters.AddWithValue("@mplot", MVSPlot.Text);
                cmd.Parameters.AddWithValue("@mrelase", MVSReleaseDate.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayMData();
                ClearData();
                MessageBox.Show("Record Inserted Successfully");

            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }



        private void MVSUpdate_Click(object sender, EventArgs e)
        {
            if (MVSID.Text != "" && MVSTitle.Text != "" && MVSRating.Text != "" && MVSGenre.Text != "" && MVSCost.Text != "" && MVSCopies.Text != "" && MVSPlot.Text != "" && MVSReleaseDate.Text != "")
            {
                cmd = new SqlCommand("update Movie set MovieId=@mid,Title=@mtitle,Rating=@mrating,Genre=@mgenre,Cost=@mcost,Copies=@mcopies,Plot=@mplot,RelaseDate=@mrelase where MovieId=@mid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@mid", MVSID.Text);
                cmd.Parameters.AddWithValue("@mtitle", MVSTitle.Text);
                cmd.Parameters.AddWithValue("@mrating", MVSRating.Text);
                cmd.Parameters.AddWithValue("@mgenre", MVSGenre.Text);
                cmd.Parameters.AddWithValue("@mcost", MVSCost.Text);
                cmd.Parameters.AddWithValue("@mcopies", MVSCopies.Text);
                cmd.Parameters.AddWithValue("@mplot", MVSPlot.Text);
                cmd.Parameters.AddWithValue("@mrelase", MVSReleaseDate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayMData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }




        private void MVSDelete_Click(object sender, EventArgs e)
        {
            if (MVSID.Text != "")
            {
                cmd = new SqlCommand("delete from Movie where MovieId=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", MVSID.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayMData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }




        private void DisplayMData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Movie", con);
            adapt.Fill(dt);
            MVGrid.DataSource = dt;
            con.Close();
        }




        private void RentMovie_Click(object sender, EventArgs e)
        {
            if (RMId.Text != "" && RMVId.Text != "" && RCustId.Text != "" && RIDate.Text != "" && RRDate.Text == "")
            {
                cmd = new SqlCommand("insert into Rental(RMId,MovieId,CustmerId,Rental_date,Return_date) values(@rmid,@rmvid,@rmcid,@rmrd,@rmrdd)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@rmid", RMId.Text);
                cmd.Parameters.AddWithValue("@rmvid", RMVId.Text);
                cmd.Parameters.AddWithValue("@rmcid", RCustId.Text);
                cmd.Parameters.AddWithValue("@rmrd", RIDate.Text);
                cmd.Parameters.AddWithValue("@rmrdd", RRDate.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                
                MessageBox.Show("Record Inserted Successfully");
               
                DisplayRData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }



       

        private void ReceiveRentMovie_Click(object sender, EventArgs e)
        {
            if (RMId.Text != "" && RMVId.Text != "" && RCustId.Text != "" && RIDate.Text != "" || RRDate.Text != "")
            {
                cmd = new SqlCommand("update Rental set RMId=@rmid, Return_date=@rmrdd where RMId=@rmid", con);
                con.Open();
                cmd.Parameters.AddWithValue("@rmid", RMId.Text);
                
                cmd.Parameters.AddWithValue("@rmrdd", RRDate.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                con.Close();
                DisplayRData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Update");
            }
        }

       

        private void DisplayRData()
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select RMId, FirstName, LastName, Address, Title, Cost, Rental_date, Return_date from Rental JOIN Custmer ON Rental.CustmerId = Custmer.CustmerId JOIN Movie ON Movie.MovieId=Rental.MovieId", con);
            adapt.Fill(dt);
            RentalGrid.DataSource = dt;
            con.Close();
        }


        private void ListEveryMovie_CheckedChanged(object sender, EventArgs e)
        {

            DisplayRData();
        }

        private void ListRentMovie_CheckedChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select RMId, FirstName, LastName, Address, Title, Cost, Rental_date, Return_date from Rental JOIN Custmer ON Rental.CustmerId = Custmer.CustmerId JOIN Movie ON Movie.MovieId=Rental.MovieId where Rental.Return_date=''", con);
            adapt.Fill(dt);
            RentalGrid.DataSource = dt;
         
          


        }


        private void ListMostPopularMovies_CheckedChanged(object sender, EventArgs e)
        {
            con.Open();
            DataTable dt = new DataTable();
            adapt = new SqlDataAdapter("select * from Movie where Rating = (select max(rating) from Movie)", con);
            adapt.Fill(dt);
            MVGrid.DataSource = dt;
            con.Close();
        }
    } 
}

