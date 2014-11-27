using System.Windows.Forms;

namespace Journal.App.Controls {
	public partial class ActionButtonBase : UserControl , IButtonControl {
		public ActionButtonBase() {
			InitializeComponent();
		}


		#region IButtonControl Members

		public DialogResult DialogResult {
			get {
				throw new System.NotImplementedException();
			}
			set {
				throw new System.NotImplementedException();
			}
		}

		public void NotifyDefault( bool value ) {
			throw new System.NotImplementedException();
		}

		public void PerformClick() {
			throw new System.NotImplementedException();
		}

		#endregion
	}
}
