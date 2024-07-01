namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_CompanyList
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
            btn_back = new Button();
            lb_Info = new Label();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            btn_add = new Button();
            dtGrid_companyList = new DataGridView();
            tb_compName = new TextBox();
            lb_name = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_companyList).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(btn_back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Controls.Add(ptn_refresh);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(btn_add);
            pn_parents.Controls.Add(dtGrid_companyList);
            pn_parents.Controls.Add(tb_compName);
            pn_parents.Controls.Add(lb_name);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Margin = new Padding(3, 2, 3, 2);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(783, 319);
            pn_parents.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.BackgroundImage = Properties.Resources.button_round21;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_back.ForeColor = SystemColors.Window;
            btn_back.Location = new Point(668, 282);
            btn_back.Margin = new Padding(3, 2, 3, 2);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(80, 28);
            btn_back.TabIndex = 121;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(287, 8);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(217, 25);
            lb_Info.TabIndex = 120;
            lb_Info.Text = "Thông tin doanh nghiệp";
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(616, 41);
            ptn_refresh.Margin = new Padding(3, 2, 3, 2);
            ptn_refresh.Name = "ptn_refresh";
            ptn_refresh.Size = new Size(43, 29);
            ptn_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            ptn_refresh.TabIndex = 119;
            ptn_refresh.TabStop = false;
            ptn_refresh.Click += ptn_refresh_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round22;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(668, 41);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(80, 28);
            btn_search.TabIndex = 118;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.White;
            btn_add.BackgroundImage = Properties.Resources.button_round21;
            btn_add.FlatAppearance.BorderSize = 0;
            btn_add.FlatStyle = FlatStyle.Flat;
            btn_add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_add.ForeColor = SystemColors.Window;
            btn_add.Location = new Point(553, 282);
            btn_add.Margin = new Padding(3, 2, 3, 2);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(80, 28);
            btn_add.TabIndex = 117;
            btn_add.Text = "Tạo mới";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // dtGrid_companyList
            // 
            dtGrid_companyList.BackgroundColor = SystemColors.Control;
            dtGrid_companyList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_companyList.Location = new Point(34, 79);
            dtGrid_companyList.Margin = new Padding(3, 2, 3, 2);
            dtGrid_companyList.Name = "dtGrid_companyList";
            dtGrid_companyList.RowHeadersWidth = 51;
            dtGrid_companyList.Size = new Size(714, 196);
            dtGrid_companyList.TabIndex = 116;
            dtGrid_companyList.CellContentClick += dtGrid_companyList_CellContentClick;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(178, 44);
            tb_compName.Margin = new Padding(3, 2, 3, 2);
            tb_compName.Name = "tb_compName";
            tb_compName.Size = new Size(423, 29);
            tb_compName.TabIndex = 115;
            tb_compName.TabStop = false;
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(34, 46);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(133, 21);
            lb_name.TabIndex = 114;
            lb_name.Text = "Tên doanh nghiệp";
            // 
            // P_CompanyList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "P_CompanyList";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_CompanyList";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_companyList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button btn_back;
        private Label lb_Info;
        private PictureBox ptn_refresh;
        private Button btn_search;
        private Button btn_add;
        private DataGridView dtGrid_companyList;
        private TextBox tb_compName;
        private Label lb_name;
    }
}