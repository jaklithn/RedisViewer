namespace RedisViewer
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpDatabases = new System.Windows.Forms.GroupBox();
            this.optDatabase1 = new System.Windows.Forms.RadioButton();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.grdKeys = new System.Windows.Forms.DataGridView();
            this.keyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.versionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblKeyCount = new System.Windows.Forms.Label();
            this.grpRetrieve = new System.Windows.Forms.GroupBox();
            this.txtValuePart = new System.Windows.Forms.TextBox();
            this.txtKeyPart = new System.Windows.Forms.TextBox();
            this.btnGetByValue = new System.Windows.Forms.Button();
            this.btnGetByKey = new System.Windows.Forms.Button();
            this.txtContent = new ICSharpCode.TextEditor.TextEditorControl();
            this.grpDatabases.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdKeys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyItemBindingSource)).BeginInit();
            this.grpRetrieve.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatabases
            // 
            this.grpDatabases.Controls.Add(this.optDatabase1);
            this.grpDatabases.Location = new System.Drawing.Point(12, 12);
            this.grpDatabases.Name = "grpDatabases";
            this.grpDatabases.Size = new System.Drawing.Size(546, 55);
            this.grpDatabases.TabIndex = 0;
            this.grpDatabases.TabStop = false;
            this.grpDatabases.Text = "Select Database";
            // 
            // optDatabase1
            // 
            this.optDatabase1.Appearance = System.Windows.Forms.Appearance.Button;
            this.optDatabase1.Location = new System.Drawing.Point(6, 19);
            this.optDatabase1.Name = "optDatabase1";
            this.optDatabase1.Size = new System.Drawing.Size(104, 24);
            this.optDatabase1.TabIndex = 0;
            this.optDatabase1.TabStop = true;
            this.optDatabase1.Text = "Name1";
            this.optDatabase1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.optDatabase1.UseVisualStyleBackColor = true;
            this.optDatabase1.CheckedChanged += new System.EventHandler(this.Database_CheckedChanged);
            // 
            // btnGetAll
            // 
            this.btnGetAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetAll.Location = new System.Drawing.Point(52, 22);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(75, 23);
            this.btnGetAll.TabIndex = 1;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // grdKeys
            // 
            this.grdKeys.AllowUserToAddRows = false;
            this.grdKeys.AllowUserToDeleteRows = false;
            this.grdKeys.AllowUserToResizeRows = false;
            this.grdKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grdKeys.AutoGenerateColumns = false;
            this.grdKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyDataGridViewTextBoxColumn,
            this.versionDataGridViewTextBoxColumn,
            this.Name1,
            this.Name2,
            this.valueDataGridViewTextBoxColumn});
            this.grdKeys.DataSource = this.keyItemBindingSource;
            this.grdKeys.Location = new System.Drawing.Point(12, 73);
            this.grdKeys.Name = "grdKeys";
            this.grdKeys.ReadOnly = true;
            this.grdKeys.RowHeadersWidth = 20;
            this.grdKeys.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdKeys.Size = new System.Drawing.Size(660, 673);
            this.grdKeys.TabIndex = 2;
            // 
            // keyDataGridViewTextBoxColumn
            // 
            this.keyDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keyDataGridViewTextBoxColumn.DataPropertyName = "Key";
            this.keyDataGridViewTextBoxColumn.HeaderText = "Key";
            this.keyDataGridViewTextBoxColumn.Name = "keyDataGridViewTextBoxColumn";
            this.keyDataGridViewTextBoxColumn.ReadOnly = true;
            this.keyDataGridViewTextBoxColumn.Visible = false;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            this.versionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            this.versionDataGridViewTextBoxColumn.FillWeight = 20F;
            this.versionDataGridViewTextBoxColumn.HeaderText = "Version";
            this.versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            this.versionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Name1
            // 
            this.Name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name1.DataPropertyName = "Name1";
            this.Name1.FillWeight = 25F;
            this.Name1.HeaderText = "Name1";
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Name2
            // 
            this.Name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name2.DataPropertyName = "Name2";
            this.Name2.FillWeight = 25F;
            this.Name2.HeaderText = "Name2";
            this.Name2.Name = "Name2";
            this.Name2.ReadOnly = true;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.FillWeight = 30F;
            this.valueDataGridViewTextBoxColumn.HeaderText = "Value";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keyItemBindingSource
            // 
            this.keyItemBindingSource.AllowNew = false;
            this.keyItemBindingSource.DataSource = typeof(RedisViewer.Entities.KeyItem);
            this.keyItemBindingSource.CurrentChanged += new System.EventHandler(this.keyItemBindingSource_CurrentChanged);
            // 
            // lblKeyCount
            // 
            this.lblKeyCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblKeyCount.Location = new System.Drawing.Point(564, 47);
            this.lblKeyCount.Name = "lblKeyCount";
            this.lblKeyCount.Size = new System.Drawing.Size(108, 20);
            this.lblKeyCount.TabIndex = 3;
            this.lblKeyCount.Text = "0 keys";
            this.lblKeyCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpRetrieve
            // 
            this.grpRetrieve.Controls.Add(this.txtValuePart);
            this.grpRetrieve.Controls.Add(this.txtKeyPart);
            this.grpRetrieve.Controls.Add(this.btnGetByValue);
            this.grpRetrieve.Controls.Add(this.btnGetByKey);
            this.grpRetrieve.Controls.Add(this.btnGetAll);
            this.grpRetrieve.Location = new System.Drawing.Point(678, 12);
            this.grpRetrieve.Name = "grpRetrieve";
            this.grpRetrieve.Size = new System.Drawing.Size(705, 55);
            this.grpRetrieve.TabIndex = 4;
            this.grpRetrieve.TabStop = false;
            this.grpRetrieve.Text = "Retrieve";
            // 
            // txtValuePart
            // 
            this.txtValuePart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValuePart.Location = new System.Drawing.Point(466, 21);
            this.txtValuePart.Name = "txtValuePart";
            this.txtValuePart.Size = new System.Drawing.Size(100, 20);
            this.txtValuePart.TabIndex = 5;
            // 
            // txtKeyPart
            // 
            this.txtKeyPart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKeyPart.Location = new System.Drawing.Point(174, 23);
            this.txtKeyPart.Name = "txtKeyPart";
            this.txtKeyPart.Size = new System.Drawing.Size(100, 20);
            this.txtKeyPart.TabIndex = 4;
            // 
            // btnGetByValue
            // 
            this.btnGetByValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetByValue.Location = new System.Drawing.Point(572, 19);
            this.btnGetByValue.Name = "btnGetByValue";
            this.btnGetByValue.Size = new System.Drawing.Size(127, 23);
            this.btnGetByValue.TabIndex = 3;
            this.btnGetByValue.Text = "Get by Value part";
            this.btnGetByValue.UseVisualStyleBackColor = true;
            this.btnGetByValue.Click += new System.EventHandler(this.btnGetByValue_Click);
            // 
            // btnGetByKey
            // 
            this.btnGetByKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetByKey.Location = new System.Drawing.Point(280, 21);
            this.btnGetByKey.Name = "btnGetByKey";
            this.btnGetByKey.Size = new System.Drawing.Size(127, 23);
            this.btnGetByKey.TabIndex = 2;
            this.btnGetByKey.Text = "Get by Key part";
            this.btnGetByKey.UseVisualStyleBackColor = true;
            this.btnGetByKey.Click += new System.EventHandler(this.btnGetByKey_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtContent.IsReadOnly = false;
            this.txtContent.Location = new System.Drawing.Point(678, 73);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(705, 673);
            this.txtContent.TabIndex = 5;
            this.txtContent.VRulerRow = 0;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1395, 758);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.grpRetrieve);
            this.Controls.Add(this.lblKeyCount);
            this.Controls.Add(this.grdKeys);
            this.Controls.Add(this.grpDatabases);
            this.Name = "Start";
            this.Text = "Redis Viewer";
            this.Load += new System.EventHandler(this.Start_Load);
            this.grpDatabases.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdKeys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyItemBindingSource)).EndInit();
            this.grpRetrieve.ResumeLayout(false);
            this.grpRetrieve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatabases;
        private System.Windows.Forms.RadioButton optDatabase1;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.DataGridView grdKeys;
        private System.Windows.Forms.BindingSource keyItemBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblKeyCount;
        private System.Windows.Forms.GroupBox grpRetrieve;
        private System.Windows.Forms.Button btnGetByValue;
        private System.Windows.Forms.Button btnGetByKey;
        private System.Windows.Forms.TextBox txtValuePart;
        private System.Windows.Forms.TextBox txtKeyPart;
        private ICSharpCode.TextEditor.TextEditorControl txtContent;
    }
}

