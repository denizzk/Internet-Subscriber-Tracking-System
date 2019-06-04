namespace IATS
{
    partial class PaketSil
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
            this.paketDeleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.paketAdTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // paketDeleteButton
            // 
            this.paketDeleteButton.Location = new System.Drawing.Point(12, 144);
            this.paketDeleteButton.Name = "paketDeleteButton";
            this.paketDeleteButton.Size = new System.Drawing.Size(259, 38);
            this.paketDeleteButton.TabIndex = 5;
            this.paketDeleteButton.Text = "Sil";
            this.paketDeleteButton.UseVisualStyleBackColor = true;
            this.paketDeleteButton.Click += new System.EventHandler(this.paketDeleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kaydı Silinecek Paketin Adını Giriniz";
            // 
            // paketAdTextBox
            // 
            this.paketAdTextBox.Location = new System.Drawing.Point(12, 109);
            this.paketAdTextBox.MaxLength = 10;
            this.paketAdTextBox.Name = "paketAdTextBox";
            this.paketAdTextBox.Size = new System.Drawing.Size(259, 20);
            this.paketAdTextBox.TabIndex = 3;
            // 
            // PaketSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.paketDeleteButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.paketAdTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaketSil";
            this.ShowIcon = false;
            this.Text = "Paket Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button paketDeleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paketAdTextBox;
    }
}