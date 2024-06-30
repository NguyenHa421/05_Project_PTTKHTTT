namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_ExpiredContract
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
            pn_parents = new Panel();
            btn_restore = new Button();
            btn_print = new Button();
            btn_back = new Button();
            lb_Info = new Label();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            btn_delete = new Button();
            dtGrid_expiredComp = new DataGridView();
            tb_compName = new TextBox();
            lb_compName = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_expiredComp).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(btn_restore);
            pn_parents.Controls.Add(btn_print);
            pn_parents.Controls.Add(btn_back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Controls.Add(ptn_refresh);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(btn_delete);
            pn_parents.Controls.Add(dtGrid_expiredComp);
            pn_parents.Controls.Add(tb_compName);
            pn_parents.Controls.Add(lb_compName);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Margin = new Padding(3, 2, 3, 2);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(783, 319);
            pn_parents.TabIndex = 3;
            // 
            // btn_restore
            // 
            btn_restore.BackColor = Color.White;
            btn_restore.BackgroundImage = Properties.Resources.button_round21;
            btn_restore.FlatAppearance.BorderSize = 0;
            btn_restore.FlatStyle = FlatStyle.Flat;
            btn_restore.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_restore.ForeColor = SystemColors.Window;
            btn_restore.Location = new Point(567, 282);
            btn_restore.Margin = new Padding(3, 2, 3, 2);
            btn_restore.Name = "btn_restore";
            btn_restore.Size = new Size(80, 28);
            btn_restore.TabIndex = 123;
            btn_restore.Text = "Khôi phục";
            btn_restore.UseVisualStyleBackColor = false;
            btn_restore.Click += btn_restore_Click_1;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.White;
            btn_print.BackgroundImage = Properties.Resources.button_round21;
            btn_print.FlatAppearance.BorderSize = 0;
            btn_print.FlatStyle = FlatStyle.Flat;
            btn_print.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_print.ForeColor = SystemColors.Window;
            btn_print.Location = new Point(325, 282);
            btn_print.Margin = new Padding(3, 2, 3, 2);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(80, 28);
            btn_print.TabIndex = 122;
            btn_print.Text = "In";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click_1;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.BackgroundImage = Properties.Resources.button_round21;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_back.ForeColor = SystemColors.Window;
            btn_back.Location = new Point(678, 282);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(80, 28);
            btn_back.TabIndex = 121;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click_1;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(244, 8);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(260, 25);
            lb_Info.TabIndex = 120;
            lb_Info.Text = "Danh sách hợp đồng hết hạn";
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(620, 39);
            ptn_refresh.Margin = new Padding(3, 2, 3, 2);
            ptn_refresh.Name = "ptn_refresh";
            ptn_refresh.Size = new Size(43, 29);
            ptn_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            ptn_refresh.TabIndex = 119;
            ptn_refresh.TabStop = false;
            ptn_refresh.Click += ptn_refresh_Click_1;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round22;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(678, 39);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(80, 28);
            btn_search.TabIndex = 118;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click_1;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.White;
            btn_delete.BackgroundImage = Properties.Resources.button_round21;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_delete.ForeColor = SystemColors.Window;
            btn_delete.Location = new Point(448, 282);
            btn_delete.Margin = new Padding(3, 2, 3, 2);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(80, 28);
            btn_delete.TabIndex = 117;
            btn_delete.Text = "Xóa";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click_1;
            // 
            // dtGrid_expiredComp
            // 
            dtGrid_expiredComp.BackgroundColor = SystemColors.Control;
            dtGrid_expiredComp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_expiredComp.Location = new Point(28, 75);
            dtGrid_expiredComp.Margin = new Padding(3, 2, 3, 2);
            dtGrid_expiredComp.Name = "dtGrid_expiredComp";
            dtGrid_expiredComp.RowHeadersWidth = 51;
            dtGrid_expiredComp.Size = new Size(730, 200);
            dtGrid_expiredComp.TabIndex = 116;
            dtGrid_expiredComp.CellContentClick += dtGrid_expiredComp_CellContentClick_1;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(173, 40);
            tb_compName.Margin = new Padding(3, 2, 3, 2);
            tb_compName.Name = "tb_compName";
            tb_compName.Size = new Size(433, 29);
            tb_compName.TabIndex = 115;
            tb_compName.TabStop = false;
            // 
            // lb_compName
            // 
            lb_compName.AutoSize = true;
            lb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_compName.Location = new Point(28, 43);
            lb_compName.Name = "lb_compName";
            lb_compName.Size = new Size(133, 21);
            lb_compName.TabIndex = 114;
            lb_compName.Text = "Tên doanh nghiệp";
            // 
            // P_ExpiredContract
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "P_ExpiredContract";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_ExpiredContract";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_expiredComp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button btn_restore;
        private Button btn_print;
        private Button btn_back;
        private Label lb_Info;
        private PictureBox ptn_refresh;
        private Button btn_search;
        private Button btn_delete;
        private DataGridView dtGrid_expiredComp;
        private TextBox tb_compName;
        private Label lb_compName;
    }
}