namespace Journal.App {
	partial class frmMain {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing ) {
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.splBody = new System.Windows.Forms.SplitContainer();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.txtEditorZone = new Journal.App.Controls.TextEditor();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.entryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splBody)).BeginInit();
			this.splBody.Panel1.SuspendLayout();
			this.splBody.Panel2.SuspendLayout();
			this.splBody.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(887, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// optionsToolStripMenuItem
			// 
			this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
			this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.optionsToolStripMenuItem.Text = "Options";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// statusStrip1
			// 
			this.statusStrip1.Location = new System.Drawing.Point(0, 540);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(887, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// splBody
			// 
			this.splBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splBody.Location = new System.Drawing.Point(0, 24);
			this.splBody.Name = "splBody";
			// 
			// splBody.Panel1
			// 
			this.splBody.Panel1.Controls.Add(this.treeView1);
			// 
			// splBody.Panel2
			// 
			this.splBody.Panel2.Controls.Add(this.txtEditorZone);
			this.splBody.Panel2.Controls.Add(this.toolStrip1);
			this.splBody.Size = new System.Drawing.Size(887, 516);
			this.splBody.SplitterDistance = 153;
			this.splBody.TabIndex = 2;
			// 
			// treeView1
			// 
			this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeView1.Location = new System.Drawing.Point(0, 0);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(153, 516);
			this.treeView1.TabIndex = 0;
			// 
			// txtEditorZone
			// 
			this.txtEditorZone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtEditorZone.Location = new System.Drawing.Point(0, 25);
			this.txtEditorZone.Name = "txtEditorZone";
			this.txtEditorZone.Size = new System.Drawing.Size(730, 491);
			this.txtEditorZone.TabIndex = 3;
			// 
			// toolStrip1
			// 
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(730, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.entryToolStripMenuItem});
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.newToolStripMenuItem.Text = "New";
			// 
			// bookToolStripMenuItem
			// 
			this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
			this.bookToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.bookToolStripMenuItem.Text = "Journal";
			// 
			// entryToolStripMenuItem
			// 
			this.entryToolStripMenuItem.Name = "entryToolStripMenuItem";
			this.entryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.entryToolStripMenuItem.Text = "Entry";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(887, 562);
			this.Controls.Add(this.splBody);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "frmMain";
			this.Text = "frmMain";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splBody.Panel1.ResumeLayout(false);
			this.splBody.Panel2.ResumeLayout(false);
			this.splBody.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splBody)).EndInit();
			this.splBody.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.SplitContainer splBody;
		private System.Windows.Forms.TreeView treeView1;
		private Controls.TextEditor txtEditorZone;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem entryToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}