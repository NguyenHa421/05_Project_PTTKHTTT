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
            btn_findwork = new Button();
            pic_findwork = new PictureBox();
            pn_apply = new Panel();
            btn_apply = new Button();
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
            pn_parent.Name = "pn_parent";
            pn_parent.Size = new Size(895, 425);
            pn_parent.TabIndex = 1;
            // 
            // pn_findwork
            // 
            pn_findwork.BackColor = Color.White;
            pn_findwork.BackgroundImage = Properties.Resources.Bg_icon;
            pn_findwork.BackgroundImageLayout = ImageLayout.Zoom;
            pn_findwork.Controls.Add(btn_findwork);
            pn_findwork.Controls.Add(pic_findwork);
            pn_findwork.Location = new Point(116, 79);
            pn_findwork.Name = "pn_findwork";
            pn_findwork.Size = new Size(234, 244);
            pn_findwork.TabIndex = 4;
            // 
            // btn_findwork
            // 
            btn_findwork.BackgroundImage = Properties.Resources.button_2;
            btn_findwork.BackgroundImageLayout = ImageLayout.Zoom;
            btn_findwork.FlatStyle = FlatStyle.Flat;
            btn_findwork.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_findwork.ForeColor = Color.White;
            btn_findwork.Location = new Point(25, 183);
            btn_findwork.Name = "btn_findwork";
            btn_findwork.Size = new Size(177, 45);
            btn_findwork.TabIndex = 1;
            btn_findwork.Text = "Tìm việc";
            btn_findwork.UseVisualStyleBackColor = true;
            // 
            // pic_findwork
            // 
            pic_findwork.Image = Properties.Resources.search_vacancy;
            pic_findwork.Location = new Point(25, 19);
            pic_findwork.Name = "pic_findwork";
            pic_findwork.Size = new Size(177, 148);
            pic_findwork.SizeMode = PictureBoxSizeMode.Zoom;
            pic_findwork.TabIndex = 1;
            pic_findwork.TabStop = false;
            // 
            // pn_apply
            // 
            pn_apply.BackColor = Color.White;
            pn_apply.BackgroundImage = Properties.Resources.Bg_icon;
            pn_apply.BackgroundImageLayout = ImageLayout.Zoom;
            pn_apply.Controls.Add(btn_apply);
            pn_apply.Controls.Add(pic_apply);
            pn_apply.Location = new Point(515, 79);
            pn_apply.Name = "pn_apply";
            pn_apply.Size = new Size(234, 244);
            pn_apply.TabIndex = 5;
            // 
            // btn_apply
            // 
            btn_apply.BackgroundImage = Properties.Resources.button_2;
            btn_apply.BackgroundImageLayout = ImageLayout.Zoom;
            btn_apply.FlatStyle = FlatStyle.Flat;
            btn_apply.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_apply.ForeColor = Color.White;
            btn_apply.Location = new Point(28, 183);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new Size(177, 45);
            btn_apply.TabIndex = 1;
            btn_apply.Text = "Tình trạng hồ sơ";
            btn_apply.UseVisualStyleBackColor = true;
            // 
            // pic_apply
            // 
            pic_apply.Image = Properties.Resources.apply;
            pic_apply.Location = new Point(28, 19);
            pic_apply.Name = "pic_apply";
            pic_apply.Size = new Size(177, 148);
            pic_apply.SizeMode = PictureBoxSizeMode.Zoom;
            pic_apply.TabIndex = 1;
            pic_apply.TabStop = false;
            // 
            // C_Homepage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(pn_parent);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button btn_findwork;
        private PictureBox pic_findwork;
        private Panel pn_apply;
        private Button btn_apply;
        private PictureBox pic_apply;
    }
}