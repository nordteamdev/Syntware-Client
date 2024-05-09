
namespace Client {
    partial class Notepad {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.BottomInfoPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.NameSymbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountSymbLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Split = new System.Windows.Forms.ToolStripStatusLabel();
            this.LinesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CountLinesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.NameForm = new System.Windows.Forms.Label();
            this.SaveIcon = new FontAwesome.Sharp.IconPictureBox();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.BottomInfoPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // BottomInfoPanel
            // 
            this.BottomInfoPanel.Controls.Add(this.statusStrip1);
            this.BottomInfoPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomInfoPanel.Location = new System.Drawing.Point(0, 559);
            this.BottomInfoPanel.Name = "BottomInfoPanel";
            this.BottomInfoPanel.Size = new System.Drawing.Size(297, 30);
            this.BottomInfoPanel.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NameSymbLabel,
            this.CountSymbLabel,
            this.Split,
            this.LinesLabel,
            this.CountLinesLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 8);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(297, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // NameSymbLabel
            // 
            this.NameSymbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameSymbLabel.Name = "NameSymbLabel";
            this.NameSymbLabel.Size = new System.Drawing.Size(64, 17);
            this.NameSymbLabel.Text = "Символов: ";
            // 
            // CountSymbLabel
            // 
            this.CountSymbLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountSymbLabel.Name = "CountSymbLabel";
            this.CountSymbLabel.Size = new System.Drawing.Size(13, 17);
            this.CountSymbLabel.Text = "0";
            // 
            // Split
            // 
            this.Split.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Split.Name = "Split";
            this.Split.Size = new System.Drawing.Size(15, 17);
            this.Split.Text = " | ";
            // 
            // LinesLabel
            // 
            this.LinesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LinesLabel.Name = "LinesLabel";
            this.LinesLabel.Size = new System.Drawing.Size(43, 17);
            this.LinesLabel.Text = "Строк: ";
            // 
            // CountLinesLabel
            // 
            this.CountLinesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountLinesLabel.Name = "CountLinesLabel";
            this.CountLinesLabel.Size = new System.Drawing.Size(13, 17);
            this.CountLinesLabel.Text = "0";
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.TopPanel.Controls.Add(this.NameForm);
            this.TopPanel.Controls.Add(this.SaveIcon);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(297, 32);
            this.TopPanel.TabIndex = 1;
            // 
            // NameForm
            // 
            this.NameForm.AutoSize = true;
            this.NameForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameForm.ForeColor = System.Drawing.Color.White;
            this.NameForm.Location = new System.Drawing.Point(81, 8);
            this.NameForm.Name = "NameForm";
            this.NameForm.Size = new System.Drawing.Size(138, 16);
            this.NameForm.TabIndex = 1;
            this.NameForm.Text = "Быстрый Блокнот";
            // 
            // SaveIcon
            // 
            this.SaveIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.SaveIcon.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.SaveIcon.IconColor = System.Drawing.Color.White;
            this.SaveIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.SaveIcon.IconSize = 24;
            this.SaveIcon.Location = new System.Drawing.Point(7, 8);
            this.SaveIcon.Name = "SaveIcon";
            this.SaveIcon.Size = new System.Drawing.Size(24, 24);
            this.SaveIcon.TabIndex = 0;
            this.SaveIcon.TabStop = false;
            this.SaveIcon.Click += new System.EventHandler(this.SaveIcon_Click);
            // 
            // Textbox
            // 
            this.Textbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Textbox.ForeColor = System.Drawing.Color.White;
            this.Textbox.Location = new System.Drawing.Point(0, 32);
            this.Textbox.Multiline = true;
            this.Textbox.Name = "Textbox";
            this.Textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.Textbox.Size = new System.Drawing.Size(297, 527);
            this.Textbox.TabIndex = 2;
            this.Textbox.TextChanged += new System.EventHandler(this.Textbox_TextChanged);
            // 
            // Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 589);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.BottomInfoPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notepad";
            this.Text = "Notepad";
            this.BottomInfoPanel.ResumeLayout(false);
            this.BottomInfoPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaveIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel BottomInfoPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel NameSymbLabel;
        private System.Windows.Forms.ToolStripStatusLabel CountSymbLabel;
        private System.Windows.Forms.ToolStripStatusLabel Split;
        private System.Windows.Forms.ToolStripStatusLabel LinesLabel;
        private System.Windows.Forms.ToolStripStatusLabel CountLinesLabel;
        private System.Windows.Forms.Panel TopPanel;
        private FontAwesome.Sharp.IconPictureBox SaveIcon;
        private System.Windows.Forms.TextBox Textbox;
        protected System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label NameForm;
    }
}