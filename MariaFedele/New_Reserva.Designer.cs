namespace MariaFedele
{
    partial class New_Reserva
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
            this.fechaReserva = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Persona = new System.Windows.Forms.TextBox();
            this.b_aceptar = new System.Windows.Forms.Button();
            this.b_cancelar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_comentarios = new System.Windows.Forms.RichTextBox();
            this.TB_personas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fechaReserva
            // 
            this.fechaReserva.Location = new System.Drawing.Point(103, 50);
            this.fechaReserva.Name = "fechaReserva";
            this.fechaReserva.Size = new System.Drawing.Size(200, 20);
            this.fechaReserva.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "A nombre de";
            // 
            // TB_Persona
            // 
            this.TB_Persona.Location = new System.Drawing.Point(103, 20);
            this.TB_Persona.Name = "TB_Persona";
            this.TB_Persona.Size = new System.Drawing.Size(200, 20);
            this.TB_Persona.TabIndex = 5;
            // 
            // b_aceptar
            // 
            this.b_aceptar.Location = new System.Drawing.Point(72, 207);
            this.b_aceptar.Name = "b_aceptar";
            this.b_aceptar.Size = new System.Drawing.Size(75, 23);
            this.b_aceptar.TabIndex = 6;
            this.b_aceptar.Text = "Aceptar";
            this.b_aceptar.UseVisualStyleBackColor = true;
            this.b_aceptar.Click += new System.EventHandler(this.b_aceptar_Click);
            // 
            // b_cancelar
            // 
            this.b_cancelar.Location = new System.Drawing.Point(185, 207);
            this.b_cancelar.Name = "b_cancelar";
            this.b_cancelar.Size = new System.Drawing.Size(75, 23);
            this.b_cancelar.TabIndex = 7;
            this.b_cancelar.Text = "Cancelar";
            this.b_cancelar.UseVisualStyleBackColor = true;
            this.b_cancelar.Click += new System.EventHandler(this.b_cancelar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Comentarios";
            // 
            // TB_comentarios
            // 
            this.TB_comentarios.Location = new System.Drawing.Point(103, 110);
            this.TB_comentarios.Name = "TB_comentarios";
            this.TB_comentarios.Size = new System.Drawing.Size(200, 76);
            this.TB_comentarios.TabIndex = 10;
            this.TB_comentarios.Text = "";
            // 
            // TB_personas
            // 
            this.TB_personas.Location = new System.Drawing.Point(103, 80);
            this.TB_personas.Name = "TB_personas";
            this.TB_personas.Size = new System.Drawing.Size(200, 20);
            this.TB_personas.TabIndex = 11;
            // 
            // New_Reserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 241);
            this.Controls.Add(this.TB_personas);
            this.Controls.Add(this.TB_comentarios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_cancelar);
            this.Controls.Add(this.b_aceptar);
            this.Controls.Add(this.TB_Persona);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaReserva);
            this.Name = "New_Reserva";
            this.Text = "Nueva Reserva";
            this.Load += new System.EventHandler(this.Tests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker fechaReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Persona;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.Button b_cancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TB_comentarios;
        private System.Windows.Forms.TextBox TB_personas;
    }
}