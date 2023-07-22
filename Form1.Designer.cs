namespace ProgramacionOrientadaObjetos
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.prácticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.práctica1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.práctica2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.práctica3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(854, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú principal de las practicas realizadas en la materia Programación Orientada a" +
    " Objetos\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(103, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prácticasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(962, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // prácticasToolStripMenuItem
            // 
            this.prácticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.práctica1ToolStripMenuItem,
            this.práctica2ToolStripMenuItem,
            this.práctica3ToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1});
            this.prácticasToolStripMenuItem.Name = "prácticasToolStripMenuItem";
            this.prácticasToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.prácticasToolStripMenuItem.Text = "Prácticas";
            // 
            // práctica1ToolStripMenuItem
            // 
            this.práctica1ToolStripMenuItem.Name = "práctica1ToolStripMenuItem";
            this.práctica1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.práctica1ToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.práctica1ToolStripMenuItem.Text = "Práctica 1 - Triángulos";
            this.práctica1ToolStripMenuItem.Click += new System.EventHandler(this.práctica1ToolStripMenuItem_Click);
            // 
            // práctica2ToolStripMenuItem
            // 
            this.práctica2ToolStripMenuItem.Name = "práctica2ToolStripMenuItem";
            this.práctica2ToolStripMenuItem.Size = new System.Drawing.Size(288, 26);
            this.práctica2ToolStripMenuItem.Text = "Práctica 2";
            this.práctica2ToolStripMenuItem.Click += new System.EventHandler(this.práctica2ToolStripMenuItem_Click);
            // 
            // práctica3ToolStripMenuItem
            // 
            this.práctica3ToolStripMenuItem.Name = "práctica3ToolStripMenuItem";
            this.práctica3ToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.práctica3ToolStripMenuItem.Text = "Práctica 3";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(238, 26);
            this.toolStripMenuItem1.Text = "Salir";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(962, 488);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema de programación";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prácticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem práctica1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem práctica2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem práctica3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

