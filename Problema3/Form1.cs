using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Problema3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((txtNume.Text == "") || (txtPrenume.Text == "") || (txtVarsta.Text == "") || (txtAdresa.Text == "") || (txtDep.Text == "") || (txtNrTel.Text == "") || (txtNrSerie.Text == "") || (txtSerie.Text == "") || (textNumeLoc.Text == ""))
            {
                MessageBox.Show("Nu ati completat toate campurile");
                // Environment.Exit(0);
            }
            listBox2.ColumnWidth = 300; // poți seta dimensiunea coloanei după preferință
            listBox2.MultiColumn = true;
            string adaugare = "Nume: " + txtNume.Text;
            listBox2.Items.Add(adaugare);
            string prenume = "Prenume: " + txtPrenume.Text;
            listBox2.Items.Add(prenume);
            string varsta = "Varsta: " + txtVarsta.Text;
            listBox2.Items.Add(varsta);
            string numeLoc = "Nume loc de munca: " + textNumeLoc.Text;
            listBox2.Items.Add(numeLoc);
            string DepLoc = "Deparatamentul locului de munca: " + txtDep.Text;
            listBox2.Items.Add(DepLoc);
            string Adresa = "Adresa: " + txtAdresa.Text;
            listBox2.Items.Add(Adresa);
            string nrTel = "Numar de telefon: " + txtNrTel.Text;
            listBox2.Items.Add(nrTel);
            string Serie = "Serie: " + txtSerie.Text + " Nr serie: " + txtNrSerie.Text;
            listBox2.Items.Add(Serie);


        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.Match(txtNume.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Va rog completati cu un Nume corespunzator");
                txtNume.Clear();
                return;
            }
        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.Match(txtPrenume.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Va rog completati cu un prenume corespunzator");
                txtPrenume.Clear();
                return;
            }
        }

        private void txtVarsta_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtVarsta.Text, @"^[0-9]*$") || (txtVarsta.Text.Length > 2))
            {

                MessageBox.Show("Scrieti o varsta valida");
                txtVarsta.Text = txtVarsta.Text.Remove(txtVarsta.Text.Length - 1);

            }
        }

        private void textNumeLoc_TextChanged(object sender, EventArgs e)
        {

            if (!Regex.Match(textNumeLoc.Text, "^[A-Z][a-zA-Z]*$").Success)
            {
                MessageBox.Show("Va rog completati corespunzator");
                textNumeLoc.Clear();
                return;
            }
        }

        private void txtNrTel_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNrTel.Text, @"^[0][0-9]*$") || (txtNrTel.Text.Length > 10))
            {

                MessageBox.Show("Scrieti un numar de telefon valid ");
                txtNrTel.Clear();

            }
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            if (!Regex.Match(txtSerie.Text, "^[A-Z]*$").Success || (txtSerie.Text.Length > 2))
            {
                MessageBox.Show("Va rog completati cu o serie corespunzatoare");
                txtSerie.Clear();
                return;
            }
        }

        private void txtNrSerie_TextChanged(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtNrSerie.Text, @"^[0-9]*$") || (txtNrSerie.Text.Length > 6))
            {

                MessageBox.Show("Scrieti o serie valida");
                txtNrSerie.Text = txtNrSerie.Text.Remove(txtNrSerie.Text.Length - 1);

            }
        }
    }
}