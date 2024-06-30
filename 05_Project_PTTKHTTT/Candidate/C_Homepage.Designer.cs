namespace _05_Project_PTTKHTTT.Candidate
{
    partial class C_Homepage
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
            pn_parent = new Panel();
            pn_findwork = new Panel();
            btn_findjob = new Button();
            pic_findwork = new PictureBox();
            pn_apply = new Panel();
            btn_applied = new Button();
            pic_apply = new PictureBox();
            pn_parent.SuspendLayout();
            pn_findwork.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_findwork).BeginInit();
            pn_apply.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_apply).BeginInit();
            SuspendLayout();
            // 
            // pn_parent
            // 
            pn_parent.BackgroundImage = Properties.Resources.plane2;
            pn_parent.Controls.Add(pn_findwork);
            pn_parent.Controls.Add(pn_apply);
            pn_parent.Location = new Point(0, 0);
            pn_parent.Margin = new Padding(3, 2, 3, 2);
            pn_parent.Name = "pn_parent";
            pn_parent.Size = new Size(783, 319);
            pn_parent.TabIndex = 1;
            // 
            // pn_findwork
            // 
            pn_findwork.BackColor = Color.White;
            pn_findwork.BackgroundImage = Properties.Resources.Bg_icon;
            pn_findwork.BackgroundImageLayout = ImageLayout.Zoom;
            pn_findwork.Controls.Add(btn_findjob);
            pn_findwork.Controls.Add(pic_findwork);
            pn_findwork.Location = new Point(102, 59);
            pn_findwork.Margin = new Padding(3, 2, 3, 2);
            pn_findwork.Name = "pn_findwork";
            pn_findwork.Size = new Size(205, 183);
            pn_findwork.TabIndex = 4;
            // 
            // btn_findjob
            // 
            btn_findjob.BackgroundImage = Properties.Resources.button_2;
            btn_findjob.BackgroundImageLayout = ImageLayout.Zoom;
            btn_findjob.FlatStyle = FlatStyle.Flat;
            btn_findjob.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_findjob.ForeColor = Color.White;
            btn_findjob.Location = new Point(22, 137);
            btn_findjob.Margin = new Padding(3, 2, 3, 2);
            btn_findjob.Name = "btn_findjob";
            btn_findjob.Size = new Size(155, 34);
            btn_findjob.TabIndex = 1;
            btn_findjob.Text = "Tìm việc";
            btn_findjob.UseVisualStyleBackColor = true;
            btn_findjob.Click += btn_findjob_Click;
            // 
            // pic_findwork
            // 
            pic_findwork.Image = Properties.Resources.search_vacancy;
            pic_findwork.Location = new Point(22, 14);
            pic_findwork.Margin = new Padding(3, 2, 3, 2);
            pic_findwork.Name = "pic_findwork";
            pic_findwork.Size = new Size(155, 111);
            pic_findwork.SizeMode = PictureBoxSizeMode.Zoom;
            pic_findwork.TabIndex = 1;
            pic_findwork.TabStop = false;
            // 
            // pn_apply
            // 
            pn_apply.BackColor = Color.White;
            pn_apply.BackgroundImage = Properties.Resources.Bg_icon;
            pn_apply.BackgroundImageLayout = ImageLayout.Zoom;
            pn_apply.Controls.Add(btn_applied);
            pn_apply.Controls.Add(pic_apply);
            pn_apply.Location = new Point(451, 59);
            pn_apply.Margin = new Padding(3, 2, 3, 2);
            pn_apply.Name = "pn_apply";
            pn_apply.Size = new Size(205, 183);
            pn_apply.TabIndex = 5;
            // 
            // btn_applied
            // 
            btn_applied.BackgroundImage = Properties.Resources.button_2;
            btn_applied.BackgroundImageLayout = ImageLayout.Zoom;
            btn_applied.FlatStyle = FlatStyle.Flat;
            btn_applied.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_applied.ForeColor = Color.White;
            btn_applied.Location = new Point(24, 137);
            btn_applied.Margin = new Padding(3, 2, 3, 2);
            btn_applied.Name = "btn_applied";
            btn_applied.Size = new Size(155, 34);
            btn_applied.TabIndex = 1;
            btn_applied.Text = "Tình trạng hồ sơ";
            btn_applied.UseVisualStyleBackColor = true;
            btn_applied.Click += btn_applied_Click;
            // 
            // pic_apply
            // 
            pic_apply.Image = Properties.Resources.apply;
            pic_apply.Location = new Point(24, 14);
            pic_apply.Margin = new Padding(3, 2, 3, 2);
            pic_apply.Name = "pic_apply";
            pic_apply.Size = new Size(155, 111);
            pic_apply.SizeMode = PictureBoxSizeMode.Zoom;
            pic_apply.TabIndex = 1;
            pic_apply.TabStop = false;
            // 
            // C_Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(783, 319);
            Controls.Add(pn_parent);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "C_Homepage";
            StartPosition = FormStartPosition.CenterParent;
            Text = "C_Homepage";
            pn_parent.ResumeLayout(false);
            pn_findwork.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_findwork).EndInit();
            pn_apply.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_apply).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_parent;
        private Panel pn_findwork;
        private Button btn_findjob;
        private PictureBox pic_findwork;
        private Panel pn_apply;
        private Button btn_applied;
        private PictureBox pic_apply;
    }
}