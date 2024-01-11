namespace UpdateTrucks
{
    partial class TrucksUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrucksUpdate));
            this.pbEstatus = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubirCambios = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxOrigen = new System.Windows.Forms.TextBox();
            this.explorer = new System.Windows.Forms.Button();
            this.txtboxVersion = new System.Windows.Forms.TextBox();
            this.VersionTrucks = new System.Windows.Forms.Label();
            this.txtboxVersionFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbEstatus
            // 
            this.pbEstatus.Location = new System.Drawing.Point(16, 207);
            this.pbEstatus.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbEstatus.Name = "pbEstatus";
            this.pbEstatus.Size = new System.Drawing.Size(335, 28);
            this.pbEstatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estatus archivos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 94);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(333, 22);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Direcctorio Destino";
            // 
            // btnSubirCambios
            // 
            this.btnSubirCambios.Location = new System.Drawing.Point(16, 243);
            this.btnSubirCambios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubirCambios.Name = "btnSubirCambios";
            this.btnSubirCambios.Size = new System.Drawing.Size(335, 33);
            this.btnSubirCambios.TabIndex = 4;
            this.btnSubirCambios.Text = "Actualizar";
            this.btnSubirCambios.UseVisualStyleBackColor = true;
            this.btnSubirCambios.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Direcctorio Origen";
            // 
            // txtboxOrigen
            // 
            this.txtboxOrigen.Location = new System.Drawing.Point(13, 33);
            this.txtboxOrigen.Margin = new System.Windows.Forms.Padding(4);
            this.txtboxOrigen.Name = "txtboxOrigen";
            this.txtboxOrigen.Size = new System.Drawing.Size(253, 22);
            this.txtboxOrigen.TabIndex = 5;
            // 
            // explorer
            // 
            this.explorer.Location = new System.Drawing.Point(273, 32);
            this.explorer.Name = "explorer";
            this.explorer.Size = new System.Drawing.Size(73, 23);
            this.explorer.TabIndex = 7;
            this.explorer.Text = "FilePath";
            this.explorer.UseVisualStyleBackColor = true;
            this.explorer.Click += new System.EventHandler(this.explorer_Click);
            // 
            // txtboxVersion
            // 
            this.txtboxVersion.Location = new System.Drawing.Point(123, 136);
            this.txtboxVersion.Name = "txtboxVersion";
            this.txtboxVersion.Size = new System.Drawing.Size(69, 22);
            this.txtboxVersion.TabIndex = 8;
            // 
            // VersionTrucks
            // 
            this.VersionTrucks.AutoSize = true;
            this.VersionTrucks.Location = new System.Drawing.Point(13, 139);
            this.VersionTrucks.Name = "VersionTrucks";
            this.VersionTrucks.Size = new System.Drawing.Size(97, 16);
            this.VersionTrucks.TabIndex = 9;
            this.VersionTrucks.Text = "Trucks Version";
            // 
            // txtboxVersionFinal
            // 
            this.txtboxVersionFinal.Location = new System.Drawing.Point(215, 136);
            this.txtboxVersionFinal.Name = "txtboxVersionFinal";
            this.txtboxVersionFinal.Size = new System.Drawing.Size(69, 22);
            this.txtboxVersionFinal.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "-";
            // 
            // TrucksUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 289);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtboxVersionFinal);
            this.Controls.Add(this.VersionTrucks);
            this.Controls.Add(this.txtboxVersion);
            this.Controls.Add(this.explorer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxOrigen);
            this.Controls.Add(this.btnSubirCambios);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEstatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TrucksUpdate";
            this.Text = "Trucks Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbEstatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubirCambios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxOrigen;
        private System.Windows.Forms.Button explorer;
        private System.Windows.Forms.TextBox txtboxVersion;
        private System.Windows.Forms.Label VersionTrucks;
        private System.Windows.Forms.TextBox txtboxVersionFinal;
        private System.Windows.Forms.Label label4;
    }
}

