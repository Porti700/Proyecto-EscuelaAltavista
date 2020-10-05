namespace Proyecto
{
    partial class Estudiantes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtidE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgradoE = new System.Windows.Forms.TextBox();
            this.txtapellidoE = new System.Windows.Forms.TextBox();
            this.txtnombreE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnmenuE = new System.Windows.Forms.Button();
            this.dgvestudiantes = new System.Windows.Forms.DataGridView();
            this.btningresarE = new System.Windows.Forms.Button();
            this.btnactualizarE = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtidE);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtgradoE);
            this.groupBox1.Controls.Add(this.txtapellidoE);
            this.groupBox1.Controls.Add(this.txtnombreE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 270);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos estudiante";
            // 
            // txtidE
            // 
            this.txtidE.Location = new System.Drawing.Point(135, 167);
            this.txtidE.Name = "txtidE";
            this.txtidE.Size = new System.Drawing.Size(278, 20);
            this.txtidE.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Id:";
            // 
            // txtgradoE
            // 
            this.txtgradoE.Location = new System.Drawing.Point(135, 124);
            this.txtgradoE.Name = "txtgradoE";
            this.txtgradoE.Size = new System.Drawing.Size(278, 20);
            this.txtgradoE.TabIndex = 5;
            this.txtgradoE.TextChanged += new System.EventHandler(this.txtgradoE_TextChanged);
            this.txtgradoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgradoestu);
            // 
            // txtapellidoE
            // 
            this.txtapellidoE.Location = new System.Drawing.Point(135, 83);
            this.txtapellidoE.Name = "txtapellidoE";
            this.txtapellidoE.Size = new System.Drawing.Size(278, 20);
            this.txtapellidoE.TabIndex = 4;
            this.txtapellidoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido);
            // 
            // txtnombreE
            // 
            this.txtnombreE.Location = new System.Drawing.Point(135, 42);
            this.txtnombreE.Name = "txtnombreE";
            this.txtnombreE.Size = new System.Drawing.Size(278, 20);
            this.txtnombreE.TabIndex = 3;
            this.txtnombreE.TextChanged += new System.EventHandler(this.txtnombreE_TextChanged);
            this.txtnombreE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombreEstu);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            // 
            // btnmenuE
            // 
            this.btnmenuE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmenuE.Location = new System.Drawing.Point(621, 208);
            this.btnmenuE.Name = "btnmenuE";
            this.btnmenuE.Size = new System.Drawing.Size(135, 74);
            this.btnmenuE.TabIndex = 1;
            this.btnmenuE.Text = "Menú principal";
            this.btnmenuE.UseVisualStyleBackColor = false;
            this.btnmenuE.Click += new System.EventHandler(this.btnmenuE_Click);
            // 
            // dgvestudiantes
            // 
            this.dgvestudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvestudiantes.Location = new System.Drawing.Point(12, 288);
            this.dgvestudiantes.Name = "dgvestudiantes";
            this.dgvestudiantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvestudiantes.Size = new System.Drawing.Size(744, 172);
            this.dgvestudiantes.TabIndex = 2;
            this.dgvestudiantes.DoubleClick += new System.EventHandler(this.dvglistado);
            // 
            // btningresarE
            // 
            this.btningresarE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btningresarE.Location = new System.Drawing.Point(621, 22);
            this.btningresarE.Name = "btningresarE";
            this.btningresarE.Size = new System.Drawing.Size(135, 35);
            this.btningresarE.TabIndex = 3;
            this.btningresarE.Text = "Ingresar";
            this.btningresarE.UseVisualStyleBackColor = false;
            this.btningresarE.Click += new System.EventHandler(this.BtningresarE_Click);
            // 
            // btnactualizarE
            // 
            this.btnactualizarE.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnactualizarE.Location = new System.Drawing.Point(621, 80);
            this.btnactualizarE.Name = "btnactualizarE";
            this.btnactualizarE.Size = new System.Drawing.Size(135, 35);
            this.btnactualizarE.TabIndex = 7;
            this.btnactualizarE.Text = "Actualizar";
            this.btnactualizarE.UseVisualStyleBackColor = false;
            this.btnactualizarE.Click += new System.EventHandler(this.btnactualizarE_Click);
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(768, 472);
            this.Controls.Add(this.btnactualizarE);
            this.Controls.Add(this.btningresarE);
            this.Controls.Add(this.dgvestudiantes);
            this.Controls.Add(this.btnmenuE);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Estudiantes_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvestudiantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnmenuE;
        private System.Windows.Forms.TextBox txtgradoE;
        private System.Windows.Forms.TextBox txtapellidoE;
        private System.Windows.Forms.TextBox txtnombreE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvestudiantes;
        private System.Windows.Forms.Button btningresarE;
        private System.Windows.Forms.Button btnactualizarE;
        private System.Windows.Forms.TextBox txtidE;
        private System.Windows.Forms.Label label4;
    }
}