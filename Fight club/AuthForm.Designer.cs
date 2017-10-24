namespace Fight_club
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rtbName = new System.Windows.Forms.RichTextBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblBoxEmpty = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblBoxEmpty);
            this.groupBox1.Controls.Add(this.rtbName);
            this.groupBox1.Controls.Add(this.btnPlay);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 116);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter your name";
            // 
            // rtbName
            // 
            this.rtbName.Location = new System.Drawing.Point(68, 38);
            this.rtbName.Multiline = false;
            this.rtbName.Name = "rtbName";
            this.rtbName.Size = new System.Drawing.Size(173, 23);
            this.rtbName.TabIndex = 3;
            this.rtbName.Text = "";
            this.rtbName.WordWrap = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(118, 67);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblBoxEmpty
            // 
            this.lblBoxEmpty.AutoSize = true;
            this.lblBoxEmpty.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBoxEmpty.ForeColor = System.Drawing.Color.Red;
            this.lblBoxEmpty.Location = new System.Drawing.Point(71, 96);
            this.lblBoxEmpty.Name = "lblBoxEmpty";
            this.lblBoxEmpty.Size = new System.Drawing.Size(166, 17);
            this.lblBoxEmpty.TabIndex = 4;
            this.lblBoxEmpty.Text = "Name can\'t be empty!!!";
            this.lblBoxEmpty.Visible = false;
            // 
            // AuthForm
            // 
            this.AcceptButton = this.btnPlay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 116);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtbName;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblBoxEmpty;
    }
}