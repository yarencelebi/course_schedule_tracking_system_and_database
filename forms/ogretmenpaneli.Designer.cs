namespace veritabanı_ui.forms
{
    partial class ogretmenpaneli
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ogretmenpaneli));
            lblyazi = new Label();
            dgvhocaprogram = new DataGridView();
            lblogrencilist = new Label();
            dgvogrencilist = new DataGridView();
            refresh = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvhocaprogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvogrencilist).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblyazi
            // 
            lblyazi.AutoSize = true;
            lblyazi.Font = new Font("Segoe UI", 16F);
            lblyazi.Location = new Point(12, 20);
            lblyazi.Name = "lblyazi";
            lblyazi.Size = new Size(90, 37);
            lblyazi.TabIndex = 0;
            lblyazi.Text = "label1";
            lblyazi.Click += lblyazi_Click;
            // 
            // dgvhocaprogram
            // 
            dgvhocaprogram.AllowUserToAddRows = false;
            dgvhocaprogram.AllowUserToDeleteRows = false;
            dgvhocaprogram.AllowUserToResizeColumns = false;
            dgvhocaprogram.AllowUserToResizeRows = false;
            dgvhocaprogram.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvhocaprogram.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvhocaprogram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvhocaprogram.DefaultCellStyle = dataGridViewCellStyle2;
            dgvhocaprogram.Location = new Point(12, 75);
            dgvhocaprogram.Name = "dgvhocaprogram";
            dgvhocaprogram.ReadOnly = true;
            dgvhocaprogram.RowHeadersWidth = 51;
            dgvhocaprogram.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvhocaprogram.Size = new Size(784, 192);
            dgvhocaprogram.TabIndex = 1;
            dgvhocaprogram.CellContentClick += dataGridView1_CellContentClick;
            dgvhocaprogram.SelectionChanged += dgvhocaprogram_SelectionChanged;
            // 
            // lblogrencilist
            // 
            lblogrencilist.AutoSize = true;
            lblogrencilist.Font = new Font("Segoe UI", 16F);
            lblogrencilist.Location = new Point(12, 334);
            lblogrencilist.Name = "lblogrencilist";
            lblogrencilist.Size = new Size(90, 37);
            lblogrencilist.TabIndex = 2;
            lblogrencilist.Text = "label1";
            lblogrencilist.Click += lblogrencilist_Click;
            // 
            // dgvogrencilist
            // 
            dgvogrencilist.AllowUserToAddRows = false;
            dgvogrencilist.AllowUserToDeleteRows = false;
            dgvogrencilist.AllowUserToResizeColumns = false;
            dgvogrencilist.AllowUserToResizeRows = false;
            dgvogrencilist.BackgroundColor = SystemColors.Control;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvogrencilist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvogrencilist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvogrencilist.DefaultCellStyle = dataGridViewCellStyle4;
            dgvogrencilist.Location = new Point(12, 396);
            dgvogrencilist.Name = "dgvogrencilist";
            dgvogrencilist.ReadOnly = true;
            dgvogrencilist.RowHeadersWidth = 51;
            dgvogrencilist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvogrencilist.Size = new Size(564, 190);
            dgvogrencilist.TabIndex = 3;
            dgvogrencilist.CellContentClick += dataGridView2_CellContentClick;
            dgvogrencilist.SelectionChanged += dgvogrencilist_SelectionChanged;
            // 
            // refresh
            // 
            refresh.Font = new Font("Segoe UI", 15F);
            refresh.Location = new Point(901, 114);
            refresh.Name = "refresh";
            refresh.Size = new Size(186, 87);
            refresh.TabIndex = 4;
            refresh.Text = "refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(607, 396);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(480, 190);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ogretmenpaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 598);
            Controls.Add(pictureBox2);
            Controls.Add(refresh);
            Controls.Add(dgvogrencilist);
            Controls.Add(lblogrencilist);
            Controls.Add(dgvhocaprogram);
            Controls.Add(lblyazi);
            Font = new Font("Segoe UI", 9F);
            Name = "ogretmenpaneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ogretmenpaneli";
            Load += ogretmenpaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhocaprogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvogrencilist).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblyazi;
        private DataGridView dgvhocaprogram;
        private Label lblogrencilist;
        private DataGridView dgvogrencilist;
        private Button refresh;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}