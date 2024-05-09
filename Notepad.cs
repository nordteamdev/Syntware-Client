using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Client {
    public partial class Notepad : Form {
        public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public Notepad() {
            InitializeComponent();
        }

        private void Textbox_TextChanged(object sender, EventArgs e) {
            CountSymbLabel.Text = Textbox.Text.Length.ToString(CultureInfo.InvariantCulture);
            CountLinesLabel.Text = Convert.ToString(Textbox.Lines.Length);
        }

        private void SaveIcon_Click(object sender, EventArgs e) {
            { // Test-version
                saveFileDialog1.InitialDirectory = @"C:\";
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = "*.txt";
                saveFile.Filter = "Text files|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName.Length > 0) {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.InitialDirectory, true)) {
                        sw.WriteLine(Textbox.Text);
                        sw.Close();
                    }
                }
            }
        }
    }
}
