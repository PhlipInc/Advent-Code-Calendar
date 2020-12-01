
namespace Day1
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
            this.PrintDoubleButton = new System.Windows.Forms.Button();
            this.PrintTripleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrintDoubleButton
            // 
            this.PrintDoubleButton.Location = new System.Drawing.Point(12, 12);
            this.PrintDoubleButton.Name = "PrintDoubleButton";
            this.PrintDoubleButton.Size = new System.Drawing.Size(116, 67);
            this.PrintDoubleButton.TabIndex = 0;
            this.PrintDoubleButton.Text = "Sum of Doubles";
            this.PrintDoubleButton.UseVisualStyleBackColor = true;
            this.PrintDoubleButton.Click += new System.EventHandler(this.PrintDoubleButton_Click);
            // 
            // PrintTripleButton
            // 
            this.PrintTripleButton.Location = new System.Drawing.Point(136, 12);
            this.PrintTripleButton.Name = "PrintTripleButton";
            this.PrintTripleButton.Size = new System.Drawing.Size(116, 67);
            this.PrintTripleButton.TabIndex = 1;
            this.PrintTripleButton.Text = "Sum of Triples";
            this.PrintTripleButton.UseVisualStyleBackColor = true;
            this.PrintTripleButton.Click += new System.EventHandler(this.PrintTripleButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 91);
            this.Controls.Add(this.PrintTripleButton);
            this.Controls.Add(this.PrintDoubleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintDoubleButton;
        private System.Windows.Forms.Button PrintTripleButton;
    }
}

