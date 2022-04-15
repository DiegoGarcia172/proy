
namespace Proyecto
{
    partial class Editor_de_Fotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.redbar = new System.Windows.Forms.TrackBar();
            this.bluebar = new System.Windows.Forms.TrackBar();
            this.greenbar = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarFiltrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtro3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorDeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolDeDirectorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // redbar
            // 
            this.redbar.Location = new System.Drawing.Point(12, 557);
            this.redbar.Name = "redbar";
            this.redbar.Size = new System.Drawing.Size(866, 45);
            this.redbar.TabIndex = 1;
            this.redbar.Scroll += new System.EventHandler(this.redbar_Scroll_1);
            // 
            // bluebar
            // 
            this.bluebar.Location = new System.Drawing.Point(12, 594);
            this.bluebar.Name = "bluebar";
            this.bluebar.Size = new System.Drawing.Size(866, 45);
            this.bluebar.TabIndex = 2;
            this.bluebar.Scroll += new System.EventHandler(this.bluebar_Scroll_1);
            // 
            // greenbar
            // 
            this.greenbar.Location = new System.Drawing.Point(12, 632);
            this.greenbar.Name = "greenbar";
            this.greenbar.Size = new System.Drawing.Size(866, 45);
            this.greenbar.TabIndex = 3;
            this.greenbar.Scroll += new System.EventHandler(this.greenbar_Scroll_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1273, 523);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.cambiarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1309, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.borrarImagenToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // borrarImagenToolStripMenuItem
            // 
            this.borrarImagenToolStripMenuItem.Name = "borrarImagenToolStripMenuItem";
            this.borrarImagenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.borrarImagenToolStripMenuItem.Text = "Borrar Imagen";
            this.borrarImagenToolStripMenuItem.Click += new System.EventHandler(this.borrarImagenToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.guardarToolStripMenuItem.Text = "Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitarFiltrosToolStripMenuItem,
            this.filtro1ToolStripMenuItem,
            this.filtro2ToolStripMenuItem,
            this.filtro3ToolStripMenuItem});
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // quitarFiltrosToolStripMenuItem
            // 
            this.quitarFiltrosToolStripMenuItem.Name = "quitarFiltrosToolStripMenuItem";
            this.quitarFiltrosToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.quitarFiltrosToolStripMenuItem.Text = "Quitar filtros";
            this.quitarFiltrosToolStripMenuItem.Click += new System.EventHandler(this.quitarFiltrosToolStripMenuItem_Click);
            // 
            // filtro1ToolStripMenuItem
            // 
            this.filtro1ToolStripMenuItem.Name = "filtro1ToolStripMenuItem";
            this.filtro1ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.filtro1ToolStripMenuItem.Text = "Filtro 1";
            this.filtro1ToolStripMenuItem.Click += new System.EventHandler(this.filtro1ToolStripMenuItem_Click);
            // 
            // filtro2ToolStripMenuItem
            // 
            this.filtro2ToolStripMenuItem.Name = "filtro2ToolStripMenuItem";
            this.filtro2ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.filtro2ToolStripMenuItem.Text = "Filtro 2";
            this.filtro2ToolStripMenuItem.Click += new System.EventHandler(this.filtro2ToolStripMenuItem_Click);
            // 
            // filtro3ToolStripMenuItem
            // 
            this.filtro3ToolStripMenuItem.Name = "filtro3ToolStripMenuItem";
            this.filtro3ToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.filtro3ToolStripMenuItem.Text = "Filtro 3";
            this.filtro3ToolStripMenuItem.Click += new System.EventHandler(this.filtro3ToolStripMenuItem_Click);
            // 
            // cambiarToolStripMenuItem
            // 
            this.cambiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproductorDeVideoToolStripMenuItem,
            this.arbolDeDirectorioToolStripMenuItem});
            this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            this.cambiarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cambiarToolStripMenuItem.Text = "Cambiar";
            // 
            // reproductorDeVideoToolStripMenuItem
            // 
            this.reproductorDeVideoToolStripMenuItem.Name = "reproductorDeVideoToolStripMenuItem";
            this.reproductorDeVideoToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.reproductorDeVideoToolStripMenuItem.Text = "Reproductor de video";
            this.reproductorDeVideoToolStripMenuItem.Click += new System.EventHandler(this.reproductorDeVideoToolStripMenuItem_Click);
            // 
            // arbolDeDirectorioToolStripMenuItem
            // 
            this.arbolDeDirectorioToolStripMenuItem.Name = "arbolDeDirectorioToolStripMenuItem";
            this.arbolDeDirectorioToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.arbolDeDirectorioToolStripMenuItem.Text = "Arbol de directorio";
            this.arbolDeDirectorioToolStripMenuItem.Click += new System.EventHandler(this.arbolDeDirectorioToolStripMenuItem_Click);
            // 
            // Editor_de_Fotos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 673);
            this.Controls.Add(this.greenbar);
            this.Controls.Add(this.bluebar);
            this.Controls.Add(this.redbar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Editor_de_Fotos";
            this.Text = "Editor_de_Fotos";
            ((System.ComponentModel.ISupportInitialize)(this.redbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bluebar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar redbar;
        private System.Windows.Forms.TrackBar bluebar;
        private System.Windows.Forms.TrackBar greenbar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarFiltrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtro3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductorDeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolDeDirectorioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}