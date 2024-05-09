/* =======================================
 * Syntware Client v4.3
 * Author: Artem Romanov
 * Group: Nordteam (t.me/nordteamdev)
 * License: MIT
 * =======================================
 */

using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;


namespace Client {
    public partial class Main : Form {

        public ChromiumWebBrowser chromium;
        public string gameurl = "https://url.com";
        public string serverTwo = "https://url.com";
        public Main() {
            #region Init CEF
            /*- Initialization CefSharp -*/
            CefSettings cefSettings = new CefSettings();
            cefSettings.CachePath = AppDomain.CurrentDomain.BaseDirectory + "flash\\cache";
            cefSettings.CefCommandLineArgs.Add("persist_session_cookies", "true");
            cefSettings.CefCommandLineArgs.Add("enable-npapi", "true");
            cefSettings.CefCommandLineArgs.Add("enable-system-flash", "true");
            cefSettings.CefCommandLineArgs.Add("ppapi-flash-path", AppDomain.CurrentDomain.BaseDirectory + @"flash\patch.dll");
            cefSettings.CefCommandLineArgs.Add("ppapi-flash-version", "32.22.0.0.209");
            cefSettings.CefCommandLineArgs.Add("profile.managed_plugins_allowed_for_urls", "[\"https://*\", \"http://*\"]");
            cefSettings.CefCommandLineArgs.Add("plugins.run_all_flash_in_allow_mode", "true");
            cefSettings.CefCommandLineArgs.Add("webkit.webprefs.plugins_enabled", "true");
            cefSettings.CefCommandLineArgs.Add("plugins.allow_outdated", "true");
            cefSettings.PersistSessionCookies = true;
            cefSettings.CefCommandLineArgs.Add("plugin-policy", "allow");
            #endregion

            Cef.Initialize(cefSettings);
            InitializeComponent();

            /*- Flash autoplay -*/
            var contx = Cef.GetGlobalRequestContext();
            Cef.UIThreadTaskFactory.StartNew(delegate {
                contx.SetPreference("profile.default_content_setting_values.plugins", 1, out string err);
            });
        }

