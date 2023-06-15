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
    public partial class LoginInterface : Form
    {
        public LoginInterface()
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
            //animatie buton login
            loginButton.MouseEnter += OnMouseEnterloginButton;
            loginButton.MouseLeave += OnMouseLeaveloginButton;
   
        }
        

        private void OnMouseEnterloginButton(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(128, 181, 255);
            loginButton.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void OnMouseLeaveloginButton(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(196, 221, 255);
            loginButton.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            int nradministratori = 0;
            Admin admin = new Admin();
            Persoana[] admini = admin.GetPersoana(out nradministratori, "admin.csv");
            for(int i=0;i<nradministratori; i++)
            if ((textBoxUsername.Text == "alex" && textBoxPassoword.Text == "0000")|| (textBoxUsername.Text == admini[i].GetUsername() && textBoxPassoword.Text == admini[i].GetPassword()))
            {

                textBoxUsername.Text = "";
                textBoxPassoword.Text = "";
                dateIncorecte.BackColor = Color.LightGreen;
                dateIncorecte.ForeColor = Color.Black;
                dateIncorecte.Text = "Date Corecte";
                AdminInterface adminii = new AdminInterface();
                adminii.Show();
                
            }
            else
            {
                dateIncorecte.BackColor = Color.IndianRed;
                dateIncorecte.ForeColor = Color.White;
                dateIncorecte.Text = "Date Incorecte";
            }
            
            
            
        }

        private void LoginInterface_Load(object sender, EventArgs e)
        {

        }

        private void dateIncorecte_Click(object sender, EventArgs e)
        {

        }

        private void passwoerdText_Click(object sender, EventArgs e)
        {

        }

        private void usernameText_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPassoword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextTitleLogin_Click(object sender, EventArgs e)
        {

        }

        private void LoginInterface_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
