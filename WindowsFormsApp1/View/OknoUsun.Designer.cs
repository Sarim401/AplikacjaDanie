namespace WindowsFormsApp1.View
{
    partial class OknoUsun
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
            this.PrzepisyListBox = new System.Windows.Forms.ListBox();
            this.UsunButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PrzepisyListBox
            // 
            this.PrzepisyListBox.FormattingEnabled = true;
            this.PrzepisyListBox.Location = new System.Drawing.Point(33, 13);
            this.PrzepisyListBox.Name = "PrzepisyListBox";
            this.PrzepisyListBox.Size = new System.Drawing.Size(306, 420);
            this.PrzepisyListBox.TabIndex = 0;
            // 
            // UsunButton
            // 
            this.UsunButton.Location = new System.Drawing.Point(360, 13);
            this.UsunButton.Name = "UsunButton";
            this.UsunButton.Size = new System.Drawing.Size(92, 39);
            this.UsunButton.TabIndex = 1;
            this.UsunButton.Text = "Usuń Przepis";
            this.UsunButton.UseVisualStyleBackColor = true;
            this.UsunButton.Click += new System.EventHandler(this.UsunButton_Click);
            // 
            // OknoUsun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UsunButton);
            this.Controls.Add(this.PrzepisyListBox);
            this.Name = "OknoUsun";
            this.Text = "OknoUsun";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PrzepisyListBox;
        private System.Windows.Forms.Button UsunButton;
    }
}