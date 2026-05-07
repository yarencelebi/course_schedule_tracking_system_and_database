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
            lblyazi = new Label();
            dgvhocaprogram = new DataGridView();
            lblogrencilist = new Label();
            dgvogrencilist = new DataGridView();
            refresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvhocaprogram).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvogrencilist).BeginInit();
            SuspendLayout();
            // 
            // lblyazi
            // 
            lblyazi.AutoSize = true;
            lblyazi.Font = new Font("Segoe UI", 16F);
            lblyazi.Location = new Point(38, 9);
            lblyazi.Name = "lblyazi";
            lblyazi.Size = new Size(90, 37);
            lblyazi.TabIndex = 0;
            lblyazi.Text = "label1";
            lblyazi.Click += lblyazi_Click;
            // 
            // dgvhocaprogram
            // 
            dgvhocaprogram.BackgroundColor = SystemColors.Control;
            dgvhocaprogram.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhocaprogram.Location = new Point(38, 95);
            dgvhocaprogram.Name = "dgvhocaprogram";
            dgvhocaprogram.ReadOnly = true;
            dgvhocaprogram.RowHeadersWidth = 51;
            dgvhocaprogram.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvhocaprogram.Size = new Size(1013, 209);
            dgvhocaprogram.TabIndex = 1;
            dgvhocaprogram.CellContentClick += dataGridView1_CellContentClick;
            dgvhocaprogram.SelectionChanged += dgvhocaprogram_SelectionChanged;
            // 
            // lblogrencilist
            // 
            lblogrencilist.AutoSize = true;
            lblogrencilist.Font = new Font("Segoe UI", 16F);
            lblogrencilist.Location = new Point(550, 9);
            lblogrencilist.Name = "lblogrencilist";
            lblogrencilist.Size = new Size(90, 37);
            lblogrencilist.TabIndex = 2;
            lblogrencilist.Text = "label1";
            lblogrencilist.Click += lblogrencilist_Click;
            // 
            // dgvogrencilist
            // 
            dgvogrencilist.BackgroundColor = SystemColors.Control;
            dgvogrencilist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvogrencilist.Location = new Point(38, 347);
            dgvogrencilist.Name = "dgvogrencilist";
            dgvogrencilist.ReadOnly = true;
            dgvogrencilist.RowHeadersWidth = 51;
            dgvogrencilist.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvogrencilist.Size = new Size(585, 209);
            dgvogrencilist.TabIndex = 3;
            dgvogrencilist.CellContentClick += dataGridView2_CellContentClick;
            dgvogrencilist.SelectionChanged += dgvogrencilist_SelectionChanged;
            // 
            // refresh
            // 
            refresh.Font = new Font("Segoe UI", 15F);
            refresh.Location = new Point(764, 390);
            refresh.Name = "refresh";
            refresh.Size = new Size(186, 87);
            refresh.TabIndex = 4;
            refresh.Text = "sayfayı yenile";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // ogretmenpaneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 598);
            Controls.Add(refresh);
            Controls.Add(dgvogrencilist);
            Controls.Add(lblogrencilist);
            Controls.Add(dgvhocaprogram);
            Controls.Add(lblyazi);
            Font = new Font("Segoe UI", 9F);
            Name = "ogretmenpaneli";
            Text = "ogretmenpaneli";
            Load += ogretmenpaneli_Load;
            ((System.ComponentModel.ISupportInitialize)dgvhocaprogram).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvogrencilist).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblyazi;
        private DataGridView dgvhocaprogram;
        private Label lblogrencilist;
        private DataGridView dgvogrencilist;
        private Button refresh;
    }
}