namespace WindowsFormsApp1
{
    partial class frmFriends
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
            this.lblUrl = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.lblFriends = new System.Windows.Forms.Label();
            this.lstFriends = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.butFetch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(12, 15);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(122, 13);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "Steam Friend Page URL";
            // 
            // tbUrl
            // 
            this.tbUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUrl.Location = new System.Drawing.Point(140, 12);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(567, 20);
            this.tbUrl.TabIndex = 1;
            this.tbUrl.Text = "https://steamcommunity.com/id/xxxxx/friends/";
            this.tbUrl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUrl_KeyPress);
            // 
            // lblFriends
            // 
            this.lblFriends.AutoSize = true;
            this.lblFriends.Location = new System.Drawing.Point(12, 39);
            this.lblFriends.Name = "lblFriends";
            this.lblFriends.Size = new System.Drawing.Size(41, 13);
            this.lblFriends.TabIndex = 2;
            this.lblFriends.Text = "Friends";
            // 
            // lstFriends
            // 
            this.lstFriends.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstFriends.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstFriends.HideSelection = false;
            this.lstFriends.Location = new System.Drawing.Point(12, 55);
            this.lstFriends.Name = "lstFriends";
            this.lstFriends.Size = new System.Drawing.Size(776, 383);
            this.lstFriends.TabIndex = 3;
            this.lstFriends.UseCompatibleStateImageBehavior = false;
            this.lstFriends.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Account Name";
            this.columnHeader1.Width = 772;
            // 
            // butFetch
            // 
            this.butFetch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butFetch.Location = new System.Drawing.Point(713, 10);
            this.butFetch.Name = "butFetch";
            this.butFetch.Size = new System.Drawing.Size(75, 23);
            this.butFetch.TabIndex = 4;
            this.butFetch.Text = "Fetch";
            this.butFetch.UseVisualStyleBackColor = true;
            this.butFetch.Click += new System.EventHandler(this.butFetch_Click);
            // 
            // frmFriends
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butFetch);
            this.Controls.Add(this.lstFriends);
            this.Controls.Add(this.lblFriends);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.lblUrl);
            this.Name = "frmFriends";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.Label lblFriends;
        private System.Windows.Forms.ListView lstFriends;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button butFetch;
    }
}

