namespace EstacaoTrem
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
            this.gpbControle = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblVel2 = new System.Windows.Forms.Label();
            this.btnFarol2 = new System.Windows.Forms.Button();
            this.btnParar2 = new System.Windows.Forms.Button();
            this.vel2 = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnBuzina1 = new System.Windows.Forms.Button();
            this.lblVel1 = new System.Windows.Forms.Label();
            this.btnFarol1 = new System.Windows.Forms.Button();
            this.btnParar1 = new System.Windows.Forms.Button();
            this.vel1 = new System.Windows.Forms.TrackBar();
            this.gpbGuindaste = new System.Windows.Forms.GroupBox();
            this.gpbDesvio = new System.Windows.Forms.GroupBox();
            this.chk2A = new System.Windows.Forms.CheckBox();
            this.chk2B = new System.Windows.Forms.CheckBox();
            this.chk3B = new System.Windows.Forms.CheckBox();
            this.chk3A = new System.Windows.Forms.CheckBox();
            this.chk4B = new System.Windows.Forms.CheckBox();
            this.chk4A = new System.Windows.Forms.CheckBox();
            this.chk1A = new System.Windows.Forms.CheckBox();
            this.chk1B = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.gpbControle.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vel2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vel1)).BeginInit();
            this.gpbDesvio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbControle
            // 
            this.gpbControle.Controls.Add(this.groupBox2);
            this.gpbControle.Controls.Add(this.groupBox5);
            this.gpbControle.Enabled = false;
            this.gpbControle.Location = new System.Drawing.Point(12, 12);
            this.gpbControle.Name = "gpbControle";
            this.gpbControle.Size = new System.Drawing.Size(272, 627);
            this.gpbControle.TabIndex = 0;
            this.gpbControle.TabStop = false;
            this.gpbControle.Text = "Controle Trem";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblVel2);
            this.groupBox2.Controls.Add(this.btnFarol2);
            this.groupBox2.Controls.Add(this.btnParar2);
            this.groupBox2.Controls.Add(this.vel2);
            this.groupBox2.Location = new System.Drawing.Point(19, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(235, 295);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            // 
            // lblVel2
            // 
            this.lblVel2.AutoSize = true;
            this.lblVel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVel2.Location = new System.Drawing.Point(118, 228);
            this.lblVel2.Name = "lblVel2";
            this.lblVel2.Size = new System.Drawing.Size(37, 24);
            this.lblVel2.TabIndex = 4;
            this.lblVel2.Text = "0%";
            // 
            // btnFarol2
            // 
            this.btnFarol2.BackColor = System.Drawing.Color.Yellow;
            this.btnFarol2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarol2.Location = new System.Drawing.Point(85, 26);
            this.btnFarol2.Name = "btnFarol2";
            this.btnFarol2.Size = new System.Drawing.Size(112, 40);
            this.btnFarol2.TabIndex = 3;
            this.btnFarol2.Text = "FAROL";
            this.btnFarol2.UseVisualStyleBackColor = false;
            this.btnFarol2.Click += new System.EventHandler(this.btnFarol2_Click);
            // 
            // btnParar2
            // 
            this.btnParar2.BackColor = System.Drawing.Color.Red;
            this.btnParar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar2.Location = new System.Drawing.Point(85, 144);
            this.btnParar2.Name = "btnParar2";
            this.btnParar2.Size = new System.Drawing.Size(112, 64);
            this.btnParar2.TabIndex = 2;
            this.btnParar2.Text = "PARAR";
            this.btnParar2.UseVisualStyleBackColor = false;
            this.btnParar2.Click += new System.EventHandler(this.btnParar2_Click);
            // 
            // vel2
            // 
            this.vel2.LargeChange = 10;
            this.vel2.Location = new System.Drawing.Point(6, 19);
            this.vel2.Maximum = 100;
            this.vel2.Minimum = -100;
            this.vel2.Name = "vel2";
            this.vel2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vel2.Size = new System.Drawing.Size(45, 270);
            this.vel2.SmallChange = 5;
            this.vel2.TabIndex = 0;
            this.vel2.TickFrequency = 10;
            this.vel2.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vel2.Scroll += new System.EventHandler(this.vel2_Scroll);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnBuzina1);
            this.groupBox5.Controls.Add(this.lblVel1);
            this.groupBox5.Controls.Add(this.btnFarol1);
            this.groupBox5.Controls.Add(this.btnParar1);
            this.groupBox5.Controls.Add(this.vel1);
            this.groupBox5.Location = new System.Drawing.Point(19, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(235, 295);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "1";
            // 
            // btnBuzina1
            // 
            this.btnBuzina1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBuzina1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuzina1.Location = new System.Drawing.Point(85, 65);
            this.btnBuzina1.Name = "btnBuzina1";
            this.btnBuzina1.Size = new System.Drawing.Size(112, 42);
            this.btnBuzina1.TabIndex = 5;
            this.btnBuzina1.Text = "Buzina";
            this.btnBuzina1.UseVisualStyleBackColor = false;
            this.btnBuzina1.Click += new System.EventHandler(this.btnBuzina1_Click);
            // 
            // lblVel1
            // 
            this.lblVel1.AutoSize = true;
            this.lblVel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVel1.Location = new System.Drawing.Point(118, 228);
            this.lblVel1.Name = "lblVel1";
            this.lblVel1.Size = new System.Drawing.Size(37, 24);
            this.lblVel1.TabIndex = 4;
            this.lblVel1.Text = "0%";
            // 
            // btnFarol1
            // 
            this.btnFarol1.BackColor = System.Drawing.Color.Gray;
            this.btnFarol1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarol1.Location = new System.Drawing.Point(85, 19);
            this.btnFarol1.Name = "btnFarol1";
            this.btnFarol1.Size = new System.Drawing.Size(112, 40);
            this.btnFarol1.TabIndex = 3;
            this.btnFarol1.Text = "FAROL";
            this.btnFarol1.UseVisualStyleBackColor = false;
            this.btnFarol1.Click += new System.EventHandler(this.btnFarol1_Click);
            // 
            // btnParar1
            // 
            this.btnParar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnParar1.BackColor = System.Drawing.Color.Red;
            this.btnParar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParar1.Location = new System.Drawing.Point(85, 140);
            this.btnParar1.Name = "btnParar1";
            this.btnParar1.Size = new System.Drawing.Size(112, 64);
            this.btnParar1.TabIndex = 2;
            this.btnParar1.Text = "PARAR";
            this.btnParar1.UseVisualStyleBackColor = false;
            this.btnParar1.Click += new System.EventHandler(this.btnParar1_Click);
            // 
            // vel1
            // 
            this.vel1.LargeChange = 10;
            this.vel1.Location = new System.Drawing.Point(6, 19);
            this.vel1.Maximum = 100;
            this.vel1.Minimum = -100;
            this.vel1.Name = "vel1";
            this.vel1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.vel1.Size = new System.Drawing.Size(45, 270);
            this.vel1.SmallChange = 5;
            this.vel1.TabIndex = 0;
            this.vel1.TickFrequency = 10;
            this.vel1.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.vel1.Scroll += new System.EventHandler(this.vel1_Scroll);
            // 
            // gpbGuindaste
            // 
            this.gpbGuindaste.Enabled = false;
            this.gpbGuindaste.Location = new System.Drawing.Point(704, 259);
            this.gpbGuindaste.Name = "gpbGuindaste";
            this.gpbGuindaste.Size = new System.Drawing.Size(368, 305);
            this.gpbGuindaste.TabIndex = 2;
            this.gpbGuindaste.TabStop = false;
            this.gpbGuindaste.Text = "Guindaste";
            // 
            // gpbDesvio
            // 
            this.gpbDesvio.Controls.Add(this.chk2A);
            this.gpbDesvio.Controls.Add(this.chk2B);
            this.gpbDesvio.Controls.Add(this.chk3B);
            this.gpbDesvio.Controls.Add(this.chk3A);
            this.gpbDesvio.Controls.Add(this.chk4B);
            this.gpbDesvio.Controls.Add(this.chk4A);
            this.gpbDesvio.Controls.Add(this.chk1A);
            this.gpbDesvio.Controls.Add(this.chk1B);
            this.gpbDesvio.Controls.Add(this.pictureBox1);
            this.gpbDesvio.Enabled = false;
            this.gpbDesvio.Location = new System.Drawing.Point(290, 12);
            this.gpbDesvio.Name = "gpbDesvio";
            this.gpbDesvio.Size = new System.Drawing.Size(408, 627);
            this.gpbDesvio.TabIndex = 0;
            this.gpbDesvio.TabStop = false;
            this.gpbDesvio.Text = "Desvios";
            // 
            // chk2A
            // 
            this.chk2A.AutoSize = true;
            this.chk2A.Location = new System.Drawing.Point(368, 209);
            this.chk2A.Name = "chk2A";
            this.chk2A.Size = new System.Drawing.Size(15, 14);
            this.chk2A.TabIndex = 8;
            this.chk2A.UseVisualStyleBackColor = true;
            this.chk2A.CheckedChanged += new System.EventHandler(this.chk2A_CheckedChanged);
            // 
            // chk2B
            // 
            this.chk2B.AutoSize = true;
            this.chk2B.Checked = true;
            this.chk2B.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk2B.Enabled = false;
            this.chk2B.Location = new System.Drawing.Point(332, 209);
            this.chk2B.Name = "chk2B";
            this.chk2B.Size = new System.Drawing.Size(15, 14);
            this.chk2B.TabIndex = 7;
            this.chk2B.UseVisualStyleBackColor = true;
            this.chk2B.CheckedChanged += new System.EventHandler(this.chk2B_CheckedChanged);
            // 
            // chk3B
            // 
            this.chk3B.AutoSize = true;
            this.chk3B.Location = new System.Drawing.Point(216, 277);
            this.chk3B.Name = "chk3B";
            this.chk3B.Size = new System.Drawing.Size(15, 14);
            this.chk3B.TabIndex = 6;
            this.chk3B.UseVisualStyleBackColor = true;
            this.chk3B.CheckedChanged += new System.EventHandler(this.chk3B_CheckedChanged);
            // 
            // chk3A
            // 
            this.chk3A.AutoSize = true;
            this.chk3A.Checked = true;
            this.chk3A.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk3A.Enabled = false;
            this.chk3A.Location = new System.Drawing.Point(263, 277);
            this.chk3A.Name = "chk3A";
            this.chk3A.Size = new System.Drawing.Size(15, 14);
            this.chk3A.TabIndex = 5;
            this.chk3A.UseVisualStyleBackColor = true;
            this.chk3A.CheckedChanged += new System.EventHandler(this.chk3A_CheckedChanged);
            // 
            // chk4B
            // 
            this.chk4B.AutoSize = true;
            this.chk4B.Checked = true;
            this.chk4B.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk4B.Enabled = false;
            this.chk4B.ForeColor = System.Drawing.Color.Black;
            this.chk4B.Location = new System.Drawing.Point(216, 584);
            this.chk4B.Name = "chk4B";
            this.chk4B.Size = new System.Drawing.Size(15, 14);
            this.chk4B.TabIndex = 4;
            this.chk4B.UseVisualStyleBackColor = true;
            this.chk4B.CheckedChanged += new System.EventHandler(this.chk4B_CheckedChanged);
            // 
            // chk4A
            // 
            this.chk4A.AutoSize = true;
            this.chk4A.Location = new System.Drawing.Point(216, 550);
            this.chk4A.Name = "chk4A";
            this.chk4A.Size = new System.Drawing.Size(15, 14);
            this.chk4A.TabIndex = 3;
            this.chk4A.UseVisualStyleBackColor = true;
            this.chk4A.CheckedChanged += new System.EventHandler(this.chk4A_CheckedChanged);
            // 
            // chk1A
            // 
            this.chk1A.AutoSize = true;
            this.chk1A.Checked = true;
            this.chk1A.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk1A.Enabled = false;
            this.chk1A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk1A.Location = new System.Drawing.Point(65, 396);
            this.chk1A.Name = "chk1A";
            this.chk1A.Size = new System.Drawing.Size(15, 14);
            this.chk1A.TabIndex = 2;
            this.chk1A.UseVisualStyleBackColor = true;
            this.chk1A.CheckedChanged += new System.EventHandler(this.chk1A_CheckedChanged);
            // 
            // chk1B
            // 
            this.chk1B.AutoSize = true;
            this.chk1B.Location = new System.Drawing.Point(14, 396);
            this.chk1B.Name = "chk1B";
            this.chk1B.Size = new System.Drawing.Size(15, 14);
            this.chk1B.TabIndex = 1;
            this.chk1B.UseVisualStyleBackColor = true;
            this.chk1B.CheckedChanged += new System.EventHandler(this.chk1B_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 596);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(165, 19);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(133, 38);
            this.btnConectar.TabIndex = 3;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Porta serial:";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(74, 29);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(39, 20);
            this.txtPorta.TabIndex = 5;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnConectar);
            this.groupBox6.Controls.Add(this.txtPorta);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Location = new System.Drawing.Point(704, 570);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(335, 70);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Conexão";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 652);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.gpbGuindaste);
            this.Controls.Add(this.gpbDesvio);
            this.Controls.Add(this.gpbControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle DCC";
            this.gpbControle.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vel2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vel1)).EndInit();
            this.gpbDesvio.ResumeLayout(false);
            this.gpbDesvio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbControle;
        private System.Windows.Forms.GroupBox gpbGuindaste;
        private System.Windows.Forms.GroupBox gpbDesvio;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar vel1;
        private System.Windows.Forms.Button btnFarol1;
        private System.Windows.Forms.Button btnParar1;
        private System.Windows.Forms.Label lblVel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVel2;
        private System.Windows.Forms.Button btnFarol2;
        private System.Windows.Forms.Button btnParar2;
        private System.Windows.Forms.TrackBar vel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk2A;
        private System.Windows.Forms.CheckBox chk2B;
        private System.Windows.Forms.CheckBox chk3B;
        private System.Windows.Forms.CheckBox chk3A;
        private System.Windows.Forms.CheckBox chk4B;
        private System.Windows.Forms.CheckBox chk4A;
        private System.Windows.Forms.CheckBox chk1A;
        private System.Windows.Forms.CheckBox chk1B;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBuzina1;
    }
}

