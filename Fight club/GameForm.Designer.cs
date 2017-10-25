namespace Fight_club
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.scLog = new System.Windows.Forms.SplitContainer();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.gbPlayer = new System.Windows.Forms.GroupBox();
            this.gbPlayerHealth = new System.Windows.Forms.GroupBox();
            this.pbPlayer = new System.Windows.Forms.ProgressBar();
            this.gbEnemy = new System.Windows.Forms.GroupBox();
            this.gbEnemyHealth = new System.Windows.Forms.GroupBox();
            this.pbEnemy = new System.Windows.Forms.ProgressBar();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.gbBodyPart = new System.Windows.Forms.GroupBox();
            this.tlpAction = new System.Windows.Forms.TableLayoutPanel();
            this.btnLegs = new System.Windows.Forms.Button();
            this.btnTorso = new System.Windows.Forms.Button();
            this.btnHead = new System.Windows.Forms.Button();
            this.gbTurn = new System.Windows.Forms.GroupBox();
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.gbLog = new System.Windows.Forms.GroupBox();
            this.gameLog = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scLog)).BeginInit();
            this.scLog.Panel1.SuspendLayout();
            this.scLog.Panel2.SuspendLayout();
            this.scLog.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.gbPlayer.SuspendLayout();
            this.gbPlayerHealth.SuspendLayout();
            this.gbEnemy.SuspendLayout();
            this.gbEnemyHealth.SuspendLayout();
            this.tlpControl.SuspendLayout();
            this.gbBodyPart.SuspendLayout();
            this.tlpAction.SuspendLayout();
            this.gbTurn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            this.gbLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // scLog
            // 
            this.scLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLog.Location = new System.Drawing.Point(0, 0);
            this.scLog.Name = "scLog";
            this.scLog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scLog.Panel1
            // 
            this.scLog.Panel1.Controls.Add(this.tlpMain);
            // 
            // scLog.Panel2
            // 
            this.scLog.Panel2.Controls.Add(this.gbLog);
            this.scLog.Size = new System.Drawing.Size(809, 297);
            this.scLog.SplitterDistance = 199;
            this.scLog.TabIndex = 2;
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.Controls.Add(this.gbPlayer, 0, 0);
            this.tlpMain.Controls.Add(this.gbEnemy, 2, 0);
            this.tlpMain.Controls.Add(this.tlpControl, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 1;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.Size = new System.Drawing.Size(809, 199);
            this.tlpMain.TabIndex = 1;
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
            // tlpControl
            // 
            this.tlpControl.ColumnCount = 1;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpControl.Controls.Add(this.gbBodyPart, 0, 1);
            this.tlpControl.Controls.Add(this.gbTurn, 0, 0);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControl.Location = new System.Drawing.Point(323, 0);
            this.tlpControl.Margin = new System.Windows.Forms.Padding(0);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 2;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.12435F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.87565F));
            this.tlpControl.Size = new System.Drawing.Size(161, 199);
            this.tlpControl.TabIndex = 2;
            // 
            // gbBodyPart
            // 
            this.gbBodyPart.Controls.Add(this.tlpAction);
            this.gbBodyPart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbBodyPart.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbBodyPart.Location = new System.Drawing.Point(3, 66);
            this.gbBodyPart.Name = "gbBodyPart";
            this.gbBodyPart.Size = new System.Drawing.Size(155, 130);
            this.gbBodyPart.TabIndex = 1;
            this.gbBodyPart.TabStop = false;
            this.gbBodyPart.Text = "*part*";
            // 
            // tlpAction
            // 
            this.tlpAction.ColumnCount = 1;
            this.tlpAction.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpAction.Controls.Add(this.btnLegs, 0, 2);
            this.tlpAction.Controls.Add(this.btnTorso, 0, 1);
            this.tlpAction.Controls.Add(this.btnHead, 0, 0);
            this.tlpAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAction.Location = new System.Drawing.Point(3, 20);
            this.tlpAction.Margin = new System.Windows.Forms.Padding(0);
            this.tlpAction.Name = "tlpAction";
            this.tlpAction.RowCount = 3;
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tlpAction.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tlpAction.Size = new System.Drawing.Size(149, 107);
            this.tlpAction.TabIndex = 0;
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
            // gbTurn
            // 
            this.gbTurn.Controls.Add(this.pbArrow);
            this.gbTurn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTurn.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbTurn.Location = new System.Drawing.Point(3, 3);
            this.gbTurn.Name = "gbTurn";
            this.gbTurn.Size = new System.Drawing.Size(155, 57);
            this.gbTurn.TabIndex = 0;
            this.gbTurn.TabStop = false;
            this.gbTurn.Text = "Turn";
            // 
            // pbArrow
            // 
            this.pbArrow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbArrow.Image = global::Fight_club.Properties.Resources.arrow;
            this.pbArrow.InitialImage = global::Fight_club.Properties.Resources.arrow;
            this.pbArrow.Location = new System.Drawing.Point(3, 20);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(149, 34);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 0;
            this.pbArrow.TabStop = false;
            // 
            // gbLog
            // 
            this.gbLog.Controls.Add(this.gameLog);
            this.gbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbLog.Font = new System.Drawing.Font("Calibri Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbLog.Location = new System.Drawing.Point(0, 0);
            this.gbLog.Name = "gbLog";
            this.gbLog.Size = new System.Drawing.Size(809, 94);
            this.gbLog.TabIndex = 1;
            this.gbLog.TabStop = false;
            this.gbLog.Text = "Game Log";
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 297);
            this.Controls.Add(this.scLog);
            this.Font = new System.Drawing.Font("Calibri Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameForm";
            this.Text = "Fight";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.scLog.Panel1.ResumeLayout(false);
            this.scLog.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scLog)).EndInit();
            this.scLog.ResumeLayout(false);
            this.tlpMain.ResumeLayout(false);
            this.gbPlayer.ResumeLayout(false);
            this.gbPlayerHealth.ResumeLayout(false);
            this.gbEnemy.ResumeLayout(false);
            this.gbEnemyHealth.ResumeLayout(false);
            this.tlpControl.ResumeLayout(false);
            this.gbBodyPart.ResumeLayout(false);
            this.tlpAction.ResumeLayout(false);
            this.gbTurn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            this.gbLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scLog;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.GroupBox gbPlayer;
        private System.Windows.Forms.GroupBox gbEnemy;
        private System.Windows.Forms.GroupBox gbLog;
        private System.Windows.Forms.RichTextBox gameLog;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.GroupBox gbBodyPart;
        private System.Windows.Forms.TableLayoutPanel tlpAction;
        private System.Windows.Forms.Button btnLegs;
        private System.Windows.Forms.Button btnTorso;
        private System.Windows.Forms.Button btnHead;
        private System.Windows.Forms.GroupBox gbTurn;
        private System.Windows.Forms.GroupBox gbPlayerHealth;
        private System.Windows.Forms.ProgressBar pbPlayer;
        private System.Windows.Forms.GroupBox gbEnemyHealth;
        private System.Windows.Forms.ProgressBar pbEnemy;
        private System.Windows.Forms.PictureBox pbArrow;
    }
}

