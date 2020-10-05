namespace Proyecto
{
    partial class MENU
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
            this.btnestudiantes = new System.Windows.Forms.Button();
            this.btnnotas = new System.Windows.Forms.Button();
            this.btnarchivo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú principal";
            // 
            // btnestudiantes
            // 
            this.btnestudiantes.BackColor = System.Drawing.Color.Black;
            this.btnestudiantes.Location = new System.Drawing.Point(161, 90);
            this.btnestudiantes.Name = "btnestudiantes";
            this.btnestudiantes.Size = new System.Drawing.Size(161, 49);
            this.btnestudiantes.TabIndex = 1;
            this.btnestudiantes.Text = "Registro de estudiantes";
            this.btnestudiantes.UseVisualStyleBackColor = false;
            this.btnestudiantes.Click += new System.EventHandler(this.Btnestudiantes_Click);
            // 
            // btnnotas
            // 
            this.btnnotas.BackColor = System.Drawing.Color.Black;
            this.btnnotas.Location = new System.Drawing.Point(161, 159);
            this.btnnotas.Name = "btnnotas";
            this.btnnotas.Size = new System.Drawing.Size(161, 49);
            this.btnnotas.TabIndex = 2;
            this.btnnotas.Text = "Subir notas";
            this.btnnotas.UseVisualStyleBackColor = false;
            this.btnnotas.Click += new System.EventHandler(this.Btnnotas_Click);
            // 
            // btnarchivo
            // 
            this.btnarchivo.BackColor = System.Drawing.Color.Black;
            this.btnarchivo.Location = new System.Drawing.Point(161, 232);
            this.btnarchivo.Name = "btnarchivo";
            this.btnarchivo.Size = new System.Drawing.Size(161, 49);
            this.btnarchivo.TabIndex = 4;
            this.btnarchivo.Text = "Crear documento de impresión";
            this.btnarchivo.UseVisualStyleBackColor = false;
            this.btnarchivo.Click += new System.EventHandler(this.Btnarchivo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(161, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(497, 445);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnarchivo);
            this.Controls.Add(this.btnnotas);
            this.Controls.Add(this.btnestudiantes);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MENU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnestudiantes;
        private System.Windows.Forms.Button btnnotas;
        private System.Windows.Forms.Button btnarchivo;
        private System.Windows.Forms.Button button1;
    }
}