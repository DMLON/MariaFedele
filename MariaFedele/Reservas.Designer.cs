namespace MariaFedele
{
    partial class Reservas
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button2 = new System.Windows.Forms.Button();
            this.Agregar_reserva = new System.Windows.Forms.Button();
            this.Calendario_reservas = new System.Windows.Forms.MonthCalendar();
            this.Grid_reservas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_reservas)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.Agregar_reserva);
            this.splitContainer1.Panel1.Controls.Add(this.Calendario_reservas);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Grid_reservas);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 212;
            this.splitContainer1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Agregar_reserva
            // 
            this.Agregar_reserva.Location = new System.Drawing.Point(12, 183);
            this.Agregar_reserva.Name = "Agregar_reserva";
            this.Agregar_reserva.Size = new System.Drawing.Size(75, 23);
            this.Agregar_reserva.TabIndex = 1;
            this.Agregar_reserva.Text = "Nueva";
            this.Agregar_reserva.UseVisualStyleBackColor = true;
            this.Agregar_reserva.Click += new System.EventHandler(this.Agregar_reserva_Click);
            // 
            // Calendario_reservas
            // 
            this.Calendario_reservas.Location = new System.Drawing.Point(9, 9);
            this.Calendario_reservas.Name = "Calendario_reservas";
            this.Calendario_reservas.TabIndex = 0;
            this.Calendario_reservas.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendario_reservas_DateChanged);
            // 
            // Grid_reservas
            // 
            this.Grid_reservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_reservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid_reservas.Location = new System.Drawing.Point(0, 0);
            this.Grid_reservas.Name = "Grid_reservas";
            this.Grid_reservas.Size = new System.Drawing.Size(584, 450);
            this.Grid_reservas.TabIndex = 0;
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_reservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar Calendario_reservas;
        private System.Windows.Forms.DataGridView Grid_reservas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Agregar_reserva;
    }
}