namespace IATS
{
    partial class PaketUpdate
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.paketFiyatTextBox = new System.Windows.Forms.TextBox();
            this.paketAkkTextBox = new System.Windows.Forms.TextBox();
            this.taahhutTextBox = new System.Windows.Forms.TextBox();
            this.paketAdLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.getirButton = new System.Windows.Forms.Button();
            this.getirPaketTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.paketFiyatTextBox);
            this.groupBox1.Controls.Add(this.paketAkkTextBox);
            this.groupBox1.Controls.Add(this.taahhutTextBox);
            this.groupBox1.Controls.Add(this.paketAdLabel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 170);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Paket";
            // 
            // paketFiyatTextBox
            // 
            this.paketFiyatTextBox.Location = new System.Drawing.Point(162, 51);
            this.paketFiyatTextBox.Name = "paketFiyatTextBox";
            this.paketFiyatTextBox.Size = new System.Drawing.Size(120, 20);
            this.paketFiyatTextBox.TabIndex = 58;
            this.paketFiyatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paketFiyatTextBox_KeyPress);
            // 
            // paketAkkTextBox
            // 
            this.paketAkkTextBox.Location = new System.Drawing.Point(9, 99);
            this.paketAkkTextBox.Name = "paketAkkTextBox";
            this.paketAkkTextBox.Size = new System.Drawing.Size(125, 20);
            this.paketAkkTextBox.TabIndex = 57;
            this.paketAkkTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.paketAkkTextBox_KeyPress);
            // 
            // taahhutTextBox
            // 
            this.taahhutTextBox.Location = new System.Drawing.Point(162, 99);
            this.taahhutTextBox.Name = "taahhutTextBox";
            this.taahhutTextBox.Size = new System.Drawing.Size(120, 20);
            this.taahhutTextBox.TabIndex = 56;
            this.taahhutTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.taahhutTextBox_KeyPress);
            // 
            // paketAdLabel
            // 
            this.paketAdLabel.AutoSize = true;
            this.paketAdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paketAdLabel.Location = new System.Drawing.Point(6, 51);
            this.paketAdLabel.Name = "paketAdLabel";
            this.paketAdLabel.Size = new System.Drawing.Size(0, 17);
            this.paketAdLabel.TabIndex = 55;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fiyatı";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adı";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(14, 290);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(260, 61);
            this.updateButton.TabIndex = 4;
            this.updateButton.Text = "GÜNCELLE";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // getirButton
            // 
            this.getirButton.Location = new System.Drawing.Point(10, 78);
            this.getirButton.Name = "getirButton";
            this.getirButton.Size = new System.Drawing.Size(273, 33);
            this.getirButton.TabIndex = 52;
            this.getirButton.Text = "Getir";
            this.getirButton.UseVisualStyleBackColor = true;
            this.getirButton.Click += new System.EventHandler(this.getirButton_Click);
            // 
            // getirPaketTextBox
            // 
            this.getirPaketTextBox.Location = new System.Drawing.Point(10, 42);
            this.getirPaketTextBox.MaxLength = 10;
            this.getirPaketTextBox.Name = "getirPaketTextBox";
            this.getirPaketTextBox.Size = new System.Drawing.Size(273, 20);
            this.getirPaketTextBox.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(206, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Güncellenecek Paketin Paket Adını Giriniz";
            // 
            // PaketUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.getirButton);
            this.Controls.Add(this.getirPaketTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaketUpdate";
            this.ShowIcon = false;
            this.Text = "Paket Güncelleme";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button getirButton;
        private System.Windows.Forms.TextBox getirPaketTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label paketAdLabel;
        private System.Windows.Forms.TextBox paketFiyatTextBox;
        private System.Windows.Forms.TextBox paketAkkTextBox;
        private System.Windows.Forms.TextBox taahhutTextBox;
    }
}