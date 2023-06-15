
namespace Interfata
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.MenueTitle = new System.Windows.Forms.Label();
            this.AdminPanel = new System.Windows.Forms.Panel();
            this.btnAddAdmin = new System.Windows.Forms.Button();
            this.panelMenue = new System.Windows.Forms.Panel();
            this.panelMeniu = new System.Windows.Forms.Panel();
            this.btnViewClienti = new System.Windows.Forms.Button();
            this.btnViewAdmins = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.panelTileMenue = new System.Windows.Forms.Panel();
            this.btnDeleteData = new System.Windows.Forms.Button();
            this.panelMenue.SuspendLayout();
            this.panelMeniu.SuspendLayout();
            this.panelTileMenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenueTitle
            // 
            this.MenueTitle.AutoSize = true;
            this.MenueTitle.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenueTitle.ForeColor = System.Drawing.Color.White;
            this.MenueTitle.Location = new System.Drawing.Point(21, 26);
            this.MenueTitle.Name = "MenueTitle";
            this.MenueTitle.Size = new System.Drawing.Size(237, 26);
            this.MenueTitle.TabIndex = 0;
            this.MenueTitle.Text = "MENIU ADMINISTRATOR";
            this.MenueTitle.Click += new System.EventHandler(this.MenueTitle_Click);
            // 
            // AdminPanel
            // 
            this.AdminPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.AdminPanel.Location = new System.Drawing.Point(276, 0);
            this.AdminPanel.Name = "AdminPanel";
            this.AdminPanel.Size = new System.Drawing.Size(708, 561);
            this.AdminPanel.TabIndex = 2;
            this.AdminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminPanel_Paint);
            // 
            // btnAddAdmin
            // 
            this.btnAddAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAddAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddAdmin.FlatAppearance.BorderSize = 0;
            this.btnAddAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAdmin.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.btnAddAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAddAdmin.Name = "btnAddAdmin";
            this.btnAddAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddAdmin.Size = new System.Drawing.Size(278, 42);
            this.btnAddAdmin.TabIndex = 5;
            this.btnAddAdmin.Text = "Adaugare Administrator";
            this.btnAddAdmin.UseVisualStyleBackColor = false;
            this.btnAddAdmin.Click += new System.EventHandler(this.BtnAddAdmin_Click);
            // 
            // panelMenue
            // 
            this.panelMenue.Controls.Add(this.panelMeniu);
            this.panelMenue.Controls.Add(this.panelTileMenue);
            this.panelMenue.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenue.Location = new System.Drawing.Point(0, 0);
            this.panelMenue.Name = "panelMenue";
            this.panelMenue.Size = new System.Drawing.Size(278, 561);
            this.panelMenue.TabIndex = 3;
            // 
            // panelMeniu
            // 
            this.panelMeniu.Controls.Add(this.btnDeleteData);
            this.panelMeniu.Controls.Add(this.btnViewClienti);
            this.panelMeniu.Controls.Add(this.btnViewAdmins);
            this.panelMeniu.Controls.Add(this.btnAddClient);
            this.panelMeniu.Controls.Add(this.btnAddAdmin);
            this.panelMeniu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMeniu.Location = new System.Drawing.Point(0, 77);
            this.panelMeniu.Name = "panelMeniu";
            this.panelMeniu.Size = new System.Drawing.Size(278, 479);
            this.panelMeniu.TabIndex = 1;
            // 
            // btnViewClienti
            // 
            this.btnViewClienti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnViewClienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewClienti.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewClienti.FlatAppearance.BorderSize = 0;
            this.btnViewClienti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewClienti.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClienti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.btnViewClienti.Location = new System.Drawing.Point(0, 126);
            this.btnViewClienti.Name = "btnViewClienti";
            this.btnViewClienti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewClienti.Size = new System.Drawing.Size(278, 42);
            this.btnViewClienti.TabIndex = 9;
            this.btnViewClienti.Text = "Vizualizare Inchirieri";
            this.btnViewClienti.UseVisualStyleBackColor = false;
            this.btnViewClienti.Click += new System.EventHandler(this.btnViewClienti_Click);
            // 
            // btnViewAdmins
            // 
            this.btnViewAdmins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnViewAdmins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnViewAdmins.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnViewAdmins.FlatAppearance.BorderSize = 0;
            this.btnViewAdmins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAdmins.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAdmins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.btnViewAdmins.Location = new System.Drawing.Point(0, 84);
            this.btnViewAdmins.Name = "btnViewAdmins";
            this.btnViewAdmins.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnViewAdmins.Size = new System.Drawing.Size(278, 42);
            this.btnViewAdmins.TabIndex = 8;
            this.btnViewAdmins.Text = "Vizualizare Administratori";
            this.btnViewAdmins.UseVisualStyleBackColor = false;
            this.btnViewAdmins.Click += new System.EventHandler(this.btnViewAdmins_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnAddClient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddClient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddClient.FlatAppearance.BorderSize = 0;
            this.btnAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClient.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.btnAddClient.Location = new System.Drawing.Point(0, 42);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddClient.Size = new System.Drawing.Size(278, 42);
            this.btnAddClient.TabIndex = 6;
            this.btnAddClient.Text = "Adaugare Inchiriere";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // panelTileMenue
            // 
            this.panelTileMenue.Controls.Add(this.MenueTitle);
            this.panelTileMenue.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTileMenue.Location = new System.Drawing.Point(0, 0);
            this.panelTileMenue.Name = "panelTileMenue";
            this.panelTileMenue.Size = new System.Drawing.Size(278, 77);
            this.panelTileMenue.TabIndex = 0;
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(221)))), ((int)(((byte)(255)))));
            this.btnDeleteData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDeleteData.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteData.FlatAppearance.BorderSize = 0;
            this.btnDeleteData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteData.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.btnDeleteData.Location = new System.Drawing.Point(0, 168);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeleteData.Size = new System.Drawing.Size(278, 42);
            this.btnDeleteData.TabIndex = 10;
            this.btnDeleteData.Text = "Stergere Date";
            this.btnDeleteData.UseVisualStyleBackColor = false;
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelMenue);
            this.Controls.Add(this.AdminPanel);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminInterface_FormClosing);
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            this.panelMenue.ResumeLayout(false);
            this.panelMeniu.ResumeLayout(false);
            this.panelTileMenue.ResumeLayout(false);
            this.panelTileMenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MenueTitle;
        private System.Windows.Forms.Panel AdminPanel;
        private System.Windows.Forms.Panel panelMenue;
        private System.Windows.Forms.Panel panelMeniu;
        private System.Windows.Forms.Panel panelTileMenue;
        private System.Windows.Forms.Button btnAddAdmin;
        private System.Windows.Forms.Button btnViewClienti;
        private System.Windows.Forms.Button btnViewAdmins;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnDeleteData;
    }
}