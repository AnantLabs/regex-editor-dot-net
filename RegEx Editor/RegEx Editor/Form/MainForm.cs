using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace RegEx_Editor {
	public partial class MainForm : Form {

		private String _search_pattern;
		private String _replace_pattern;
		private String _file_path;
		private String _search_input;


		public MainForm() {
			InitializeComponent();
			// add resize eventhandler to this form
			this.Resize += new System.EventHandler(this.Form1_Resize);
			//this.FileTextBox.Enter += new System.EventHandler(this.Control_GotFocus);
			//this.FileTextBox.Leave += new System.EventHandler(this.Control_LostFocus);
			
			foreach( Control c in this.Controls ) {
				if (c.GetType() == typeof(System.Windows.Forms.TextBox) ) {
					((System.Windows.Forms.TextBox)c).Enter += new System.EventHandler(this.Control_GotFocus);
					((System.Windows.Forms.TextBox)c).Leave += new System.EventHandler(this.Control_LostFocus);
					((System.Windows.Forms.TextBox)c).KeyUp += new KeyEventHandler(this.Control_CursorChanged);
				}
				if (c.GetType() == typeof(DigitalRune.Windows.TextEditor.TextEditorControl)) {
					((DigitalRune.Windows.TextEditor.TextEditorControl)c).Enter += new System.EventHandler(this.Control_GotFocus);
					((DigitalRune.Windows.TextEditor.TextEditorControl)c).Leave += new System.EventHandler(this.Control_LostFocus);
					((DigitalRune.Windows.TextEditor.TextEditorControl)c).KeyUp += new KeyEventHandler(this.Control_CursorChanged);
				}
			}
			
			this.ActivWindowLabel.Text = "";
			this.PositionLabel.Text = "";
		}

		private void Control_GotFocus(Object sender, EventArgs e) {
			this.ActivWindowLabel.Text = ((Control)sender).Name;
		}

		private void Control_LostFocus(Object sender, EventArgs e) {
			this.ActivWindowLabel.Text = "";
			PositionLabel.Text = "";
		}
		
		public void Control_CursorChanged(Object sender, EventArgs e) {
			if (sender.GetType() == typeof(System.Windows.Forms.TextBox) ) {
				PositionLabel.Text = ((System.Windows.Forms.TextBox)sender).SelectionStart.ToString();
			}
			if (sender.GetType() == typeof(DigitalRune.Windows.TextEditor.TextEditorControl)) {
				// PositionLabel.Text = (String)((DigitalRune.Windows.TextEditor.TextEditorControl)sender).SelectionStart;
			}
		}
		

		/// <summary>
		/// function that will become executed after this form was resized
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void Form1_Resize(Object sender, EventArgs e) {
			// calc new searchbox position (37% of the form heigth)
			Int32 new_pos = 0;
			new_pos = this.Height * 37 / 100;

			// move controls to their new position
			QuitButton.Location = new Point(this.Width - 42, 12);
			InfoButton.Location = new Point(this.Width - 70, 12);
			OpenFileButton.Location = new Point(InfoButton.Location.X - OpenFileButton.Size.Width - 10, 12);
			PathTextBox.Size = new Size(OpenFileButton.Location.X - 20, PathTextBox.Size.Height);

			FileTextBox.Size = new Size(this.Width - 31, new_pos - 70);

			label1.Location = new Point(label1.Location.X, new_pos);
			label2.Location = new Point(label2.Location.X, new_pos + 82);

			LoadExpressionButton.Location = new Point(this.Width - (LoadExpressionButton.Size.Width + 18), new_pos);
			IsMatchButton.Location = new Point(this.Width - (IsMatchButton.Size.Width + 18), new_pos + (IsMatchButton.Size.Height + 2));
			MatchButton.Location = new Point(this.Width - (MatchButton.Size.Width + 18), new_pos + (2 * MatchButton.Size.Height + 4));

			LoadReplaceButton.Location = new Point(this.Width - (LoadReplaceButton.Size.Width + 18), new_pos + (3 * LoadReplaceButton.Size.Height + 11));
			ReplaceButton.Location = new Point(this.Width - (ReplaceButton.Size.Width + 18), new_pos + (4 * ReplaceButton.Size.Height + 13));

			RegExTextBox.Location = new Point(RegExTextBox.Location.X, new_pos);
			ReplaceTextBox.Location = new Point(ReplaceTextBox.Location.X, new_pos + 80);

			RegExTextBox.Size = new Size(LoadExpressionButton.Location.X - 100, RegExTextBox.Size.Height);
			ReplaceTextBox.Size = new Size(LoadExpressionButton.Location.X - 100, RegExTextBox.Size.Height);

			ResultTextBox.Location = new Point(ResultTextBox.Location.X, new_pos + 162);
			MatchDataGrid.Location = new Point(ResultTextBox.Location.X, new_pos + 162);

			Int32 loc_y = ResultTextBox.Location.Y;
			new_pos = this.Height - (loc_y + 35);

			ResultTextBox.Size = new Size(this.Width - 30, new_pos - 20);
			MatchDataGrid.Size = new Size(this.Width - 30, new_pos - 20);
		}

		/// <summary>
		/// becomes executed to open a new file
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void OpenFileButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();

			ofd.ShowDialog();
			PathTextBox.Text = ofd.FileName;
			if (ofd.FileName != "") {
				LoadFromFile(ofd.FileName);
			}
		}

		/// <summary>
		/// loads file content into the filetextbox
		/// </summary>
		/// <param name="path">path and file</param>
		private void LoadFromFile(String path) {
			System.IO.StreamReader sr = new System.IO.StreamReader(path);
			while (sr.EndOfStream == false) {
				FileTextBox.Text = sr.ReadToEnd();
			}
			sr.Close();
			sr.Dispose();
		}

		/// <summary>
		/// becomes executed when filetextbox text changes
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void FileTextBox_TextChanged(object sender, EventArgs e) {
			_search_input = FileTextBox.Text;
			ButtonEnableing();
		}

		private void LoadSearchInput() {
			_search_input = FileTextBox.Text;
			ButtonEnableing();
		}

		/// <summary>
		/// checks witch button (ismatch, match, replace) has to become enables / disables
		/// </summary>
		private void ButtonEnableing() {
			if (FileTextBox.Text == "") {
				IsMatchButton.Enabled = false;
				MatchButton.Enabled = false;
				ReplaceButton.Enabled = false;
			} else {
				if (RegExTextBox.Text == "") {
					IsMatchButton.Enabled = false;
					MatchButton.Enabled = false;
					ReplaceButton.Enabled = false;
				} else {
					IsMatchButton.Enabled = true;
					MatchButton.Enabled = true;
					if (ReplaceTextBox.Text == "") {
						ReplaceButton.Enabled = false;
					} else {
						ReplaceButton.Enabled = true;
					}
				}
			}
		}

		/// <summary>
		/// will be executed if regextextbox text changes
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void RegExTextBox_TextChanged(object sender, EventArgs e) {
			_search_pattern = RegExTextBox.Text;
			ButtonEnableing();
		}

		/// <summary>
		/// will be executed if replacetextbox text changes
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void ReplaceTextBox_TextChanged(object sender, EventArgs e) {
			_replace_pattern = ReplaceTextBox.Text;
			ButtonEnableing();
		}

		/// <summary>
		/// will be executed if the ismatchbutton was clicked
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void IsMatchButton_Click(object sender, EventArgs e) {
			ResetResultboxes();
			LoadSearchInput();
			try {
				Regex re = new Regex(_search_pattern);
				ResultTextBox.Text = re.IsMatch(_search_input).ToString() + " (" + re.Matches(_search_input).Count + ")";
				ResultTextBox.BringToFront();
			} catch (ArgumentException aex) {
				SendExceptionMessageToTextBox(aex);
			}
			/// FileTextBox.ActiveTextAreaControl.TextArea.SelectionManager.Selections.ad
		}

		/// <summary>
		/// formats the resulttextbox and sends the exceptions errormessage to it
		/// </summary>
		/// <param name="aex">exception</param>
		private void SendExceptionMessageToTextBox(ArgumentException aex) {
			// adding text
			ResultTextBox.Text = "[" + aex.Message + "]";
			// formating textbox
			ResultTextBox.Font = new Font(new FontFamily("Courier New"), 8, FontStyle.Italic);
			// bring it to the front
			ResultTextBox.BringToFront();
			// sent textcolor red
			ResultTextBox.ForeColor = Color.Red;
		}

		/// <summary>
		/// will become executed if replace button becomes clicked
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void ReplaceButton_Click(object sender, EventArgs e) {
			ResetResultboxes();
			LoadSearchInput();
			try {
				Regex re = new Regex(_search_pattern);
				ResultTextBox.Text = re.Replace(_search_input, _replace_pattern);
				ResultTextBox.BringToFront();
			} catch (ArgumentException aex) {
				SendExceptionMessageToTextBox(aex);
			}
		}

		/// <summary>
		/// resets result boxes ResultTextBox and MatchDataGrid
		/// </summary>
		private void ResetResultboxes() {
			// remove text
			ResultTextBox.Text = "";
			// set color to black
			ResultTextBox.ForeColor = Color.Black;
			// format the text
			ResultTextBox.Font = new Font(new FontFamily("Courier New"), 8, FontStyle.Regular);
			// remove all rows from datagrid
			MatchDataGrid.Rows.Clear();
			// remove all cols from datagrid
			MatchDataGrid.Columns.Clear();
			// add one column to the datagrid
			MatchDataGrid.Columns.Add("found", "Found");
		}

		/// <summary>
		/// will be executed when matchbutton will be clicked
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void MatchButton_Click(object sender, EventArgs e) {
			ResetResultboxes();
			LoadSearchInput();
			try {
				Regex re = new Regex(_search_pattern);
				System.Text.RegularExpressions.MatchCollection mc;
				mc = re.Matches(_search_input);

				System.Collections.IEnumerator ie = mc.GetEnumerator();

				bool column_add = false;

				// for each match
				while (ie.MoveNext()) {
					System.Text.RegularExpressions.Match m = (System.Text.RegularExpressions.Match)ie.Current;
					if (column_add == false) {
						// add column for every search group
						for (Int32 i = 0; i < m.Groups.Count - 1; i++) {
							MatchDataGrid.Columns.Add(i.ToString(), "$" + (i + 1));
						}
						column_add = true;
					}

					// create one row for the datagrid
					Int32 count = 0;
					String[] s = new String[30];

					// found value
					s[count] = m.Value;

					count++;

					// add every found group
					for (Int32 i = 0; i < m.Groups.Count - 1; i++) {
						s[count] = m.Groups[i + 1].Value;
						count++;
					}

					// add row to the datagrid
					MatchDataGrid.Rows.Add(s);
					MatchDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
				}

			} catch (ArgumentException aex) {
				SendExceptionMessageToTextBox(aex);
			}
			MatchDataGrid.BringToFront();
		}

		/// <summary>
		/// executes when form loads
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void Form1_Load(object sender, EventArgs e) {
			ResultTextBox.BringToFront();
			Form1_Resize(this, new EventArgs());
		}

		/// <summary>
		/// executes when exit button becomes clicked
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void button1_Click(object sender, EventArgs e) {
			if (MessageBox.Show("Exit RegEx Explorer.NET?", "", MessageBoxButtons.YesNo) == DialogResult.Yes) {
				Close();
			}
		}

		/// <summary>
		/// executes when info button becomes clicked
		/// </summary>
		/// <param name="sender">sender</param>
		/// <param name="e">eventargs</param>
		private void InfoButton_Click(object sender, EventArgs e) {
			String s = "[RegEx Editor.NET]" + Environment.NewLine + Environment.NewLine;

			s += "Author: Jens Blawatt" + Environment.NewLine;
			s += "Website: http://www.blawatt.de" + Environment.NewLine + Environment.NewLine;
			s += "Version: 1.6" + Environment.NewLine + Environment.NewLine;

			s += "Description:" + Environment.NewLine;
			s += "This Software enables you to employ regulare expressions on typed text or textbased files." + Environment.NewLine;
			s += "Also it's possible to replace parts of the text via replace expression.";

			MessageBox.Show(s, "Info!");
		}

		/// <summary>
		/// executes when pathtextbox text changes
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PathTextBox_TextChanged(object sender, EventArgs e) {
			_file_path = PathTextBox.Text;
		}

		private void LoadExpressionButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			try {
				System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
				RegExTextBox.Text = sr.ReadToEnd();
				sr.Close();
			} catch (Exception ex) {
			}
		}

		private void LoadReplaceButton_Click(object sender, EventArgs e) {
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.ShowDialog();
			ofd.ShowDialog();
			try {
				System.IO.StreamReader sr = new System.IO.StreamReader(ofd.FileName);
				ReplaceTextBox.Text = sr.ReadToEnd();
				sr.Close();
			} catch (Exception ex) {
			}
		}
	}
}