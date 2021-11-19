
namespace OssKeyWordAlarm
{
    partial class makeKey
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
            this.Keyword_TextBox = new System.Windows.Forms.TextBox();
            this.keyWord_listBox = new System.Windows.Forms.ListBox();
            this.pnlText = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlText.SuspendLayout();
            this.SuspendLayout();
            // 
            // Keyword_TextBox
            // 
            this.Keyword_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword_TextBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Keyword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keyword_TextBox.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Keyword_TextBox.Location = new System.Drawing.Point(479, 406);
            this.Keyword_TextBox.Name = "Keyword_TextBox";
            this.Keyword_TextBox.Size = new System.Drawing.Size(255, 19);
            this.Keyword_TextBox.TabIndex = 1;
            this.Keyword_TextBox.Text = "키워드를 입력하세요.";
            this.Keyword_TextBox.TextChanged += new System.EventHandler(this.Keyword_TextBox_TextChanged);
            this.Keyword_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKeyword_KeyDown);
            // 
            // keyWord_listBox
            // 
            this.keyWord_listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.keyWord_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyWord_listBox.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.keyWord_listBox.ForeColor = System.Drawing.Color.White;
            this.keyWord_listBox.FormattingEnabled = true;
            this.keyWord_listBox.ItemHeight = 15;
            this.keyWord_listBox.Location = new System.Drawing.Point(56, 140);
            this.keyWord_listBox.Margin = new System.Windows.Forms.Padding(15);
            this.keyWord_listBox.Name = "keyWord_listBox";
            this.keyWord_listBox.Size = new System.Drawing.Size(380, 285);
            this.keyWord_listBox.TabIndex = 10;
            // 
            // pnlText
            // 
            this.pnlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlText.Controls.Add(this.label1);
            this.pnlText.Location = new System.Drawing.Point(56, 87);
            this.pnlText.Name = "pnlText";
            this.pnlText.Size = new System.Drawing.Size(380, 75);
            this.pnlText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "키워드 리스트";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(88)))));
            this.panel1.Location = new System.Drawing.Point(56, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 101);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(52, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "자유롭게 키워드를 추가하거나 삭제하세요.";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = global::OssKeyWordAlarm.Properties.Resources.edit_32px;
            this.btnEdit.Location = new System.Drawing.Point(548, 160);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(186, 63);
            this.btnEdit.TabIndex = 14;
            this.btnEdit.Text = "   키워드 수정";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::OssKeyWordAlarm.Properties.Resources.broom_30px;
            this.btnClear.Location = new System.Drawing.Point(548, 241);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 63);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "   키워드 모두 삭제";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("아리따-돋움4.0(OTF)-Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::OssKeyWordAlarm.Properties.Resources.trash_30px;
            this.btnDelete.Location = new System.Drawing.Point(548, 324);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(186, 63);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "   키워드 삭제";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // makeKey
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlText);
            this.Controls.Add(this.keyWord_listBox);
            this.Controls.Add(this.Keyword_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "makeKey";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.makeKey_Load);
            this.pnlText.ResumeLayout(false);
            this.pnlText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Keyword_TextBox;
        private System.Windows.Forms.ListBox keyWord_listBox;

        private System.Windows.Forms.Panel pnlText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
    }
}