
namespace lab2
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
            this.x1 = new System.Windows.Forms.NumericUpDown();
            this.y1 = new System.Windows.Forms.NumericUpDown();
            this.y2 = new System.Windows.Forms.NumericUpDown();
            this.x2 = new System.Windows.Forms.NumericUpDown();
            this.y4 = new System.Windows.Forms.NumericUpDown();
            this.x4 = new System.Windows.Forms.NumericUpDown();
            this.y3 = new System.Windows.Forms.NumericUpDown();
            this.x3 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.power = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.x1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).BeginInit();
            this.SuspendLayout();
            // 
            // x1
            // 
            this.x1.Location = new System.Drawing.Point(628, 33);
            this.x1.Maximum = new decimal(new int[] {
            610,
            0,
            0,
            0});
            this.x1.Name = "x1";
            this.x1.Size = new System.Drawing.Size(77, 22);
            this.x1.TabIndex = 0;
            // 
            // y1
            // 
            this.y1.Location = new System.Drawing.Point(711, 33);
            this.y1.Maximum = new decimal(new int[] {
            410,
            0,
            0,
            0});
            this.y1.Name = "y1";
            this.y1.Size = new System.Drawing.Size(77, 22);
            this.y1.TabIndex = 1;
            // 
            // y2
            // 
            this.y2.Location = new System.Drawing.Point(711, 61);
            this.y2.Maximum = new decimal(new int[] {
            410,
            0,
            0,
            0});
            this.y2.Name = "y2";
            this.y2.Size = new System.Drawing.Size(77, 22);
            this.y2.TabIndex = 3;
            // 
            // x2
            // 
            this.x2.Location = new System.Drawing.Point(628, 61);
            this.x2.Maximum = new decimal(new int[] {
            610,
            0,
            0,
            0});
            this.x2.Name = "x2";
            this.x2.Size = new System.Drawing.Size(77, 22);
            this.x2.TabIndex = 2;
            // 
            // y4
            // 
            this.y4.Location = new System.Drawing.Point(711, 117);
            this.y4.Maximum = new decimal(new int[] {
            410,
            0,
            0,
            0});
            this.y4.Name = "y4";
            this.y4.Size = new System.Drawing.Size(77, 22);
            this.y4.TabIndex = 7;
            // 
            // x4
            // 
            this.x4.Location = new System.Drawing.Point(628, 117);
            this.x4.Maximum = new decimal(new int[] {
            610,
            0,
            0,
            0});
            this.x4.Name = "x4";
            this.x4.Size = new System.Drawing.Size(77, 22);
            this.x4.TabIndex = 6;
            // 
            // y3
            // 
            this.y3.Location = new System.Drawing.Point(711, 89);
            this.y3.Maximum = new decimal(new int[] {
            410,
            0,
            0,
            0});
            this.y3.Name = "y3";
            this.y3.Size = new System.Drawing.Size(77, 22);
            this.y3.TabIndex = 5;
            // 
            // x3
            // 
            this.x3.Location = new System.Drawing.Point(628, 89);
            this.x3.Maximum = new decimal(new int[] {
            610,
            0,
            0,
            0});
            this.x3.Name = "x3";
            this.x3.Size = new System.Drawing.Size(77, 22);
            this.x3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "координаты x и y";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(9, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(610, 410);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "степень";
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(677, 162);
            this.power.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.power.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(77, 22);
            this.power.TabIndex = 11;
            this.power.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(624, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "рисовать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(624, 247);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.power);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.y4);
            this.Controls.Add(this.x4);
            this.Controls.Add(this.y3);
            this.Controls.Add(this.x3);
            this.Controls.Add(this.y2);
            this.Controls.Add(this.x2);
            this.Controls.Add(this.y1);
            this.Controls.Add(this.x1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.x1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.power)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown x1;
        private System.Windows.Forms.NumericUpDown y1;
        private System.Windows.Forms.NumericUpDown y2;
        private System.Windows.Forms.NumericUpDown x2;
        private System.Windows.Forms.NumericUpDown y4;
        private System.Windows.Forms.NumericUpDown x4;
        private System.Windows.Forms.NumericUpDown y3;
        private System.Windows.Forms.NumericUpDown x3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown power;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

