
namespace ZachV9
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Spravka = new System.Windows.Forms.Label();
            this.text1 = new System.Windows.Forms.Label();
            this.ignore = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.text4 = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Spravka
            // 
            this.Spravka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Spravka.AutoSize = true;
            this.Spravka.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spravka.Location = new System.Drawing.Point(462, 14);
            this.Spravka.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Spravka.Name = "Spravka";
            this.Spravka.Size = new System.Drawing.Size(191, 35);
            this.Spravka.TabIndex = 0;
            this.Spravka.Text = "С П Р А В К А";
            this.Spravka.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Spravka.Click += new System.EventHandler(this.label1_Click);
            // 
            // text1
            // 
            this.text1.AutoSize = true;
            this.text1.BackColor = System.Drawing.Color.Transparent;
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text1.Location = new System.Drawing.Point(19, 151);
            this.text1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(1168, 93);
            this.text1.TabIndex = 1;
            this.text1.Text = resources.GetString("text1.Text");
            this.text1.Click += new System.EventHandler(this.label2_Click);
            // 
            // ignore
            // 
            this.ignore.AutoSize = true;
            this.ignore.BackColor = System.Drawing.Color.Transparent;
            this.ignore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ignore.Location = new System.Drawing.Point(19, 244);
            this.ignore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ignore.Name = "ignore";
            this.ignore.Size = new System.Drawing.Size(698, 31);
            this.ignore.TabIndex = 2;
            this.ignore.Text = "ОП _______________ Период обучения _______ года.\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 3;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 27);
            this.button2.TabIndex = 4;
            this.button2.Text = "Сохранить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // text4
            // 
            this.text4.AutoSize = true;
            this.text4.BackColor = System.Drawing.Color.Transparent;
            this.text4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text4.Location = new System.Drawing.Point(19, 384);
            this.text4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(997, 31);
            this.text4.TabIndex = 5;
            this.text4.Text = "Ио. декана физико-технического факультета _________________ Собко А.О.\r\n";
            // 
            // text3
            // 
            this.text3.AutoSize = true;
            this.text3.BackColor = System.Drawing.Color.Transparent;
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text3.Location = new System.Drawing.Point(19, 336);
            this.text3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(910, 31);
            this.text3.TabIndex = 6;
            this.text3.Text = "Справка предоставляется для предъявления _____________________\r\n";
            this.text3.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "1";
            this.label2.TextChanged += new System.EventHandler(this.label2_TextChanged);
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(327, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "`";
            this.label3.TextChanged += new System.EventHandler(this.label3_TextChanged);
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "label4";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(651, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1041, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(70, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text3);
            this.Controls.Add(this.text4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ignore);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.Spravka);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Spravka;
        private System.Windows.Forms.Label text1;
        private System.Windows.Forms.Label ignore;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label text4;
        private System.Windows.Forms.Label text3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}