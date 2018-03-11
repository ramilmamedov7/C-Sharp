namespace AirportSystem
{
    partial class AirportForm
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
            this.lblcompanyName = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbCompany = new System.Windows.Forms.ComboBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.cmbRunway = new System.Windows.Forms.ComboBox();
            this.cmbGate = new System.Windows.Forms.ComboBox();
            this.cmbAirport = new System.Windows.Forms.ComboBox();
            this.lblRunway = new System.Windows.Forms.Label();
            this.lblGate = new System.Windows.Forms.Label();
            this.lblAirport = new System.Windows.Forms.Label();
            this.rbtTypeArrival = new System.Windows.Forms.RadioButton();
            this.rbtTypeDeparture = new System.Windows.Forms.RadioButton();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.dgvFlights = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcompanyName
            // 
            this.lblcompanyName.AutoSize = true;
            this.lblcompanyName.Location = new System.Drawing.Point(3, 9);
            this.lblcompanyName.Name = "lblcompanyName";
            this.lblcompanyName.Size = new System.Drawing.Size(51, 13);
            this.lblcompanyName.TabIndex = 1;
            this.lblcompanyName.Text = "Company";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(3, 57);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(43, 13);
            this.lblCountry.TabIndex = 2;
            this.lblCountry.Text = "Country";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(3, 105);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // cmbCompany
            // 
            this.cmbCompany.FormattingEnabled = true;
            this.cmbCompany.Location = new System.Drawing.Point(6, 27);
            this.cmbCompany.Name = "cmbCompany";
            this.cmbCompany.Size = new System.Drawing.Size(121, 21);
            this.cmbCompany.TabIndex = 1;
            // 
            // cmbCountry
            // 
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(6, 75);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(121, 21);
            this.cmbCountry.TabIndex = 2;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(6, 124);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 3;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // cmbRunway
            // 
            this.cmbRunway.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cmbRunway.FormattingEnabled = true;
            this.cmbRunway.Location = new System.Drawing.Point(186, 124);
            this.cmbRunway.Name = "cmbRunway";
            this.cmbRunway.Size = new System.Drawing.Size(121, 21);
            this.cmbRunway.TabIndex = 6;
            // 
            // cmbGate
            // 
            this.cmbGate.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cmbGate.FormattingEnabled = true;
            this.cmbGate.Location = new System.Drawing.Point(186, 75);
            this.cmbGate.Name = "cmbGate";
            this.cmbGate.Size = new System.Drawing.Size(121, 21);
            this.cmbGate.TabIndex = 5;
            // 
            // cmbAirport
            // 
            this.cmbAirport.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.cmbAirport.FormattingEnabled = true;
            this.cmbAirport.Location = new System.Drawing.Point(186, 27);
            this.cmbAirport.Name = "cmbAirport";
            this.cmbAirport.Size = new System.Drawing.Size(121, 21);
            this.cmbAirport.TabIndex = 4;
            // 
            // lblRunway
            // 
            this.lblRunway.AutoSize = true;
            this.lblRunway.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblRunway.Location = new System.Drawing.Point(183, 105);
            this.lblRunway.Name = "lblRunway";
            this.lblRunway.Size = new System.Drawing.Size(46, 13);
            this.lblRunway.TabIndex = 9;
            this.lblRunway.Text = "Runway";
            // 
            // lblGate
            // 
            this.lblGate.AutoSize = true;
            this.lblGate.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblGate.Location = new System.Drawing.Point(183, 57);
            this.lblGate.Name = "lblGate";
            this.lblGate.Size = new System.Drawing.Size(30, 13);
            this.lblGate.TabIndex = 8;
            this.lblGate.Text = "Gate";
            // 
            // lblAirport
            // 
            this.lblAirport.AutoSize = true;
            this.lblAirport.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblAirport.Location = new System.Drawing.Point(183, 9);
            this.lblAirport.Name = "lblAirport";
            this.lblAirport.Size = new System.Drawing.Size(37, 13);
            this.lblAirport.TabIndex = 7;
            this.lblAirport.Text = "Airport";
            // 
            // rbtTypeArrival
            // 
            this.rbtTypeArrival.AutoSize = true;
            this.rbtTypeArrival.Checked = true;
            this.rbtTypeArrival.Location = new System.Drawing.Point(351, 28);
            this.rbtTypeArrival.Name = "rbtTypeArrival";
            this.rbtTypeArrival.Size = new System.Drawing.Size(54, 17);
            this.rbtTypeArrival.TabIndex = 7;
            this.rbtTypeArrival.TabStop = true;
            this.rbtTypeArrival.Text = "Arrival";
            this.rbtTypeArrival.UseVisualStyleBackColor = true;
            // 
            // rbtTypeDeparture
            // 
            this.rbtTypeDeparture.AutoSize = true;
            this.rbtTypeDeparture.Location = new System.Drawing.Point(428, 27);
            this.rbtTypeDeparture.Name = "rbtTypeDeparture";
            this.rbtTypeDeparture.Size = new System.Drawing.Size(72, 17);
            this.rbtTypeDeparture.TabIndex = 8;
            this.rbtTypeDeparture.Text = "Departure";
            this.rbtTypeDeparture.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblDate.Location = new System.Drawing.Point(348, 57);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 15;
            this.lblDate.Text = "Date";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "HH:mm dd.MM.yyyy";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(351, 75);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(149, 20);
            this.dtpDate.TabIndex = 9;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Location = new System.Drawing.Point(351, 124);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(149, 23);
            this.btnAddFlight.TabIndex = 16;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // dgvFlights
            // 
            this.dgvFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFlights.Location = new System.Drawing.Point(6, 171);
            this.dgvFlights.Name = "dgvFlights";
            this.dgvFlights.Size = new System.Drawing.Size(745, 187);
            this.dgvFlights.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(535, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvFlights);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.rbtTypeDeparture);
            this.Controls.Add(this.rbtTypeArrival);
            this.Controls.Add(this.cmbRunway);
            this.Controls.Add(this.cmbGate);
            this.Controls.Add(this.cmbAirport);
            this.Controls.Add(this.lblRunway);
            this.Controls.Add(this.lblGate);
            this.Controls.Add(this.lblAirport);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.cmbCountry);
            this.Controls.Add(this.cmbCompany);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblcompanyName);
            this.Name = "AirportForm";
            this.Text = "Airport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcompanyName;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.ComboBox cmbCompany;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.ComboBox cmbRunway;
        private System.Windows.Forms.ComboBox cmbGate;
        private System.Windows.Forms.ComboBox cmbAirport;
        private System.Windows.Forms.Label lblRunway;
        private System.Windows.Forms.Label lblGate;
        private System.Windows.Forms.Label lblAirport;
        private System.Windows.Forms.RadioButton rbtTypeArrival;
        private System.Windows.Forms.RadioButton rbtTypeDeparture;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.DataGridView dgvFlights;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}

