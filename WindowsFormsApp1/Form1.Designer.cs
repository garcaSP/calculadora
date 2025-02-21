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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cominJS = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOpr1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cominJS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btSoma
            // 
            this.btSoma.BackColor = System.Drawing.Color.Silver;
            this.btSoma.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.btSoma.ForeColor = System.Drawing.Color.Red;
            this.btSoma.Location = new System.Drawing.Point(23, 227);
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
            this.btSub.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.btSub.ForeColor = System.Drawing.Color.Red;
            this.btSub.Location = new System.Drawing.Point(72, 227);
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
            this.btMult.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.btMult.ForeColor = System.Drawing.Color.Red;
            this.btMult.Location = new System.Drawing.Point(121, 227);
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
            this.btDiv.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.btDiv.ForeColor = System.Drawing.Color.Red;
            this.btDiv.Location = new System.Drawing.Point(170, 227);
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
            this.btIgual.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.btIgual.ForeColor = System.Drawing.Color.Red;
            this.btIgual.Location = new System.Drawing.Point(170, 336);
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
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 16.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(19, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Operando 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 16.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "Operando2";
            // 
            // lblOpr
            // 
            this.lblOpr.AutoSize = true;
            this.lblOpr.Font = new System.Drawing.Font("Old English Text MT", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblOpr.ForeColor = System.Drawing.Color.Red;
            this.lblOpr.Location = new System.Drawing.Point(241, 236);
            this.lblOpr.Name = "lblOpr";
            this.lblOpr.Size = new System.Drawing.Size(33, 27);
            this.lblOpr.TabIndex = 7;
            this.lblOpr.Text = "...";
            // 
            // lblResultado
            // 
            this.lblResultado.Font = new System.Drawing.Font("Old English Text MT", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblResultado.ForeColor = System.Drawing.Color.Red;
            this.lblResultado.Location = new System.Drawing.Point(19, 393);
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
            this.numOpr1.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.numOpr1.ForeColor = System.Drawing.Color.Red;
            this.numOpr1.Location = new System.Drawing.Point(170, 181);
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
            this.numOpr1.Size = new System.Drawing.Size(120, 27);
            this.numOpr1.TabIndex = 9;
            this.numOpr1.ValueChanged += new System.EventHandler(this.numOpr1_ValueChanged);
            // 
            // numOpr2
            // 
            this.numOpr2.BackColor = System.Drawing.Color.Silver;
            this.numOpr2.DecimalPlaces = 2;
            this.numOpr2.Font = new System.Drawing.Font("Old English Text MT", 12.25F, System.Drawing.FontStyle.Bold);
            this.numOpr2.ForeColor = System.Drawing.Color.Red;
            this.numOpr2.Location = new System.Drawing.Point(170, 285);
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
            this.numOpr2.Size = new System.Drawing.Size(120, 27);
            this.numOpr2.TabIndex = 10;
            this.numOpr2.ValueChanged += new System.EventHandler(this.numOpr2_ValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(394, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(444, 510);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-3, 503);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(841, 460);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(719, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1129, 860);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Captura_de_tela_2025_02_20_110221;
            this.pictureBox4.Location = new System.Drawing.Point(-1, -8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(397, 167);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kratos Kalculadora";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cominJS
            // 
            this.cominJS.Image = ((System.Drawing.Image)(resources.GetObject("cominJS.Image")));
            this.cominJS.Location = new System.Drawing.Point(-99, 471);
            this.cominJS.Name = "cominJS";
            this.cominJS.Size = new System.Drawing.Size(628, 509);
            this.cominJS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cominJS.TabIndex = 16;
            this.cominJS.TabStop = false;
            this.cominJS.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(296, 191);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 274);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(14, 324);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(129, 83);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(-1, -8);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(397, 167);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 19;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(395, 499);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cominJS);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
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
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "Kratos Kalculadora resenha 1453";
            ((System.ComponentModel.ISupportInitialize)(this.numOpr1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOpr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cominJS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox cominJS;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

