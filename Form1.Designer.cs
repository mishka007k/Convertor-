namespace Convertor
{
    partial class Convertor
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gr = new System.Windows.Forms.Label();
            this.tn = new System.Windows.Forms.Label();
            this.cn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(336, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(104, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Конвертатор веса";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 126);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.TextChanched);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(128, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ввведите вес в кг:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(128, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вес в граммах:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(128, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Вес в тоннах:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(128, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вес в центнерах:";
            // 
            // gr
            // 
            this.gr.AutoSize = true;
            this.gr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.gr.Location = new System.Drawing.Point(133, 198);
            this.gr.Name = "gr";
            this.gr.Size = new System.Drawing.Size(0, 29);
            this.gr.TabIndex = 7;
            // 
            // tn
            // 
            this.tn.AutoSize = true;
            this.tn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tn.Location = new System.Drawing.Point(133, 292);
            this.tn.Name = "tn";
            this.tn.Size = new System.Drawing.Size(0, 29);
            this.tn.TabIndex = 8;
            // 
            // cn
            // 
            this.cn.AutoSize = true;
            this.cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cn.Location = new System.Drawing.Point(133, 377);
            this.cn.Name = "cn";
            this.cn.Size = new System.Drawing.Size(0, 29);
            this.cn.TabIndex = 9;
            // 
            // Convertor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(445, 490);
            this.Controls.Add(this.cn);
            this.Controls.Add(this.tn);
            this.Controls.Add(this.gr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Convertor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label gr;
        private System.Windows.Forms.Label tn;
        private System.Windows.Forms.Label cn;
    }
}

