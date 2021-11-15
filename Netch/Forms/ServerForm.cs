#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Netch.Models;
using Netch.Properties;
using Netch.Utils;
using Netch.Servers;
using System.Net;
using System.IO;
using Newtonsoft.Json;
namespace Netch.Forms
{
    [DesignerCategory(@"Code")]
    public abstract class ServerForm : Form
    {
        private const int ControlLineHeight = 28;
        private const int InputBoxWidth = 294;

        private readonly Dictionary<Control, Func<string, bool>> _checkActions = new();

        private readonly Dictionary<Control, Action<object>> _saveActions = new();

        private int _controlLines = 2;
        private Label UserIdLabel;
        protected TextBox UserIdTextBox;

        private readonly IContainer components = null;

        private GroupBox ConfigurationGroupBox;
        private Label PortLabel;
        private TextBox PortTextBox;
        private Label ServerIpLabel;
        protected TextBox ServerIpTextBox;
        private Label RemeberLabel;
        protected CheckBox RemeberButton;
        private String serverIp;
        private String userId;

        protected ServerForm()
        {
            InitializeComponent();

            // _checkActions.Add(ServerIpTextBox, s => true);
            _saveActions.Add(ServerIpTextBox, s => serverIp = (string)s);

            // _checkActions.Add(UserIdTextBox, s => s != string.Empty);
            _saveActions.Add(UserIdTextBox, s => userId = (string)s);


            // _checkActions.Add(PortTextBox, s => ushort.TryParse(s, out var port) && port != 0);
            // _saveActions.Add(PortTextBox, s => Server.Port = ushort.Parse((string)s));
        }

        protected abstract string TypeName { get; }

        protected Server Server { get; set; }

        public new void ShowDialog()
        {
            AfterFactor();
            base.ShowDialog();
        }

        public new void Show()
        {
            AfterFactor();
            base.Show();
        }

