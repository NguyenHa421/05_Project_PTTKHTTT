namespace _05_Project_PTTKHTTT.Personnel
{
    partial class P_CandidateProfile
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
            btn_update = new Button();
            btn_back = new Button();
            lb_Info = new Label();
            ptn_refresh = new PictureBox();
            btn_search = new Button();
            dtGrid_CandidateCV = new DataGridView();
            tb_compName = new TextBox();
            lb_compName = new Label();
            pn_parents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_CandidateCV).BeginInit();
            SuspendLayout();
            // 
            // pn_parents
            // 
            pn_parents.Controls.Add(btn_update);
            pn_parents.Controls.Add(btn_back);
            pn_parents.Controls.Add(lb_Info);
            pn_parents.Controls.Add(ptn_refresh);
            pn_parents.Controls.Add(btn_search);
            pn_parents.Controls.Add(dtGrid_CandidateCV);
            pn_parents.Controls.Add(tb_compName);
            pn_parents.Controls.Add(lb_compName);
            pn_parents.Location = new Point(0, 0);
            pn_parents.Name = "pn_parents";
            pn_parents.Size = new Size(895, 425);
            pn_parents.TabIndex = 4;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.White;
            btn_update.BackgroundImage = Properties.Resources.button_round21;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_update.ForeColor = SystemColors.Window;
            btn_update.Location = new Point(648, 376);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(91, 38);
            btn_update.TabIndex = 123;
            btn_update.Text = "Cập nhật";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.White;
            btn_back.BackgroundImage = Properties.Resources.button_round21;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_back.ForeColor = SystemColors.Window;
            btn_back.Location = new Point(775, 376);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(91, 38);
            btn_back.TabIndex = 121;
            btn_back.Text = "Quay lại";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(293, 10);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(280, 31);
            lb_Info.TabIndex = 120;
            lb_Info.Text = "Danh sách hồ sơ ứng viên";
            // 
            // ptn_refresh
            // 
            ptn_refresh.Image = Properties.Resources.refresh_buttons;
            ptn_refresh.Location = new Point(708, 52);
            ptn_refresh.Name = "ptn_refresh";
            ptn_refresh.Size = new Size(49, 39);
            ptn_refresh.SizeMode = PictureBoxSizeMode.Zoom;
            ptn_refresh.TabIndex = 119;
            ptn_refresh.TabStop = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.White;
            btn_search.BackgroundImage = Properties.Resources.button_round22;
            btn_search.FlatAppearance.BorderSize = 0;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search.ForeColor = SystemColors.Window;
            btn_search.Location = new Point(775, 52);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(91, 38);
            btn_search.TabIndex = 118;
            btn_search.Text = "Tìm kiếm";
            btn_search.UseVisualStyleBackColor = false;
            // 
            // dtGrid_CandidateCV
            // 
            dtGrid_CandidateCV.BackgroundColor = SystemColors.Control;
            dtGrid_CandidateCV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_CandidateCV.Location = new Point(32, 100);
            dtGrid_CandidateCV.Name = "dtGrid_CandidateCV";
            dtGrid_CandidateCV.RowHeadersWidth = 51;
            dtGrid_CandidateCV.Size = new Size(834, 267);
            dtGrid_CandidateCV.TabIndex = 116;
            // 
            // tb_compName
            // 
            tb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_compName.Location = new Point(198, 54);
            tb_compName.Name = "tb_compName";
            tb_compName.Size = new Size(494, 34);
            tb_compName.TabIndex = 115;
            tb_compName.TabStop = false;
            // 
            // lb_compName
            // 
            lb_compName.AutoSize = true;
            lb_compName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_compName.Location = new Point(32, 57);
            lb_compName.Name = "lb_compName";
            lb_compName.Size = new Size(168, 28);
            lb_compName.TabIndex = 114;
            lb_compName.Text = "Tên doanh nghiệp";
            // 
            // P_CandidateProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parents);
            FormBorderStyle = FormBorderStyle.None;
            Name = "P_CandidateProfile";
            StartPosition = FormStartPosition.CenterParent;
            Text = "P_CandidateProfile";
            pn_parents.ResumeLayout(false);
            pn_parents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptn_refresh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_CandidateCV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parents;
        private Button btn_update;
        private Button btn_back;
        private Label lb_Info;
        private PictureBox ptn_refresh;
        private Button btn_search;
        private DataGridView dtGrid_CandidateCV;
        private TextBox tb_compName;
        private Label lb_compName;
    }
}