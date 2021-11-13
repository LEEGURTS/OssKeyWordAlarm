
namespace OssKeyWordAlarm.Forms
{
    partial class Notice
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbltitle = new System.Windows.Forms.Label();
            this.lblLink = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(25, 16);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(103, 16);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "글 공지 테스트";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLink.ForeColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(57, 41);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(36, 12);
            this.lblLink.TabIndex = 1;
            this.lblLink.Text = "label1";
            // 
            // Notice
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.lbltitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Notice";
            this.Size = new System.Drawing.Size(500, 70);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notice_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Label lblLink;
    }
}
