
namespace WindowsFormsApp
{
    partial class AitLibary
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.forgotPwdLnkLbl = new System.Windows.Forms.LinkLabel();
            this.loginBtn = new System.Windows.Forms.Button();
            this.usernameTBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.pwordTBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(353, 31);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(106, 39);
            this.loginLbl.TabIndex = 0;
            this.loginLbl.Text = "Login";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.Location = new System.Drawing.Point(109, 160);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(124, 29);
            this.passwordLbl.TabIndex = 2;
            this.passwordLbl.Text = "Password";
            // 
            // forgotPwdLnkLbl
            // 
            this.forgotPwdLnkLbl.ActiveLinkColor = System.Drawing.Color.DarkOrchid;
            this.forgotPwdLnkLbl.AutoSize = true;
            this.forgotPwdLnkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPwdLnkLbl.Location = new System.Drawing.Point(340, 217);
            this.forgotPwdLnkLbl.Name = "forgotPwdLnkLbl";
            this.forgotPwdLnkLbl.Size = new System.Drawing.Size(136, 20);
            this.forgotPwdLnkLbl.TabIndex = 3;
            this.forgotPwdLnkLbl.TabStop = true;
            this.forgotPwdLnkLbl.Text = "Forgot Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.Location = new System.Drawing.Point(360, 261);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(99, 53);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // usernameTBox
            // 
            this.usernameTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTBox.Location = new System.Drawing.Point(245, 112);
            this.usernameTBox.Name = "usernameTBox";
            this.usernameTBox.Size = new System.Drawing.Size(349, 36);
            this.usernameTBox.TabIndex = 5;
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.Location = new System.Drawing.Point(109, 115);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(130, 29);
            this.usernameLbl.TabIndex = 6;
            this.usernameLbl.Text = "Username";
            // 
            // pwordTBox
            // 
            this.pwordTBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwordTBox.Location = new System.Drawing.Point(245, 157);
            this.pwordTBox.Name = "pwordTBox";
            this.pwordTBox.Size = new System.Drawing.Size(349, 36);
            this.pwordTBox.TabIndex = 7;
            this.pwordTBox.UseSystemPasswordChar = true;
            // 
            // AitLibary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pwordTBox);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.usernameTBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.forgotPwdLnkLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.loginLbl);
            this.Name = "AitLibary";
            this.Text = "AIT Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.LinkLabel forgotPwdLnkLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox usernameTBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.TextBox pwordTBox;
    }
}

