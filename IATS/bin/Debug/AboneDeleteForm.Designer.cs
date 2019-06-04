namespace IATS
{
    partial class AboneSil
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
            this.label1 = new System.Windows.Forms.Label();
            this.aboneDeleteButton = new System.Windows.Forms.Button();
            this.tcTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kaydı Silinecek Abonenin T.C. Kimlik Numarasını Giriniz";
            // 
            // aboneDeleteButton
            // 
            this.aboneDeleteButton.Location = new System.Drawing.Point(13, 120);
            this.aboneDeleteButton.Name = "aboneDeleteButton";
            this.aboneDeleteButton.Size = new System.Drawing.Size(259, 38);
            this.aboneDeleteButton.TabIndex = 2;
            this.aboneDeleteButton.Text = "Sil";
            this.aboneDeleteButton.UseVisualStyleBackColor = true;
            this.aboneDeleteButton.Click += new System.EventHandler(this.aboneDeleteButton_Click);
            // 
            // tcTextBox
            // 
            this.tcTextBox.Location = new System.Drawing.Point(13, 85);
            this.tcTextBox.MaxLength = 11;
            this.tcTextBox.Name = "aboneTcGetirTextBox";
            this.tcTextBox.Size = new System.Drawing.Size(259, 20);
            this.tcTextBox.TabIndex = 56;
            this.tcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aboneTcGetirTextBox_KeyPress);
            // 
            // AboneSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.tcTextBox);
            this.Controls.Add(this.aboneDeleteButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboneSil";
            this.ShowIcon = false;
            this.Text = "Abone Kayıt Silme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aboneDeleteButton;
        private System.Windows.Forms.TextBox tcTextBox;
    }
}