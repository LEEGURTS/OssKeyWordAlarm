﻿
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
            this.btnRemove_keyWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Keyword_TextBox
            // 
            this.Keyword_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Keyword_TextBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Keyword_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Keyword_TextBox.Font = new System.Drawing.Font("G마켓 산스 TTF Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Keyword_TextBox.Location = new System.Drawing.Point(540, 438);
            this.Keyword_TextBox.Name = "Keyword_TextBox";
            this.Keyword_TextBox.Size = new System.Drawing.Size(200, 19);
            this.Keyword_TextBox.TabIndex = 1;
            this.Keyword_TextBox.Text = "키워드를 입력하세요.";
            this.Keyword_TextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnKeyword_KeyDown);
            // 
            // keyWord_listBox
            // 
            this.keyWord_listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyWord_listBox.FormattingEnabled = true;
            this.keyWord_listBox.ItemHeight = 12;
            this.keyWord_listBox.Location = new System.Drawing.Point(66, 94);
            this.keyWord_listBox.Name = "keyWord_listBox";
            this.keyWord_listBox.Size = new System.Drawing.Size(330, 264);
            this.keyWord_listBox.TabIndex = 2;
            // 
            // btnRemove_keyWord
            // 
            this.btnRemove_keyWord.Location = new System.Drawing.Point(559, 207);
            this.btnRemove_keyWord.Name = "btnRemove_keyWord";
            this.btnRemove_keyWord.Size = new System.Drawing.Size(149, 106);
            this.btnRemove_keyWord.TabIndex = 3;
            this.btnRemove_keyWord.Text = "button1";
            this.btnRemove_keyWord.UseVisualStyleBackColor = true;
            this.btnRemove_keyWord.Click += new System.EventHandler(this.btnRemove_keyWord_Click);
            // 
            // makeKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(770, 489);
            this.Controls.Add(this.btnRemove_keyWord);
            this.Controls.Add(this.keyWord_listBox);
            this.Controls.Add(this.Keyword_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "makeKey";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.makeKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Keyword_TextBox;
        private System.Windows.Forms.ListBox keyWord_listBox;
        private System.Windows.Forms.Button btnRemove_keyWord;
    }
}