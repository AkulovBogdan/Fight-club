namespace Fight_club
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.gbPlayerHealth = new System.Windows.Forms.GroupBox();
            this.pbPlayer = new System.Windows.Forms.ProgressBar();
            this.gbEnemy = new System.Windows.Forms.GroupBox();
            this.gbEnemyHealth = new System.Windows.Forms.GroupBox();
            this.pbEnemy = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.gbBodyPart = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnLegs = new System.Windows.Forms.Button();
            this.btnTorso = new System.Windows.Forms.Button();
            this.btnHead = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gameLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbPlayer.SuspendLayout();
            this.gbPlayerHealth.SuspendLayout();
            this.gbEnemy.SuspendLayout();
            this.gbEnemyHealth.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.gbBodyPart.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox3);
            this.splitContainer1.Size = new System.Drawing.Size(809, 297);
            this.splitContainer1.SplitterDistance = 199;
            this.splitContainer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.gbPlayer, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbEnemy, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 199);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gbPlayer
            // 
            this.gbPlayer.Controls.Add(this.gbPlayerHealth);
            this.gbPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbPlayer.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPlayer.Location = new System.Drawing.Point(3, 3);
            this.gbPlayer.Name = "gbPlayer";
            this.gbPlayer.Size = new System.Drawing.Size(317, 193);
            this.gbPlayer.TabIndex = 0;
            this.gbPlayer.TabStop = false;
            this.gbPlayer.Text = "Player";
            // 
            // gbPlayerHealth
            // 
            this.gbPlayerHealth.Controls.Add(this.pbPlayer);
            this.gbPlayerHealth.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbPlayerHealth.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbPlayerHealth.Location = new System.Drawing.Point(3, 26);
            this.gbPlayerHealth.Name = "gbPlayerHealth";
            this.gbPlayerHealth.Size = new System.Drawing.Size(311, 46);
            this.gbPlayerHealth.TabIndex = 2;
            this.gbPlayerHealth.TabStop = false;
            this.gbPlayerHealth.Text = "Health 100/100";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPlayer.Location = new System.Drawing.Point(3, 20);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(10);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(305, 23);
            this.pbPlayer.Step = 1;
            this.pbPlayer.TabIndex = 2;
            this.pbPlayer.Value = 100;
            // 
            // gbEnemy
            // 
            this.gbEnemy.Controls.Add(this.gbEnemyHealth);
            this.gbEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEnemy.Font = new System.Drawing.Font("Calibri Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEnemy.Location = new System.Drawing.Point(487, 3);
            this.gbEnemy.Name = "gbEnemy";
            this.gbEnemy.Size = new System.Drawing.Size(319, 193);
            this.gbEnemy.TabIndex = 1;
            this.gbEnemy.TabStop = false;
            this.gbEnemy.Text = "Enemy";
            // 
            // gbEnemyHealth
            // 
            this.gbEnemyHealth.Controls.Add(this.pbEnemy);
            this.gbEnemyHealth.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbEnemyHealth.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEnemyHealth.Location = new System.Drawing.Point(3, 26);
            this.gbEnemyHealth.Name = "gbEnemyHealth";
            this.gbEnemyHealth.Size = new System.Drawing.Size(313, 46);
            this.gbEnemyHealth.TabIndex = 3;
            this.gbEnemyHealth.TabStop = false;
            this.gbEnemyHealth.Text = "Health 100/100";
            // 
            // pbEnemy
            // 
            this.pbEnemy.Cursor = System.Windows.Forms.Cursors.Default;
            this.pbEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbEnemy.Location = new System.Drawing.Point(3, 20);
            this.pbEnemy.Margin = new System.Windows.Forms.Padding(10);
            this.pbEnemy.Name = "pbEnemy";
            this.pbEnemy.Size = new System.Drawing.Size(307, 23);
            this.pbEnemy.Step = 1;
            this.pbEnemy.TabIndex = 2;
            this.pbEnemy.Value = 100;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gbBodyPart, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(323, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.12435F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.87565F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(161, 199);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // gbBodyPart
            // 
            this.gbBodyPart.Controls.Add(this.tableLayoutPanel3);
            this.gbBodyPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBodyPart.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbBodyPart.Location = new System.Drawing.Point(3, 66);
            this.gbBodyPart.Name = "gbBodyPart";
            this.gbBodyPart.Size = new System.Drawing.Size(155, 130);
            this.gbBodyPart.TabIndex = 1;
            this.gbBodyPart.TabStop = false;
            this.gbBodyPart.Text = "*part*";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btnLegs, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnTorso, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnHead, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 20);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(149, 107);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnLegs
            // 
            this.btnLegs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLegs.Location = new System.Drawing.Point(3, 73);
            this.btnLegs.Name = "btnLegs";
            this.btnLegs.Size = new System.Drawing.Size(143, 31);
            this.btnLegs.TabIndex = 2;
            this.btnLegs.Text = "Legs";
            this.btnLegs.UseVisualStyleBackColor = true;
            this.btnLegs.Click += new System.EventHandler(this.btnLegs_Click);
            // 
            // btnTorso
            // 
            this.btnTorso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTorso.Location = new System.Drawing.Point(3, 38);
            this.btnTorso.Name = "btnTorso";
            this.btnTorso.Size = new System.Drawing.Size(143, 29);
            this.btnTorso.TabIndex = 1;
            this.btnTorso.Text = "Torso";
            this.btnTorso.UseVisualStyleBackColor = true;
            this.btnTorso.Click += new System.EventHandler(this.btnTorso_Click);
            // 
            // btnHead
            // 
            this.btnHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHead.Location = new System.Drawing.Point(3, 3);
            this.btnHead.Name = "btnHead";
            this.btnHead.Size = new System.Drawing.Size(143, 29);
            this.btnHead.TabIndex = 0;
            this.btnHead.Text = "Head";
            this.btnHead.UseVisualStyleBackColor = true;
            this.btnHead.Click += new System.EventHandler(this.btnHead_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(155, 57);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Turn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Fight_club.Properties.Resources.arrow;
            this.pictureBox1.InitialImage = global::Fight_club.Properties.Resources.arrow;
            this.pictureBox1.Location = new System.Drawing.Point(3, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gameLog);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(809, 94);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Game Log";
            // 
            // gameLog
            // 
            this.gameLog.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gameLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameLog.Location = new System.Drawing.Point(3, 20);
            this.gameLog.Margin = new System.Windows.Forms.Padding(10);
            this.gameLog.Name = "gameLog";
            this.gameLog.ReadOnly = true;
            this.gameLog.Size = new System.Drawing.Size(803, 71);
            this.gameLog.TabIndex = 3;
            this.gameLog.Text = "";
            this.gameLog.Click += new System.EventHandler(this.gameLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 297);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fight";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayerHealth.ResumeLayout(false);
            this.gbEnemy.ResumeLayout(false);
            this.gbEnemyHealth.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.gbBodyPart.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.GroupBox gbEnemy;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox gameLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox gbBodyPart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnLegs;
        private System.Windows.Forms.Button btnTorso;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox gbPlayerHealth;
        private System.Windows.Forms.ProgressBar pbPlayer;
        private System.Windows.Forms.GroupBox gbEnemyHealth;
        private System.Windows.Forms.ProgressBar pbEnemy;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

