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
    public partial class modifyClient : Form
    {
        public modifyClient()
        {
            InitializeComponent();
            dataGridViewClienti.ForeColor = Color.Black;
            buttonAfiseaza.MouseEnter += OnMouseEnterloginButton;
            buttonAfiseaza.MouseLeave += OnMouseLeaveloginButton;
            
            
        }
        private void OnMouseEnterloginButton(object sender, EventArgs e)
        {
            buttonAfiseaza.BackColor = Color.FromArgb(128, 181, 255);
            buttonAfiseaza.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void OnMouseLeaveloginButton(object sender, EventArgs e)
        {
            buttonAfiseaza.BackColor = Color.FromArgb(196, 221, 255);
            buttonAfiseaza.ForeColor = Color.FromArgb(39, 38, 67);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewClienti.SelectedRows)
            {
                dataGridViewClienti.Rows.RemoveAt(item.Index);
            }
        }


        private void buttonAfiseaza_Click(object sender, EventArgs e)
        {
            int nradministratori = 0;
            Admin admin = new Admin();
            Persoana[] admini = admin.GetPersoana(out nradministratori, "clienti.csv");

            int nrAuto = 0;
            Admin administrator = new Admin();
            ClassAuto[] auto = administrator.GetAuto(out nrAuto, "auto.csv");
            for (int i = 1; i < nrAuto; i++)
                dataGridViewClienti.Rows.Add(admini[i].GetNume(), admini[i].GetPrenume(), admini[i].GetCNP(), auto[i].GetMarca(), auto[i].GetCuloare(), auto[i].GetVin());
        }
    }
}
