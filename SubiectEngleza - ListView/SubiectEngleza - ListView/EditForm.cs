using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubiectEngleza___ListView
{
    public partial class EditForm : Form
    {
        Zbor _zbor;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Zbor zbor):this() 
        {
            _zbor = zbor;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            numericNrZbor.Value = (int)_zbor.nrZbor;
            numericCapacitate.Value=(int)_zbor.capacitate;
            textBoxDestinatie.Text=_zbor.destinatie.ToString();

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _zbor.nrZbor =(int) numericNrZbor.Value;
            _zbor.capacitate = (int)numericCapacitate.Value;
            _zbor.destinatie = textBoxDestinatie.Text;
        }

        public bool NumarZborValid(int cod)
        {
            return cod > 3 && cod < 50;
        }

        public bool DenumireValida(string denumire)
        {
            return denumire.Length > 3 && denumire.Length < 20;
        }
        public bool CapacitateValida(int capacitate)
        {
            return capacitate> 3 && capacitate < 50;
        }

        private void numericNrZbor_Validating(object sender, CancelEventArgs e)
        {
            if(!NumarZborValid((int)numericNrZbor.Value))
            {
                errorProvider1.SetError(numericNrZbor, "baga altceva!");
                e.Cancel= true;
            }
        }

        private void numericNrZbor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(numericNrZbor, String.Empty);
        }

        private void textBoxDestinatie_Validating(object sender, CancelEventArgs e)
        {
            if(!DenumireValida(textBoxDestinatie.Text))
            {
                errorProvider1.SetError(textBoxDestinatie, "Eroare de destinatie!");
                e.Cancel= true;
            }
        }

        private void textBoxDestinatie_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxDestinatie, String.Empty);
        }

        private void numericCapacitate_Validating(object sender, CancelEventArgs e)
        {
            if(!CapacitateValida((int)numericCapacitate.Value))
            {
                errorProvider1.SetError(numericCapacitate, "Eroare capacitate!");
                e.Cancel= true;
            }
        }

        private void numericCapacitate_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(numericCapacitate,String.Empty);
        }
    }
}
