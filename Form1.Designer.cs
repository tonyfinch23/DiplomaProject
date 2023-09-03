namespace sampleconnection
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.weightValue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.shedding = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.heightValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ageValue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "How much do you weigh?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // weightValue
            // 
            this.weightValue.Location = new System.Drawing.Point(199, 6);
            this.weightValue.Name = "weightValue";
            this.weightValue.Size = new System.Drawing.Size(125, 27);
            this.weightValue.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "How much do you wish to lose?";
            // 
            // shedding
            // 
            this.shedding.Location = new System.Drawing.Point(237, 43);
            this.shedding.Name = "shedding";
            this.shedding.Size = new System.Drawing.Size(125, 27);
            this.shedding.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "What is your sex?";
            // 
            // comboBox1
            // 
            this.comboBox1.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox1.Location = new System.Drawing.Point(141, 82);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "What is your height?";
            // 
            // heightValue
            // 
            this.heightValue.Location = new System.Drawing.Point(162, 126);
            this.heightValue.Name = "heightValue";
            this.heightValue.Size = new System.Drawing.Size(125, 27);
            this.heightValue.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "What is your age?";
            // 
            // ageValue
            // 
            this.ageValue.Location = new System.Drawing.Point(145, 166);
            this.ageValue.Name = "ageValue";
            this.ageValue.Size = new System.Drawing.Size(125, 27);
            this.ageValue.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "What is your exercise frequency?";
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "Little or none",
            "1-3 days a week",
            "3-5 days a week",
            "6-7 days a week",
            "Extra heavy physical activity almost if not every day"});
            this.comboBox2.Location = new System.Drawing.Point(242, 208);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(370, 28);
            this.comboBox2.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(389, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "How many months are you willing to allocate to the diet?";
            // 
            // comboBox3
            // 
            this.comboBox3.Items.AddRange(new object[] {
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox3.Location = new System.Drawing.Point(407, 250);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(85, 28);
            this.comboBox3.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(539, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 29);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate daily caloric intake";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ageValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.heightValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shedding);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.weightValue);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox weightValue;
        private Label label2;
        private TextBox shedding;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox heightValue;
        private Label label5;
        private TextBox ageValue;
        private Label label6;
        private ComboBox comboBox2;
        private Label label7;
        private ComboBox comboBox3;
        private Button button1;
    }
}