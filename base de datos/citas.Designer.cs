namespace base_de_datos
{
    partial class citas
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxcitas_tser = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxid_pac_citas = new System.Windows.Forms.TextBox();
            this.comboBoxcitadocrdisp = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBoxcitadocrdisp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxcitas_tser);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxid_pac_citas);
            this.groupBox1.Location = new System.Drawing.Point(93, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agrega citas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "tipo de servicio";
            // 
            // comboBoxcitas_tser
            // 
            this.comboBoxcitas_tser.FormattingEnabled = true;
            this.comboBoxcitas_tser.Location = new System.Drawing.Point(40, 78);
            this.comboBoxcitas_tser.Name = "comboBoxcitas_tser";
            this.comboBoxcitas_tser.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcitas_tser.TabIndex = 11;
            this.comboBoxcitas_tser.SelectedIndexChanged += new System.EventHandler(this.comboBoxcitas_tser_SelectedIndexChanged);
            this.comboBoxcitas_tser.SelectionChangeCommitted += new System.EventHandler(this.comboBoxcitas_tser_SelectionChangeCommitted);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::base_de_datos.Properties.Resources.icons8_de_acuerdo_96;
            this.pictureBox1.Location = new System.Drawing.Point(88, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "id_paciente";
            // 
            // textBoxid_pac_citas
            // 
            this.textBoxid_pac_citas.Location = new System.Drawing.Point(40, 33);
            this.textBoxid_pac_citas.Name = "textBoxid_pac_citas";
            this.textBoxid_pac_citas.Size = new System.Drawing.Size(100, 20);
            this.textBoxid_pac_citas.TabIndex = 1;
            // 
            // comboBoxcitadocrdisp
            // 
            this.comboBoxcitadocrdisp.FormattingEnabled = true;
            this.comboBoxcitadocrdisp.Location = new System.Drawing.Point(40, 119);
            this.comboBoxcitadocrdisp.Name = "comboBoxcitadocrdisp";
            this.comboBoxcitadocrdisp.Size = new System.Drawing.Size(121, 21);
            this.comboBoxcitadocrdisp.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Doctor disponible";
            // 
            // citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 433);
            this.Controls.Add(this.groupBox1);
            this.Name = "citas";
            this.Text = "citas";
            this.Load += new System.EventHandler(this.citas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxid_pac_citas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxcitas_tser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxcitadocrdisp;
    }
}