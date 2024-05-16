namespace CrediTecTA
{
    partial class Catalogo
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
            this.BtnEventosAcad = new System.Windows.Forms.Button();
            this.BtnProyectos = new System.Windows.Forms.Button();
            this.BtnTutorias = new System.Windows.Forms.Button();
            this.BtnAsesorias1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnAsesorias2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnEventosAcad
            // 
            this.BtnEventosAcad.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEventosAcad.Location = new System.Drawing.Point(343, 65);
            this.BtnEventosAcad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnEventosAcad.Name = "BtnEventosAcad";
            this.BtnEventosAcad.Size = new System.Drawing.Size(221, 62);
            this.BtnEventosAcad.TabIndex = 13;
            this.BtnEventosAcad.Text = "Eventos academicos\r\nparticipación en los diversos eventos \r\nAcadémicos 1 credito " +
    "20 Hrs\r\n";
            this.BtnEventosAcad.UseVisualStyleBackColor = true;
            this.BtnEventosAcad.Click += new System.EventHandler(this.BtnEventosAcad_Click);
            // 
            // BtnProyectos
            // 
            this.BtnProyectos.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProyectos.Location = new System.Drawing.Point(343, 132);
            this.BtnProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnProyectos.Name = "BtnProyectos";
            this.BtnProyectos.Size = new System.Drawing.Size(221, 87);
            this.BtnProyectos.TabIndex = 12;
            this.BtnProyectos.Text = "Proyectos de Investigacion\r\nparticipar como apoyo en un \r\nproyecto de investigaci" +
    "ón \r\ncientífica, tecnológica y / o educativa.\r\n2 Creditos 40 Hrs";
            this.BtnProyectos.UseVisualStyleBackColor = true;
            this.BtnProyectos.Click += new System.EventHandler(this.BtnProyectos_Click);
            // 
            // BtnTutorias
            // 
            this.BtnTutorias.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTutorias.Location = new System.Drawing.Point(48, 227);
            this.BtnTutorias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnTutorias.Name = "BtnTutorias";
            this.BtnTutorias.Size = new System.Drawing.Size(170, 79);
            this.BtnTutorias.TabIndex = 11;
            this.BtnTutorias.Text = "Tutorias\r\nAsistir a la tutoría que imparta \r\nel docente tutor cumpliendo \r\nun mín" +
    "imo de 16 sesiones y 6 \r\nconferencias.  2 Creditos 40 Hrs";
            this.BtnTutorias.UseVisualStyleBackColor = true;
            this.BtnTutorias.Click += new System.EventHandler(this.BtnTutorias_Click);
            // 
            // BtnAsesorias1
            // 
            this.BtnAsesorias1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsesorias1.Location = new System.Drawing.Point(48, 65);
            this.BtnAsesorias1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAsesorias1.Name = "BtnAsesorias1";
            this.BtnAsesorias1.Size = new System.Drawing.Size(170, 62);
            this.BtnAsesorias1.TabIndex = 10;
            this.BtnAsesorias1.Text = "Asesorias\r\nRecibir Asesoría académica\r\n1 credito 20 Hrs";
            this.BtnAsesorias1.UseVisualStyleBackColor = true;
            this.BtnAsesorias1.Click += new System.EventHandler(this.BtnAsesorias1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 49);
            this.panel1.TabIndex = 9;
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
            this.BtnCerrar.Location = new System.Drawing.Point(568, 7);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 32);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::CrediTecTA.Properties.Resources.catalogo_alternativo;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 2);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 41);
            this.button1.TabIndex = 2;
            this.button1.Text = "Catalogo de Actividades";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnAsesorias2
            // 
            this.BtnAsesorias2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAsesorias2.Location = new System.Drawing.Point(48, 145);
            this.BtnAsesorias2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAsesorias2.Name = "BtnAsesorias2";
            this.BtnAsesorias2.Size = new System.Drawing.Size(170, 62);
            this.BtnAsesorias2.TabIndex = 14;
            this.BtnAsesorias2.Text = "Asesorias\r\nImpartir Asesoría académica\r\n2 creditos 40 Hrs";
            this.BtnAsesorias2.UseVisualStyleBackColor = true;
            this.BtnAsesorias2.Click += new System.EventHandler(this.BtnAsesorias2_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(456, 312);
            this.button7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(108, 32);
            this.button7.TabIndex = 15;
            this.button7.Text = "siguiente";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.BtnAsesorias2);
            this.Controls.Add(this.BtnEventosAcad);
            this.Controls.Add(this.BtnProyectos);
            this.Controls.Add(this.BtnTutorias);
            this.Controls.Add(this.BtnAsesorias1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(254, 40);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Catalogo";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnEventosAcad;
        private System.Windows.Forms.Button BtnProyectos;
        private System.Windows.Forms.Button BtnTutorias;
        private System.Windows.Forms.Button BtnAsesorias1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnAsesorias2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button BtnCerrar;
    }
}