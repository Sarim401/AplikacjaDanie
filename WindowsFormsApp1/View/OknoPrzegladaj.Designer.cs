namespace WindowsFormsApp1.View
{
    partial class OknoPrzegladaj
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
            this.OpisPrzepisow = new System.Windows.Forms.TextBox();
            this.ProduktyListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OpisPrzepisow
            // 
            this.OpisPrzepisow.Location = new System.Drawing.Point(220, 13);
            this.OpisPrzepisow.Multiline = true;
            this.OpisPrzepisow.Name = "OpisPrzepisow";
            this.OpisPrzepisow.ReadOnly = true;
            this.OpisPrzepisow.Size = new System.Drawing.Size(568, 420);
            this.OpisPrzepisow.TabIndex = 1;
            // 
            // ProduktyListBox
            // 
            this.ProduktyListBox.FormattingEnabled = true;
            this.ProduktyListBox.Location = new System.Drawing.Point(13, 13);
            this.ProduktyListBox.Name = "ProduktyListBox";
            this.ProduktyListBox.Size = new System.Drawing.Size(201, 420);
            this.ProduktyListBox.TabIndex = 2;
            this.ProduktyListBox.SelectedIndexChanged += new System.EventHandler(this.ProduktyListBox_SelectedIndexChanged);
            // 
            // OknoPrzegladaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProduktyListBox);
            this.Controls.Add(this.OpisPrzepisow);
            this.Name = "OknoPrzegladaj";
            this.Text = "OknoPrzegladaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox OpisPrzepisow;
        private System.Windows.Forms.ListBox ProduktyListBox;
    }
}