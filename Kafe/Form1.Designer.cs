namespace Kafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Deserts = new System.Windows.Forms.GroupBox();
            this.C4 = new System.Windows.Forms.CheckBox();
            this.C3 = new System.Windows.Forms.CheckBox();
            this.C2 = new System.Windows.Forms.CheckBox();
            this.С1 = new System.Windows.Forms.CheckBox();
            this.drinks = new System.Windows.Forms.GroupBox();
            this.C8 = new System.Windows.Forms.CheckBox();
            this.С7 = new System.Windows.Forms.CheckBox();
            this.C6 = new System.Windows.Forms.CheckBox();
            this.C5 = new System.Windows.Forms.CheckBox();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Deserts.SuspendLayout();
            this.drinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Deserts
            // 
            this.Deserts.Controls.Add(this.C4);
            this.Deserts.Controls.Add(this.C3);
            this.Deserts.Controls.Add(this.C2);
            this.Deserts.Controls.Add(this.С1);
            this.Deserts.Location = new System.Drawing.Point(12, 29);
            this.Deserts.Name = "Deserts";
            this.Deserts.Size = new System.Drawing.Size(241, 209);
            this.Deserts.TabIndex = 0;
            this.Deserts.TabStop = false;
            this.Deserts.Text = "Десерти";
            // 
            // C4
            // 
            this.C4.AutoSize = true;
            this.C4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C4.Location = new System.Drawing.Point(20, 132);
            this.C4.Name = "C4";
            this.C4.Size = new System.Drawing.Size(181, 24);
            this.C4.TabIndex = 5;
            this.C4.Text = "Десерт \"Білосніжка\"";
            this.C4.UseVisualStyleBackColor = true;
            this.C4.CheckedChanged += new System.EventHandler(this.C4_CheckedChanged);
            // 
            // C3
            // 
            this.C3.AutoSize = true;
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3.Location = new System.Drawing.Point(20, 100);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(159, 24);
            this.C3.TabIndex = 4;
            this.C3.Text = "Тістечко \"Сніжок\"";
            this.C3.UseVisualStyleBackColor = true;
            this.C3.CheckedChanged += new System.EventHandler(this.C3_CheckedChanged);
            // 
            // C2
            // 
            this.C2.AutoSize = true;
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2.Location = new System.Drawing.Point(20, 66);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(208, 24);
            this.C2.TabIndex = 3;
            this.C2.Text = "Морозиво з шоколадом";
            this.C2.UseVisualStyleBackColor = true;
            this.C2.CheckedChanged += new System.EventHandler(this.C2_CheckedChanged);
            // 
            // С1
            // 
            this.С1.AutoSize = true;
            this.С1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.С1.Location = new System.Drawing.Point(20, 31);
            this.С1.Name = "С1";
            this.С1.Size = new System.Drawing.Size(163, 24);
            this.С1.TabIndex = 2;
            this.С1.Text = "Морозиво \"Казка\"";
            this.С1.UseVisualStyleBackColor = true;
            this.С1.CheckedChanged += new System.EventHandler(this.С1_CheckedChanged);
            // 
            // drinks
            // 
            this.drinks.Controls.Add(this.C8);
            this.drinks.Controls.Add(this.С7);
            this.drinks.Controls.Add(this.C6);
            this.drinks.Controls.Add(this.C5);
            this.drinks.Location = new System.Drawing.Point(563, 29);
            this.drinks.Name = "drinks";
            this.drinks.Size = new System.Drawing.Size(215, 182);
            this.drinks.TabIndex = 1;
            this.drinks.TabStop = false;
            this.drinks.Text = "Напої";
            // 
            // C8
            // 
            this.C8.AutoSize = true;
            this.C8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C8.Location = new System.Drawing.Point(20, 132);
            this.C8.Name = "C8";
            this.C8.Size = new System.Drawing.Size(98, 24);
            this.C8.TabIndex = 9;
            this.C8.Text = "Лимонад";
            this.C8.UseVisualStyleBackColor = true;
            this.C8.CheckedChanged += new System.EventHandler(this.C8_CheckedChanged);
            // 
            // С7
            // 
            this.С7.AutoSize = true;
            this.С7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.С7.Location = new System.Drawing.Point(20, 100);
            this.С7.Name = "С7";
            this.С7.Size = new System.Drawing.Size(142, 24);
            this.С7.TabIndex = 8;
            this.С7.Text = "Чай з лимоном";
            this.С7.UseVisualStyleBackColor = true;
            this.С7.CheckedChanged += new System.EventHandler(this.С7_CheckedChanged);
            // 
            // C6
            // 
            this.C6.AutoSize = true;
            this.C6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C6.Location = new System.Drawing.Point(20, 66);
            this.C6.Name = "C6";
            this.C6.Size = new System.Drawing.Size(176, 24);
            this.C6.TabIndex = 7;
            this.C6.Text = "Сік \"Мультивітамін\"";
            this.C6.UseVisualStyleBackColor = true;
            this.C6.CheckedChanged += new System.EventHandler(this.C6_CheckedChanged);
            // 
            // C5
            // 
            this.C5.AutoSize = true;
            this.C5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C5.Location = new System.Drawing.Point(20, 31);
            this.C5.Name = "C5";
            this.C5.Size = new System.Drawing.Size(180, 24);
            this.C5.TabIndex = 6;
            this.C5.Text = "Молочний коктейль";
            this.C5.UseVisualStyleBackColor = true;
            this.C5.CheckedChanged += new System.EventHandler(this.C5_CheckedChanged);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(33, 284);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(207, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Редагувати замовлення";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(563, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сформувати замовлення";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 287);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 331);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Deserts);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.drinks);
            this.Name = "Form1";
            this.Text = "Дитяча кав\'ярня \"Золотий ключик\"";
            this.Deserts.ResumeLayout(false);
            this.Deserts.PerformLayout();
            this.drinks.ResumeLayout(false);
            this.drinks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Deserts;
        private System.Windows.Forms.CheckBox C4;
        private System.Windows.Forms.CheckBox C3;
        private System.Windows.Forms.CheckBox C2;
        private System.Windows.Forms.CheckBox С1;
        private System.Windows.Forms.GroupBox drinks;
        private System.Windows.Forms.CheckBox C8;
        private System.Windows.Forms.CheckBox С7;
        private System.Windows.Forms.CheckBox C6;
        private System.Windows.Forms.CheckBox C5;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

