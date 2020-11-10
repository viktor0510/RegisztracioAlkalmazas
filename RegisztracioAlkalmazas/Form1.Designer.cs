namespace RegisztracioAlkalmazas
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
            this.label1_name = new System.Windows.Forms.Label();
            this.label1_date = new System.Windows.Forms.Label();
            this.label1_gender = new System.Windows.Forms.Label();
            this.label1_kehobby = new System.Windows.Forms.Label();
            this.label1_ujhobby = new System.Windows.Forms.Label();
            this.numericUpDown1_date = new System.Windows.Forms.NumericUpDown();
            this.radioButton1_F = new System.Windows.Forms.RadioButton();
            this.radioButton1_N = new System.Windows.Forms.RadioButton();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.textBox1_ujhobby = new System.Windows.Forms.TextBox();
            this.listBox1_kehobby = new System.Windows.Forms.ListBox();
            this.button1_add = new System.Windows.Forms.Button();
            this.button1_save = new System.Windows.Forms.Button();
            this.button1_load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_date)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_name
            // 
            this.label1_name.AutoSize = true;
            this.label1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_name.Location = new System.Drawing.Point(19, 24);
            this.label1_name.Name = "label1_name";
            this.label1_name.Size = new System.Drawing.Size(49, 24);
            this.label1_name.TabIndex = 0;
            this.label1_name.Text = "Név:";
            // 
            // label1_date
            // 
            this.label1_date.AutoSize = true;
            this.label1_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_date.Location = new System.Drawing.Point(19, 64);
            this.label1_date.Name = "label1_date";
            this.label1_date.Size = new System.Drawing.Size(113, 24);
            this.label1_date.TabIndex = 1;
            this.label1_date.Text = "Szül. dátum:";
            // 
            // label1_gender
            // 
            this.label1_gender.AutoSize = true;
            this.label1_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_gender.Location = new System.Drawing.Point(19, 104);
            this.label1_gender.Name = "label1_gender";
            this.label1_gender.Size = new System.Drawing.Size(56, 24);
            this.label1_gender.TabIndex = 2;
            this.label1_gender.Text = "Nem:";
            // 
            // label1_kehobby
            // 
            this.label1_kehobby.AutoSize = true;
            this.label1_kehobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_kehobby.Location = new System.Drawing.Point(275, 24);
            this.label1_kehobby.Name = "label1_kehobby";
            this.label1_kehobby.Size = new System.Drawing.Size(143, 24);
            this.label1_kehobby.TabIndex = 3;
            this.label1_kehobby.Text = "Kedvenc hobbi:";
            // 
            // label1_ujhobby
            // 
            this.label1_ujhobby.AutoSize = true;
            this.label1_ujhobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1_ujhobby.Location = new System.Drawing.Point(193, 186);
            this.label1_ujhobby.Name = "label1_ujhobby";
            this.label1_ujhobby.Size = new System.Drawing.Size(85, 24);
            this.label1_ujhobby.TabIndex = 4;
            this.label1_ujhobby.Text = "Új hobbi:";
            // 
            // numericUpDown1_date
            // 
            this.numericUpDown1_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1_date.Location = new System.Drawing.Point(138, 59);
            this.numericUpDown1_date.Maximum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.numericUpDown1_date.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.numericUpDown1_date.Name = "numericUpDown1_date";
            this.numericUpDown1_date.Size = new System.Drawing.Size(131, 29);
            this.numericUpDown1_date.TabIndex = 5;
            this.numericUpDown1_date.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // radioButton1_F
            // 
            this.radioButton1_F.AutoSize = true;
            this.radioButton1_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1_F.Location = new System.Drawing.Point(157, 100);
            this.radioButton1_F.Name = "radioButton1_F";
            this.radioButton1_F.Size = new System.Drawing.Size(40, 28);
            this.radioButton1_F.TabIndex = 6;
            this.radioButton1_F.TabStop = true;
            this.radioButton1_F.Text = "F";
            this.radioButton1_F.UseVisualStyleBackColor = true;
            // 
            // radioButton1_N
            // 
            this.radioButton1_N.AutoSize = true;
            this.radioButton1_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1_N.Location = new System.Drawing.Point(212, 100);
            this.radioButton1_N.Name = "radioButton1_N";
            this.radioButton1_N.Size = new System.Drawing.Size(42, 28);
            this.radioButton1_N.TabIndex = 7;
            this.radioButton1_N.TabStop = true;
            this.radioButton1_N.Text = "N";
            this.radioButton1_N.UseVisualStyleBackColor = true;
            // 
            // textBox1_name
            // 
            this.textBox1_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1_name.Location = new System.Drawing.Point(138, 24);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(131, 29);
            this.textBox1_name.TabIndex = 8;
            // 
            // textBox1_ujhobby
            // 
            this.textBox1_ujhobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1_ujhobby.Location = new System.Drawing.Point(294, 183);
            this.textBox1_ujhobby.Name = "textBox1_ujhobby";
            this.textBox1_ujhobby.Size = new System.Drawing.Size(124, 29);
            this.textBox1_ujhobby.TabIndex = 9;
            // 
            // listBox1_kehobby
            // 
            this.listBox1_kehobby.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1_kehobby.FormattingEnabled = true;
            this.listBox1_kehobby.ItemHeight = 24;
            this.listBox1_kehobby.Items.AddRange(new object[] {
            "Uszás",
            "Horgászat",
            "Futás"});
            this.listBox1_kehobby.Location = new System.Drawing.Point(294, 51);
            this.listBox1_kehobby.Name = "listBox1_kehobby";
            this.listBox1_kehobby.Size = new System.Drawing.Size(124, 124);
            this.listBox1_kehobby.TabIndex = 10;
            // 
            // button1_add
            // 
            this.button1_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_add.Location = new System.Drawing.Point(326, 231);
            this.button1_add.Name = "button1_add";
            this.button1_add.Size = new System.Drawing.Size(92, 34);
            this.button1_add.TabIndex = 11;
            this.button1_add.Text = "Hozzáad";
            this.button1_add.UseVisualStyleBackColor = true;
            // 
            // button1_save
            // 
            this.button1_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_save.Location = new System.Drawing.Point(239, 296);
            this.button1_save.Name = "button1_save";
            this.button1_save.Size = new System.Drawing.Size(81, 35);
            this.button1_save.TabIndex = 12;
            this.button1_save.Text = "Mentés";
            this.button1_save.UseVisualStyleBackColor = true;
            // 
            // button1_load
            // 
            this.button1_load.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_load.Location = new System.Drawing.Point(326, 296);
            this.button1_load.Name = "button1_load";
            this.button1_load.Size = new System.Drawing.Size(87, 35);
            this.button1_load.TabIndex = 13;
            this.button1_load.Text = "Betöltés";
            this.button1_load.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.button1_load);
            this.Controls.Add(this.button1_save);
            this.Controls.Add(this.button1_add);
            this.Controls.Add(this.listBox1_kehobby);
            this.Controls.Add(this.textBox1_ujhobby);
            this.Controls.Add(this.textBox1_name);
            this.Controls.Add(this.radioButton1_N);
            this.Controls.Add(this.radioButton1_F);
            this.Controls.Add(this.numericUpDown1_date);
            this.Controls.Add(this.label1_ujhobby);
            this.Controls.Add(this.label1_kehobby);
            this.Controls.Add(this.label1_gender);
            this.Controls.Add(this.label1_date);
            this.Controls.Add(this.label1_name);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "Form1";
            this.Text = "RegisztracioAlkalmazas";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1_date)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_name;
        private System.Windows.Forms.Label label1_date;
        private System.Windows.Forms.Label label1_gender;
        private System.Windows.Forms.Label label1_kehobby;
        private System.Windows.Forms.Label label1_ujhobby;
        private System.Windows.Forms.NumericUpDown numericUpDown1_date;
        private System.Windows.Forms.RadioButton radioButton1_F;
        private System.Windows.Forms.RadioButton radioButton1_N;
        private System.Windows.Forms.TextBox textBox1_name;
        private System.Windows.Forms.TextBox textBox1_ujhobby;
        private System.Windows.Forms.ListBox listBox1_kehobby;
        private System.Windows.Forms.Button button1_add;
        private System.Windows.Forms.Button button1_save;
        private System.Windows.Forms.Button button1_load;
    }
}

