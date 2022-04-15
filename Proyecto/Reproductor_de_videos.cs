using System;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Reproductor_de_videos : Form
    {
        public Reproductor_de_videos()
        {
            InitializeComponent();
        }
        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           OpenFileDialog Dg = new OpenFileDialog();
           DialogResult dr = Dg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                textBox1.Text = Dg.FileName;
                axVLCPlugin21.playlist.items.clear();
                axVLCPlugin21.playlist.add("file:///" + textBox1.Text);
                axVLCPlugin21.playlist.play();  
            }
        }
        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Menu frm = new Menu();
            frm.Show();
        }
        private void pararToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.stop();
            textBox1.Clear();
        }
        private void playToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            axVLCPlugin21.playlist.play();
        }
        private void editorDeFotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Editor_de_Fotos FRM = new Editor_de_Fotos();
            FRM.Show();
        }
        private void arbolDeDirectoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Arbol_de_directiorios FRM = new Arbol_de_directiorios();
            FRM.Show();
        }

    }
}
