namespace veritabanı_ui.forms
{
    partial class ogrencipaneli
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
            lblhosgeldin = new Label();
            dgvdersprogrami = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdersprogrami).BeginInit();
            SuspendLayout();
            // 
            // lblhosgeldin
            // 
            lblhosgeldin.AutoSize = true;
            lblhosgeldin.Font = new Font("Segoe UI", 15F);
            lblhosgeldin.Location = new Point(369, 74);
            lblhosgeldin.Name = "lblhosgeldin";
            lblhosgeldin.Size = new Size(81, 35);
            lblhosgeldin.TabIndex = 0;
            lblhosgeldin.Text = "label1";
            // 
            // dgvdersprogrami
            // 
            dgvdersprogrami.AllowUserToAddRows = false;
            dgvdersprogrami.AllowUserToDeleteRows = false;
            dgvdersprogrami.AllowUserToResizeColumns = false;
            dgvdersprogrami.AllowUserToResizeRows = false;
            dgvdersprogrami.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdersprogrami.BackgroundColor = SystemColors.Control;
            dgvdersprogrami.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdersprogrami.Location = new Point(337, 172);
            dgvdersprogrami.Name = "dgvdersprogrami";
            dgvdersprogrami.ReadOnly = true;
            dgvdersprogrami.RowHeadersVisible = false;
            dgvdersprogrami.RowHeadersWidth = 51;
            dgvdersprogrami.Size = new Size(683, 271);
            dgvdersprogrami.TabIndex = 1;
            // 
            // ogrencipaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 627);
            Controls.Add(dgvdersprogrami);
            Controls.Add(lblhosgeldin);
            Name = "ogrencipaneli";
            Text = "ogrencipaneli";
            Load += ogrencipaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdersprogrami).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhosgeldin;
        private DataGridView dgvdersprogrami;
    }
}