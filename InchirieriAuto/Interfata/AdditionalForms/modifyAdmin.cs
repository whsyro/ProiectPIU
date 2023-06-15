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
    public partial class modifyAdmin : Form
    {
        public modifyAdmin()
        {
            InitializeComponent();
            dataGridViewAdmin.ForeColor = Color.Black;
            buttonAfisare.MouseEnter += OnMouseEnterloginButton;
            buttonAfisare.MouseLeave += OnMouseLeaveloginButton;
        }
        private void OnMouseEnterloginButton(object sender, EventArgs e)
        {
            buttonAfisare.BackColor = Color.FromArgb(128, 181, 255);
            buttonAfisare.ForeColor = Color.FromArgb(39, 38, 67);

        }
        private void OnMouseLeaveloginButton(object sender, EventArgs e)
        {
            buttonAfisare.BackColor = Color.FromArgb(196, 221, 255);
            buttonAfisare.ForeColor = Color.FromArgb(39, 38, 67);

        }

        private void buttonAfisare_Click(object sender, EventArgs e)
        {
            int nradministratori = 0;
            Admin admin = new Admin();
            Persoana[] admini = admin.GetPersoana(out nradministratori, "admin.csv");
            for (int i = 1; i < nradministratori; i++)
                dataGridViewAdmin.Rows.Add(admini[i].GetNume(), admini[i].GetPrenume(), admini[i].GetCNP(),admini[i].GetUsername(),admini[i].GetPassword());
        }
    }
}
