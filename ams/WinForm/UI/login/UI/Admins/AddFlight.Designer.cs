namespace login.UI.Admin
{
    partial class Add_Flight
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FlightID = new Guna.UI2.WinForms.Guna2TextBox();
            this.FlightName = new Guna.UI2.WinForms.Guna2TextBox();
            this.StartPlace = new Guna.UI2.WinForms.Guna2TextBox();
            this.TakeOffTime = new Guna.UI2.WinForms.Guna2TextBox();
            this.Price = new Guna.UI2.WinForms.Guna2TextBox();
            this.Seats = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddFlight = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Destination = new Guna.UI2.WinForms.Guna2TextBox();
            this.TravelDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.AddFlightGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFlightGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1122, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(44, 35);
            this.guna2ControlBox1.TabIndex = 10;
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(9)))), ((int)(((byte)(43)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1072, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(44, 35);
            this.guna2ControlBox2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(176, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 47);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Flight";
            // 
            // FlightID
            // 
            this.FlightID.Animated = true;
            this.FlightID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FlightID.BorderRadius = 10;
            this.FlightID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FlightID.DefaultText = "";
            this.FlightID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FlightID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FlightID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FlightID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FlightID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.FlightID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FlightID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FlightID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FlightID.Location = new System.Drawing.Point(27, 121);
            this.FlightID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FlightID.Name = "FlightID";
            this.FlightID.PasswordChar = '\0';
            this.FlightID.PlaceholderText = "Flight ID";
            this.FlightID.SelectedText = "";
            this.FlightID.Size = new System.Drawing.Size(278, 26);
            this.FlightID.TabIndex = 13;
           
            // FlightName
            // 
            this.FlightName.Animated = true;
            this.FlightName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FlightName.BorderRadius = 10;
            this.FlightName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FlightName.DefaultText = "";
            this.FlightName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FlightName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FlightName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FlightName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FlightName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.FlightName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FlightName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FlightName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FlightName.Location = new System.Drawing.Point(27, 173);
            this.FlightName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FlightName.Name = "FlightName";
            this.FlightName.PasswordChar = '\0';
            this.FlightName.PlaceholderText = "Flight Name";
            this.FlightName.SelectedText = "";
            this.FlightName.Size = new System.Drawing.Size(278, 26);
            this.FlightName.TabIndex = 14;
            // 
            // StartPlace
            // 
            this.StartPlace.Animated = true;
            this.StartPlace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.StartPlace.BorderRadius = 10;
            this.StartPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.StartPlace.DefaultText = "";
            this.StartPlace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.StartPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.StartPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StartPlace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.StartPlace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.StartPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StartPlace.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StartPlace.Location = new System.Drawing.Point(27, 230);
            this.StartPlace.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartPlace.Name = "StartPlace";
            this.StartPlace.PasswordChar = '\0';
            this.StartPlace.PlaceholderText = "Current Place";
            this.StartPlace.SelectedText = "";
            this.StartPlace.Size = new System.Drawing.Size(278, 26);
            this.StartPlace.TabIndex = 15;
            // 
            // TakeOffTime
            // 
            this.TakeOffTime.Animated = true;
            this.TakeOffTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TakeOffTime.BorderRadius = 10;
            this.TakeOffTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TakeOffTime.DefaultText = "";
            this.TakeOffTime.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TakeOffTime.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TakeOffTime.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TakeOffTime.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TakeOffTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.TakeOffTime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TakeOffTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TakeOffTime.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TakeOffTime.Location = new System.Drawing.Point(535, 173);
            this.TakeOffTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TakeOffTime.Name = "TakeOffTime";
            this.TakeOffTime.PasswordChar = '\0';
            this.TakeOffTime.PlaceholderText = "Take Off Time";
            this.TakeOffTime.SelectedText = "";
            this.TakeOffTime.Size = new System.Drawing.Size(278, 26);
            this.TakeOffTime.TabIndex = 16;
            // 
            // Price
            // 
            this.Price.Animated = true;
            this.Price.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Price.BorderRadius = 10;
            this.Price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Price.DefaultText = "";
            this.Price.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Price.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Price.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Price.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.Price.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Price.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Price.Location = new System.Drawing.Point(535, 230);
            this.Price.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Price.Name = "Price";
            this.Price.PasswordChar = '\0';
            this.Price.PlaceholderText = "Price";
            this.Price.SelectedText = "";
            this.Price.Size = new System.Drawing.Size(278, 26);
            this.Price.TabIndex = 17;
            // 
            // Seats
            // 
            this.Seats.Animated = true;
            this.Seats.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Seats.BorderRadius = 10;
            this.Seats.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Seats.DefaultText = "";
            this.Seats.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Seats.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Seats.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Seats.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Seats.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.Seats.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Seats.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Seats.Location = new System.Drawing.Point(535, 283);
            this.Seats.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Seats.Name = "Seats";
            this.Seats.PasswordChar = '\0';
            this.Seats.PlaceholderText = "Seats";
            this.Seats.SelectedText = "";
            this.Seats.Size = new System.Drawing.Size(278, 26);
            this.Seats.TabIndex = 18;
            // 
            // AddFlight
            // 
            this.AddFlight.BorderRadius = 10;
            this.AddFlight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddFlight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddFlight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddFlight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddFlight.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(46)))), ((int)(((byte)(135)))));
            this.AddFlight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddFlight.ForeColor = System.Drawing.Color.White;
            this.AddFlight.HoverState.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlight.Location = new System.Drawing.Point(362, 283);
            this.AddFlight.Name = "AddFlight";
            this.AddFlight.Size = new System.Drawing.Size(106, 41);
            this.AddFlight.TabIndex = 19;
            this.AddFlight.Text = "Add";
            this.AddFlight.Click += new System.EventHandler(this.AddFlight_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::login.Properties.Resources.icons8_add_new_64;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(47, 25);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(99, 73);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 24;
            this.guna2PictureBox1.TabStop = false;
            // 
            // Destination
            // 
            this.Destination.Animated = true;
            this.Destination.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Destination.BorderRadius = 10;
            this.Destination.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Destination.DefaultText = "";
            this.Destination.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Destination.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Destination.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Destination.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Destination.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.Destination.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Destination.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Destination.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Destination.Location = new System.Drawing.Point(27, 283);
            this.Destination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Destination.Name = "Destination";
            this.Destination.PasswordChar = '\0';
            this.Destination.PlaceholderText = "Destination";
            this.Destination.SelectedText = "";
            this.Destination.Size = new System.Drawing.Size(278, 26);
            this.Destination.TabIndex = 25;
            // 
            // TravelDate
            // 
            this.TravelDate.Animated = true;
            this.TravelDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TravelDate.BorderRadius = 10;
            this.TravelDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TravelDate.DefaultText = "";
            this.TravelDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TravelDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TravelDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TravelDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TravelDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.TravelDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TravelDate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TravelDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TravelDate.Location = new System.Drawing.Point(535, 125);
            this.TravelDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TravelDate.Name = "TravelDate";
            this.TravelDate.PasswordChar = '\0';
            this.TravelDate.PlaceholderText = "Travel Date";
            this.TravelDate.SelectedText = "";
            this.TravelDate.Size = new System.Drawing.Size(278, 40);
            this.TravelDate.TabIndex = 21;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(546, 134);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(257, 22);
            this.date.TabIndex = 26;
            // 
            // AddFlightGrid
            // 
            this.AddFlightGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AddFlightGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddFlightGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AddFlightGrid.ColumnHeadersHeight = 4;
            this.AddFlightGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AddFlightGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.AddFlightGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddFlightGrid.Location = new System.Drawing.Point(27, 356);
            this.AddFlightGrid.Name = "AddFlightGrid";
            this.AddFlightGrid.ReadOnly = true;
            this.AddFlightGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AddFlightGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.AddFlightGrid.RowHeadersVisible = false;
            this.AddFlightGrid.RowHeadersWidth = 51;
            this.AddFlightGrid.RowTemplate.Height = 24;
            this.AddFlightGrid.Size = new System.Drawing.Size(799, 271);
            this.AddFlightGrid.TabIndex = 20;
            this.AddFlightGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AddFlightGrid.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddFlightGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AddFlightGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AddFlightGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AddFlightGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.AddFlightGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AddFlightGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AddFlightGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AddFlightGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AddFlightGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.AddFlightGrid.ThemeStyle.ReadOnly = true;
            this.AddFlightGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AddFlightGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AddFlightGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(123)))), ((int)(((byte)(134)))));
            this.AddFlightGrid.ThemeStyle.RowsStyle.Height = 24;
            this.AddFlightGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AddFlightGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
        
            // 
            // Add_Flight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(15)))), ((int)(((byte)(43)))));
            this.ClientSize = new System.Drawing.Size(1167, 677);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Destination);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.TravelDate);
            this.Controls.Add(this.AddFlightGrid);
            this.Controls.Add(this.AddFlight);
            this.Controls.Add(this.Seats);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.TakeOffTime);
            this.Controls.Add(this.StartPlace);
            this.Controls.Add(this.FlightName);
            this.Controls.Add(this.FlightID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Add_Flight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Flight";
           
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddFlightGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox FlightID;
        private Guna.UI2.WinForms.Guna2TextBox FlightName;
        private Guna.UI2.WinForms.Guna2TextBox StartPlace;
        private Guna.UI2.WinForms.Guna2TextBox TakeOffTime;
        private Guna.UI2.WinForms.Guna2TextBox Price;
        private Guna.UI2.WinForms.Guna2TextBox Seats;
        private Guna.UI2.WinForms.Guna2Button AddFlight;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox Destination;
        private Guna.UI2.WinForms.Guna2TextBox TravelDate;
        private System.Windows.Forms.DateTimePicker date;
        private Guna.UI2.WinForms.Guna2DataGridView AddFlightGrid;
    }
}