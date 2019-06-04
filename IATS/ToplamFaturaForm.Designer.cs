namespace IATS
{
    partial class total
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.genelToplamTabPage = new System.Windows.Forms.TabPage();
            this.genelToplamPanel = new System.Windows.Forms.Panel();
            this.totalPaketLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalAboneLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.totalGelirLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.paketToplamTabPage = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.paketAdTextBox = new System.Windows.Forms.TextBox();
            this.getirButton = new System.Windows.Forms.Button();
            this.paketTotalAboneLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.paketTotalGelirLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.genelToplamTabPage.SuspendLayout();
            this.genelToplamPanel.SuspendLayout();
            this.paketToplamTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.genelToplamTabPage);
            this.tabControl1.Controls.Add(this.paketToplamTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 361);
            this.tabControl1.TabIndex = 1;
            // 
            // genelToplamTabPage
            // 
            this.genelToplamTabPage.Controls.Add(this.genelToplamPanel);
            this.genelToplamTabPage.Location = new System.Drawing.Point(4, 22);
            this.genelToplamTabPage.Name = "genelToplamTabPage";
            this.genelToplamTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.genelToplamTabPage.Size = new System.Drawing.Size(776, 335);
            this.genelToplamTabPage.TabIndex = 0;
            this.genelToplamTabPage.Text = "Genel Toplam";
            this.genelToplamTabPage.UseVisualStyleBackColor = true;
            // 
            // genelToplamPanel
            // 
            this.genelToplamPanel.BackColor = System.Drawing.SystemColors.Control;
            this.genelToplamPanel.Controls.Add(this.totalPaketLabel);
            this.genelToplamPanel.Controls.Add(this.label6);
            this.genelToplamPanel.Controls.Add(this.totalAboneLabel);
            this.genelToplamPanel.Controls.Add(this.label1);
            this.genelToplamPanel.Controls.Add(this.totalGelirLabel);
            this.genelToplamPanel.Controls.Add(this.label2);
            this.genelToplamPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.genelToplamPanel.Location = new System.Drawing.Point(3, 3);
            this.genelToplamPanel.Name = "genelToplamPanel";
            this.genelToplamPanel.Size = new System.Drawing.Size(770, 329);
            this.genelToplamPanel.TabIndex = 1;
            this.genelToplamPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.genelToplamPanel_Paint);
            // 
            // totalPaketLabel
            // 
            this.totalPaketLabel.AutoSize = true;
            this.totalPaketLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPaketLabel.Location = new System.Drawing.Point(222, 93);
            this.totalPaketLabel.Name = "totalPaketLabel";
            this.totalPaketLabel.Size = new System.Drawing.Size(124, 135);
            this.totalPaketLabel.TabIndex = 7;
            this.totalPaketLabel.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(241, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Toplam Paket Sayısı";
            // 
            // totalAboneLabel
            // 
            this.totalAboneLabel.AutoSize = true;
            this.totalAboneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalAboneLabel.Location = new System.Drawing.Point(-3, 93);
            this.totalAboneLabel.Name = "totalAboneLabel";
            this.totalAboneLabel.Size = new System.Drawing.Size(191, 135);
            this.totalAboneLabel.TabIndex = 5;
            this.totalAboneLabel.Text = "42";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Toplam Abone Sayısı";
            // 
            // totalGelirLabel
            // 
            this.totalGelirLabel.AutoSize = true;
            this.totalGelirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalGelirLabel.Location = new System.Drawing.Point(440, 93);
            this.totalGelirLabel.Name = "totalGelirLabel";
            this.totalGelirLabel.Size = new System.Drawing.Size(325, 135);
            this.totalGelirLabel.TabIndex = 3;
            this.totalGelirLabel.Text = "333₺";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(459, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Toplam Fatura Geliri";
            // 
            // paketToplamTabPage
            // 
            this.paketToplamTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.paketToplamTabPage.Controls.Add(this.label11);
            this.paketToplamTabPage.Controls.Add(this.paketAdTextBox);
            this.paketToplamTabPage.Controls.Add(this.getirButton);
            this.paketToplamTabPage.Controls.Add(this.paketTotalAboneLabel);
            this.paketToplamTabPage.Controls.Add(this.label8);
            this.paketToplamTabPage.Controls.Add(this.paketTotalGelirLabel);
            this.paketToplamTabPage.Controls.Add(this.label10);
            this.paketToplamTabPage.Location = new System.Drawing.Point(4, 22);
            this.paketToplamTabPage.Name = "paketToplamTabPage";
            this.paketToplamTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.paketToplamTabPage.Size = new System.Drawing.Size(776, 335);
            this.paketToplamTabPage.TabIndex = 1;
            this.paketToplamTabPage.Text = "Paket Toplamı";
            this.paketToplamTabPage.Click += new System.EventHandler(this.paketToplamTabPage_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Paket Adını Giriniz";
            // 
            // paketAdTextBox
            // 
            this.paketAdTextBox.Location = new System.Drawing.Point(36, 46);
            this.paketAdTextBox.Name = "paketAdTextBox";
            this.paketAdTextBox.Size = new System.Drawing.Size(136, 20);
            this.paketAdTextBox.TabIndex = 13;
            // 
            // getirButton
            // 
            this.getirButton.Location = new System.Drawing.Point(178, 44);
            this.getirButton.Name = "getirButton";
            this.getirButton.Size = new System.Drawing.Size(75, 23);
            this.getirButton.TabIndex = 12;
            this.getirButton.Text = "Getir";
            this.getirButton.UseVisualStyleBackColor = true;
            this.getirButton.Click += new System.EventHandler(this.getirButton_Click);
            // 
            // paketTotalAboneLabel
            // 
            this.paketTotalAboneLabel.AutoSize = true;
            this.paketTotalAboneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paketTotalAboneLabel.Location = new System.Drawing.Point(225, 168);
            this.paketTotalAboneLabel.Name = "paketTotalAboneLabel";
            this.paketTotalAboneLabel.Size = new System.Drawing.Size(0, 135);
            this.paketTotalAboneLabel.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(244, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Toplam Abone Sayısı";
            // 
            // paketTotalGelirLabel
            // 
            this.paketTotalGelirLabel.AutoSize = true;
            this.paketTotalGelirLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paketTotalGelirLabel.Location = new System.Drawing.Point(443, 168);
            this.paketTotalGelirLabel.Name = "paketTotalGelirLabel";
            this.paketTotalGelirLabel.Size = new System.Drawing.Size(0, 135);
            this.paketTotalGelirLabel.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(462, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Toplam Fatura Geliri";
            // 
            // total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "total";
            this.ShowIcon = false;
            this.Text = "Toplam Fatura Bilgisi";
            this.tabControl1.ResumeLayout(false);
            this.genelToplamTabPage.ResumeLayout(false);
            this.genelToplamPanel.ResumeLayout(false);
            this.genelToplamPanel.PerformLayout();
            this.paketToplamTabPage.ResumeLayout(false);
            this.paketToplamTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage genelToplamTabPage;
        private System.Windows.Forms.Panel genelToplamPanel;
        private System.Windows.Forms.Label totalPaketLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label totalAboneLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalGelirLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage paketToplamTabPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox paketAdTextBox;
        private System.Windows.Forms.Button getirButton;
        private System.Windows.Forms.Label paketTotalAboneLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label paketTotalGelirLabel;
        private System.Windows.Forms.Label label10;
    }
}