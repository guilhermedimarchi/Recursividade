namespace Recursividade
{
    partial class Exerc
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
            this.components = new System.ComponentModel.Container();
            this.udFat = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFat = new System.Windows.Forms.Button();
            this.lblFat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFib = new System.Windows.Forms.Button();
            this.lblFib = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.udFib = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.btnDiscos = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.udDiscos = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.udFat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFib)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // udFat
            // 
            this.udFat.Location = new System.Drawing.Point(91, 23);
            this.udFat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udFat.Name = "udFat";
            this.udFat.Size = new System.Drawing.Size(60, 26);
            this.udFat.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFat);
            this.groupBox1.Controls.Add(this.lblFat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.udFat);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(282, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatorial:";
            // 
            // btnFat
            // 
            this.btnFat.Location = new System.Drawing.Point(169, 23);
            this.btnFat.Name = "btnFat";
            this.btnFat.Size = new System.Drawing.Size(98, 52);
            this.btnFat.TabIndex = 5;
            this.btnFat.Text = "Calcular";
            this.btnFat.UseVisualStyleBackColor = true;
            this.btnFat.Click += new System.EventHandler(this.btnFat_Click);
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.Location = new System.Drawing.Point(87, 55);
            this.lblFat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(19, 20);
            this.lblFat.TabIndex = 4;
            this.lblFat.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saída:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Entrada:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFib);
            this.groupBox2.Controls.Add(this.lblFib);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.udFib);
            this.groupBox2.Location = new System.Drawing.Point(310, 18);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(282, 90);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fibonacci:";
            // 
            // btnFib
            // 
            this.btnFib.Location = new System.Drawing.Point(169, 23);
            this.btnFib.Name = "btnFib";
            this.btnFib.Size = new System.Drawing.Size(98, 52);
            this.btnFib.TabIndex = 5;
            this.btnFib.Text = "Calcular";
            this.btnFib.UseVisualStyleBackColor = true;
            this.btnFib.Click += new System.EventHandler(this.btnFib_Click);
            // 
            // lblFib
            // 
            this.lblFib.AutoSize = true;
            this.lblFib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFib.Location = new System.Drawing.Point(87, 55);
            this.lblFib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFib.Name = "lblFib";
            this.lblFib.Size = new System.Drawing.Size(19, 20);
            this.lblFib.TabIndex = 4;
            this.lblFib.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Saída:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 25);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Entrada:";
            // 
            // udFib
            // 
            this.udFib.Location = new System.Drawing.Point(91, 23);
            this.udFib.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udFib.Name = "udFib";
            this.udFib.Size = new System.Drawing.Size(60, 26);
            this.udFib.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lblHora);
            this.groupBox3.Controls.Add(this.lb3);
            this.groupBox3.Controls.Add(this.lb2);
            this.groupBox3.Controls.Add(this.lb1);
            this.groupBox3.Controls.Add(this.btnDiscos);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.udDiscos);
            this.groupBox3.Location = new System.Drawing.Point(18, 118);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(574, 364);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hanói:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(330, 38);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 20);
            this.lblHora.TabIndex = 9;
            this.lblHora.Text = "label3";
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.FormattingEnabled = true;
            this.lb3.Location = new System.Drawing.Point(382, 69);
            this.lb3.Margin = new System.Windows.Forms.Padding(1);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(182, 277);
            this.lb3.TabIndex = 8;
            // 
            // lb2
            // 
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(198, 69);
            this.lb2.Margin = new System.Windows.Forms.Padding(1);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(182, 277);
            this.lb2.TabIndex = 7;
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.FormattingEnabled = true;
            this.lb1.Items.AddRange(new object[] {
            "_",
            "__",
            "___"});
            this.lb1.Location = new System.Drawing.Point(14, 69);
            this.lb1.Margin = new System.Windows.Forms.Padding(1);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(182, 277);
            this.lb1.TabIndex = 6;
            // 
            // btnDiscos
            // 
            this.btnDiscos.Location = new System.Drawing.Point(169, 23);
            this.btnDiscos.Name = "btnDiscos";
            this.btnDiscos.Size = new System.Drawing.Size(98, 33);
            this.btnDiscos.TabIndex = 5;
            this.btnDiscos.Text = "Resolver";
            this.btnDiscos.UseVisualStyleBackColor = true;
            this.btnDiscos.Click += new System.EventHandler(this.btnDiscos_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Discos:";
            // 
            // udDiscos
            // 
            this.udDiscos.Location = new System.Drawing.Point(86, 27);
            this.udDiscos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.udDiscos.Name = "udDiscos";
            this.udDiscos.Size = new System.Drawing.Size(60, 26);
            this.udDiscos.TabIndex = 0;
            this.udDiscos.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.udDiscos.ValueChanged += new System.EventHandler(this.udDiscos_ValueChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Exerc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 496);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Exerc";
            this.Text = "Exemplos de Recursão";
            ((System.ComponentModel.ISupportInitialize)(this.udFat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udFib)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udDiscos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown udFat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFib;
        private System.Windows.Forms.Label lblFib;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown udFib;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDiscos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown udDiscos;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb3;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