        public void Main_Load(object sender, EventArgs e) {
            // CefSharp setup (component initialization)
            chromium = new ChromiumWebBrowser(gameurl);
            SubmenuPanel.Controls.Add(chromium);
            chromium.Dock = DockStyle.Fill;

            Timer.Interval = 10;
            Timer.Enabled = true;
            Timer.Start();

            // Checking the location of the cache directory (relevant for manual cleaning)
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"flash\cache")) {
                return;
            } else {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"flash\cache");
            }

        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        #region Clear Cache
        public void ClearCache() {
            System.Diagnostics.Process.Start("cleaner.bat");
            Application.Exit();

        }
        #endregion
        #region Timer
        /* Timer setting */
        private void Timer_Tick(object sender, EventArgs e) {
            Time.Text = DateTime.Now.ToString("HH:mm");
        }
        #endregion
        #region CEFSharp Buttons
        private void RefreshButton_Click(object sender, EventArgs e) {
            this.chromium.Reload(true);
        }

        private void BackPageButton_Click(object sender, EventArgs e) {
            this.chromium.Back();
        }

        private void ForwardPageButton_Click(object sender, EventArgs e) {
            this.chromium.Forward();
        }
        public void ChangeZoom(double change) => this.chromium.GetZoomLevelAsync().ContinueWith((Action<Task<double>>)(previous => {
            if (!previous.IsCompleted)
                throw new InvalidOperationException("Unexpected failure of calling CEF->GetZoomLevelAsync", (Exception)previous.Exception);
            this.chromium.SetZoomLevel(previous.Result + change);
        }), TaskContinuationOptions.ExecuteSynchronously);
        private void ScalePlusButton_Click(object sender, EventArgs e) {
            this.ChangeZoom(0.5);
        }

        private void ScaleMinusButton_Click(object sender, EventArgs e) {
            this.ChangeZoom(-0.5);
        }
        #endregion
        #region Child Form
        private Form activeForm = null;
        private void openChildForm(Form childform) {
            if(activeForm != null) {
                activeForm.Close();
            }
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            SubPanel.Controls.Add(childform);
            SubPanel.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        #endregion
        #region Buttons
        private void NotepadIconButton_Click(object sender, EventArgs e) {
            if (SubPanel.Visible) {
                SubPanel.Visible = false;
            } else {
                SubPanel.Visible = true;
                openChildForm(new Notepad());
            }
        }

        private void FolderIcon_Click(object sender, EventArgs e) {
            Process.Start("explorer", AppContext.BaseDirectory);
        }

        private void ClearCacheButton_Click(object sender, EventArgs e) {
            const string message = "Вы уверены что хотите очистить кэш?\nРазработчик не гарантирует полную очистку кэша.";
            const string caption = "Очистка кэша";

            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes) { ClearCache(); }
        }
        #endregion
        #region Do not open
        private void Time_DoubleClick(object sender, EventArgs e) {
            MessageBox.Show("Author: Romanov\n生き続けるか、人間にとどまる。\n\nSHA-256: b0c9276a92edfdf2128b25cbdd2c2edd0ba59339862911ad38c26087d229e3a3\nProduct Key (B64): Tk9SRC1LRVk6MjQvMDM6Om9mZmljaWFs");
        }
        #endregion
        #region Tabs

        private void TabsSwitcher_Click(object sender, EventArgs e)
        {
            if(TabsPanel.Visible)
            {
                TabsPanel.Visible = false;
            } else { TabsPanel.Visible = true; }
        }

        private void addTab_Click(object sender, EventArgs e)
        {
            if (server1.Visible && server2.Visible) {
                MessageBox.Show("Нельзя создать больше 2-х вкладок.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                if (addTabPanel.Visible) {
                    addTabPanel.Visible = false;
                } else { addTabPanel.Visible = true; }
            }
        }

        private void addTab_cancel_Click(object sender, EventArgs e)
        {
            addTabPanel.Visible = false;
        }
        public string Userver1 = "";
        public string Userver2 = "";

        public void button_addTab_Click(object sender, EventArgs e)
        {
            if (!server1.Visible)
            {
                if (tb_URL.Text != "")
                {
                    if (tb_Name.Text != "")
                    {
                        server1.Text = tb_Name.Text;
                        chromium.Load(tb_URL.Text);
                        Userver1 = tb_URL.Text;
                        SubmenuPanel.Controls.Add(chromium);
                        server1.Visible = true;
                            
                        addTabPanel.Visible = false;
                    }
                }
            } else
            {
                if (tb_URL.Text != "")
                {
                    if (tb_Name.Text != "")
                    {
                        server2.Text = tb_Name.Text;
                        chromium.Load(tb_URL.Text);
                        SubmenuPanel.Controls.Add(chromium);
                        server2.Visible = true;
                        Userver2 = tb_URL.Text;

                        addTabPanel.Visible = false;
                    }
                }
            }
        }

        private void server1_Click(object sender, EventArgs e)
        {
            if (server1.Visible)
            {
                //chromium.Load(Userver1);
                //SubmenuPanel.Controls.Add(chromium);

                chromium.Load(serverTwo);
                Userver1 = tb_URL.Text;
                SubmenuPanel.Controls.Add(chromium);
                server1.Visible = true;

                addTabPanel.Visible = false;
            }
        }

        private void server2_Click(object sender, EventArgs e)
        {
            if (server2.Visible)
            {
                chromium.Load(Userver2);
                SubmenuPanel.Controls.Add(chromium);
            }

        }

        private void DefaultTab_Click(object sender, EventArgs e) {

            //if (chromium.Visible) {
            //    chromium.Visible = false;
            //} else { chromium.Visible = true; }


            chromium.Load(gameurl);
            SubmenuPanel.Controls.Add(chromium);
        }

        private void server2_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                DialogResult result = MessageBox.Show("Закрыть вкладку?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK) {
                    server2.Visible = false;
                    chromium.Load(Userver1);
                }
            }
        }

        private void server2_MouseEnter(object sender, EventArgs e) {
            ToolTip t = new ToolTip();
            t.SetToolTip(server2, "Открыт сервер по ссылке:\n" + serverTwo + "\n\nЕсли вы переключитесь на эту вкладку — она будет перезагружена.");
        }

        private void server1_MouseEnter(object sender, EventArgs e) {
            ToolTip t = new ToolTip();
            t.SetToolTip(server1, "Открыт сервер по ссылке:\n" + serverTwo + "\n\nЕсли вы переключитесь на эту вкладку — она будет перезагружена.");
        }

        private void DefaultTab_MouseEnter(object sender, EventArgs e) {
            ToolTip t = new ToolTip();
            t.SetToolTip(DefaultTab, "Открыт сервер по ссылке:\n" + gameurl + "\n\nЕсли вы переключитесь на эту вкладку — она будет перезагружена.");
        }

        private void server1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                DialogResult result = MessageBox.Show("Закрыть вкладку?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK) {
                    server1.Visible = false;
                    chromium.Load(gameurl);
                }
            }
        }

        private void devtools_Click(object sender, EventArgs e) {
            chromium.ShowDevTools();
        }
        #endregion
    }
}