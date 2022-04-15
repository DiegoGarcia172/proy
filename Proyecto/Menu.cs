using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.Opacity = 0;
            this.ShowInTaskbar = false;
            Login f = new Login(this);
            f.WindowState = FormWindowState.Maximized;
            f.ShowDialog();
        }
        private void reproductorDeVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reproductor_de_videos frm = new Reproductor_de_videos();
            frm.Show();
        }

        private void editorDeImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Editor_de_Fotos frm = new Editor_de_Fotos();
            frm.Show();
        }
        private void arbolDeDirectoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Arbol_de_directiorios frm = new Arbol_de_directiorios();
            frm.Show();
        }
    }
}
