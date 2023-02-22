namespace WeatherApp
{
    partial class WeatherForm
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
            this.WeatherDataGrid = new System.Windows.Forms.DataGridView();
            this.poisk = new System.Windows.Forms.TextBox();
            this.filtr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Button();
            this.sbroc = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sortirovka = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WeatherDataGrid
            // 
            this.WeatherDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WeatherDataGrid.BackgroundColor = System.Drawing.SystemColors.Info;
            this.WeatherDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WeatherDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WeatherDataGrid.Location = new System.Drawing.Point(12, 12);
            this.WeatherDataGrid.Name = "WeatherDataGrid";
            this.WeatherDataGrid.ReadOnly = true;
            this.WeatherDataGrid.Size = new System.Drawing.Size(776, 220);
            this.WeatherDataGrid.TabIndex = 0;
            // 
            // poisk
            // 
            this.poisk.BackColor = System.Drawing.SystemColors.Info;
            this.poisk.Location = new System.Drawing.Point(3, 29);
            this.poisk.Name = "poisk";
            this.poisk.Size = new System.Drawing.Size(131, 20);
            this.poisk.TabIndex = 1;
            this.poisk.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // filtr
            // 
            this.filtr.BackColor = System.Drawing.SystemColors.Info;
            this.filtr.FormattingEnabled = true;
            this.filtr.Location = new System.Drawing.Point(180, 29);
            this.filtr.Name = "filtr";
            this.filtr.Size = new System.Drawing.Size(131, 21);
            this.filtr.TabIndex = 2;
            this.filtr.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Город";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Единица измерения";
            // 
            // plus
            // 
            this.plus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.plus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.plus.Location = new System.Drawing.Point(115, 99);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(78, 25);
            this.plus.TabIndex = 5;
            this.plus.Text = "Вывести +";
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // sbroc
            // 
            this.sbroc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.sbroc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.sbroc.Location = new System.Drawing.Point(180, 67);
            this.sbroc.Name = "sbroc";
            this.sbroc.Size = new System.Drawing.Size(131, 23);
            this.sbroc.TabIndex = 6;
            this.sbroc.Text = "Сброс";
            this.sbroc.UseVisualStyleBackColor = true;
            this.sbroc.Click += new System.EventHandler(this.sbroc_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.sortirovka);
            this.panel1.Controls.Add(this.plus);
            this.panel1.Controls.Add(this.filtr);
            this.panel1.Controls.Add(this.sbroc);
            this.panel1.Controls.Add(this.poisk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(212, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 139);
            this.panel1.TabIndex = 7;
            // 
            // sortirovka
            // 
            this.sortirovka.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.sortirovka.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Cyan;
            this.sortirovka.Location = new System.Drawing.Point(6, 66);
            this.sortirovka.Name = "sortirovka";
            this.sortirovka.Size = new System.Drawing.Size(128, 23);
            this.sortirovka.TabIndex = 7;
            this.sortirovka.Text = "Сортировка";
            this.sortirovka.UseVisualStyleBackColor = true;
            this.sortirovka.Click += new System.EventHandler(this.sortirovka_Click);
            // 
            // WeatherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.WeatherDataGrid);
            this.Name = "WeatherForm";
            this.Text = "Погода Хакасии";
            ((System.ComponentModel.ISupportInitialize)(this.WeatherDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView WeatherDataGrid;
        private System.Windows.Forms.TextBox poisk;
        private System.Windows.Forms.ComboBox filtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Button sbroc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button sortirovka;
    }
}

