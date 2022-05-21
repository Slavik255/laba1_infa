
namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.RadioButton();
            this.B = new System.Windows.Forms.RadioButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Special = new System.Windows.Forms.TextBox();
            this.Cours = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Info = new System.Windows.Forms.Button();
            this.Dell = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.80838F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.19162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel1.Controls.Add(this.Name, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.K, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.B, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Special, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Cours, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Add, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Info, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dell, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Red, 3, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.27397F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.72603F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(3, 238);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(169, 22);
            this.Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Курс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Специальность";
            // 
            // K
            // 
            this.K.AutoSize = true;
            this.K.Checked = true;
            this.K.Location = new System.Drawing.Point(595, 204);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(91, 21);
            this.K.TabIndex = 7;
            this.K.TabStop = true;
            this.K.Text = "Контракт";
            this.K.UseVisualStyleBackColor = true;
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(595, 238);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(80, 21);
            this.B.TabIndex = 6;
            this.B.Text = "Бюджет";
            this.B.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tableLayoutPanel1.SetColumnSpan(this.listView1, 4);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(770, 195);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ФИО";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Специальность";
            this.columnHeader2.Width = 238;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Курс";
            this.columnHeader3.Width = 182;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Бюджет/Контракт";
            this.columnHeader4.Width = 145;
            // 
            // Special
            // 
            this.Special.Location = new System.Drawing.Point(178, 238);
            this.Special.Name = "Special";
            this.Special.Size = new System.Drawing.Size(202, 22);
            this.Special.TabIndex = 9;
            // 
            // Cours
            // 
            this.Cours.Location = new System.Drawing.Point(386, 238);
            this.Cours.Name = "Cours";
            this.Cours.Size = new System.Drawing.Size(203, 22);
            this.Cours.TabIndex = 10;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(178, 328);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(202, 95);
            this.Add.TabIndex = 11;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Info
            // 
            this.Info.Location = new System.Drawing.Point(3, 328);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(169, 95);
            this.Info.TabIndex = 1;
            this.Info.Text = "Информация о контрактниках";
            this.Info.UseVisualStyleBackColor = true;
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Dell
            // 
            this.Dell.Location = new System.Drawing.Point(386, 328);
            this.Dell.Name = "Dell";
            this.Dell.Size = new System.Drawing.Size(203, 95);
            this.Dell.TabIndex = 12;
            this.Dell.Text = "Удалить";
            this.Dell.UseVisualStyleBackColor = true;
            this.Dell.Click += new System.EventHandler(this.Dell_Click);
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(595, 328);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(172, 95);
            this.Red.TabIndex = 13;
            this.Red.Text = "Редактировать";
            this.Red.UseVisualStyleBackColor = true;
            this.Red.Click += new System.EventHandler(this.Red_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Button Info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton B;
        private System.Windows.Forms.RadioButton K;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox Special;
        private System.Windows.Forms.TextBox Cours;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Dell;
        private System.Windows.Forms.Button Red;
    }
}

