using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibrarieClase;
namespace Interfata
{
    public partial class AdminInterface : Form
    {
        private Form activeForm;
        public AdminInterface()
        {
            
            InitializeComponent();
            btnAddAdmin.MouseEnter += OnMouseEnterloginButton;
            btnAddAdmin.MouseLeave += OnMouseLeaveloginButton;
            
            
        }
        private void OnMouseEnterloginButton(object sender, EventArgs e)
        {
            btnAddAdmin.BackColor = Color.FromArgb(128, 181, 255);
            btnAddAdmin.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void OnMouseLeaveloginButton(object sender, EventArgs e)
        {
            btnAddAdmin.BackColor = Color.FromArgb(196, 221, 255);
            btnAddAdmin.ForeColor = Color.FromArgb(39, 38, 67);

        }

        private void OpenChildForm (Form childForm, object btnPressed)
        {
            if(activeForm !=null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.AdminPanel.Controls.Add(childForm);
            this.AdminPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

            

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void BtnAddAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalForms.AddAdmin(), sender);
        }


        private void MenueTitle_Click(object sender, EventArgs e)
        {

        }

        

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalForms.AddClient(), sender);
        }

        private void AdminInterface_Load(object sender, EventArgs e)
        {
            
        }

        private void AdminInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnViewAdmins_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalForms.modifyAdmin(), sender);
        }

        private void btnViewClienti_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalForms.modifyClient(), sender);
        }

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AdditionalForms.deleteData(), sender);
        }
    }
    
}
