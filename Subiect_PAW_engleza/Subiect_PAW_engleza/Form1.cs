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

namespace Subiect_PAW_engleza
{
    public partial class Form1 : Form
    {
        public Pista _pista;
        public Form1()
        {
            InitializeComponent();
           // Pista();
        }

        public void DisplayZboruri()
        {
            zborTv.Nodes[0].Nodes.Clear();
            _pista.listaZboruri.Sort();
            foreach(Zbor z in _pista.listaZboruri)
            {
                TreeNode node= new TreeNode(z.ToString());
                node.Tag = z;
                zborTv.Nodes[0].Nodes.Add(node);
            }

        }
        private void adaugaBtn_Click(object sender, EventArgs e)
        {
            var zbor=new Zbor();
            var form = new EditForm(zbor);
            if(form.ShowDialog()==DialogResult.OK)
            {
                _pista.listaZboruri.Add(zbor);
                DisplayZboruri();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _pista = new Pista();
            TreeNode treeNode=new TreeNode(_pista.ToString());
            zborTv.Nodes.Add(treeNode);
        }

        private void zborTv_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var zbor = (Zbor)zborTv.SelectedNode.Tag;
            var form = new EditForm(zbor);
            if(form.ShowDialog()==DialogResult.OK)
            {
                DisplayZboruri();
            }
        }

        private void serializareBinaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf=new BinaryFormatter();
            using(FileStream fs=File.OpenWrite("export.bin"))
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
            XmlSerializer xmlSerializer=new XmlSerializer(typeof(Pista));
            using(FileStream fs=File.OpenWrite("serializare.xml"))
            {
                xmlSerializer.Serialize(fs, _pista); 
            }
        }

        private void deserializareXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XmlSerializer xmlSerializer= new XmlSerializer(typeof(Pista));
            using(FileStream fs=File.OpenRead("serializare.xml"))
            {
                _pista = (Pista)xmlSerializer.Deserialize(fs);
                DisplayZboruri();
            }
        }
    }
}
