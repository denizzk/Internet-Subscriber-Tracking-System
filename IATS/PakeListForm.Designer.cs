namespace IATS
{
    partial class PaketList
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
            this.bulButton = new System.Windows.Forms.Button();
            this.paketListDataGridView = new System.Windows.Forms.DataGridView();
            this.paketAdTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.paketListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Paket Adı";
            // 
            // bulButton
            // 
            this.bulButton.Location = new System.Drawing.Point(192, 69);
            this.bulButton.Name = "bulButton";
            this.bulButton.Size = new System.Drawing.Size(75, 20);
            this.bulButton.TabIndex = 55;
            this.bulButton.Text = "Bul";
            this.bulButton.UseVisualStyleBackColor = true;
            this.bulButton.Click += new System.EventHandler(this.bulButton_Click);
            // 
            // paketListDataGridView
            // 
            this.paketListDataGridView.AllowUserToAddRows = false;
            this.paketListDataGridView.AllowUserToDeleteRows = false;
            this.paketListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paketListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.paketListDataGridView.Location = new System.Drawing.Point(0, 137);
            this.paketListDataGridView.Name = "paketListDataGridView";
            this.paketListDataGridView.ReadOnly = true;
            this.paketListDataGridView.Size = new System.Drawing.Size(443, 170);
            this.paketListDataGridView.TabIndex = 54;
            // 
            // paketAdTextBox
            // 
            this.paketAdTextBox.Location = new System.Drawing.Point(16, 68);
            this.paketAdTextBox.Name = "paketAdTextBox";
            this.paketAdTextBox.Size = new System.Drawing.Size(135, 20);
            this.paketAdTextBox.TabIndex = 57;
            // 
            // PaketList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 307);
            this.Controls.Add(this.paketAdTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bulButton);
            this.Controls.Add(this.paketListDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaketList";
            this.ShowIcon = false;
            this.Text = "Paket Görüntüleme";
            this.Load += new System.EventHandler(this.PaketList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paketListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bulButton;
        private System.Windows.Forms.DataGridView paketListDataGridView;
        private System.Windows.Forms.TextBox paketAdTextBox;
    }
}