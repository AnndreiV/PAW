using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Subiect_PAW_engleza
{
    public partial class EditForm : Form
    {
        public Zbor _zbor;
        public EditForm()
        {
            InitializeComponent();
        }

        public EditForm(Zbor zbor):this()
        {
            _zbor = zbor;
        }


        private void btnSubmit_Click(object sender, EventArgs e)
        {
            _zbor.nrZbor = (int)numericNrZbor.Value;
            _zbor.capacitate = (int)numericCapacitate.Value;
            _zbor.destinatie = textBoxDestinatie.Text;
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            if (_zbor == null)
                _zbor = new Zbor();
            numericNrZbor.Value = _zbor.nrZbor;
            numericCapacitate.Value = _zbor.capacitate;
            textBoxDestinatie.Text = _zbor.destinatie;
        }

        private bool DestinatieValida(string destinatie)
        {
            return destinatie.Length > 3 && destinatie.Length < 30;
        }
        private bool CapacitateValida(int capacitate)
        {
            return capacitate > 3 && capacitate < 100;
        }

        private bool NumarZborValid(int nrZbor)
        {
            return nrZbor > 3 && nrZbor < 100;
        }

        private void numericNrZbor_Validating(object sender, CancelEventArgs e)
        {
            if(!NumarZborValid((int)numericNrZbor.Value))
            {
                errorProvider1.SetError(numericNrZbor, "Numar zbor invalid!");
                e.Cancel = true;
            }
        }

        private void numericNrZbor_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(numericNrZbor, String.Empty);
        }

        private void textBoxDestinatie_Validating(object sender, CancelEventArgs e)
        {
            if (!DestinatieValida(textBoxDestinatie.Text))
            {
                errorProvider1.SetError(textBoxDestinatie, "Destinatie invalida!");
                e.Cancel = true;
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
                errorProvider1.SetError(numericCapacitate, "Capacitate invalida!");
                e.Cancel = true;
            }
        }

        private void numericCapacitate_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(numericCapacitate, String.Empty);
        }
    }
}
