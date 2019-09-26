namespace SlidingMenu
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelHead = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelTrash = new System.Windows.Forms.Panel();
            this.panelJunk = new System.Windows.Forms.Panel();
            this.panelSpams = new System.Windows.Forms.Panel();
            this.panelDraft = new System.Windows.Forms.Panel();
            this.panelSend = new System.Windows.Forms.Panel();
            this.panelInbox = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.picMenuBar = new System.Windows.Forms.PictureBox();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnJunk = new System.Windows.Forms.Button();
            this.btnSpams = new System.Windows.Forms.Button();
            this.btnDraft = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnInbox = new System.Windows.Forms.Button();
            this.picNormal = new System.Windows.Forms.PictureBox();
            this.picMaximize = new System.Windows.Forms.PictureBox();
            this.picMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.panelHead.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(206)))));
            this.panelHead.Controls.Add(this.picNormal);
            this.panelHead.Controls.Add(this.picMaximize);
            this.panelHead.Controls.Add(this.picMinimize);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Controls.Add(this.pictureBox1);
            this.panelHead.Controls.Add(this.picClose);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(952, 35);
            this.panelHead.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sliding Menu";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenu.Controls.Add(this.panelTrash);
            this.panelMenu.Controls.Add(this.panelJunk);
            this.panelMenu.Controls.Add(this.panelSpams);
            this.panelMenu.Controls.Add(this.panelDraft);
            this.panelMenu.Controls.Add(this.panelSend);
            this.panelMenu.Controls.Add(this.panelInbox);
            this.panelMenu.Controls.Add(this.picMenuBar);
            this.panelMenu.Controls.Add(this.btnTrash);
            this.panelMenu.Controls.Add(this.btnJunk);
            this.panelMenu.Controls.Add(this.btnSpams);
            this.panelMenu.Controls.Add(this.btnDraft);
            this.panelMenu.Controls.Add(this.btnSend);
            this.panelMenu.Controls.Add(this.btnInbox);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 35);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(225, 465);
            this.panelMenu.TabIndex = 1;
            // 
            // panelTrash
            // 
            this.panelTrash.Location = new System.Drawing.Point(0, 333);
            this.panelTrash.Name = "panelTrash";
            this.panelTrash.Size = new System.Drawing.Size(225, 3);
            this.panelTrash.TabIndex = 1;
            // 
            // panelJunk
            // 
            this.panelJunk.Location = new System.Drawing.Point(0, 293);
            this.panelJunk.Name = "panelJunk";
            this.panelJunk.Size = new System.Drawing.Size(225, 3);
            this.panelJunk.TabIndex = 1;
            // 
            // panelSpams
            // 
            this.panelSpams.Location = new System.Drawing.Point(0, 253);
            this.panelSpams.Name = "panelSpams";
            this.panelSpams.Size = new System.Drawing.Size(225, 3);
            this.panelSpams.TabIndex = 1;
            // 
            // panelDraft
            // 
            this.panelDraft.Location = new System.Drawing.Point(0, 213);
            this.panelDraft.Name = "panelDraft";
            this.panelDraft.Size = new System.Drawing.Size(225, 3);
            this.panelDraft.TabIndex = 1;
            // 
            // panelSend
            // 
            this.panelSend.Location = new System.Drawing.Point(0, 173);
            this.panelSend.Name = "panelSend";
            this.panelSend.Size = new System.Drawing.Size(225, 3);
            this.panelSend.TabIndex = 1;
            // 
            // panelInbox
            // 
            this.panelInbox.Location = new System.Drawing.Point(0, 133);
            this.panelInbox.Name = "panelInbox";
            this.panelInbox.Size = new System.Drawing.Size(225, 3);
            this.panelInbox.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(45)))), ((int)(((byte)(58)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(225, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(727, 465);
            this.panelContainer.TabIndex = 2;
            // 
            // picMenuBar
            // 
            this.picMenuBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMenuBar.Image = ((System.Drawing.Image)(resources.GetObject("picMenuBar.Image")));
            this.picMenuBar.Location = new System.Drawing.Point(185, 13);
            this.picMenuBar.Name = "picMenuBar";
            this.picMenuBar.Size = new System.Drawing.Size(30, 30);
            this.picMenuBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMenuBar.TabIndex = 0;
            this.picMenuBar.TabStop = false;
            this.picMenuBar.Click += new System.EventHandler(this.picMenuBar_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrash.ForeColor = System.Drawing.Color.White;
            this.btnTrash.Image = global::SlidingMenu.Properties.Resources.garbage;
            this.btnTrash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrash.Location = new System.Drawing.Point(10, 301);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(205, 34);
            this.btnTrash.TabIndex = 5;
            this.btnTrash.Text = "Trash";
            this.btnTrash.UseVisualStyleBackColor = true;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnJunk
            // 
            this.btnJunk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJunk.FlatAppearance.BorderSize = 0;
            this.btnJunk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJunk.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJunk.ForeColor = System.Drawing.Color.White;
            this.btnJunk.Image = ((System.Drawing.Image)(resources.GetObject("btnJunk.Image")));
            this.btnJunk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnJunk.Location = new System.Drawing.Point(10, 261);
            this.btnJunk.Name = "btnJunk";
            this.btnJunk.Size = new System.Drawing.Size(205, 34);
            this.btnJunk.TabIndex = 4;
            this.btnJunk.Text = "Junk";
            this.btnJunk.UseVisualStyleBackColor = true;
            this.btnJunk.Click += new System.EventHandler(this.btnJunk_Click);
            // 
            // btnSpams
            // 
            this.btnSpams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpams.FlatAppearance.BorderSize = 0;
            this.btnSpams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpams.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpams.ForeColor = System.Drawing.Color.White;
            this.btnSpams.Image = global::SlidingMenu.Properties.Resources.CloseShield;
            this.btnSpams.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpams.Location = new System.Drawing.Point(10, 221);
            this.btnSpams.Name = "btnSpams";
            this.btnSpams.Size = new System.Drawing.Size(205, 34);
            this.btnSpams.TabIndex = 3;
            this.btnSpams.Text = "Spams";
            this.btnSpams.UseVisualStyleBackColor = true;
            this.btnSpams.Click += new System.EventHandler(this.btnSpams_Click);
            // 
            // btnDraft
            // 
            this.btnDraft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDraft.FlatAppearance.BorderSize = 0;
            this.btnDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDraft.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraft.ForeColor = System.Drawing.Color.White;
            this.btnDraft.Image = global::SlidingMenu.Properties.Resources.NoteMemo;
            this.btnDraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDraft.Location = new System.Drawing.Point(10, 181);
            this.btnDraft.Name = "btnDraft";
            this.btnDraft.Size = new System.Drawing.Size(205, 34);
            this.btnDraft.TabIndex = 2;
            this.btnDraft.Text = "Draft";
            this.btnDraft.UseVisualStyleBackColor = true;
            this.btnDraft.Click += new System.EventHandler(this.btnDraft_Click);
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = ((System.Drawing.Image)(resources.GetObject("btnSend.Image")));
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(10, 141);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(205, 34);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnInbox
            // 
            this.btnInbox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInbox.FlatAppearance.BorderSize = 0;
            this.btnInbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInbox.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInbox.ForeColor = System.Drawing.Color.White;
            this.btnInbox.Image = ((System.Drawing.Image)(resources.GetObject("btnInbox.Image")));
            this.btnInbox.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInbox.Location = new System.Drawing.Point(10, 101);
            this.btnInbox.Name = "btnInbox";
            this.btnInbox.Size = new System.Drawing.Size(205, 34);
            this.btnInbox.TabIndex = 0;
            this.btnInbox.Text = "Inbox";
            this.btnInbox.UseVisualStyleBackColor = true;
            this.btnInbox.Click += new System.EventHandler(this.btnInbox_Click);
            // 
            // picNormal
            // 
            this.picNormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNormal.Image = ((System.Drawing.Image)(resources.GetObject("picNormal.Image")));
            this.picNormal.Location = new System.Drawing.Point(875, 0);
            this.picNormal.Name = "picNormal";
            this.picNormal.Size = new System.Drawing.Size(35, 35);
            this.picNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picNormal.TabIndex = 2;
            this.picNormal.TabStop = false;
            this.picNormal.Visible = false;
            this.picNormal.Click += new System.EventHandler(this.picNormal_Click);
            // 
            // picMaximize
            // 
            this.picMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMaximize.Image = ((System.Drawing.Image)(resources.GetObject("picMaximize.Image")));
            this.picMaximize.Location = new System.Drawing.Point(875, 0);
            this.picMaximize.Name = "picMaximize";
            this.picMaximize.Size = new System.Drawing.Size(35, 35);
            this.picMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMaximize.TabIndex = 1;
            this.picMaximize.TabStop = false;
            this.picMaximize.Click += new System.EventHandler(this.picMaximize_Click);
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMinimize.Image = ((System.Drawing.Image)(resources.GetObject("picMinimize.Image")));
            this.picMinimize.Location = new System.Drawing.Point(834, 0);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.Size = new System.Drawing.Size(35, 35);
            this.picMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMinimize.TabIndex = 0;
            this.picMinimize.TabStop = false;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SlidingMenu.Properties.Resources.mediaPlay;
            this.pictureBox1.Location = new System.Drawing.Point(12, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.Image = global::SlidingMenu.Properties.Resources.close3;
            this.picClose.Location = new System.Drawing.Point(916, 0);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(35, 35);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 500);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMenuBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button btnInbox;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.Button btnJunk;
        private System.Windows.Forms.Button btnSpams;
        private System.Windows.Forms.Button btnDraft;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.PictureBox picMenuBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelInbox;
        private System.Windows.Forms.Panel panelDraft;
        private System.Windows.Forms.Panel panelSend;
        private System.Windows.Forms.Panel panelTrash;
        private System.Windows.Forms.Panel panelJunk;
        private System.Windows.Forms.Panel panelSpams;
        private System.Windows.Forms.PictureBox picMinimize;
        private System.Windows.Forms.PictureBox picMaximize;
        private System.Windows.Forms.PictureBox picNormal;
    }
}