        private void AfterFactor()
        {
            Text = TypeName ?? string.Empty;

            ServerIpTextBox.Text = Server.Remark;
            UserIdTextBox.Text = Server.Hostname;
            PortTextBox.Text = Server.Port.ToString();

            AddSaveButton();
            i18N.TranslateForm(this);
            displayUserData();

            ConfigurationGroupBox.Enabled = !Server.IsInGroup();

            ConfigurationGroupBox.ResumeLayout(false);
            ConfigurationGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void displayUserData()
        {
            if (File.Exists(Global.NetchDir + "data\\user.json"))
            {
                StorageData storage = new StorageData();
                string st = storage.GetJsonFile(Global.NetchDir + "data\\user.json");
                if (!string.IsNullOrEmpty(st))
                {
                    UserData obj = JsonConvert.DeserializeObject<UserData>(st);
                    ServerIpTextBox.Text = obj.ip;
                    UserIdTextBox.Text = obj.userId;
                }
            }
        }

        protected void CreateTextBox(string name,
            string remark,
            Func<string, bool> check,
            Action<string> save,
            string value,
            int width = InputBoxWidth)
        {
            _controlLines++;

            var textBox = new TextBox
            {
                Location = new Point(120, ControlLineHeight * _controlLines),
                Name = $"{name}TextBox",
                Size = new Size(width, 23),
                TextAlign = HorizontalAlignment.Center,
                Text = value
            };

            _checkActions.Add(textBox, check);
            _saveActions.Add(textBox, o => save.Invoke((string)o));
            ConfigurationGroupBox.Controls.AddRange(new Control[]
            {
                textBox,
                new Label
                {
                    AutoSize = true,
                    Location = new Point(10, ControlLineHeight * _controlLines),
                    Name = $"{name}Label",
                    Size = new Size(56, 17),
                    Text = remark
                }
            });
        }

        protected void CreateComboBox(string name, string remark, List<string> values, Action<string> save, string value, int width = InputBoxWidth)
        {
            _controlLines++;

            var comboBox = new ComboBox
            {
                Location = new Point(120, ControlLineHeight * _controlLines),
                Name = $"{name}ComboBox",
                Size = new Size(width, 23),
                DrawMode = DrawMode.OwnerDrawFixed,
                DropDownStyle = ComboBoxStyle.DropDownList,
                FormattingEnabled = true
            };

            comboBox.Items.AddRange(values.ToArray());
            comboBox.SelectedIndex = values.IndexOf(value);
            comboBox.DrawItem += Utils.Utils.DrawCenterComboBox;
            _saveActions.Add(comboBox, o => save.Invoke((string)o));
            ConfigurationGroupBox.Controls.AddRange(new Control[]
            {
                comboBox,
                new Label
                {
                    AutoSize = true,
                    Location = new Point(10, ControlLineHeight * _controlLines),
                    Name = $"{name}Label",
                    Size = new Size(56, 17),
                    Text = remark
                }
            });
        }

        protected void CreateCheckBox(string name, string remark, Action<bool> save, bool value)
        {
            _controlLines++;

            var checkBox = new CheckBox
            {
                AutoSize = true,
                Location = new Point(120, ControlLineHeight * _controlLines),
                Name = $"{name}CheckBox",
                Checked = value,
                Text = remark
            };

            _saveActions.Add(checkBox, o => save.Invoke((bool)o));
            ConfigurationGroupBox.Controls.AddRange(new Control[]
            {
                checkBox
            });
        }

        private void AddSaveButton()
        {
            _controlLines++;
            var control = new Button
            {
                Location = new Point(340, _controlLines * ControlLineHeight + 10),
                Name = "ControlButton",
                Size = new Size(75, 23),
                Text = "Save",
                UseVisualStyleBackColor = true
            };

            control.Click += ControlButton_Click;
            ConfigurationGroupBox.Controls.Add(control);
        }

        private void RemeberButton_CheckedChanged(object sender, EventArgs e)
        {
            // RemeberButton.Checked = !RemeberButton.Checked;
            Console.WriteLine("点击了选中框");
            if (RemeberButton.Checked)
            {
                Console.WriteLine("选中");
            }
            else
            {
                Console.WriteLine("没有选中");
            }
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            Utils.Utils.ComponentIterator(this, component => Utils.Utils.ChangeControlForeColor(component, Color.Black));

            var flag = true;
            foreach (var pair in _checkActions.Where(pair => !pair.Value.Invoke(pair.Key.Text)))
            {
                Utils.Utils.ChangeControlForeColor(pair.Key, Color.Red);
                flag = false;
            }

            if (!flag)
                return;

            foreach (var pair in _saveActions)
                switch (pair.Key)
                {
                    case CheckBox c:
                        pair.Value.Invoke(c.Checked);
                        break;
                    default:
                        pair.Value.Invoke(pair.Key.Text);
                        break;
                }
            // Global.Settings.Server.Clear();
            // if (Global.Settings.Server.IndexOf(Server) == -1)
            //     Global.Settings.Server.Add(Server);
            if (string.IsNullOrEmpty(serverIp))
            {
                MessageBoxX.Show("服务器地址不能为空！");
                return;
            }
            else if (string.IsNullOrEmpty(userId))
            {
                MessageBoxX.Show("用户id不能为空！");
                return;
            };

            if (RemeberButton.Checked)
            {
                //选中记住，将数据保存在本地
                UserData u = new UserData { ip = serverIp, userId = userId };
                var json = JsonConvert.SerializeObject(u);
                StorageData storage = new StorageData();
                if (File.Exists(Global.NetchDir + "data\\user.json"))
                {
                    File.Delete(Global.NetchDir + "data\\user.json");
                }
                storage.WriteJsonFile(Global.NetchDir + "data\\user.json", json);

            }
            else
            {
                if (File.Exists(Global.NetchDir + "data\\user.json"))
                {
                    File.Delete(Global.NetchDir + "data\\user.json");
                }
            }
            Global.Settings.Server.Clear();
            //发起网络请求从服务器端获取配置 
            string url = serverIp + "/ostrich/api/mobile/server/lists";
            string id = userId;
            string response = WebUtil.PostRequest(url, id);
            Console.WriteLine("打印服务器请求内容");
            Console.WriteLine(response);
            if (response == "error")
            {
                MessageBoxX.Show("请检查你的服务器地址或者网络情况！");
                return;
            }
            Root obj = JsonConvert.DeserializeObject<Root>(response);
            Console.WriteLine(obj.code);
            if (obj.code == 200)
            {
                MessageBoxX.Show(obj.msg);

                for (int i = 0; i < obj.ret.server.Count; i++)
                {
                    Trojan trojanServer = new Trojan();
                    trojanServer.Remark = obj.ret.server[i].country;
                    trojanServer.Host = obj.ret.server[i].ip;
                    trojanServer.Password = obj.ret.server[i].passwd;
                    trojanServer.Port = ushort.Parse(obj.ret.server[i].port.ToString());
                    /// hostname-----sni
                    trojanServer.Hostname = obj.ret.server[i].ip;
                    Global.Settings.Server.Add(trojanServer);
                }

            }
            else
            {
                MessageBoxX.Show(obj.msg);
            }

            Close();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                components?.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            ConfigurationGroupBox = new GroupBox();
            UserIdLabel = new Label();
            PortTextBox = new TextBox();
            UserIdTextBox = new TextBox();
            ServerIpTextBox = new TextBox();
            ServerIpLabel = new Label();
            PortLabel = new Label();
            RemeberLabel = new Label();
            RemeberButton = new CheckBox();
            ConfigurationGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ConfigurationGroupBox
            // 
            ConfigurationGroupBox.AutoSize = true;
            ConfigurationGroupBox.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ConfigurationGroupBox.Controls.Add(UserIdLabel);
            // ConfigurationGroupBox.Controls.Add(PortTextBox);
            ConfigurationGroupBox.Controls.Add(UserIdTextBox);
            ConfigurationGroupBox.Controls.Add(ServerIpTextBox);
            ConfigurationGroupBox.Controls.Add(ServerIpLabel);
            ConfigurationGroupBox.Controls.Add(RemeberLabel);
            ConfigurationGroupBox.Controls.Add(RemeberButton);
            // ConfigurationGroupBox.Controls.Add(PortLabel);
            ConfigurationGroupBox.Dock = DockStyle.Fill;
            ConfigurationGroupBox.Location = new Point(5, 5);
            ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            ConfigurationGroupBox.Size = new Size(434, 127);
            ConfigurationGroupBox.TabIndex = 0;
            ConfigurationGroupBox.TabStop = false;
            ConfigurationGroupBox.Text = "Configuration";
            // 
            // UserIdLabel
            // 
            UserIdLabel.AutoSize = true;
            UserIdLabel.Location = new Point(10, ControlLineHeight * 2);
            UserIdLabel.Name = "UserIdLabel";
            UserIdLabel.Size = new Size(56, 17);
            UserIdLabel.TabIndex = 2;
            UserIdLabel.Text = "用户ID:";
            // 
            // PortTextBox
            // 
            // PortTextBox.Location = new Point(358, ControlLineHeight * 2);
            // PortTextBox.Name = "PortTextBox";
            // PortTextBox.Size = new Size(56, 23);
            // PortTextBox.TabIndex = 5;
            // PortTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UserIdTextBox
            // 
            UserIdTextBox.Location = new Point(120, ControlLineHeight * 2);
            UserIdTextBox.Name = "UserIdTextBox";
            UserIdTextBox.Size = new Size(294, 23);
            UserIdTextBox.TabIndex = 3;
            UserIdTextBox.TextAlign = HorizontalAlignment.Center;

            //
            //RemeberLaber
            //
            RemeberLabel.Location = new Point(10, ControlLineHeight * 3);
            RemeberLabel.Name = "RemoberLabel";
            RemeberLabel.Size = new Size(56, 17);
            RemeberLabel.TabIndex = 4;
            RemeberLabel.Text = "记住:";
            //
            //RemeberButton
            //
            // 
            RemeberButton.Location = new Point(120, ControlLineHeight * 3);
            RemeberButton.TabIndex = 5;
            RemeberButton.Size = new Size(56, 17);
            RemeberButton.Checked = true;
            RemeberButton.CheckedChanged += new EventHandler(RemeberButton_CheckedChanged);

            // ServerIpTextBox
            // 
            ServerIpTextBox.Location = new Point(120, ControlLineHeight);
            ServerIpTextBox.Name = "ServerIpTextBox";
            ServerIpTextBox.Size = new Size(294, 23);
            ServerIpTextBox.TabIndex = 1;
            ServerIpTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ServerIpLabel
            // 
            ServerIpLabel.AutoSize = true;
            ServerIpLabel.Location = new Point(10, ControlLineHeight);
            ServerIpLabel.Name = "ServerIpLabel";
            ServerIpLabel.Size = new Size(53, 17);
            ServerIpLabel.TabIndex = 0;
            ServerIpLabel.Text = "服务器地址：";
            // 
            // PortLabel
            // 
            // PortLabel.AutoSize = true;
            // PortLabel.Location = new Point(351, ControlLineHeight * 2);
            // PortLabel.Name = "PortLabel";
            // PortLabel.Size = new Size(11, 17);
            // PortLabel.TabIndex = 4;
            // PortLabel.Text = ":";
            // 
            // ServerForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(444, 137);
            Controls.Add(ConfigurationGroupBox);
            Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = Icon.FromHandle(Resources.Netch.GetHicon());
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ServerForm";
            Padding = new Padding(11, 5, 11, 4);
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}