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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogrencipaneli));
            lblhosgeldin = new Label();
            dgvdersprogrami = new DataGridView();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvdersprogrami).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblhosgeldin
            // 
            lblhosgeldin.AutoSize = true;
            lblhosgeldin.Font = new Font("Segoe UI", 15F);
            lblhosgeldin.ForeColor = Color.MidnightBlue;
            lblhosgeldin.Location = new Point(12, 9);
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
            dgvdersprogrami.BackgroundColor = Color.White;
            dgvdersprogrami.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdersprogrami.Location = new Point(12, 65);
            dgvdersprogrami.Name = "dgvdersprogrami";
            dgvdersprogrami.ReadOnly = true;
            dgvdersprogrami.RowHeadersVisible = false;
            dgvdersprogrami.RowHeadersWidth = 51;
            dgvdersprogrami.RowTemplate.Height = 30;
            dgvdersprogrami.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvdersprogrami.Size = new Size(1118, 297);
            dgvdersprogrami.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 368);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(373, 247);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(675, 438);
            button1.Name = "button1";
            button1.Size = new Size(234, 105);
            button1.TabIndex = 3;
            button1.Text = "programı yenile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ogrencipaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 627);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(dgvdersprogrami);
            Controls.Add(lblhosgeldin);
            Name = "ogrencipaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ogrencipaneli";
            Load += ogrencipaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dgvdersprogrami).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblhosgeldin;
        private DataGridView dgvdersprogrami;
        private PictureBox pictureBox1;
        private Button button1;
    }
}