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
    public partial class deleteData : Form
    {
        public deleteData()
        {
            InitializeComponent();
            buttonStergere.MouseEnter += OnMouseEnterloginButton;
            buttonStergere.MouseLeave += OnMouseLeaveloginButton;
        }
        private void OnMouseEnterloginButton(object sender, EventArgs e)
        {
            buttonStergere.BackColor = Color.FromArgb(128, 181, 255);
            buttonStergere.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void OnMouseLeaveloginButton(object sender, EventArgs e)
        {
            buttonStergere.BackColor = Color.FromArgb(196, 221, 255);
            buttonStergere.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void ResetareCamp()
        {
            textBoxCNP.Text = string.Empty;
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            if (radioButtonClient.Checked && textBoxCNP.Text != string.Empty)
            { Admin.StergeDatePersoanaFisierClient(textBoxCNP.Text, "clienti.csv", "auto.csv");
                lblInfoDel.Text = "Date CLIENT sterse cu succes!";
                lblInfoDel.ForeColor = Color.Black;
                lblInfoDel.BackColor = Color.LightGreen;
                ResetareCamp();
            }
            if (radioButtonAdmin.Checked && textBoxCNP.Text != string.Empty)
            {
                Admin.StergeDatePersoanaFisierAdmin(textBoxCNP.Text, "admin.csv");
                lblInfoDel.Text = "Date Administrator sterse cu succes!";
                lblInfoDel.ForeColor = Color.Black;
                lblInfoDel.BackColor = Color.LightGreen;
                ResetareCamp();
            }
            if (!radioButtonAdmin.Checked && !radioButtonClient.Checked && textBoxCNP.Text != string.Empty)
            {
                
                lblInfoDel.Text = "Selecteaza ce tip de date vrei sa stergi ADMIN/CLIENT";
                lblInfoDel.ForeColor = Color.Black;
                lblInfoDel.BackColor = Color.IndianRed;
            }
            if (textBoxCNP.Text==string.Empty && radioButtonAdmin.Checked && radioButtonClient.Checked)
            {

                lblInfoDel.Text = "Scrie datele despre persoana pe care vrei sa o elimini";
                lblInfoDel.ForeColor = Color.Black;
                lblInfoDel.BackColor = Color.IndianRed;
            }
            if (!radioButtonAdmin.Checked && !radioButtonClient.Checked && textBoxCNP.Text == string.Empty)
            {

                lblInfoDel.Text = "Atentie la completarea datelor! Totul este liber!";
                lblInfoDel.ForeColor = Color.Black;
                lblInfoDel.BackColor = Color.IndianRed;
            }

        }
    }
}
