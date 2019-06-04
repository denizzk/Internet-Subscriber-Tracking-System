namespace IATS
{
    partial class PaketEkle
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
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.taahhutTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paketFiyatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.paketAkkTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.paketAdTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(12, 185);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(260, 61);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "EKLE";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.taahhutTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.paketFiyatTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.paketAkkTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.paketAdTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 170);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paket";
            // 
            // taahhutTextBox
            // 
            this.taahhutTextBox.Location = new System.Drawing.Point(162, 99);
            this.taahhutTextBox.Name = "taahhutTextBox";
            this.taahhutTextBox.Size = new System.Drawing.Size(120, 20);
            this.taahhutTextBox.TabIndex = 9;
            this.taahhutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taahhutTextbox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Taahhüt Süresi";
            // 
            // paketFiyatTextBox
            // 
            this.paketFiyatTextBox.Location = new System.Drawing.Point(162, 50);
            this.paketFiyatTextBox.Name = "paketFiyatTextBox";
            this.paketFiyatTextBox.Size = new System.Drawing.Size(120, 20);
            this.paketFiyatTextBox.TabIndex = 7;
            this.paketFiyatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paketFiyatTextBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyatı";
            // 
            // paketAkkTextBox
            // 
            this.paketAkkTextBox.Location = new System.Drawing.Point(9, 99);
            this.paketAkkTextBox.Name = "paketAkkTextBox";
            this.paketAkkTextBox.Size = new System.Drawing.Size(125, 20);
            this.paketAkkTextBox.TabIndex = 5;
            this.paketAkkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paketAkkTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Adil Kullanım Kotası (AKK)";
            // 
            // paketAdTextBox
            // 
            this.paketAdTextBox.Location = new System.Drawing.Point(9, 50);
            this.paketAdTextBox.MaxLength = 10;
            this.paketAdTextBox.Name = "paketAdTextBox";
            this.paketAdTextBox.Size = new System.Drawing.Size(125, 20);
            this.paketAdTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı";
            // 
            // PaketEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaketEkle";
            this.ShowIcon = false;
            this.Text = "Paket Ekleme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox paketFiyatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox paketAkkTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox paketAdTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taahhutTextBox;
    }
}