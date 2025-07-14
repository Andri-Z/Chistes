namespace Chistes
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            btnChistesMalos = new Button();
            btnChistesPapa = new Button();
            btnChistesTecnologia = new Button();
            btnChistesAnimales = new Button();
            btnChistesCortos = new Button();
            SuspendLayout();
            // 
            // btnChistesMalos
            // 
            btnChistesMalos.Anchor = AnchorStyles.None;
            btnChistesMalos.BackColor = Color.Gray;
            btnChistesMalos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChistesMalos.ForeColor = Color.White;
            btnChistesMalos.Location = new Point(66, 21);
            btnChistesMalos.Name = "btnChistesMalos";
            btnChistesMalos.Size = new Size(170, 35);
            btnChistesMalos.TabIndex = 0;
            btnChistesMalos.Text = "Chistes Malos";
            btnChistesMalos.UseVisualStyleBackColor = false;
            btnChistesMalos.Click += btnChistesMalos_Click;
            // 
            // btnChistesPapa
            // 
            btnChistesPapa.Anchor = AnchorStyles.None;
            btnChistesPapa.BackColor = Color.Gray;
            btnChistesPapa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChistesPapa.ForeColor = Color.White;
            btnChistesPapa.Location = new Point(66, 62);
            btnChistesPapa.Name = "btnChistesPapa";
            btnChistesPapa.Size = new Size(170, 35);
            btnChistesPapa.TabIndex = 1;
            btnChistesPapa.Text = "Chistes de Papa";
            btnChistesPapa.UseVisualStyleBackColor = false;
            btnChistesPapa.Click += btnChistesPapa_Click;
            // 
            // btnChistesTecnologia
            // 
            btnChistesTecnologia.Anchor = AnchorStyles.None;
            btnChistesTecnologia.BackColor = Color.Gray;
            btnChistesTecnologia.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChistesTecnologia.ForeColor = Color.White;
            btnChistesTecnologia.Location = new Point(66, 103);
            btnChistesTecnologia.Name = "btnChistesTecnologia";
            btnChistesTecnologia.Size = new Size(170, 35);
            btnChistesTecnologia.TabIndex = 2;
            btnChistesTecnologia.Text = "Chistes de Tecnologia";
            btnChistesTecnologia.UseVisualStyleBackColor = false;
            btnChistesTecnologia.Click += btnChistesTecnologia_Click;
            // 
            // btnChistesAnimales
            // 
            btnChistesAnimales.Anchor = AnchorStyles.None;
            btnChistesAnimales.BackColor = Color.Gray;
            btnChistesAnimales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChistesAnimales.ForeColor = Color.White;
            btnChistesAnimales.Location = new Point(66, 144);
            btnChistesAnimales.Name = "btnChistesAnimales";
            btnChistesAnimales.Size = new Size(170, 35);
            btnChistesAnimales.TabIndex = 3;
            btnChistesAnimales.Text = "Chistes de Animales";
            btnChistesAnimales.UseVisualStyleBackColor = false;
            btnChistesAnimales.Click += btnChistesAnimales_Click;
            // 
            // btnChistesCortos
            // 
            btnChistesCortos.Anchor = AnchorStyles.None;
            btnChistesCortos.BackColor = Color.Gray;
            btnChistesCortos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChistesCortos.ForeColor = Color.White;
            btnChistesCortos.Location = new Point(66, 185);
            btnChistesCortos.Name = "btnChistesCortos";
            btnChistesCortos.Size = new Size(170, 35);
            btnChistesCortos.TabIndex = 4;
            btnChistesCortos.Text = "Chistes Cortos";
            btnChistesCortos.UseVisualStyleBackColor = false;
            btnChistesCortos.Click += btnChistesCortos_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(294, 246);
            Controls.Add(btnChistesCortos);
            Controls.Add(btnChistesAnimales);
            Controls.Add(btnChistesTecnologia);
            Controls.Add(btnChistesPapa);
            Controls.Add(btnChistesMalos);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new Size(270, 173);
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chistes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnChistesMalos;
        private Button btnChistesPapa;
        private Button btnChistesTecnologia;
        private Button btnChistesAnimales;
        private Button btnChistesCortos;
    }
}
