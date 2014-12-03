namespace Journal.App.Controls {
	partial class TextEditor {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtSource = new System.Windows.Forms.TextBox();
			this.rtbRender = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splTextEditorViewer)).BeginInit();
			this.splTextEditorViewer.Panel1.SuspendLayout();
			this.splTextEditorViewer.Panel2.SuspendLayout();
			this.splTextEditorViewer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splTextEditorViewer
			// 
			// 
			// splTextEditorViewer.Panel1
			// 
			this.splTextEditorViewer.Panel1.Controls.Add(this.txtSource);
			// 
			// splTextEditorViewer.Panel2
			// 
			this.splTextEditorViewer.Panel2.Controls.Add(this.rtbRender);
			// 
			// txtSource
			// 
			this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSource.Location = new System.Drawing.Point(0, 0);
			this.txtSource.Multiline = true;
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(327, 418);
			this.txtSource.TabIndex = 0;
			// 
			// rtbRender
			// 
			this.rtbRender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbRender.Location = new System.Drawing.Point(0, 0);
			this.rtbRender.Name = "rtbRender";
			this.rtbRender.Size = new System.Drawing.Size(315, 418);
			this.rtbRender.TabIndex = 0;
			this.rtbRender.Text = "";
			// 
			// TextEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "TextEditor";
			this.splTextEditorViewer.Panel1.ResumeLayout(false);
			this.splTextEditorViewer.Panel1.PerformLayout();
			this.splTextEditorViewer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splTextEditorViewer)).EndInit();
			this.splTextEditorViewer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.RichTextBox rtbRender;
	}
}
