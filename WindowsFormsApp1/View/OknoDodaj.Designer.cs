namespace WindowsFormsApp1.View
{
    partial class OknoDodaj
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
            this.DanieLabel = new System.Windows.Forms.Label();
            this.OpisLabel = new System.Windows.Forms.Label();
            this.SkladnikiLabel = new System.Windows.Forms.Label();
            this.PodgladSkladnikowLabel = new System.Windows.Forms.Label();
            this.DanieTextBox = new System.Windows.Forms.TextBox();
            this.OpisTextBox = new System.Windows.Forms.TextBox();
            this.SkladnikiTextBox = new System.Windows.Forms.TextBox();
            this.PodgladSkladnikowTextBox = new System.Windows.Forms.TextBox();
            this.DodajSkladnikButton = new System.Windows.Forms.Button();
            this.UsunSkladnikButton = new System.Windows.Forms.Button();
            this.DodajDanieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DanieLabel
            // 
            this.DanieLabel.AutoSize = true;
            this.DanieLabel.Location = new System.Drawing.Point(22, 13);
            this.DanieLabel.Name = "DanieLabel";
            this.DanieLabel.Size = new System.Drawing.Size(71, 13);
            this.DanieLabel.TabIndex = 0;
            this.DanieLabel.Text = "Nazwa Dania";
            // 
            // OpisLabel
            // 
            this.OpisLabel.AutoSize = true;
            this.OpisLabel.Location = new System.Drawing.Point(22, 67);
            this.OpisLabel.Name = "OpisLabel";
            this.OpisLabel.Size = new System.Drawing.Size(28, 13);
            this.OpisLabel.TabIndex = 1;
            this.OpisLabel.Text = "Opis";
            // 
            // SkladnikiLabel
            // 
            this.SkladnikiLabel.AutoSize = true;
            this.SkladnikiLabel.Location = new System.Drawing.Point(22, 115);
            this.SkladnikiLabel.Name = "SkladnikiLabel";
            this.SkladnikiLabel.Size = new System.Drawing.Size(52, 13);
            this.SkladnikiLabel.TabIndex = 2;
            this.SkladnikiLabel.Text = "Składniki";
            // 
            // PodgladSkladnikowLabel
            // 
            this.PodgladSkladnikowLabel.AutoSize = true;
            this.PodgladSkladnikowLabel.Location = new System.Drawing.Point(22, 160);
            this.PodgladSkladnikowLabel.Name = "PodgladSkladnikowLabel";
            this.PodgladSkladnikowLabel.Size = new System.Drawing.Size(104, 13);
            this.PodgladSkladnikowLabel.TabIndex = 3;
            this.PodgladSkladnikowLabel.Text = "Podgląd składników";
            // 
            // DanieTextBox
            // 
            this.DanieTextBox.Location = new System.Drawing.Point(19, 29);
            this.DanieTextBox.Name = "DanieTextBox";
            this.DanieTextBox.Size = new System.Drawing.Size(100, 20);
            this.DanieTextBox.TabIndex = 4;
            this.DanieTextBox.TextChanged += new System.EventHandler(this.DanieTextBox_TextChanged);
            // 
            // OpisTextBox
            // 
            this.OpisTextBox.Location = new System.Drawing.Point(19, 83);
            this.OpisTextBox.Name = "OpisTextBox";
            this.OpisTextBox.Size = new System.Drawing.Size(100, 20);
            this.OpisTextBox.TabIndex = 5;
            // 
            // SkladnikiTextBox
            // 
            this.SkladnikiTextBox.Location = new System.Drawing.Point(19, 131);
            this.SkladnikiTextBox.Name = "SkladnikiTextBox";
            this.SkladnikiTextBox.Size = new System.Drawing.Size(100, 20);
            this.SkladnikiTextBox.TabIndex = 6;
            // 
            // PodgladSkladnikowTextBox
            // 
            this.PodgladSkladnikowTextBox.Location = new System.Drawing.Point(19, 176);
            this.PodgladSkladnikowTextBox.Multiline = true;
            this.PodgladSkladnikowTextBox.Name = "PodgladSkladnikowTextBox";
            this.PodgladSkladnikowTextBox.Size = new System.Drawing.Size(100, 107);
            this.PodgladSkladnikowTextBox.TabIndex = 7;
            // 
            // DodajSkladnikButton
            // 
            this.DodajSkladnikButton.Location = new System.Drawing.Point(125, 131);
            this.DodajSkladnikButton.Name = "DodajSkladnikButton";
            this.DodajSkladnikButton.Size = new System.Drawing.Size(75, 23);
            this.DodajSkladnikButton.TabIndex = 8;
            this.DodajSkladnikButton.Text = "Dodaj";
            this.DodajSkladnikButton.UseVisualStyleBackColor = true;
            // 
            // UsunSkladnikButton
            // 
            this.UsunSkladnikButton.Location = new System.Drawing.Point(125, 176);
            this.UsunSkladnikButton.Name = "UsunSkladnikButton";
            this.UsunSkladnikButton.Size = new System.Drawing.Size(75, 23);
            this.UsunSkladnikButton.TabIndex = 9;
            this.UsunSkladnikButton.Text = "Usuń";
            this.UsunSkladnikButton.UseVisualStyleBackColor = true;
            this.UsunSkladnikButton.Click += new System.EventHandler(this.UsunSkladnikButton_Click);
            // 
            // DodajDanieButton
            // 
            this.DodajDanieButton.Location = new System.Drawing.Point(19, 289);
            this.DodajDanieButton.Name = "DodajDanieButton";
            this.DodajDanieButton.Size = new System.Drawing.Size(100, 23);
            this.DodajDanieButton.TabIndex = 10;
            this.DodajDanieButton.Text = "Dodaj Danie";
            this.DodajDanieButton.UseVisualStyleBackColor = true;
            this.DodajDanieButton.Click += new System.EventHandler(this.DodajDanieButton_Click);
            // 
            // OknoDodaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DodajDanieButton);
            this.Controls.Add(this.UsunSkladnikButton);
            this.Controls.Add(this.DodajSkladnikButton);
            this.Controls.Add(this.PodgladSkladnikowTextBox);
            this.Controls.Add(this.SkladnikiTextBox);
            this.Controls.Add(this.OpisTextBox);
            this.Controls.Add(this.DanieTextBox);
            this.Controls.Add(this.PodgladSkladnikowLabel);
            this.Controls.Add(this.SkladnikiLabel);
            this.Controls.Add(this.OpisLabel);
            this.Controls.Add(this.DanieLabel);
            this.Name = "OknoDodaj";
            this.Text = "OknoDodaj";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DanieLabel;
        private System.Windows.Forms.Label OpisLabel;
        private System.Windows.Forms.Label SkladnikiLabel;
        private System.Windows.Forms.Label PodgladSkladnikowLabel;
        private System.Windows.Forms.TextBox DanieTextBox;
        private System.Windows.Forms.TextBox OpisTextBox;
        private System.Windows.Forms.TextBox SkladnikiTextBox;
        private System.Windows.Forms.TextBox PodgladSkladnikowTextBox;
        private System.Windows.Forms.Button DodajSkladnikButton;
        private System.Windows.Forms.Button UsunSkladnikButton;
        private System.Windows.Forms.Button DodajDanieButton;
    }
}