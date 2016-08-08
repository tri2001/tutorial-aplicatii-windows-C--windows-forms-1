using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicatieWindowsForms
{
    public partial class FereastraPrincipala : Form
    {
        public List<PersoanaAgenda> _listaPersoane = new List<PersoanaAgenda>();

        public FereastraPrincipala()
        {
            InitializeComponent();
        }

        private void LaClickPeAdauga(object sender, EventArgs e)
        {
            PersoanaAgenda p = new PersoanaAgenda();

            p.Nume = tbNume.Text;
            p.Telefon = tbTelefon.Text;

            if (rbMasculin.Checked)
            {
                p.GenulPersoanei = PersoanaAgenda.Gen.Masculin;
            }
            else
            {
                p.GenulPersoanei = PersoanaAgenda.Gen.Feminin;
            }

            // afisam mesaj de confirmare
            DialogResult rezultat = MessageBox.Show("Adauga persoana cu numele: " + p.Nume + " si numarul de telefon: " + p.Telefon + "?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (rezultat == System.Windows.Forms.DialogResult.Yes)
            {
                _listaPersoane.Add(p);
            }

            // golim textboxuri
            tbNume.Text = "";
            tbTelefon.Text = "";

            tbNume.Focus();
        }
    }
}
