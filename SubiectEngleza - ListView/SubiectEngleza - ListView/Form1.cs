using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace SubiectEngleza___ListView
{
    public partial class Form1 : Form
    {
        Pista _pista;
        public Form1()
        {
            InitializeComponent();
        }

        public void DisplayZboruri()
        {
            zboruriLv.Items.Clear();

            foreach(Zbor zbor in _pista.listaZboruri)
            {
                var listViewItem=new ListViewItem(zbor.nrZbor.ToString());
                listViewItem.SubItems.Add(zbor.destinatie);
                listViewItem.SubItems.Add(zbor.capacitate.ToString());
                listViewItem.Tag= zbor;//

                zboruriLv.Items.Add(listViewItem);

            }
        }
        private void adgBtn_Click(object sender, EventArgs e)
        {
            var zbor = new Zbor();//by default 
            var form = new EditForm(zbor);
            if(form.ShowDialog()==DialogResult.OK)
            {
                _pista.listaZboruri.Add(zbor);
                DisplayZboruri();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pista=new Pista();
        }

        private void zboruriLv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var zbor = (Zbor)zboruriLv.SelectedItems[0].Tag;
            EditForm form=new EditForm(zbor);
            if(form.ShowDialog()==DialogResult.OK)
            {
                DisplayZboruri();
            }
        }

        private void serializareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = File.OpenWrite("export.bin"))
            {
                bf.Serialize(fs, _pista);
            }
        }

        private void deserializareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf=new BinaryFormatter();
            using(FileStream fs=File.OpenRead("export.bin"))
            {
                _pista=(Pista)bf.Deserialize(fs);
                DisplayZboruri();
            }
        }

        private void serializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer= new XmlSerializer(typeof(Pista));
            using(FileStream fs=File.OpenWrite("serializare.xml"))
            {
                xmlSerializer.Serialize(fs, _pista);
            }
        }

        private void deserializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xml=new XmlSerializer(typeof(Pista));
            using(FileStream fs=File.OpenRead("serializare.xml"))
            {
                _pista=(Pista)xml.Deserialize(fs);
                DisplayZboruri();
            }
        }
    }
}
