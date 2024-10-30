namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Tb_CreatedNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_CreateNum = new Guna.UI2.WinForms.Guna2Button();
            this.Cb_Special = new Guna.UI2.WinForms.Guna2CheckBox();
            this.Cb_BigEn = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TBar_Num = new Guna.UI2.WinForms.Guna2TrackBar();
            this.lb_num = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CtrlBox_exit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.SuspendLayout();
            // 
            // Tb_CreatedNum
            // 
            this.Tb_CreatedNum.Animated = true;
            this.Tb_CreatedNum.AutoRoundedCorners = true;
            this.Tb_CreatedNum.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Tb_CreatedNum.BorderRadius = 14;
            this.Tb_CreatedNum.BorderThickness = 2;
            this.Tb_CreatedNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Tb_CreatedNum.DefaultText = "";
            this.Tb_CreatedNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Tb_CreatedNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Tb_CreatedNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tb_CreatedNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Tb_CreatedNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tb_CreatedNum.Font = new System.Drawing.Font("고도 B", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_CreatedNum.ForeColor = System.Drawing.Color.Black;
            this.Tb_CreatedNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Tb_CreatedNum.Location = new System.Drawing.Point(12, 90);
            this.Tb_CreatedNum.Name = "Tb_CreatedNum";
            this.Tb_CreatedNum.PasswordChar = '\0';
            this.Tb_CreatedNum.PlaceholderText = "";
            this.Tb_CreatedNum.SelectedText = "";
            this.Tb_CreatedNum.Size = new System.Drawing.Size(481, 31);
            this.Tb_CreatedNum.TabIndex = 0;
            // 
            // Btn_CreateNum
            // 
            this.Btn_CreateNum.AutoRoundedCorners = true;
            this.Btn_CreateNum.BorderRadius = 21;
            this.Btn_CreateNum.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_CreateNum.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_CreateNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_CreateNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_CreateNum.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Btn_CreateNum.Font = new System.Drawing.Font("고도 B", 12F);
            this.Btn_CreateNum.ForeColor = System.Drawing.Color.White;
            this.Btn_CreateNum.Location = new System.Drawing.Point(12, 127);
            this.Btn_CreateNum.Name = "Btn_CreateNum";
            this.Btn_CreateNum.Size = new System.Drawing.Size(481, 45);
            this.Btn_CreateNum.TabIndex = 1;
            this.Btn_CreateNum.Text = "생성";
            this.Btn_CreateNum.Click += new System.EventHandler(this.Btn_CreateNum_Click);
            // 
            // Cb_Special
            // 
            this.Cb_Special.AutoSize = true;
            this.Cb_Special.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.Cb_Special.CheckedState.BorderRadius = 1;
            this.Cb_Special.CheckedState.BorderThickness = 2;
            this.Cb_Special.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Cb_Special.Font = new System.Drawing.Font("고도 B", 10F);
            this.Cb_Special.Location = new System.Drawing.Point(12, 38);
            this.Cb_Special.Name = "Cb_Special";
            this.Cb_Special.Size = new System.Drawing.Size(300, 20);
            this.Cb_Special.TabIndex = 3;
            this.Cb_Special.Text = "특수 문자 포함 (include special characters)";
            this.Cb_Special.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.Cb_Special.UncheckedState.BorderRadius = 1;
            this.Cb_Special.UncheckedState.BorderThickness = 2;
            this.Cb_Special.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // Cb_BigEn
            // 
            this.Cb_BigEn.AutoSize = true;
            this.Cb_BigEn.CheckedState.BorderColor = System.Drawing.Color.Black;
            this.Cb_BigEn.CheckedState.BorderRadius = 1;
            this.Cb_BigEn.CheckedState.BorderThickness = 2;
            this.Cb_BigEn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Cb_BigEn.Font = new System.Drawing.Font("고도 B", 10F);
            this.Cb_BigEn.Location = new System.Drawing.Point(12, 64);
            this.Cb_BigEn.Name = "Cb_BigEn";
            this.Cb_BigEn.Size = new System.Drawing.Size(280, 20);
            this.Cb_BigEn.TabIndex = 4;
            this.Cb_BigEn.Text = "대문자 포함 (include uppercase letters)";
            this.Cb_BigEn.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.Cb_BigEn.UncheckedState.BorderRadius = 1;
            this.Cb_BigEn.UncheckedState.BorderThickness = 2;
            this.Cb_BigEn.UncheckedState.FillColor = System.Drawing.Color.White;
            // 
            // TBar_Num
            // 
            this.TBar_Num.Location = new System.Drawing.Point(12, 9);
            this.TBar_Num.Name = "TBar_Num";
            this.TBar_Num.Size = new System.Drawing.Size(300, 23);
            this.TBar_Num.Style = Guna.UI2.WinForms.Enums.TrackBarStyle.Metro;
            this.TBar_Num.TabIndex = 5;
            this.TBar_Num.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TBar_Num.Value = 8;
            this.TBar_Num.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TBar_Num_Scroll);
            // 
            // lb_num
            // 
            this.lb_num.AutoSize = true;
            this.lb_num.Font = new System.Drawing.Font("고도 B", 15F);
            this.lb_num.Location = new System.Drawing.Point(318, 9);
            this.lb_num.Name = "lb_num";
            this.lb_num.Size = new System.Drawing.Size(23, 23);
            this.lb_num.TabIndex = 6;
            this.lb_num.Text = "8";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.AnimateWindow = true;
            this.guna2BorderlessForm1.AnimationInterval = 600;
            this.guna2BorderlessForm1.BorderRadius = 10;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // CtrlBox_exit
            // 
            this.CtrlBox_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlBox_exit.BackColor = System.Drawing.Color.White;
            this.CtrlBox_exit.FillColor = System.Drawing.SystemColors.Control;
            this.CtrlBox_exit.ForeColor = System.Drawing.Color.Black;
            this.CtrlBox_exit.IconColor = System.Drawing.Color.Black;
            this.CtrlBox_exit.Location = new System.Drawing.Point(473, 12);
            this.CtrlBox_exit.Name = "CtrlBox_exit";
            this.CtrlBox_exit.Size = new System.Drawing.Size(20, 20);
            this.CtrlBox_exit.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 181);
            this.Controls.Add(this.CtrlBox_exit);
            this.Controls.Add(this.lb_num);
            this.Controls.Add(this.TBar_Num);
            this.Controls.Add(this.Cb_BigEn);
            this.Controls.Add(this.Cb_Special);
            this.Controls.Add(this.Btn_CreateNum);
            this.Controls.Add(this.Tb_CreatedNum);
            this.Name = "Form1";
            this.Text = "비밀번호 랜덤 생성기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Tb_CreatedNum;
        private Guna.UI2.WinForms.Guna2Button Btn_CreateNum;
        private Guna.UI2.WinForms.Guna2CheckBox Cb_Special;
        private Guna.UI2.WinForms.Guna2CheckBox Cb_BigEn;
        private Guna.UI2.WinForms.Guna2TrackBar TBar_Num;
        private System.Windows.Forms.Label lb_num;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox CtrlBox_exit;
    }
}

