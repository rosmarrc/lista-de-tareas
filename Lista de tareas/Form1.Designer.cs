namespace Lista_de_tareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Agregarbtn = new System.Windows.Forms.Button();
            this.Completarbtn = new System.Windows.Forms.Button();
            this.Eliminarbtn = new System.Windows.Forms.Button();
            this.CambiarTamañoLetraBtn = new System.Windows.Forms.Button();
            this.CambiarColorFondoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Tareas";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(72, 146);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(332, 193);
            this.listBox1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(72, 106);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 28);
            this.textBox1.TabIndex = 2;
            // 
            // Agregarbtn
            // 
            this.Agregarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Agregarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Agregarbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Agregarbtn.Location = new System.Drawing.Point(438, 106);
            this.Agregarbtn.Name = "Agregarbtn";
            this.Agregarbtn.Size = new System.Drawing.Size(110, 38);
            this.Agregarbtn.TabIndex = 3;
            this.Agregarbtn.Text = "Agregar";
            this.Agregarbtn.UseVisualStyleBackColor = false;
            this.Agregarbtn.Click += new System.EventHandler(this.Agregarbtn_Click);
            // 
            // Completarbtn
            // 
            this.Completarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Completarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Completarbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Completarbtn.Location = new System.Drawing.Point(438, 150);
            this.Completarbtn.Name = "Completarbtn";
            this.Completarbtn.Size = new System.Drawing.Size(110, 38);
            this.Completarbtn.TabIndex = 4;
            this.Completarbtn.Text = "Completar";
            this.Completarbtn.UseVisualStyleBackColor = false;
            this.Completarbtn.Click += new System.EventHandler(this.Completarbtn_Click);
            // 
            // Eliminarbtn
            // 
            this.Eliminarbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Eliminarbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminarbtn.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbtn.Location = new System.Drawing.Point(438, 194);
            this.Eliminarbtn.Name = "Eliminarbtn";
            this.Eliminarbtn.Size = new System.Drawing.Size(110, 38);
            this.Eliminarbtn.TabIndex = 5;
            this.Eliminarbtn.Text = "Eliminar";
            this.Eliminarbtn.UseVisualStyleBackColor = false;
            this.Eliminarbtn.Click += new System.EventHandler(this.Eliminarbtn_Click);
            // 
            // CambiarTamañoLetraBtn
            // 
            this.CambiarTamañoLetraBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CambiarTamañoLetraBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambiarTamañoLetraBtn.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarTamañoLetraBtn.Location = new System.Drawing.Point(229, 345);
            this.CambiarTamañoLetraBtn.Name = "CambiarTamañoLetraBtn";
            this.CambiarTamañoLetraBtn.Size = new System.Drawing.Size(161, 38);
            this.CambiarTamañoLetraBtn.TabIndex = 6;
            this.CambiarTamañoLetraBtn.Text = "Tamaño de letra";
            this.CambiarTamañoLetraBtn.UseVisualStyleBackColor = false;
            this.CambiarTamañoLetraBtn.Click += new System.EventHandler(this.CambiarTamañoLetraBtn_Click_1);
            // 
            // CambiarColorFondoBtn
            // 
            this.CambiarColorFondoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CambiarColorFondoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CambiarColorFondoBtn.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CambiarColorFondoBtn.Location = new System.Drawing.Point(82, 345);
            this.CambiarColorFondoBtn.Name = "CambiarColorFondoBtn";
            this.CambiarColorFondoBtn.Size = new System.Drawing.Size(141, 38);
            this.CambiarColorFondoBtn.TabIndex = 7;
            this.CambiarColorFondoBtn.Text = "Color de fondo";
            this.CambiarColorFondoBtn.UseVisualStyleBackColor = false;
            this.CambiarColorFondoBtn.Click += new System.EventHandler(this.CambiarColorFondoBtn_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CambiarColorFondoBtn);
            this.Controls.Add(this.CambiarTamañoLetraBtn);
            this.Controls.Add(this.Eliminarbtn);
            this.Controls.Add(this.Completarbtn);
            this.Controls.Add(this.Agregarbtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Agregarbtn;
        private System.Windows.Forms.Button Completarbtn;
        private System.Windows.Forms.Button Eliminarbtn;
        private System.Windows.Forms.Button CambiarTamañoLetraBtn;
        private System.Windows.Forms.Button CambiarColorFondoBtn;
    }
}

