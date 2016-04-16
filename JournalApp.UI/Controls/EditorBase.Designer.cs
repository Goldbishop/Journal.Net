namespace Journal.App.Controls {
	partial class EditorBase {
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
			this.splTextEditorViewer = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splTextEditorViewer)).BeginInit();
			this.splTextEditorViewer.SuspendLayout();
			this.SuspendLayout();
			// 
			// splTextEditorViewer
			// 
			this.splTextEditorViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splTextEditorViewer.Location = new System.Drawing.Point(0, 0);
			this.splTextEditorViewer.Name = "splTextEditorViewer";
			this.splTextEditorViewer.Size = new System.Drawing.Size(646, 418);
			this.splTextEditorViewer.SplitterDistance = 327;
			this.splTextEditorViewer.TabIndex = 1;
			// 
			// EditorBase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splTextEditorViewer);
			this.Name = "EditorBase";
			this.Size = new System.Drawing.Size(646, 418);
			((System.ComponentModel.ISupportInitialize)(this.splTextEditorViewer)).EndInit();
			this.splTextEditorViewer.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion



	}
}
