
namespace Interfata
{
    partial class LoginInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginInterface));
            this.TextTitleLogin = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassoword = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.Label();
            this.passwoerdText = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.dateIncorecte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextTitleLogin
            // 
            this.TextTitleLogin.AutoSize = true;
            this.TextTitleLogin.Font = new System.Drawing.Font("Candara", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTitleLogin.Location = new System.Drawing.Point(156, 44);
            this.TextTitleLogin.Name = "TextTitleLogin";
            this.TextTitleLogin.Size = new System.Drawing.Size(122, 45);
            this.TextTitleLogin.TabIndex = 0;
            this.TextTitleLogin.Text = "LOGIN";
            this.TextTitleLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TextTitleLogin.Click += new System.EventHandler(this.TextTitleLogin_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxUsername.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.textBoxUsername.Location = new System.Drawing.Point(63, 162);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(303, 31);
            this.textBoxUsername.TabIndex = 1;
            this.textBoxUsername.TextChanged += new System.EventHandler(this.textBoxUsername_TextChanged);
            // 
            // textBoxPassoword
            // 
            this.textBoxPassoword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.textBoxPassoword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassoword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassoword.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassoword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.textBoxPassoword.Location = new System.Drawing.Point(63, 252);
            this.textBoxPassoword.Name = "textBoxPassoword";
            this.textBoxPassoword.Size = new System.Drawing.Size(303, 31);
            this.textBoxPassoword.TabIndex = 2;
            this.textBoxPassoword.UseSystemPasswordChar = true;
            this.textBoxPassoword.TextChanged += new System.EventHandler(this.textBoxPassoword_TextChanged);
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameText.Location = new System.Drawing.Point(68, 136);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(111, 23);
            this.usernameText.TabIndex = 3;
            this.usernameText.Text = "USERNAME:";
            this.usernameText.Click += new System.EventHandler(this.usernameText_Click);
            // 
            // passwoerdText
            // 
            this.passwoerdText.AutoSize = true;
            this.passwoerdText.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwoerdText.Location = new System.Drawing.Point(68, 226);
            this.passwoerdText.Name = "passwoerdText";
            this.passwoerdText.Size = new System.Drawing.Size(112, 23);
            this.passwoerdText.TabIndex = 4;
            this.passwoerdText.Text = "PASSWORD:";
            this.passwoerdText.Click += new System.EventHandler(this.passwoerdText_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.loginButton.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.loginButton.Location = new System.Drawing.Point(132, 325);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(162, 46);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // dateIncorecte
            // 
            this.dateIncorecte.AutoSize = true;
            this.dateIncorecte.BackColor = System.Drawing.Color.Red;
            this.dateIncorecte.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateIncorecte.ForeColor = System.Drawing.Color.White;
            this.dateIncorecte.Location = new System.Drawing.Point(161, 303);
            this.dateIncorecte.Name = "dateIncorecte";
            this.dateIncorecte.Size = new System.Drawing.Size(0, 19);
            this.dateIncorecte.TabIndex = 6;
            this.dateIncorecte.Click += new System.EventHandler(this.dateIncorecte_Click);
            // 
            // LoginInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(424, 450);
            this.Controls.Add(this.dateIncorecte);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwoerdText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.textBoxPassoword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.TextTitleLogin);
            this.Font = new System.Drawing.Font("Candara Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginInterface";
            this.Text = "LoginInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginInterface_FormClosing);
            this.Load += new System.EventHandler(this.LoginInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TextTitleLogin;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassoword;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label passwoerdText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label dateIncorecte;
    }
}