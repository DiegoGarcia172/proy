
namespace Proyecto
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproductorDeVideoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorDeImagenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolDeDirectoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.cambiarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1150, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // cambiarToolStripMenuItem
            // 
            this.cambiarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproductorDeVideoToolStripMenuItem,
            this.editorDeImagenToolStripMenuItem,
            this.arbolDeDirectoriosToolStripMenuItem});
            this.cambiarToolStripMenuItem.Name = "cambiarToolStripMenuItem";
            this.cambiarToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.cambiarToolStripMenuItem.Text = "Cambiar";
            // 
            // reproductorDeVideoToolStripMenuItem
            // 
            this.reproductorDeVideoToolStripMenuItem.Name = "reproductorDeVideoToolStripMenuItem";
            this.reproductorDeVideoToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reproductorDeVideoToolStripMenuItem.Text = "Reproductor de Video";
            this.reproductorDeVideoToolStripMenuItem.Click += new System.EventHandler(this.reproductorDeVideoToolStripMenuItem_Click);
            // 
            // editorDeImagenToolStripMenuItem
            // 
            this.editorDeImagenToolStripMenuItem.Name = "editorDeImagenToolStripMenuItem";
            this.editorDeImagenToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.editorDeImagenToolStripMenuItem.Text = "Editor de Imagen";
            this.editorDeImagenToolStripMenuItem.Click += new System.EventHandler(this.editorDeImagenToolStripMenuItem_Click);
            // 
            // arbolDeDirectoriosToolStripMenuItem
            // 
            this.arbolDeDirectoriosToolStripMenuItem.Name = "arbolDeDirectoriosToolStripMenuItem";
            this.arbolDeDirectoriosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.arbolDeDirectoriosToolStripMenuItem.Text = "Arbol de directorios ";
            this.arbolDeDirectoriosToolStripMenuItem.Click += new System.EventHandler(this.arbolDeDirectoriosToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1150, 662);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproductorDeVideoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorDeImagenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolDeDirectoriosToolStripMenuItem;
    }
}