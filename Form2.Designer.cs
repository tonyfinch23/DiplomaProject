namespace sampleconnection
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
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelInformation = new System.Windows.Forms.Label();
            this.LabelFoods = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Location = new System.Drawing.Point(12, 9);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(50, 20);
            this.LabelResult.TabIndex = 0;
            this.LabelResult.Text = "label1";
            // 
            // LabelInformation
            // 
            this.LabelInformation.AutoSize = true;
            this.LabelInformation.Location = new System.Drawing.Point(12, 94);
            this.LabelInformation.Name = "LabelInformation";
            this.LabelInformation.Size = new System.Drawing.Size(50, 20);
            this.LabelInformation.TabIndex = 1;
            this.LabelInformation.Text = "label1";
            // 
            // LabelFoods
            // 
            this.LabelFoods.AutoSize = true;
            this.LabelFoods.Location = new System.Drawing.Point(12, 185);
            this.LabelFoods.Name = "LabelFoods";
            this.LabelFoods.Size = new System.Drawing.Size(50, 20);
            this.LabelFoods.TabIndex = 2;
            this.LabelFoods.Text = "label1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LabelFoods);
            this.Controls.Add(this.LabelInformation);
            this.Controls.Add(this.LabelResult);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LabelResult;
        private Label LabelInformation;
        private Label LabelFoods;
    }
}