namespace RecordofRentalMovies
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListRentMovie = new System.Windows.Forms.RadioButton();
            this.ListEveryMovie = new System.Windows.Forms.RadioButton();
            this.RentReturnDate = new System.Windows.Forms.Label();
            this.CAddress = new System.Windows.Forms.Label();
            this.RentRentalDate = new System.Windows.Forms.Label();
            this.RentIDMovie = new System.Windows.Forms.Label();
            this.RentCID = new System.Windows.Forms.Label();
            this.Idforrent = new System.Windows.Forms.Label();
            this.MVRelaseDate = new System.Windows.Forms.Label();
            this.MVCost = new System.Windows.Forms.Label();
            this.MVGenre = new System.Windows.Forms.Label();
            this.MVPlot = new System.Windows.Forms.Label();
            this.MVCopy = new System.Windows.Forms.Label();
            this.MVRating = new System.Windows.Forms.Label();
            this.MVName = new System.Windows.Forms.Label();
            this.MVId = new System.Windows.Forms.Label();
            this.CLastName = new System.Windows.Forms.Label();
            this.CMobile = new System.Windows.Forms.Label();
            this.CId = new System.Windows.Forms.Label();
            this.CFirstName = new System.Windows.Forms.Label();
            this.RRDate = new System.Windows.Forms.TextBox();
            this.RIDate = new System.Windows.Forms.TextBox();
            this.RMVId = new System.Windows.Forms.TextBox();
            this.RCustId = new System.Windows.Forms.TextBox();
            this.MVSReleaseDate = new System.Windows.Forms.TextBox();
            this.RMId = new System.Windows.Forms.TextBox();
            this.MVSCost = new System.Windows.Forms.TextBox();
            this.MVSPlot = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.MVGrid = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RentalGrid = new System.Windows.Forms.DataGridView();
            this.CustGrid = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.MVSGenre = new System.Windows.Forms.TextBox();
            this.MVSCopies = new System.Windows.Forms.TextBox();
            this.MVSRating = new System.Windows.Forms.TextBox();
            this.MVSTitle = new System.Windows.Forms.TextBox();
            this.MVSID = new System.Windows.Forms.TextBox();
            this.CTPhone = new System.Windows.Forms.TextBox();
            this.CTAddress = new System.Windows.Forms.TextBox();
            this.CTLastName = new System.Windows.Forms.TextBox();
            this.CTName = new System.Windows.Forms.TextBox();
            this.CTID = new System.Windows.Forms.TextBox();
            this.ReceiveRentMovie = new System.Windows.Forms.Button();
            this.RentMovie = new System.Windows.Forms.Button();
            this.MVSDelete = new System.Windows.Forms.Button();
            this.MVSUpdate = new System.Windows.Forms.Button();
            this.MVSInsert = new System.Windows.Forms.Button();
            this.CustDelete = new System.Windows.Forms.Button();
            this.CustName = new System.Windows.Forms.Button();
            this.CustUpdate = new System.Windows.Forms.Button();
            this.RentalRecordTabs = new System.Windows.Forms.TabControl();
            this.ListMostPopularMovies = new System.Windows.Forms.RadioButton();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MVGrid)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.RentalRecordTabs.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListRentMovie
            // 
            this.ListRentMovie.AutoSize = true;
            this.ListRentMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ListRentMovie.Location = new System.Drawing.Point(1086, 196);
            this.ListRentMovie.Name = "ListRentMovie";
            this.ListRentMovie.Size = new System.Drawing.Size(164, 24);
            this.ListRentMovie.TabIndex = 91;
            this.ListRentMovie.Text = "Rental Movies Out";
            this.ListRentMovie.UseVisualStyleBackColor = true;
            this.ListRentMovie.CheckedChanged += new System.EventHandler(this.ListRentMovie_CheckedChanged);
            // 
            // ListEveryMovie
            // 
            this.ListEveryMovie.AutoSize = true;
            this.ListEveryMovie.Checked = true;
            this.ListEveryMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ListEveryMovie.Location = new System.Drawing.Point(885, 196);
            this.ListEveryMovie.Name = "ListEveryMovie";
            this.ListEveryMovie.Size = new System.Drawing.Size(133, 24);
            this.ListEveryMovie.TabIndex = 90;
            this.ListEveryMovie.TabStop = true;
            this.ListEveryMovie.Text = "All Movies List";
            this.ListEveryMovie.UseVisualStyleBackColor = true;
            this.ListEveryMovie.CheckedChanged += new System.EventHandler(this.ListEveryMovie_CheckedChanged);
            // 
            // RentReturnDate
            // 
            this.RentReturnDate.AutoSize = true;
            this.RentReturnDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RentReturnDate.Location = new System.Drawing.Point(1243, 449);
            this.RentReturnDate.Name = "RentReturnDate";
            this.RentReturnDate.Size = new System.Drawing.Size(110, 20);
            this.RentReturnDate.TabIndex = 89;
            this.RentReturnDate.Text = "MReturn Date";
            // 
            // CAddress
            // 
            this.CAddress.AutoSize = true;
            this.CAddress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CAddress.Location = new System.Drawing.Point(420, 20);
            this.CAddress.Name = "CAddress";
            this.CAddress.Size = new System.Drawing.Size(68, 20);
            this.CAddress.TabIndex = 75;
            this.CAddress.Text = "Address";
            // 
            // RentRentalDate
            // 
            this.RentRentalDate.AutoSize = true;
            this.RentRentalDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RentRentalDate.Location = new System.Drawing.Point(1245, 413);
            this.RentRentalDate.Name = "RentRentalDate";
            this.RentRentalDate.Size = new System.Drawing.Size(108, 20);
            this.RentRentalDate.TabIndex = 88;
            this.RentRentalDate.Text = "MRental Date";
            // 
            // RentIDMovie
            // 
            this.RentIDMovie.AutoSize = true;
            this.RentIDMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RentIDMovie.Location = new System.Drawing.Point(1266, 341);
            this.RentIDMovie.Name = "RentIDMovie";
            this.RentIDMovie.Size = new System.Drawing.Size(71, 20);
            this.RentIDMovie.TabIndex = 87;
            this.RentIDMovie.Text = "Movie ID";
            // 
            // RentCID
            // 
            this.RentCID.AutoSize = true;
            this.RentCID.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RentCID.Location = new System.Drawing.Point(1264, 381);
            this.RentCID.Name = "RentCID";
            this.RentCID.Size = new System.Drawing.Size(63, 20);
            this.RentCID.TabIndex = 86;
            this.RentCID.Text = "Cust ID";
            // 
            // Idforrent
            // 
            this.Idforrent.AutoSize = true;
            this.Idforrent.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Idforrent.Location = new System.Drawing.Point(1266, 304);
            this.Idforrent.Name = "Idforrent";
            this.Idforrent.Size = new System.Drawing.Size(77, 20);
            this.Idforrent.TabIndex = 85;
            this.Idforrent.Text = "Rental ID";
            // 
            // MVRelaseDate
            // 
            this.MVRelaseDate.AutoSize = true;
            this.MVRelaseDate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVRelaseDate.Location = new System.Drawing.Point(1164, 71);
            this.MVRelaseDate.Name = "MVRelaseDate";
            this.MVRelaseDate.Size = new System.Drawing.Size(107, 20);
            this.MVRelaseDate.TabIndex = 84;
            this.MVRelaseDate.Text = "Release Date";
            // 
            // MVCost
            // 
            this.MVCost.AutoSize = true;
            this.MVCost.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVCost.Location = new System.Drawing.Point(906, 58);
            this.MVCost.Name = "MVCost";
            this.MVCost.Size = new System.Drawing.Size(103, 20);
            this.MVCost.TabIndex = 83;
            this.MVCost.Text = "Movie R Cost";
            // 
            // MVGenre
            // 
            this.MVGenre.AutoSize = true;
            this.MVGenre.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVGenre.Location = new System.Drawing.Point(920, 25);
            this.MVGenre.Name = "MVGenre";
            this.MVGenre.Size = new System.Drawing.Size(54, 20);
            this.MVGenre.TabIndex = 82;
            this.MVGenre.Text = "Genre";
            // 
            // MVPlot
            // 
            this.MVPlot.AutoSize = true;
            this.MVPlot.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVPlot.Location = new System.Drawing.Point(1164, 42);
            this.MVPlot.Name = "MVPlot";
            this.MVPlot.Size = new System.Drawing.Size(36, 20);
            this.MVPlot.TabIndex = 81;
            this.MVPlot.Text = "Plot";
            // 
            // MVCopy
            // 
            this.MVCopy.AutoSize = true;
            this.MVCopy.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVCopy.Location = new System.Drawing.Point(920, 84);
            this.MVCopy.Name = "MVCopy";
            this.MVCopy.Size = new System.Drawing.Size(58, 20);
            this.MVCopy.TabIndex = 80;
            this.MVCopy.Text = "Copies";
            // 
            // MVRating
            // 
            this.MVRating.AutoSize = true;
            this.MVRating.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVRating.Location = new System.Drawing.Point(647, 90);
            this.MVRating.Name = "MVRating";
            this.MVRating.Size = new System.Drawing.Size(69, 20);
            this.MVRating.TabIndex = 79;
            this.MVRating.Text = "MRating";
            // 
            // MVName
            // 
            this.MVName.AutoSize = true;
            this.MVName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVName.Location = new System.Drawing.Point(647, 55);
            this.MVName.Name = "MVName";
            this.MVName.Size = new System.Drawing.Size(64, 20);
            this.MVName.TabIndex = 78;
            this.MVName.Text = "MName";
            // 
            // MVId
            // 
            this.MVId.AutoSize = true;
            this.MVId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVId.Location = new System.Drawing.Point(647, 23);
            this.MVId.Name = "MVId";
            this.MVId.Size = new System.Drawing.Size(71, 20);
            this.MVId.TabIndex = 77;
            this.MVId.Text = "Movie ID";
            // 
            // CLastName
            // 
            this.CLastName.AutoSize = true;
            this.CLastName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CLastName.Location = new System.Drawing.Point(270, 18);
            this.CLastName.Name = "CLastName";
            this.CLastName.Size = new System.Drawing.Size(75, 20);
            this.CLastName.TabIndex = 74;
            this.CLastName.Text = "C LName";
            // 
            // CMobile
            // 
            this.CMobile.AutoSize = true;
            this.CMobile.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CMobile.Location = new System.Drawing.Point(521, 18);
            this.CMobile.Name = "CMobile";
            this.CMobile.Size = new System.Drawing.Size(115, 20);
            this.CMobile.TabIndex = 76;
            this.CMobile.Text = "Mobile Number";
            // 
            // CId
            // 
            this.CId.AutoSize = true;
            this.CId.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CId.Location = new System.Drawing.Point(12, 18);
            this.CId.Name = "CId";
            this.CId.Size = new System.Drawing.Size(63, 20);
            this.CId.TabIndex = 46;
            this.CId.Text = "Cust ID";
            // 
            // CFirstName
            // 
            this.CFirstName.AutoSize = true;
            this.CFirstName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CFirstName.Location = new System.Drawing.Point(133, 18);
            this.CFirstName.Name = "CFirstName";
            this.CFirstName.Size = new System.Drawing.Size(65, 20);
            this.CFirstName.TabIndex = 73;
            this.CFirstName.Text = "C Fame";
            // 
            // RRDate
            // 
            this.RRDate.Location = new System.Drawing.Point(1367, 446);
            this.RRDate.Name = "RRDate";
            this.RRDate.Size = new System.Drawing.Size(136, 26);
            this.RRDate.TabIndex = 72;
            // 
            // RIDate
            // 
            this.RIDate.Location = new System.Drawing.Point(1367, 410);
            this.RIDate.Name = "RIDate";
            this.RIDate.Size = new System.Drawing.Size(136, 26);
            this.RIDate.TabIndex = 71;
            // 
            // RMVId
            // 
            this.RMVId.Location = new System.Drawing.Point(1368, 335);
            this.RMVId.Name = "RMVId";
            this.RMVId.Size = new System.Drawing.Size(136, 26);
            this.RMVId.TabIndex = 70;
            // 
            // RCustId
            // 
            this.RCustId.Location = new System.Drawing.Point(1367, 372);
            this.RCustId.Name = "RCustId";
            this.RCustId.Size = new System.Drawing.Size(135, 26);
            this.RCustId.TabIndex = 69;
            // 
            // MVSReleaseDate
            // 
            this.MVSReleaseDate.Location = new System.Drawing.Point(1283, 68);
            this.MVSReleaseDate.Name = "MVSReleaseDate";
            this.MVSReleaseDate.Size = new System.Drawing.Size(150, 26);
            this.MVSReleaseDate.TabIndex = 68;
            // 
            // RMId
            // 
            this.RMId.Location = new System.Drawing.Point(1368, 298);
            this.RMId.Name = "RMId";
            this.RMId.Size = new System.Drawing.Size(136, 26);
            this.RMId.TabIndex = 67;
            // 
            // MVSCost
            // 
            this.MVSCost.Location = new System.Drawing.Point(1007, 52);
            this.MVSCost.Name = "MVSCost";
            this.MVSCost.Size = new System.Drawing.Size(151, 26);
            this.MVSCost.TabIndex = 66;
            // 
            // MVSPlot
            // 
            this.MVSPlot.Location = new System.Drawing.Point(1283, 36);
            this.MVSPlot.Name = "MVSPlot";
            this.MVSPlot.Size = new System.Drawing.Size(150, 26);
            this.MVSPlot.TabIndex = 65;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MVGrid);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1222, 373);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movie Record";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MVGrid
            // 
            this.MVGrid.AllowUserToAddRows = false;
            this.MVGrid.AllowUserToDeleteRows = false;
            this.MVGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.MVGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MVGrid.Location = new System.Drawing.Point(0, 6);
            this.MVGrid.Name = "MVGrid";
            this.MVGrid.ReadOnly = true;
            this.MVGrid.RowTemplate.Height = 28;
            this.MVGrid.Size = new System.Drawing.Size(1216, 367);
            this.MVGrid.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.RentalGrid);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1222, 373);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Movie Rental Record";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RentalGrid
            // 
            this.RentalGrid.AllowUserToAddRows = false;
            this.RentalGrid.AllowUserToDeleteRows = false;
            this.RentalGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RentalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RentalGrid.Location = new System.Drawing.Point(-4, 0);
            this.RentalGrid.Name = "RentalGrid";
            this.RentalGrid.ReadOnly = true;
            this.RentalGrid.RowTemplate.Height = 28;
            this.RentalGrid.Size = new System.Drawing.Size(1220, 370);
            this.RentalGrid.TabIndex = 0;
            // 
            // CustGrid
            // 
            this.CustGrid.AllowUserToAddRows = false;
            this.CustGrid.AllowUserToDeleteRows = false;
            this.CustGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.CustGrid.Location = new System.Drawing.Point(-4, 0);
            this.CustGrid.Name = "CustGrid";
            this.CustGrid.ReadOnly = true;
            this.CustGrid.RowTemplate.Height = 28;
            this.CustGrid.Size = new System.Drawing.Size(1226, 367);
            this.CustGrid.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CustGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1222, 373);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customer Record";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // MVSGenre
            // 
            this.MVSGenre.Location = new System.Drawing.Point(1007, 22);
            this.MVSGenre.Name = "MVSGenre";
            this.MVSGenre.Size = new System.Drawing.Size(151, 26);
            this.MVSGenre.TabIndex = 64;
            // 
            // MVSCopies
            // 
            this.MVSCopies.Location = new System.Drawing.Point(1007, 84);
            this.MVSCopies.Name = "MVSCopies";
            this.MVSCopies.Size = new System.Drawing.Size(151, 26);
            this.MVSCopies.TabIndex = 63;
            // 
            // MVSRating
            // 
            this.MVSRating.Location = new System.Drawing.Point(759, 84);
            this.MVSRating.Name = "MVSRating";
            this.MVSRating.Size = new System.Drawing.Size(141, 26);
            this.MVSRating.TabIndex = 62;
            // 
            // MVSTitle
            // 
            this.MVSTitle.Location = new System.Drawing.Point(759, 52);
            this.MVSTitle.Name = "MVSTitle";
            this.MVSTitle.Size = new System.Drawing.Size(141, 26);
            this.MVSTitle.TabIndex = 61;
            // 
            // MVSID
            // 
            this.MVSID.Location = new System.Drawing.Point(759, 20);
            this.MVSID.Name = "MVSID";
            this.MVSID.Size = new System.Drawing.Size(141, 26);
            this.MVSID.TabIndex = 60;
            // 
            // CTPhone
            // 
            this.CTPhone.Location = new System.Drawing.Point(525, 52);
            this.CTPhone.Name = "CTPhone";
            this.CTPhone.Size = new System.Drawing.Size(107, 26);
            this.CTPhone.TabIndex = 59;
            // 
            // CTAddress
            // 
            this.CTAddress.Location = new System.Drawing.Point(413, 52);
            this.CTAddress.Name = "CTAddress";
            this.CTAddress.Size = new System.Drawing.Size(106, 26);
            this.CTAddress.TabIndex = 58;
            // 
            // CTLastName
            // 
            this.CTLastName.Location = new System.Drawing.Point(274, 52);
            this.CTLastName.Name = "CTLastName";
            this.CTLastName.Size = new System.Drawing.Size(133, 26);
            this.CTLastName.TabIndex = 57;
            // 
            // CTName
            // 
            this.CTName.Location = new System.Drawing.Point(111, 52);
            this.CTName.Name = "CTName";
            this.CTName.Size = new System.Drawing.Size(149, 26);
            this.CTName.TabIndex = 56;
            // 
            // CTID
            // 
            this.CTID.Location = new System.Drawing.Point(12, 52);
            this.CTID.Name = "CTID";
            this.CTID.Size = new System.Drawing.Size(83, 26);
            this.CTID.TabIndex = 55;
            // 
            // ReceiveRentMovie
            // 
            this.ReceiveRentMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ReceiveRentMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ReceiveRentMovie.Location = new System.Drawing.Point(1367, 592);
            this.ReceiveRentMovie.Name = "ReceiveRentMovie";
            this.ReceiveRentMovie.Size = new System.Drawing.Size(123, 74);
            this.ReceiveRentMovie.TabIndex = 54;
            this.ReceiveRentMovie.Text = "Receive Return Movies";
            this.ReceiveRentMovie.UseVisualStyleBackColor = false;
            this.ReceiveRentMovie.Click += new System.EventHandler(this.ReceiveRentMovie_Click);
            // 
            // RentMovie
            // 
            this.RentMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.RentMovie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RentMovie.Location = new System.Drawing.Point(1364, 496);
            this.RentMovie.Name = "RentMovie";
            this.RentMovie.Size = new System.Drawing.Size(126, 74);
            this.RentMovie.TabIndex = 53;
            this.RentMovie.Text = "Issue Retal Movies";
            this.RentMovie.UseVisualStyleBackColor = false;
            this.RentMovie.Click += new System.EventHandler(this.RentMovie_Click);
            // 
            // MVSDelete
            // 
            this.MVSDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MVSDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVSDelete.Location = new System.Drawing.Point(1036, 127);
            this.MVSDelete.Name = "MVSDelete";
            this.MVSDelete.Size = new System.Drawing.Size(164, 37);
            this.MVSDelete.TabIndex = 52;
            this.MVSDelete.Text = "Movie Deletion";
            this.MVSDelete.UseVisualStyleBackColor = false;
            this.MVSDelete.Click += new System.EventHandler(this.MVSDelete_Click);
            // 
            // MVSUpdate
            // 
            this.MVSUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MVSUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVSUpdate.Location = new System.Drawing.Point(849, 126);
            this.MVSUpdate.Name = "MVSUpdate";
            this.MVSUpdate.Size = new System.Drawing.Size(158, 38);
            this.MVSUpdate.TabIndex = 51;
            this.MVSUpdate.Text = "Movie Updation";
            this.MVSUpdate.UseVisualStyleBackColor = false;
            this.MVSUpdate.Click += new System.EventHandler(this.MVSUpdate_Click);
            // 
            // MVSInsert
            // 
            this.MVSInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.MVSInsert.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MVSInsert.Location = new System.Drawing.Point(668, 126);
            this.MVSInsert.Name = "MVSInsert";
            this.MVSInsert.Size = new System.Drawing.Size(158, 40);
            this.MVSInsert.TabIndex = 50;
            this.MVSInsert.Text = "Movie Insert";
            this.MVSInsert.UseVisualStyleBackColor = false;
            this.MVSInsert.Click += new System.EventHandler(this.MVSInsert_Click);
            // 
            // CustDelete
            // 
            this.CustDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CustDelete.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CustDelete.Location = new System.Drawing.Point(400, 101);
            this.CustDelete.Name = "CustDelete";
            this.CustDelete.Size = new System.Drawing.Size(191, 63);
            this.CustDelete.TabIndex = 49;
            this.CustDelete.Text = "Customer deletion";
            this.CustDelete.UseVisualStyleBackColor = false;
            this.CustDelete.Click += new System.EventHandler(this.CustDelete_Click);
            // 
            // CustName
            // 
            this.CustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CustName.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CustName.Location = new System.Drawing.Point(12, 100);
            this.CustName.Name = "CustName";
            this.CustName.Size = new System.Drawing.Size(171, 64);
            this.CustName.TabIndex = 48;
            this.CustName.Text = "Customer Insert";
            this.CustName.UseVisualStyleBackColor = false;
            this.CustName.Click += new System.EventHandler(this.CustName_Click);
            // 
            // CustUpdate
            // 
            this.CustUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CustUpdate.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CustUpdate.Location = new System.Drawing.Point(205, 100);
            this.CustUpdate.Name = "CustUpdate";
            this.CustUpdate.Size = new System.Drawing.Size(176, 64);
            this.CustUpdate.TabIndex = 47;
            this.CustUpdate.Text = "Customer Updation";
            this.CustUpdate.UseVisualStyleBackColor = false;
            this.CustUpdate.Click += new System.EventHandler(this.CustUpdate_Click);
            // 
            // RentalRecordTabs
            // 
            this.RentalRecordTabs.Controls.Add(this.tabPage1);
            this.RentalRecordTabs.Controls.Add(this.tabPage2);
            this.RentalRecordTabs.Controls.Add(this.tabPage3);
            this.RentalRecordTabs.Location = new System.Drawing.Point(9, 240);
            this.RentalRecordTabs.Name = "RentalRecordTabs";
            this.RentalRecordTabs.SelectedIndex = 0;
            this.RentalRecordTabs.Size = new System.Drawing.Size(1230, 406);
            this.RentalRecordTabs.TabIndex = 45;
            // 
            // ListMostPopularMovies
            // 
            this.ListMostPopularMovies.AutoSize = true;
            this.ListMostPopularMovies.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ListMostPopularMovies.Location = new System.Drawing.Point(1283, 196);
            this.ListMostPopularMovies.Name = "ListMostPopularMovies";
            this.ListMostPopularMovies.Size = new System.Drawing.Size(173, 24);
            this.ListMostPopularMovies.TabIndex = 92;
            this.ListMostPopularMovies.Text = "Popular out of them";
            this.ListMostPopularMovies.UseVisualStyleBackColor = true;
            this.ListMostPopularMovies.CheckedChanged += new System.EventHandler(this.ListMostPopularMovies_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1529, 688);
            this.Controls.Add(this.ListMostPopularMovies);
            this.Controls.Add(this.ListRentMovie);
            this.Controls.Add(this.ListEveryMovie);
            this.Controls.Add(this.RentReturnDate);
            this.Controls.Add(this.CAddress);
            this.Controls.Add(this.RentRentalDate);
            this.Controls.Add(this.RentIDMovie);
            this.Controls.Add(this.RentCID);
            this.Controls.Add(this.Idforrent);
            this.Controls.Add(this.MVRelaseDate);
            this.Controls.Add(this.MVCost);
            this.Controls.Add(this.MVGenre);
            this.Controls.Add(this.MVPlot);
            this.Controls.Add(this.MVCopy);
            this.Controls.Add(this.MVRating);
            this.Controls.Add(this.MVName);
            this.Controls.Add(this.MVId);
            this.Controls.Add(this.CLastName);
            this.Controls.Add(this.CMobile);
            this.Controls.Add(this.CId);
            this.Controls.Add(this.CFirstName);
            this.Controls.Add(this.RRDate);
            this.Controls.Add(this.RIDate);
            this.Controls.Add(this.RMVId);
            this.Controls.Add(this.RCustId);
            this.Controls.Add(this.MVSReleaseDate);
            this.Controls.Add(this.RMId);
            this.Controls.Add(this.MVSCost);
            this.Controls.Add(this.MVSPlot);
            this.Controls.Add(this.MVSGenre);
            this.Controls.Add(this.MVSCopies);
            this.Controls.Add(this.MVSRating);
            this.Controls.Add(this.MVSTitle);
            this.Controls.Add(this.MVSID);
            this.Controls.Add(this.CTPhone);
            this.Controls.Add(this.CTAddress);
            this.Controls.Add(this.CTLastName);
            this.Controls.Add(this.CTName);
            this.Controls.Add(this.CTID);
            this.Controls.Add(this.ReceiveRentMovie);
            this.Controls.Add(this.RentMovie);
            this.Controls.Add(this.MVSDelete);
            this.Controls.Add(this.MVSUpdate);
            this.Controls.Add(this.MVSInsert);
            this.Controls.Add(this.CustDelete);
            this.Controls.Add(this.CustName);
            this.Controls.Add(this.CustUpdate);
            this.Controls.Add(this.RentalRecordTabs);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MVGrid)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RentalGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustGrid)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.RentalRecordTabs.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton ListRentMovie;
        private System.Windows.Forms.RadioButton ListEveryMovie;
        private System.Windows.Forms.Label RentReturnDate;
        private System.Windows.Forms.Label CAddress;
        private System.Windows.Forms.Label RentRentalDate;
        private System.Windows.Forms.Label RentIDMovie;
        private System.Windows.Forms.Label RentCID;
        private System.Windows.Forms.Label Idforrent;
        private System.Windows.Forms.Label MVRelaseDate;
        private System.Windows.Forms.Label MVCost;
        private System.Windows.Forms.Label MVGenre;
        private System.Windows.Forms.Label MVPlot;
        private System.Windows.Forms.Label MVCopy;
        private System.Windows.Forms.Label MVRating;
        private System.Windows.Forms.Label MVName;
        private System.Windows.Forms.Label MVId;
        private System.Windows.Forms.Label CLastName;
        private System.Windows.Forms.Label CMobile;
        private System.Windows.Forms.Label CId;
        private System.Windows.Forms.Label CFirstName;
        private System.Windows.Forms.TextBox RRDate;
        private System.Windows.Forms.TextBox RIDate;
        private System.Windows.Forms.TextBox RMVId;
        private System.Windows.Forms.TextBox RCustId;
        private System.Windows.Forms.TextBox MVSReleaseDate;
        private System.Windows.Forms.TextBox RMId;
        private System.Windows.Forms.TextBox MVSCost;
        private System.Windows.Forms.TextBox MVSPlot;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView MVGrid;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView RentalGrid;
        private System.Windows.Forms.DataGridView CustGrid;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox MVSGenre;
        private System.Windows.Forms.TextBox MVSCopies;
        private System.Windows.Forms.TextBox MVSRating;
        private System.Windows.Forms.TextBox MVSTitle;
        private System.Windows.Forms.TextBox MVSID;
        private System.Windows.Forms.TextBox CTPhone;
        private System.Windows.Forms.TextBox CTAddress;
        private System.Windows.Forms.TextBox CTLastName;
        private System.Windows.Forms.TextBox CTName;
        private System.Windows.Forms.TextBox CTID;
        private System.Windows.Forms.Button ReceiveRentMovie;
        private System.Windows.Forms.Button RentMovie;
        private System.Windows.Forms.Button MVSDelete;
        private System.Windows.Forms.Button MVSUpdate;
        private System.Windows.Forms.Button MVSInsert;
        private System.Windows.Forms.Button CustDelete;
        private System.Windows.Forms.Button CustName;
        private System.Windows.Forms.Button CustUpdate;
        private System.Windows.Forms.TabControl RentalRecordTabs;
        private System.Windows.Forms.RadioButton ListMostPopularMovies;
    }
}

