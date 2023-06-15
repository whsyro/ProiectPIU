
namespace Interfata.AdditionalForms
{
    partial class deleteData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteData));
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelInfoDelete = new System.Windows.Forms.Label();
            this.textBoxCNP = new System.Windows.Forms.TextBox();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.buttonStergere = new System.Windows.Forms.Button();
            this.lblInfoDel = new System.Windows.Forms.Label();
            this.radioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Candara", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(245, 58);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(215, 41);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Stergere Date";
            // 
            // labelInfoDelete
            // 
            this.labelInfoDelete.AutoSize = true;
            this.labelInfoDelete.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoDelete.ForeColor = System.Drawing.Color.White;
            this.labelInfoDelete.Location = new System.Drawing.Point(191, 197);
            this.labelInfoDelete.Name = "labelInfoDelete";
            this.labelInfoDelete.Size = new System.Drawing.Size(313, 15);
            this.labelInfoDelete.TabIndex = 21;
            this.labelInfoDelete.Text = "Introduceti CNP al persoanei pe care doriti sa o stergeti";
            // 
            // textBoxCNP
            // 
            this.textBoxCNP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.textBoxCNP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCNP.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCNP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.textBoxCNP.Location = new System.Drawing.Point(140, 226);
            this.textBoxCNP.Name = "textBoxCNP";
            this.textBoxCNP.Size = new System.Drawing.Size(421, 27);
            this.textBoxCNP.TabIndex = 20;
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.ForeColor = System.Drawing.Color.White;
            this.labelInfo2.Location = new System.Drawing.Point(186, 273);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(313, 15);
            this.labelInfo2.TabIndex = 24;
            this.labelInfo2.Text = "Selectati tipul de persoana pe care doriti sa o STERGETI";
            // 
            // buttonStergere
            // 
            this.buttonStergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.buttonStergere.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStergere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(38)))), ((int)(((byte)(67)))));
            this.buttonStergere.Location = new System.Drawing.Point(266, 360);
            this.buttonStergere.Name = "buttonStergere";
            this.buttonStergere.Size = new System.Drawing.Size(149, 38);
            this.buttonStergere.TabIndex = 25;
            this.buttonStergere.Text = "STERGERE";
            this.buttonStergere.UseVisualStyleBackColor = false;
            this.buttonStergere.Click += new System.EventHandler(this.buttonStergere_Click);
            // 
            // lblInfoDel
            // 
            this.lblInfoDel.AutoSize = true;
            this.lblInfoDel.Location = new System.Drawing.Point(70, 474);
            this.lblInfoDel.Name = "lblInfoDel";
            this.lblInfoDel.Size = new System.Drawing.Size(0, 13);
            this.lblInfoDel.TabIndex = 26;
            // 
            // radioButtonAdmin
            // 
            this.radioButtonAdmin.AutoSize = true;
            this.radioButtonAdmin.Location = new System.Drawing.Point(252, 311);
            this.radioButtonAdmin.Name = "radioButtonAdmin";
            this.radioButtonAdmin.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAdmin.TabIndex = 27;
            this.radioButtonAdmin.TabStop = true;
            this.radioButtonAdmin.Text = "Administrator";
            this.radioButtonAdmin.UseVisualStyleBackColor = true;
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(409, 311);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(51, 17);
            this.radioButtonClient.TabIndex = 28;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            // 
            // deleteData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(38)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(684, 561);
            this.Controls.Add(this.radioButtonClient);
            this.Controls.Add(this.radioButtonAdmin);
            this.Controls.Add(this.lblInfoDel);
            this.Controls.Add(this.buttonStergere);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfoDelete);
            this.Controls.Add(this.textBoxCNP);
            this.Controls.Add(this.labelTitle);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deleteData";
            this.Text = "deleteData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelInfoDelete;
        private System.Windows.Forms.TextBox textBoxCNP;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Button buttonStergere;
        private System.Windows.Forms.Label lblInfoDel;
        private System.Windows.Forms.RadioButton radioButtonAdmin;
        private System.Windows.Forms.RadioButton radioButtonClient;
    }
}