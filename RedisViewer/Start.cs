using RedisViewer.Entities;
using RedisViewer.Extenders;
using RedisViewer.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace RedisViewer
{
    public partial class Start : Form
    {
        private string _connectionString;

        public Start()
        {
            InitializeComponent();
            LoadConnections();
            HighlightingManager.Manager.AddSyntaxModeFileProvider(new AppSyntaxModeProvider());
            txtContent.SetHighlighting("JavaScript");
            //txtContent.SetHighlighting("Json");
        }

        private void LoadConnections()
        {
            var connections = Settings.GetConnections();

            grpDatabases.Controls.Clear();
            foreach (var connection in connections)
            {
                const int width = 80;
                const int offset = 6;
                var left = offset + grpDatabases.Controls.Count * (width + offset);
                var button = new RadioButton
                {
                    Name = $"optDatabase{grpDatabases.Controls.Count + 1}",
                    Text = connection.Key,
                    Tag = connection.Value,
                    Checked = false,
                    AutoCheck = true,
                    Appearance = Appearance.Button,
                    AutoSize = false,
                    Location = new Point(left, 19),
                    Size = new Size(width, 23),
                    TabStop = true,
                    TextAlign = ContentAlignment.MiddleCenter,
                    UseVisualStyleBackColor = true
                };
                grpDatabases.Controls.Add(button);
                button.CheckedChanged += Database_CheckedChanged;
            }

            btnGetAll.Focus();
        }

        private void LoadKeys(string keyPart, string valuePart)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                keyItemBindingSource.DataSource = null;
                lblKeyCount.Text = "0 items";

                if (_connectionString.IsSpecified())
                {
                    using (var redis = new RedisService(_connectionString))
                    {
                        IList<string> keys;
                        if (keyPart.IsSpecified())
                        {
                            keys = redis.FindByKey(keyPart).Result.ToList();
                        }
                        else if (valuePart.IsSpecified())
                        {
                            keys = redis.FindByValue(valuePart).Result;
                        }
                        else
                        {
                            keys = redis.GetAllKeys();
                        }
                        var keyItems = keys.Select(x => new KeyItem(x)).OrderBy(x => x.Key).ToList();
                        lblKeyCount.Text = $"{keyItems.Count} items";
                        keyItemBindingSource.DataSource = keyItems;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadKeys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void LoadValue()
        {
            try
            {
                Cursor = Cursors.WaitCursor; txtContent.Text = null;
                if (keyItemBindingSource.Current is KeyItem selectedKey)
                {
                    using (var redis = new RedisService(_connectionString))
                    {
                        var json = redis.GetValue(selectedKey.Key);
                        var jsonFormatted = JToken.Parse(json).ToString(Formatting.Indented);
                        txtContent.Text = jsonFormatted;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadValue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }


        #region Event Handlers

        private void Start_Load(object sender, EventArgs e)
        {
        }

        #endregion

        private void Database_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                _connectionString = radioButton.Tag.ToString();
                keyItemBindingSource.DataSource = null;
            }
        }

        private void btnGetAll_Click(object sender, EventArgs e)
        {
            txtKeyPart.Text = null;
            txtKeyPart.Text = null;
            LoadKeys(null, null);
        }

        private void btnGetByKey_Click(object sender, EventArgs e)
        {
            LoadKeys(txtKeyPart.Text, null);
        }

        private void btnGetByValue_Click(object sender, EventArgs e)
        {
            LoadKeys(null, txtValuePart.Text);
        }

        private void keyItemBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            LoadValue();
        }
    }
}