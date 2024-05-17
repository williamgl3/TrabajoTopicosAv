namespace CrediTecTA
{
    partial class Actividades
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVerCred = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.BtnVerCred);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 75);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnVerCred
            // 
            this.BtnVerCred.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVerCred.Location = new System.Drawing.Point(576, 21);
            this.BtnVerCred.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnVerCred.Name = "BtnVerCred";
            this.BtnVerCred.Size = new System.Drawing.Size(173, 44);
            this.BtnVerCred.TabIndex = 21;
            this.BtnVerCred.Text = "Ver Creditos";
            this.BtnVerCred.UseVisualStyleBackColor = true;
            this.BtnVerCred.Click += new System.EventHandler(this.BtnVerCred_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Image = global::CrediTecTA.Properties.Resources.Icono_cerrar_FN;
            this.BtnCerrar.Location = new System.Drawing.Point(852, 15);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(45, 50);
            this.BtnCerrar.TabIndex = 12;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(14, 21);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 44);
            this.button1.TabIndex = 20;
            this.button1.Text = "Catalogo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 111);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡REGISTRO EXITOSO!\r\nSE HA REGISTRADO TU ACTIVIDAD COMPLEMENTARIA\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(760, 480);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 44);
            this.button2.TabIndex = 21;
            this.button2.Text = "salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Actividades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(254, 40);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Actividades";
            this.Text = "Form6";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnVerCred;
    }
}