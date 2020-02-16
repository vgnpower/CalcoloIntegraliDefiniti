namespace CalcoloIntegraliDefiniti
{
    partial class FrmPrincipale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Solve = new System.Windows.Forms.Button();
            this.rdBtn_Rect = new System.Windows.Forms.RadioButton();
            this.rdBtn_Trap = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numUpDwn_n = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBx_eq = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBx_ris = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBx_b = new System.Windows.Forms.TextBox();
            this.txtBx_a = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_n)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(155, 75);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(75, 31);
            this.btn_Solve.TabIndex = 2;
            this.btn_Solve.Text = "Calcola";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // rdBtn_Rect
            // 
            this.rdBtn_Rect.AutoSize = true;
            this.rdBtn_Rect.Location = new System.Drawing.Point(6, 19);
            this.rdBtn_Rect.Name = "rdBtn_Rect";
            this.rdBtn_Rect.Size = new System.Drawing.Size(77, 17);
            this.rdBtn_Rect.TabIndex = 3;
            this.rdBtn_Rect.TabStop = true;
            this.rdBtn_Rect.Text = "Rettangolo";
            this.rdBtn_Rect.UseVisualStyleBackColor = true;
            this.rdBtn_Rect.CheckedChanged += new System.EventHandler(this.rdBtn_Rect_CheckedChanged);
            // 
            // rdBtn_Trap
            // 
            this.rdBtn_Trap.AutoSize = true;
            this.rdBtn_Trap.Location = new System.Drawing.Point(118, 19);
            this.rdBtn_Trap.Name = "rdBtn_Trap";
            this.rdBtn_Trap.Size = new System.Drawing.Size(66, 17);
            this.rdBtn_Trap.TabIndex = 4;
            this.rdBtn_Trap.TabStop = true;
            this.rdBtn_Trap.Text = "Trapezio";
            this.rdBtn_Trap.UseVisualStyleBackColor = true;
            this.rdBtn_Trap.CheckedChanged += new System.EventHandler(this.rdBtn_Trap_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.rdBtn_Rect);
            this.groupBox1.Controls.Add(this.rdBtn_Trap);
            this.groupBox1.Location = new System.Drawing.Point(4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 50);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo di calcolo";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.numUpDwn_n);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBx_eq);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBx_ris);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Solve);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtBx_b);
            this.groupBox2.Controls.Add(this.txtBx_a);
            this.groupBox2.Location = new System.Drawing.Point(4, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 117);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calcolo";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // numUpDwn_n
            // 
            this.numUpDwn_n.Location = new System.Drawing.Point(124, 47);
            this.numUpDwn_n.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.numUpDwn_n.Name = "numUpDwn_n";
            this.numUpDwn_n.Size = new System.Drawing.Size(106, 20);
            this.numUpDwn_n.TabIndex = 17;
            this.numUpDwn_n.ThousandsSeparator = true;
            this.numUpDwn_n.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Equazione:";
            // 
            // txtBx_eq
            // 
            this.txtBx_eq.Location = new System.Drawing.Point(76, 20);
            this.txtBx_eq.Name = "txtBx_eq";
            this.txtBx_eq.Size = new System.Drawing.Size(154, 20);
            this.txtBx_eq.TabIndex = 15;
            this.txtBx_eq.Text = "sqrt(1+x)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "n:";
            // 
            // txtBx_ris
            // 
            this.txtBx_ris.Location = new System.Drawing.Point(8, 73);
            this.txtBx_ris.Multiline = true;
            this.txtBx_ris.Name = "txtBx_ris";
            this.txtBx_ris.ReadOnly = true;
            this.txtBx_ris.Size = new System.Drawing.Size(146, 35);
            this.txtBx_ris.TabIndex = 14;
            this.txtBx_ris.Text = "risultato";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "A:";
            // 
            // txtBx_b
            // 
            this.txtBx_b.Location = new System.Drawing.Point(78, 47);
            this.txtBx_b.Name = "txtBx_b";
            this.txtBx_b.Size = new System.Drawing.Size(18, 20);
            this.txtBx_b.TabIndex = 8;
            this.txtBx_b.Text = "2";
            // 
            // txtBx_a
            // 
            this.txtBx_a.Location = new System.Drawing.Point(30, 47);
            this.txtBx_a.Name = "txtBx_a";
            this.txtBx_a.Size = new System.Drawing.Size(18, 20);
            this.txtBx_a.TabIndex = 7;
            this.txtBx_a.Text = "0";
            // 
            // FrmPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 181);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmPrincipale";
            this.ShowIcon = false;
            this.Text = "Integrazione numerica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_n)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.RadioButton rdBtn_Rect;
        private System.Windows.Forms.RadioButton rdBtn_Trap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBx_ris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBx_b;
        private System.Windows.Forms.TextBox txtBx_a;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBx_eq;
        private System.Windows.Forms.NumericUpDown numUpDwn_n;
    }
}

