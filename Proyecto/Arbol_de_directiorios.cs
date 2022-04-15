using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Arbol_de_directiorios : Form
    {
        public Arbol_de_directiorios()
        {
            InitializeComponent();
        }
        private void Borrar()
        {
            textBox1.Clear();
            treeView1.Nodes.Clear();
            pictureBox1.Image = null;
            richTextBox1.Clear();
        }
        public void ChooseFolder()
        {
            FolderBrowserDialog dialogo = new FolderBrowserDialog();
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = dialogo.SelectedPath;
                DirectoryInfo di = new DirectoryInfo(dialogo.SelectedPath);

                treeView1.AfterSelect += TreeView1_AfterSelect;
                LlenarArbol(di, treeView1.Nodes);
            }
        }
        private void LlenarArbol(DirectoryInfo di, TreeNodeCollection tnc)
        {

            TreeNode nodo = tnc.Add(di.Name);
            foreach (FileInfo archivo in di.GetFiles())
            {
                nodo.Nodes.Add(archivo.FullName, archivo.Name);
            }
            foreach (DirectoryInfo sdi in di.GetDirectories())
            {
                LlenarArbol(sdi, nodo.Nodes);
            }

        }
        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //throw new NotImplementedException();
            if (e.Node.Name.EndsWith("txt") || e.Node.Name.EndsWith("cs"))
            {
                richTextBox1.Clear();
                StreamReader lector = new StreamReader(e.Node.Name);
                richTextBox1.Text = lector.ReadToEnd();
                lector.Close();
                richTextBox1.Width = 250;
                pictureBox1.Width = 0;
            }
            if (e.Node.Name.EndsWith("jpg") || e.Node.Name.EndsWith("PNG"))
            {
                Image image = Image.FromFile(e.Node.Name);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = image;
                pictureBox1.Width = 250;
                richTextBox1.Width = 0;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Click_();
        }
        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {

            DoubleClick_();
        }
        private void Click_()
        {
            pictureBox1.Dock = DockStyle.None;
            Dock = DockStyle.Fill;
            WindowState = FormWindowState.Normal;
        }
        private void DoubleClick_()
        {
            pictureBox1.Dock = DockStyle.Fill;
            Dock = DockStyle.Fill;
            WindowState = FormWindowState.Maximized;
        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrar();

            ChooseFolder();
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
        }
        private void editorDeFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Editor_de_Fotos frm = new Editor_de_Fotos();
            frm.Show();

        }
        private void reproductorDeVideosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor_de_videos frm = new Reproductor_de_videos();
            frm.Show();
        }

        private void Arbol_de_directiorios_Load(object sender, EventArgs e)
        {

        }
    }
}
