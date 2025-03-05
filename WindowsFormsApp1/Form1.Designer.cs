namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btSoma = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOpr = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.numOpr1 = new System.Windows.Forms.NumericUpDown();
            this.numOpr2 = new System.Windows.Forms.NumericUpDown();
            this.btLimpa = new System.Windows.Forms.Button();
            this.btSegue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpr2)).BeginInit();
            this.SuspendLayout();
            // 
            // btSoma
            // 
            this.btSoma.BackColor = System.Drawing.Color.Silver;
            this.btSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btSoma.ForeColor = System.Drawing.Color.Red;
            this.btSoma.Location = new System.Drawing.Point(35, 154);
            this.btSoma.Name = "btSoma";
            this.btSoma.Size = new System.Drawing.Size(43, 39);
            this.btSoma.TabIndex = 0;
            this.btSoma.Text = "+";
            this.btSoma.UseVisualStyleBackColor = false;
            this.btSoma.Click += new System.EventHandler(this.btSoma_Click);
            // 
            // btSub
            // 
            this.btSub.BackColor = System.Drawing.Color.Silver;
            this.btSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btSub.ForeColor = System.Drawing.Color.Red;
            this.btSub.Location = new System.Drawing.Point(84, 154);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(43, 39);
            this.btSub.TabIndex = 1;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = false;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.BackColor = System.Drawing.Color.Silver;
            this.btMult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btMult.ForeColor = System.Drawing.Color.Red;
            this.btMult.Location = new System.Drawing.Point(133, 154);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(43, 39);
            this.btMult.TabIndex = 2;
            this.btMult.Text = "X";
            this.btMult.UseVisualStyleBackColor = false;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.BackColor = System.Drawing.Color.Silver;
            this.btDiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btDiv.ForeColor = System.Drawing.Color.Red;
            this.btDiv.Location = new System.Drawing.Point(182, 154);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(43, 39);
            this.btDiv.TabIndex = 3;
            this.btDiv.Text = "÷";
            this.btDiv.UseVisualStyleBackColor = false;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // btIgual
            // 
            this.btIgual.BackColor = System.Drawing.Color.Silver;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btIgual.ForeColor = System.Drawing.Color.Red;
            this.btIgual.Location = new System.Drawing.Point(182, 263);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(120, 39);
            this.btIgual.TabIndex = 4;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = false;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(31, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operando 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(31, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operando2";
            // 
            // lblOpr
            // 
            this.lblOpr.AutoSize = true;
            this.lblOpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblOpr.ForeColor = System.Drawing.Color.Red;
            this.lblOpr.Location = new System.Drawing.Point(253, 163);
            this.lblOpr.Name = "lblOpr";
            this.lblOpr.Size = new System.Drawing.Size(33, 26);
            this.lblOpr.TabIndex = 7;
            this.lblOpr.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(31, 320);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(271, 53);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "...";
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numOpr1
            // 
            this.numOpr1.BackColor = System.Drawing.Color.Silver;
            this.numOpr1.DecimalPlaces = 2;
            this.numOpr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.numOpr1.ForeColor = System.Drawing.Color.Red;
            this.numOpr1.Location = new System.Drawing.Point(182, 108);
            this.numOpr1.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numOpr1.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.numOpr1.Name = "numOpr1";
            this.numOpr1.Size = new System.Drawing.Size(120, 26);
            this.numOpr1.TabIndex = 9;
            this.numOpr1.ValueChanged += new System.EventHandler(this.numOpr1_ValueChanged);
            // 
            // numOpr2
            // 
            this.numOpr2.BackColor = System.Drawing.Color.Silver;
            this.numOpr2.DecimalPlaces = 2;
            this.numOpr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.numOpr2.ForeColor = System.Drawing.Color.Red;
            this.numOpr2.Location = new System.Drawing.Point(182, 212);
            this.numOpr2.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numOpr2.Minimum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            -2147483648});
            this.numOpr2.Name = "numOpr2";
            this.numOpr2.Size = new System.Drawing.Size(120, 26);
            this.numOpr2.TabIndex = 10;
            this.numOpr2.ValueChanged += new System.EventHandler(this.numOpr2_ValueChanged);
            // 
            // btLimpa
            // 
            this.btLimpa.BackColor = System.Drawing.Color.Silver;
            this.btLimpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btLimpa.ForeColor = System.Drawing.Color.Red;
            this.btLimpa.Location = new System.Drawing.Point(332, 154);
            this.btLimpa.Name = "btLimpa";
            this.btLimpa.Size = new System.Drawing.Size(96, 39);
            this.btLimpa.TabIndex = 11;
            this.btLimpa.Text = "Limpa";
            this.btLimpa.UseVisualStyleBackColor = false;
            this.btLimpa.Click += new System.EventHandler(this.btLimpa_Click);
            // 
            // btSegue
            // 
            this.btSegue.BackColor = System.Drawing.Color.Silver;
            this.btSegue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.btSegue.ForeColor = System.Drawing.Color.Red;
            this.btSegue.Location = new System.Drawing.Point(332, 263);
            this.btSegue.Name = "btSegue";
            this.btSegue.Size = new System.Drawing.Size(96, 39);
            this.btSegue.TabIndex = 12;
            this.btSegue.Text = "Segue";
            this.btSegue.UseVisualStyleBackColor = false;
            this.btSegue.Click += new System.EventHandler(this.btSegue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Olive;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(30, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(365, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Kratos Kalculadora resenha 1453";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(466, 416);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSegue);
            this.Controls.Add(this.btLimpa);
            this.Controls.Add(this.numOpr2);
            this.Controls.Add(this.numOpr1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblOpr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btSoma);
            this.Name = "Form1";
            this.Text = "Kratos Kalculadora resenha 1453";
            ((System.ComponentModel.ISupportInitialize)(this.numOpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpr2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSoma;
        private System.Windows.Forms.Button btSub;
        private System.Windows.Forms.Button btMult;
        private System.Windows.Forms.Button btDiv;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOpr;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.NumericUpDown numOpr1;
        private System.Windows.Forms.NumericUpDown numOpr2;
        private System.Windows.Forms.Button btLimpa;
        private System.Windows.Forms.Button btSegue;
        private System.Windows.Forms.Label label3;
    }
}

