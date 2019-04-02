namespace MariaFedele
{
    partial class Menu_Principal
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
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Calendario = new System.Windows.Forms.SplitContainer();
            this.salon_selector = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Calendario)).BeginInit();
            this.Calendario.Panel1.SuspendLayout();
            this.Calendario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salon_selector)).BeginInit();
            this.salon_selector.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1080, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mesaToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // mesaToolStripMenuItem
            // 
            this.mesaToolStripMenuItem.Name = "mesaToolStripMenuItem";
            this.mesaToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.mesaToolStripMenuItem.Text = "Mesa";
            this.mesaToolStripMenuItem.Click += new System.EventHandler(this.mesaToolStripMenuItem_Click);
            // 
            // Calendario
            // 
            this.Calendario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendario.Location = new System.Drawing.Point(0, 24);
            this.Calendario.Name = "Calendario";
            this.Calendario.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Calendario.Panel1
            // 
            this.Calendario.Panel1.Controls.Add(this.salon_selector);
            this.Calendario.Size = new System.Drawing.Size(1080, 683);
            this.Calendario.SplitterDistance = 524;
            this.Calendario.TabIndex = 1;
            // 
            // salon_selector
            // 
            this.salon_selector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salon_selector.Location = new System.Drawing.Point(0, 0);
            this.salon_selector.Name = "salon_selector";
            // 
            // salon_selector.Panel2
            // 
            this.salon_selector.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.salon_selector_Panel2_Paint);
            this.salon_selector.Size = new System.Drawing.Size(1080, 524);
            this.salon_selector.SplitterDistance = 193;
            this.salon_selector.TabIndex = 0;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 707);
            this.Controls.Add(this.Calendario);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Menu_Principal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Calendario.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Calendario)).EndInit();
            this.Calendario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salon_selector)).EndInit();
            this.salon_selector.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mesaToolStripMenuItem;
        private System.Windows.Forms.SplitContainer Calendario;
        private System.Windows.Forms.SplitContainer salon_selector;
    }
}

