namespace AITMediaLibrary
{
    partial class MediaBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaBrowser));
            this.userDetailLbl = new System.Windows.Forms.Label();
            this.mediaDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.listMediaBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mediaLbl = new System.Windows.Forms.Label();
            this.publishYearLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.genreLbl = new System.Windows.Forms.Label();
            this.publishYearTxtBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.genreTxtBox = new System.Windows.Forms.TextBox();
            this.publishYearSearchBtn = new System.Windows.Forms.Button();
            this.searchPublishYearButton = new System.Windows.Forms.Button();
            this.titleSearchBtn = new System.Windows.Forms.Button();
            this.genreSearchBtn = new System.Windows.Forms.Button();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.closeAppBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // userDetailLbl
            // 
            this.userDetailLbl.AutoSize = true;
            this.userDetailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDetailLbl.Location = new System.Drawing.Point(43, 9);
            this.userDetailLbl.Name = "userDetailLbl";
            this.userDetailLbl.Size = new System.Drawing.Size(71, 25);
            this.userDetailLbl.TabIndex = 0;
            this.userDetailLbl.Text = "Details";
            // 
            // mediaDataGridView
            // 
            this.mediaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mediaDataGridView.Location = new System.Drawing.Point(12, 54);
            this.mediaDataGridView.Name = "mediaDataGridView";
            this.mediaDataGridView.Size = new System.Drawing.Size(762, 186);
            this.mediaDataGridView.TabIndex = 1;
            this.mediaDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.mediaDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FloralWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(208, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "List All Media";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // listMediaBtn
            // 
            this.listMediaBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.listMediaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMediaBtn.Location = new System.Drawing.Point(227, 262);
            this.listMediaBtn.Name = "listMediaBtn";
            this.listMediaBtn.Size = new System.Drawing.Size(178, 42);
            this.listMediaBtn.TabIndex = 2;
            this.listMediaBtn.Text = "List All Media";
            this.listMediaBtn.UseVisualStyleBackColor = false;
            this.listMediaBtn.Click += new System.EventHandler(this.listMediaBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // mediaLbl
            // 
            this.mediaLbl.AutoSize = true;
            this.mediaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediaLbl.Location = new System.Drawing.Point(411, 271);
            this.mediaLbl.Name = "mediaLbl";
            this.mediaLbl.Size = new System.Drawing.Size(154, 25);
            this.mediaLbl.TabIndex = 3;
            this.mediaLbl.Text = "Selected Media:";
            // 
            // publishYearLbl
            // 
            this.publishYearLbl.AutoSize = true;
            this.publishYearLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishYearLbl.Location = new System.Drawing.Point(115, 329);
            this.publishYearLbl.Name = "publishYearLbl";
            this.publishYearLbl.Size = new System.Drawing.Size(128, 25);
            this.publishYearLbl.TabIndex = 4;
            this.publishYearLbl.Text = "Publish Year:";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(115, 384);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(55, 25);
            this.titleLbl.TabIndex = 5;
            this.titleLbl.Text = "Title:";
            // 
            // genreLbl
            // 
            this.genreLbl.AutoSize = true;
            this.genreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreLbl.Location = new System.Drawing.Point(120, 442);
            this.genreLbl.Name = "genreLbl";
            this.genreLbl.Size = new System.Drawing.Size(72, 25);
            this.genreLbl.TabIndex = 6;
            this.genreLbl.Text = "Genre:";
            // 
            // publishYearTxtBox
            // 
            this.publishYearTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishYearTxtBox.Location = new System.Drawing.Point(249, 326);
            this.publishYearTxtBox.Name = "publishYearTxtBox";
            this.publishYearTxtBox.Size = new System.Drawing.Size(160, 30);
            this.publishYearTxtBox.TabIndex = 7;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTextBox.Location = new System.Drawing.Point(249, 384);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(160, 30);
            this.titleTextBox.TabIndex = 8;
            // 
            // genreTxtBox
            // 
            this.genreTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreTxtBox.Location = new System.Drawing.Point(249, 446);
            this.genreTxtBox.Name = "genreTxtBox";
            this.genreTxtBox.Size = new System.Drawing.Size(160, 30);
            this.genreTxtBox.TabIndex = 9;
            // 
            // publishYearSearchBtn
            // 
            this.publishYearSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publishYearSearchBtn.Location = new System.Drawing.Point(505, 349);
            this.publishYearSearchBtn.Name = "publishYearSearchBtn";
            this.publishYearSearchBtn.Size = new System.Drawing.Size(198, 30);
            this.publishYearSearchBtn.TabIndex = 10;
            this.publishYearSearchBtn.Text = "Search Publish Year";
            this.publishYearSearchBtn.UseVisualStyleBackColor = true;
            this.publishYearSearchBtn.Click += new System.EventHandler(this.publishYearSearchBtn_Click);
            // 
            // searchPublishYearButton
            // 
            this.searchPublishYearButton.BackColor = System.Drawing.Color.FloralWhite;
            this.searchPublishYearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPublishYearButton.Location = new System.Drawing.Point(460, 326);
            this.searchPublishYearButton.Name = "searchPublishYearButton";
            this.searchPublishYearButton.Size = new System.Drawing.Size(200, 30);
            this.searchPublishYearButton.TabIndex = 10;
            this.searchPublishYearButton.Text = "Search Publish Year";
            this.searchPublishYearButton.UseVisualStyleBackColor = false;
            this.searchPublishYearButton.Click += new System.EventHandler(this.searchPublishYearButton_Click);
            // 
            // titleSearchBtn
            // 
            this.titleSearchBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.titleSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleSearchBtn.Location = new System.Drawing.Point(460, 384);
            this.titleSearchBtn.Name = "titleSearchBtn";
            this.titleSearchBtn.Size = new System.Drawing.Size(200, 30);
            this.titleSearchBtn.TabIndex = 11;
            this.titleSearchBtn.Text = "Search Title";
            this.titleSearchBtn.UseVisualStyleBackColor = false;
            this.titleSearchBtn.Click += new System.EventHandler(this.titleSearchBtn_Click);
            // 
            // genreSearchBtn
            // 
            this.genreSearchBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.genreSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreSearchBtn.Location = new System.Drawing.Point(460, 446);
            this.genreSearchBtn.Name = "genreSearchBtn";
            this.genreSearchBtn.Size = new System.Drawing.Size(200, 30);
            this.genreSearchBtn.TabIndex = 12;
            this.genreSearchBtn.Text = "Search Genre";
            this.genreSearchBtn.UseVisualStyleBackColor = false;
            this.genreSearchBtn.Click += new System.EventHandler(this.genreSearchBtn_Click);
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.logOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutBtn.Location = new System.Drawing.Point(249, 500);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(122, 44);
            this.logOutBtn.TabIndex = 13;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.UseVisualStyleBackColor = false;
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click_1);
            // 
            // closeAppBtn
            // 
            this.closeAppBtn.BackColor = System.Drawing.Color.FloralWhite;
            this.closeAppBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAppBtn.Location = new System.Drawing.Point(446, 500);
            this.closeAppBtn.Name = "closeAppBtn";
            this.closeAppBtn.Size = new System.Drawing.Size(130, 44);
            this.closeAppBtn.TabIndex = 14;
            this.closeAppBtn.Text = "Close App";
            this.closeAppBtn.UseVisualStyleBackColor = false;
            this.closeAppBtn.Click += new System.EventHandler(this.closeAppBtn_Click);
            // 
            // MediaBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(786, 625);
            this.Controls.Add(this.closeAppBtn);
            this.Controls.Add(this.logOutBtn);
            this.Controls.Add(this.genreSearchBtn);
            this.Controls.Add(this.titleSearchBtn);
            this.Controls.Add(this.searchPublishYearButton);
            this.Controls.Add(this.genreTxtBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.publishYearTxtBox);
            this.Controls.Add(this.genreLbl);
            this.Controls.Add(this.titleLbl);
            this.Controls.Add(this.publishYearLbl);
            this.Controls.Add(this.mediaLbl);
            this.Controls.Add(this.listMediaBtn);
            this.Controls.Add(this.mediaDataGridView);
            this.Controls.Add(this.userDetailLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MediaBrowser";
            this.Text = "AIT Library - Media Browser";
            this.Load += new System.EventHandler(this.MediaBrowser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mediaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userDetailLbl;
        private System.Windows.Forms.DataGridView mediaDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button listMediaBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label mediaLbl;
        private System.Windows.Forms.Label publishYearLbl;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label genreLbl;
        private System.Windows.Forms.TextBox publishYearTxtBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox genreTxtBox;
        private System.Windows.Forms.Button publishYearSearchBtn;
        private System.Windows.Forms.Button searchPublishYearButton;
        private System.Windows.Forms.Button titleSearchBtn;
        private System.Windows.Forms.Button genreSearchBtn;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button closeAppBtn;
    }
}