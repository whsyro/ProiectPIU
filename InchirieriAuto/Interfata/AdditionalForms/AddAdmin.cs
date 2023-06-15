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
namespace Interfata.AdditionalForms
{
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            if (!Admin.VerifExistFile("admin.csv"))
            {
                Admin.ScriereCsvPersoana("admin.csv", 0, "NUME", "PRENUME", "CNP", "USERNAME", "PASSWORD");
            }
            if (!Admin.VerifExistFile("clienti.csv"))
            {
                Admin.ScriereCsvPersoana("clienti.csv", 0, "NUME", "PRENUME", "CNP", "USERNAME", "PASSWORD");
            }
            if (!Admin.VerifExistFile("auto.csv"))
            {
                Admin.ScriereCsvAuto("auto.csv", 0, "MARCA", "CULOAREA", "AN FABRICATIE", "SERIA VIN", "INCIRIAT");
            }

            InitializeComponent();
            buttonADD.MouseEnter += OnMouseEnterbuttonADD;
            buttonADD.MouseLeave += OnMouseLeavebuttonADD;
        }


        private void OnMouseEnterbuttonADD(object sender, EventArgs e)
        {
            buttonADD.BackColor = Color.FromArgb(44, 105, 141);
            buttonADD.ForeColor = Color.White;

        }
        private void OnMouseLeavebuttonADD(object sender, EventArgs e)
        {
            buttonADD.BackColor = Color.FromArgb(186, 232, 232);
            buttonADD.ForeColor = Color.FromArgb(39, 38, 67);

        }

        private void txtBoxNume_TextChanged(object sender, EventArgs e)
        {

        }
        private void ResetareCamp()
        {
            txtBoxNume.Text = textBoxCNP.Text = textBoxPrenume.Text = textBoxUsername.Text = textBoxPassword.Text = string.Empty;
        }
        private void buttonADD_Click(object sender, EventArgs e)
        {
            if (txtBoxNume.Text != string.Empty && textBoxCNP.Text != string.Empty && textBoxPrenume.Text != string.Empty && textBoxUsername.Text != string.Empty && textBoxPassword.Text != string.Empty && Admin.VerifExistFile("admin.csv"))
            {
                int nradministratori=0;
                Admin admin = new Admin();
                Persoana[] admini = admin.GetPersoana(out nradministratori, "admin.csv");
                Admin.ScriereCsvPersoana("admin.csv", admini[nradministratori-1].GetIDPersoana()+1 , txtBoxNume.Text, textBoxCNP.Text, textBoxPrenume.Text, textBoxUsername.Text, textBoxPassword.Text);
                lblConfirm.Text = "Date adaugate cu succes!";
                lblConfirm.ForeColor = Color.Black;
                lblConfirm.BackColor = Color.LightGreen;
                ResetareCamp();
            }
            else
            {
                lblConfirm.Text = "Date lipsa!";
                lblConfirm.ForeColor = Color.Black;
                lblConfirm.BackColor = Color.IndianRed;
            }
        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {

        }

        private void textBoxCNP_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
