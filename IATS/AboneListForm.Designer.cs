namespace IATS
{
    partial class AboneList
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
            this.aboneListDataGridView = new System.Windows.Forms.DataGridView();
            this.aboneBulButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.aboneTcTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aboneListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // aboneListDataGridView
            // 
            this.aboneListDataGridView.AllowUserToAddRows = false;
            this.aboneListDataGridView.AllowUserToDeleteRows = false;
            this.aboneListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aboneListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboneListDataGridView.Location = new System.Drawing.Point(0, 128);
            this.aboneListDataGridView.Name = "aboneListDataGridView";
            this.aboneListDataGridView.ReadOnly = true;
            this.aboneListDataGridView.Size = new System.Drawing.Size(780, 306);
            this.aboneListDataGridView.TabIndex = 0;
            // 
            // aboneBulButton
            // 
            this.aboneBulButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.aboneBulButton.Location = new System.Drawing.Point(192, 47);
            this.aboneBulButton.Name = "aboneBulButton";
            this.aboneBulButton.Size = new System.Drawing.Size(75, 20);
            this.aboneBulButton.TabIndex = 2;
            this.aboneBulButton.Text = "Bul";
            this.aboneBulButton.UseVisualStyleBackColor = true;
            this.aboneBulButton.Click += new System.EventHandler(this.aboneBulButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Abone T.C. Kimlik Numarası";
            // 
            // aboneTcTextBox
            // 
            this.aboneTcTextBox.Location = new System.Drawing.Point(16, 48);
            this.aboneTcTextBox.MaxLength = 11;
            this.aboneTcTextBox.Name = "aboneTcTextBox";
            this.aboneTcTextBox.Size = new System.Drawing.Size(135, 20);
            this.aboneTcTextBox.TabIndex = 55;
            this.aboneTcTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aboneTcTextBox_KeyPress);
            // 
            // AboneList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(780, 434);
            this.Controls.Add(this.aboneTcTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aboneBulButton);
            this.Controls.Add(this.aboneListDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboneList";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abone Görüntüleme";
            this.Load += new System.EventHandler(this.AboneList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aboneListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView aboneListDataGridView;
        private System.Windows.Forms.Button aboneBulButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox aboneTcTextBox;
    }
}