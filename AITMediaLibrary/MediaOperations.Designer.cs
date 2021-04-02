namespace AITMediaLibrary
{
    partial class MediaOperations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaOperations));
            this.borrowDataGridView = new System.Windows.Forms.DataGridView();
            this.reservedDataGridView = new System.Windows.Forms.DataGridView();
            this.reservationsLbl = new System.Windows.Forms.Label();
            this.borrowLbl = new System.Windows.Forms.Label();
            this.userIdResLbl = new System.Windows.Forms.Label();
            this.mediaIdResLbl = new System.Windows.Forms.Label();
            this.borrowDateLbl = new System.Windows.Forms.Label();
            this.estRtrnDateLbl = new System.Windows.Forms.Label();
            this.actualRtrnDateLbl = new System.Windows.Forms.Label();
            this.userIdResTxtBox = new System.Windows.Forms.TextBox();
            this.mediaIdRestxtBox = new System.Windows.Forms.TextBox();
            this.borrowDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.estimatedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.actualDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.reservationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mediaIdBorrowTxtBox = new System.Windows.Forms.TextBox();
            this.userIdBorrowTxtBox = new System.Windows.Forms.TextBox();
            this.userIdBorrowLbl = new System.Windows.Forms.Label();
            this.mediaIdBorrowLbl = new System.Windows.Forms.Label();
            this.reservationDateLbl = new System.Windows.Forms.Label();
            this.borrowBtn = new System.Windows.Forms.Button();
            this.refreshBorrowListBtn = new System.Windows.Forms.Button();
            this.refreshReservationsListBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.reserveMediaBtn = new System.Windows.Forms.Button();
            this.updateBorrowBtn = new System.Windows.Forms.Button();
            this.uActRturndateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectedBorrowItemLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // borrowDataGridView
            // 
            this.borrowDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowDataGridView.Location = new System.Drawing.Point(13, 68);
            this.borrowDataGridView.Name = "borrowDataGridView";
            this.borrowDataGridView.Size = new System.Drawing.Size(529, 150);
            this.borrowDataGridView.TabIndex = 0;
            this.borrowDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectBorrowItem);
            this.borrowDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.borrowDataGridView_CellContentClick_1);
            // 
            // reservedDataGridView
            // 
            this.reservedDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservedDataGridView.Location = new System.Drawing.Point(13, 332);
            this.reservedDataGridView.Name = "reservedDataGridView";
            this.reservedDataGridView.Size = new System.Drawing.Size(529, 150);
            this.reservedDataGridView.TabIndex = 1;
            this.reservedDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectReservedItem);
            // 
            // reservationsLbl
            // 
            this.reservationsLbl.AutoSize = true;
            this.reservationsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationsLbl.Location = new System.Drawing.Point(8, 288);
            this.reservationsLbl.Name = "reservationsLbl";
            this.reservationsLbl.Size = new System.Drawing.Size(125, 25);
            this.reservationsLbl.TabIndex = 2;
            this.reservationsLbl.Text = "Reservations";
            // 
            // borrowLbl
            // 
            this.borrowLbl.AutoSize = true;
            this.borrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowLbl.Location = new System.Drawing.Point(12, 26);
            this.borrowLbl.Name = "borrowLbl";
            this.borrowLbl.Size = new System.Drawing.Size(154, 25);
            this.borrowLbl.TabIndex = 3;
            this.borrowLbl.Text = "Borrowed Media";
            // 
            // userIdResLbl
            // 
            this.userIdResLbl.AutoSize = true;
            this.userIdResLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdResLbl.Location = new System.Drawing.Point(677, 353);
            this.userIdResLbl.Name = "userIdResLbl";
            this.userIdResLbl.Size = new System.Drawing.Size(77, 25);
            this.userIdResLbl.TabIndex = 4;
            this.userIdResLbl.Text = "User ID";
            // 
            // mediaIdResLbl
            // 
            this.mediaIdResLbl.AutoSize = true;
            this.mediaIdResLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaIdResLbl.Location = new System.Drawing.Point(664, 394);
            this.mediaIdResLbl.Name = "mediaIdResLbl";
            this.mediaIdResLbl.Size = new System.Drawing.Size(90, 25);
            this.mediaIdResLbl.TabIndex = 5;
            this.mediaIdResLbl.Text = "Media ID";
            // 
            // borrowDateLbl
            // 
            this.borrowDateLbl.AutoSize = true;
            this.borrowDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateLbl.Location = new System.Drawing.Point(635, 100);
            this.borrowDateLbl.Name = "borrowDateLbl";
            this.borrowDateLbl.Size = new System.Drawing.Size(119, 25);
            this.borrowDateLbl.TabIndex = 6;
            this.borrowDateLbl.Text = "Borrow Date";
            // 
            // estRtrnDateLbl
            // 
            this.estRtrnDateLbl.AutoSize = true;
            this.estRtrnDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estRtrnDateLbl.Location = new System.Drawing.Point(548, 137);
            this.estRtrnDateLbl.Name = "estRtrnDateLbl";
            this.estRtrnDateLbl.Size = new System.Drawing.Size(206, 25);
            this.estRtrnDateLbl.TabIndex = 7;
            this.estRtrnDateLbl.Text = "Estimated Return Date";
            // 
            // actualRtrnDateLbl
            // 
            this.actualRtrnDateLbl.AutoSize = true;
            this.actualRtrnDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualRtrnDateLbl.Location = new System.Drawing.Point(579, 174);
            this.actualRtrnDateLbl.Name = "actualRtrnDateLbl";
            this.actualRtrnDateLbl.Size = new System.Drawing.Size(175, 25);
            this.actualRtrnDateLbl.TabIndex = 8;
            this.actualRtrnDateLbl.Text = "Actual Return Date";
            // 
            // userIdResTxtBox
            // 
            this.userIdResTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdResTxtBox.Location = new System.Drawing.Point(769, 350);
            this.userIdResTxtBox.Name = "userIdResTxtBox";
            this.userIdResTxtBox.Size = new System.Drawing.Size(149, 30);
            this.userIdResTxtBox.TabIndex = 9;
            // 
            // mediaIdRestxtBox
            // 
            this.mediaIdRestxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaIdRestxtBox.Location = new System.Drawing.Point(769, 391);
            this.mediaIdRestxtBox.Name = "mediaIdRestxtBox";
            this.mediaIdRestxtBox.Size = new System.Drawing.Size(149, 30);
            this.mediaIdRestxtBox.TabIndex = 10;
            // 
            // borrowDateTimePicker
            // 
            this.borrowDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.borrowDateTimePicker.Location = new System.Drawing.Point(769, 95);
            this.borrowDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.borrowDateTimePicker.Name = "borrowDateTimePicker";
            this.borrowDateTimePicker.Size = new System.Drawing.Size(149, 30);
            this.borrowDateTimePicker.TabIndex = 11;
            this.borrowDateTimePicker.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // estimatedDateTimePicker
            // 
            this.estimatedDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estimatedDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.estimatedDateTimePicker.Location = new System.Drawing.Point(769, 132);
            this.estimatedDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.estimatedDateTimePicker.Name = "estimatedDateTimePicker";
            this.estimatedDateTimePicker.Size = new System.Drawing.Size(149, 30);
            this.estimatedDateTimePicker.TabIndex = 12;
            this.estimatedDateTimePicker.Value = new System.DateTime(2021, 4, 8, 0, 0, 0, 0);
            // 
            // actualDateTimePicker
            // 
            this.actualDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.actualDateTimePicker.Location = new System.Drawing.Point(769, 169);
            this.actualDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.actualDateTimePicker.Name = "actualDateTimePicker";
            this.actualDateTimePicker.Size = new System.Drawing.Size(149, 30);
            this.actualDateTimePicker.TabIndex = 13;
            this.actualDateTimePicker.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // reservationDateTimePicker
            // 
            this.reservationDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.reservationDateTimePicker.Location = new System.Drawing.Point(769, 436);
            this.reservationDateTimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.reservationDateTimePicker.Name = "reservationDateTimePicker";
            this.reservationDateTimePicker.Size = new System.Drawing.Size(149, 30);
            this.reservationDateTimePicker.TabIndex = 14;
            this.reservationDateTimePicker.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // mediaIdBorrowTxtBox
            // 
            this.mediaIdBorrowTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaIdBorrowTxtBox.Location = new System.Drawing.Point(769, 59);
            this.mediaIdBorrowTxtBox.Name = "mediaIdBorrowTxtBox";
            this.mediaIdBorrowTxtBox.Size = new System.Drawing.Size(149, 30);
            this.mediaIdBorrowTxtBox.TabIndex = 15;
            // 
            // userIdBorrowTxtBox
            // 
            this.userIdBorrowTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdBorrowTxtBox.Location = new System.Drawing.Point(769, 23);
            this.userIdBorrowTxtBox.Name = "userIdBorrowTxtBox";
            this.userIdBorrowTxtBox.Size = new System.Drawing.Size(149, 30);
            this.userIdBorrowTxtBox.TabIndex = 16;
            // 
            // userIdBorrowLbl
            // 
            this.userIdBorrowLbl.AutoSize = true;
            this.userIdBorrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdBorrowLbl.Location = new System.Drawing.Point(677, 26);
            this.userIdBorrowLbl.Name = "userIdBorrowLbl";
            this.userIdBorrowLbl.Size = new System.Drawing.Size(77, 25);
            this.userIdBorrowLbl.TabIndex = 17;
            this.userIdBorrowLbl.Text = "User ID";
            // 
            // mediaIdBorrowLbl
            // 
            this.mediaIdBorrowLbl.AutoSize = true;
            this.mediaIdBorrowLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaIdBorrowLbl.Location = new System.Drawing.Point(664, 62);
            this.mediaIdBorrowLbl.Name = "mediaIdBorrowLbl";
            this.mediaIdBorrowLbl.Size = new System.Drawing.Size(90, 25);
            this.mediaIdBorrowLbl.TabIndex = 18;
            this.mediaIdBorrowLbl.Text = "Media ID";
            // 
            // reservationDateLbl
            // 
            this.reservationDateLbl.AutoSize = true;
            this.reservationDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationDateLbl.Location = new System.Drawing.Point(593, 436);
            this.reservationDateLbl.Name = "reservationDateLbl";
            this.reservationDateLbl.Size = new System.Drawing.Size(161, 25);
            this.reservationDateLbl.TabIndex = 19;
            this.reservationDateLbl.Text = "Reservation Date";
            // 
            // borrowBtn
            // 
            this.borrowBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.borrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowBtn.Location = new System.Drawing.Point(682, 205);
            this.borrowBtn.Name = "borrowBtn";
            this.borrowBtn.Size = new System.Drawing.Size(162, 33);
            this.borrowBtn.TabIndex = 20;
            this.borrowBtn.Text = "Borrow Media";
            this.borrowBtn.UseVisualStyleBackColor = false;
            this.borrowBtn.Click += new System.EventHandler(this.borrowBtn_Click);
            // 
            // refreshBorrowListBtn
            // 
            this.refreshBorrowListBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.refreshBorrowListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBorrowListBtn.Location = new System.Drawing.Point(143, 224);
            this.refreshBorrowListBtn.Name = "refreshBorrowListBtn";
            this.refreshBorrowListBtn.Size = new System.Drawing.Size(95, 44);
            this.refreshBorrowListBtn.TabIndex = 21;
            this.refreshBorrowListBtn.Text = "Refresh";
            this.refreshBorrowListBtn.UseVisualStyleBackColor = false;
            this.refreshBorrowListBtn.Click += new System.EventHandler(this.refreshBorrowListBtn_Click);
            // 
            // refreshReservationsListBtn
            // 
            this.refreshReservationsListBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.refreshReservationsListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshReservationsListBtn.Location = new System.Drawing.Point(143, 497);
            this.refreshReservationsListBtn.Name = "refreshReservationsListBtn";
            this.refreshReservationsListBtn.Size = new System.Drawing.Size(95, 43);
            this.refreshReservationsListBtn.TabIndex = 22;
            this.refreshReservationsListBtn.Text = "Refresh";
            this.refreshReservationsListBtn.UseVisualStyleBackColor = false;
            this.refreshReservationsListBtn.Click += new System.EventHandler(this.refreshReservationsListBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.backBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(295, 555);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(83, 34);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(407, 555);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(92, 34);
            this.logOutBtn.TabIndex = 24;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // reserveMediaBtn
            // 
            this.reserveMediaBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.reserveMediaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reserveMediaBtn.Location = new System.Drawing.Point(493, 497);
            this.reserveMediaBtn.Name = "reserveMediaBtn";
            this.reserveMediaBtn.Size = new System.Drawing.Size(174, 43);
            this.reserveMediaBtn.TabIndex = 25;
            this.reserveMediaBtn.Text = "Reserve Media";
            this.reserveMediaBtn.UseVisualStyleBackColor = false;
            this.reserveMediaBtn.Click += new System.EventHandler(this.reserveMediaBtn_Click);
            // 
            // updateBorrowBtn
            // 
            this.updateBorrowBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.updateBorrowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBorrowBtn.Location = new System.Drawing.Point(710, 244);
            this.updateBorrowBtn.Name = "updateBorrowBtn";
            this.updateBorrowBtn.Size = new System.Drawing.Size(260, 34);
            this.updateBorrowBtn.TabIndex = 26;
            this.updateBorrowBtn.Text = "Update Actual Return Date";
            this.updateBorrowBtn.UseVisualStyleBackColor = false;
            this.updateBorrowBtn.Click += new System.EventHandler(this.updateBorrowBtn_Click);
            // 
            // uActRturndateTimePicker
            // 
            this.uActRturndateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.uActRturndateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uActRturndateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.uActRturndateTimePicker.Location = new System.Drawing.Point(563, 248);
            this.uActRturndateTimePicker.Name = "uActRturndateTimePicker";
            this.uActRturndateTimePicker.Size = new System.Drawing.Size(141, 30);
            this.uActRturndateTimePicker.TabIndex = 27;
            this.uActRturndateTimePicker.Value = new System.DateTime(2021, 4, 1, 0, 0, 0, 0);
            // 
            // selectedBorrowItemLbl
            // 
            this.selectedBorrowItemLbl.AutoSize = true;
            this.selectedBorrowItemLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedBorrowItemLbl.Location = new System.Drawing.Point(416, 253);
            this.selectedBorrowItemLbl.Name = "selectedBorrowItemLbl";
            this.selectedBorrowItemLbl.Size = new System.Drawing.Size(127, 25);
            this.selectedBorrowItemLbl.TabIndex = 28;
            this.selectedBorrowItemLbl.Text = "selected Item";
            // 
            // MediaOperations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(972, 601);
            this.Controls.Add(this.selectedBorrowItemLbl);
            this.Controls.Add(this.uActRturndateTimePicker);
            this.Controls.Add(this.updateBorrowBtn);
            this.Controls.Add(this.reserveMediaBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.refreshReservationsListBtn);
            this.Controls.Add(this.refreshBorrowListBtn);
            this.Controls.Add(this.borrowBtn);
            this.Controls.Add(this.reservationDateLbl);
            this.Controls.Add(this.mediaIdBorrowLbl);
            this.Controls.Add(this.userIdBorrowLbl);
            this.Controls.Add(this.userIdBorrowTxtBox);
            this.Controls.Add(this.mediaIdBorrowTxtBox);
            this.Controls.Add(this.reservationDateTimePicker);
            this.Controls.Add(this.actualDateTimePicker);
            this.Controls.Add(this.estimatedDateTimePicker);
            this.Controls.Add(this.borrowDateTimePicker);
            this.Controls.Add(this.mediaIdRestxtBox);
            this.Controls.Add(this.userIdResTxtBox);
            this.Controls.Add(this.actualRtrnDateLbl);
            this.Controls.Add(this.estRtrnDateLbl);
            this.Controls.Add(this.borrowDateLbl);
            this.Controls.Add(this.mediaIdResLbl);
            this.Controls.Add(this.userIdResLbl);
            this.Controls.Add(this.borrowLbl);
            this.Controls.Add(this.reservationsLbl);
            this.Controls.Add(this.reservedDataGridView);
            this.Controls.Add(this.borrowDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaOperations";
            this.Text = "AIT Library - Media Operations";
            ((System.ComponentModel.ISupportInitialize)(this.borrowDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservedDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView borrowDataGridView;
        private System.Windows.Forms.DataGridView reservedDataGridView;
        private System.Windows.Forms.Label reservationsLbl;
        private System.Windows.Forms.Label borrowLbl;
        private System.Windows.Forms.Label userIdResLbl;
        private System.Windows.Forms.Label mediaIdResLbl;
        private System.Windows.Forms.Label borrowDateLbl;
        private System.Windows.Forms.Label estRtrnDateLbl;
        private System.Windows.Forms.Label actualRtrnDateLbl;
        private System.Windows.Forms.TextBox userIdResTxtBox;
        private System.Windows.Forms.TextBox mediaIdRestxtBox;
        private System.Windows.Forms.DateTimePicker borrowDateTimePicker;
        private System.Windows.Forms.DateTimePicker estimatedDateTimePicker;
        private System.Windows.Forms.DateTimePicker actualDateTimePicker;
        private System.Windows.Forms.DateTimePicker reservationDateTimePicker;
        private System.Windows.Forms.TextBox mediaIdBorrowTxtBox;
        private System.Windows.Forms.TextBox userIdBorrowTxtBox;
        private System.Windows.Forms.Label userIdBorrowLbl;
        private System.Windows.Forms.Label mediaIdBorrowLbl;
        private System.Windows.Forms.Label reservationDateLbl;
        private System.Windows.Forms.Button borrowBtn;
        private System.Windows.Forms.Button refreshBorrowListBtn;
        private System.Windows.Forms.Button refreshReservationsListBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button reserveMediaBtn;
        private System.Windows.Forms.Button updateBorrowBtn;
        private System.Windows.Forms.DateTimePicker uActRturndateTimePicker;
        private System.Windows.Forms.Label selectedBorrowItemLbl;
    }
}