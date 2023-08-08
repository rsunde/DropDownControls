namespace DemoApp
{
    partial class DemoForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoForm));
            label1 = new Label();
            label2 = new Label();
            imageList = new ImageList(components);
            label6 = new Label();
            rbVS = new RadioButton();
            rbPlain = new RadioButton();
            cmbList = new ComboBox();
            label7 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            chkRetainGroups = new CheckBox();
            label11 = new Label();
            rbDisabled = new RadioButton();
            rbEnabled = new RadioButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label12 = new Label();
            cmbEditable = new ComboBox();
            dsbExternal = new DropDownSearchBox();
            dsbListItems = new DropDownSearchBox();
            dataGridView1 = new DataGridView();
            Column1 = new DropDownControls.GroupedComboBoxColumn();
            Column2 = new DropDownControls.ComboTreeBoxColumn();
            ctbFlatChecks = new ComboTreeBox();
            ctbImages = new ComboTreeBox();
            ctbCheckboxes = new ComboTreeBox();
            gcbList = new GroupedComboBox();
            gcbEditable = new GroupedComboBox();
            ctbNormal = new ComboTreeBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 177);
            label1.Name = "label1";
            label1.Size = new Size(235, 33);
            label1.TabIndex = 8;
            label1.Text = "GroupedComboBox (editable)";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 144);
            label2.Name = "label2";
            label2.Size = new Size(235, 33);
            label2.TabIndex = 6;
            label2.Text = "GroupedComboBox (list)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth32Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "Closed");
            imageList.Images.SetKeyName(1, "Open");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 29);
            label6.Name = "label6";
            label6.Size = new Size(235, 29);
            label6.TabIndex = 10;
            label6.Text = "Visual styles";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbVS
            // 
            rbVS.AutoSize = true;
            rbVS.Checked = true;
            rbVS.Location = new Point(0, 0);
            rbVS.Margin = new Padding(0, 0, 6, 0);
            rbVS.Name = "rbVS";
            rbVS.Size = new Size(49, 23);
            rbVS.TabIndex = 0;
            rbVS.TabStop = true;
            rbVS.Text = "On";
            rbVS.UseVisualStyleBackColor = true;
            // 
            // rbPlain
            // 
            rbPlain.AutoSize = true;
            rbPlain.Location = new Point(55, 0);
            rbPlain.Margin = new Padding(0, 0, 6, 0);
            rbPlain.Name = "rbPlain";
            rbPlain.Size = new Size(49, 23);
            rbPlain.TabIndex = 1;
            rbPlain.Text = "Off";
            rbPlain.UseVisualStyleBackColor = true;
            // 
            // cmbList
            // 
            cmbList.Dock = DockStyle.Fill;
            cmbList.DropDownHeight = 150;
            cmbList.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbList.FormattingEnabled = true;
            cmbList.IntegralHeight = false;
            cmbList.Location = new Point(244, 61);
            cmbList.Name = "cmbList";
            cmbList.Size = new Size(277, 27);
            cmbList.Sorted = true;
            cmbList.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(3, 58);
            label7.Name = "label7";
            label7.Size = new Size(235, 33);
            label7.TabIndex = 2;
            label7.Text = "ComboBox (list) (.net)";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(rbVS);
            flowLayoutPanel1.Controls.Add(rbPlain);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(244, 32);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(277, 23);
            flowLayoutPanel1.TabIndex = 11;
            flowLayoutPanel1.WrapContents = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 210);
            label3.Name = "label3";
            label3.Size = new Size(235, 32);
            label3.TabIndex = 12;
            label3.Text = "ComboTreeBox (normal)";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 274);
            label4.Name = "label4";
            label4.Size = new Size(235, 32);
            label4.TabIndex = 16;
            label4.Text = "ComboTreeBox (checkboxes)";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 242);
            label5.Name = "label5";
            label5.Size = new Size(235, 32);
            label5.TabIndex = 14;
            label5.Text = "ComboTreeBox (images)";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(3, 306);
            label8.Name = "label8";
            label8.Size = new Size(235, 32);
            label8.TabIndex = 18;
            label8.Text = "ComboTreeBox (checkbox list)";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(3, 338);
            label9.Name = "label9";
            label9.Size = new Size(235, 32);
            label9.TabIndex = 20;
            label9.Text = "DropDownSearchBox (list items)";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(3, 399);
            label10.Name = "label10";
            label10.Size = new Size(235, 32);
            label10.TabIndex = 23;
            label10.Text = "DropDownSearchBox (external data)";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // chkRetainGroups
            // 
            chkRetainGroups.AutoSize = true;
            chkRetainGroups.Dock = DockStyle.Fill;
            chkRetainGroups.Location = new Point(244, 373);
            chkRetainGroups.Name = "chkRetainGroups";
            chkRetainGroups.Size = new Size(277, 23);
            chkRetainGroups.TabIndex = 22;
            chkRetainGroups.Text = "Show groups in search results";
            chkRetainGroups.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(235, 29);
            label11.TabIndex = 0;
            label11.Text = "State";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbDisabled
            // 
            rbDisabled.AutoSize = true;
            rbDisabled.Location = new Point(84, 0);
            rbDisabled.Margin = new Padding(0, 0, 6, 0);
            rbDisabled.Name = "rbDisabled";
            rbDisabled.Size = new Size(82, 23);
            rbDisabled.TabIndex = 1;
            rbDisabled.Text = "Disabled";
            rbDisabled.UseVisualStyleBackColor = true;
            // 
            // rbEnabled
            // 
            rbEnabled.AutoSize = true;
            rbEnabled.Checked = true;
            rbEnabled.Location = new Point(0, 0);
            rbEnabled.Margin = new Padding(0, 0, 6, 0);
            rbEnabled.Name = "rbEnabled";
            rbEnabled.Size = new Size(78, 23);
            rbEnabled.TabIndex = 0;
            rbEnabled.TabStop = true;
            rbEnabled.Text = "Enabled";
            rbEnabled.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel2.Controls.Add(rbEnabled);
            flowLayoutPanel2.Controls.Add(rbDisabled);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(244, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(277, 23);
            flowLayoutPanel2.TabIndex = 1;
            flowLayoutPanel2.WrapContents = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(3, 91);
            label12.Name = "label12";
            label12.Size = new Size(235, 33);
            label12.TabIndex = 4;
            label12.Text = "ComboBox (editable) (.net)";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbEditable
            // 
            cmbEditable.Dock = DockStyle.Fill;
            cmbEditable.DropDownHeight = 150;
            cmbEditable.FormattingEnabled = true;
            cmbEditable.IntegralHeight = false;
            cmbEditable.Location = new Point(244, 94);
            cmbEditable.Name = "cmbEditable";
            cmbEditable.Size = new Size(277, 27);
            cmbEditable.Sorted = true;
            cmbEditable.TabIndex = 2;
            // 
            // dsbExternal
            // 
            dsbExternal.Dock = DockStyle.Fill;
            dsbExternal.DropDownHeight = 300;
            dsbExternal.DroppedDown = false;
            dsbExternal.HotToNormal = 0;
            dsbExternal.Location = new Point(244, 402);
            dsbExternal.Name = "dsbExternal";
            dsbExternal.NormalToHot = 0;
            dsbExternal.PressedToNormal = 0;
            dsbExternal.SelectedNode = null;
            dsbExternal.ShowGlyphs = false;
            dsbExternal.Size = new Size(277, 26);
            dsbExternal.TabIndex = 10;
            dsbExternal.Visible = false;
            // 
            // dsbListItems
            // 
            dsbListItems.Dock = DockStyle.Fill;
            dsbListItems.DropDownHeight = 300;
            dsbListItems.DroppedDown = false;
            dsbListItems.HotToNormal = 0;
            dsbListItems.Location = new Point(244, 341);
            dsbListItems.Name = "dsbListItems";
            dsbListItems.NormalToHot = 0;
            dsbListItems.PressedToNormal = 0;
            dsbListItems.SelectedNode = null;
            dsbListItems.ShowGlyphs = false;
            dsbListItems.Size = new Size(277, 26);
            dsbListItems.TabIndex = 9;
            dsbListItems.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 454);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(518, 136);
            dataGridView1.TabIndex = 25;
            dataGridView1.Visible = false;
            // 
            // Column1
            // 
            Column1.DisplayMember = null;
            Column1.GroupMember = null;
            Column1.HeaderText = "GroupedComboBoxColumn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ValueMember = null;
            // 
            // Column2
            // 
            Column2.HeaderText = "ComboTreeBoxColumn";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Resizable = DataGridViewTriState.True;
            Column2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // ctbFlatChecks
            // 
            ctbFlatChecks.Dock = DockStyle.Fill;
            ctbFlatChecks.DroppedDown = false;
            ctbFlatChecks.HotToNormal = 0;
            ctbFlatChecks.Location = new Point(244, 309);
            ctbFlatChecks.Name = "ctbFlatChecks";
            ctbFlatChecks.NormalToHot = 0;
            ctbFlatChecks.PressedToNormal = 0;
            ctbFlatChecks.SelectedNode = null;
            ctbFlatChecks.ShowCheckBoxes = true;
            ctbFlatChecks.Size = new Size(277, 26);
            ctbFlatChecks.TabIndex = 8;
            ctbFlatChecks.Visible = false;
            // 
            // ctbImages
            // 
            ctbImages.Dock = DockStyle.Fill;
            ctbImages.DroppedDown = false;
            ctbImages.ExpandedImageIndex = 1;
            ctbImages.HotToNormal = 0;
            ctbImages.Images = imageList;
            ctbImages.Location = new Point(244, 245);
            ctbImages.Name = "ctbImages";
            ctbImages.NormalToHot = 0;
            ctbImages.PressedToNormal = 0;
            ctbImages.SelectedNode = null;
            ctbImages.Size = new Size(277, 26);
            ctbImages.TabIndex = 6;
            ctbImages.Visible = false;
            // 
            // ctbCheckboxes
            // 
            ctbCheckboxes.Dock = DockStyle.Fill;
            ctbCheckboxes.DroppedDown = false;
            ctbCheckboxes.HotToNormal = 0;
            ctbCheckboxes.Location = new Point(244, 277);
            ctbCheckboxes.Name = "ctbCheckboxes";
            ctbCheckboxes.NormalToHot = 0;
            ctbCheckboxes.PressedToNormal = 0;
            ctbCheckboxes.SelectedNode = null;
            ctbCheckboxes.ShowCheckBoxes = true;
            ctbCheckboxes.Size = new Size(277, 26);
            ctbCheckboxes.TabIndex = 7;
            ctbCheckboxes.Visible = false;
            // 
            // gcbList
            // 
            gcbList.DataSource = null;
            gcbList.Dock = DockStyle.Fill;
            gcbList.DropDownHeight = 150;
            gcbList.DropDownStyle = ComboBoxStyle.DropDownList;
            gcbList.FormattingEnabled = true;
            gcbList.HotToNormal = 1;
            gcbList.IntegralHeight = false;
            gcbList.Location = new Point(244, 147);
            gcbList.Name = "gcbList";
            gcbList.NormalToHot = 2;
            gcbList.PressedToNormal = 3;
            gcbList.Size = new Size(277, 27);
            gcbList.TabIndex = 3;
            // 
            // gcbEditable
            // 
            gcbEditable.DataSource = null;
            gcbEditable.Dock = DockStyle.Fill;
            gcbEditable.DropDownHeight = 150;
            gcbEditable.FormattingEnabled = true;
            gcbEditable.HotToNormal = 0;
            gcbEditable.IntegralHeight = false;
            gcbEditable.Location = new Point(244, 180);
            gcbEditable.Name = "gcbEditable";
            gcbEditable.NormalToHot = 0;
            gcbEditable.PressedToNormal = 0;
            gcbEditable.Size = new Size(277, 27);
            gcbEditable.TabIndex = 4;
            // 
            // ctbNormal
            // 
            ctbNormal.Dock = DockStyle.Fill;
            ctbNormal.DroppedDown = false;
            ctbNormal.HotToNormal = 0;
            ctbNormal.Location = new Point(244, 213);
            ctbNormal.Name = "ctbNormal";
            ctbNormal.NormalToHot = 0;
            ctbNormal.PressedToNormal = 0;
            ctbNormal.SelectedNode = null;
            ctbNormal.Size = new Size(277, 26);
            ctbNormal.TabIndex = 5;
            ctbNormal.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 17);
            tableLayoutPanel1.Controls.Add(label11, 0, 0);
            tableLayoutPanel1.Controls.Add(label12, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(label9, 0, 12);
            tableLayoutPanel1.Controls.Add(label2, 0, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 8);
            tableLayoutPanel1.Controls.Add(label1, 0, 7);
            tableLayoutPanel1.Controls.Add(label5, 0, 9);
            tableLayoutPanel1.Controls.Add(label8, 0, 11);
            tableLayoutPanel1.Controls.Add(label4, 0, 10);
            tableLayoutPanel1.Controls.Add(cmbEditable, 1, 4);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 3);
            tableLayoutPanel1.Controls.Add(cmbList, 1, 3);
            tableLayoutPanel1.Controls.Add(dsbExternal, 1, 14);
            tableLayoutPanel1.Controls.Add(label10, 0, 14);
            tableLayoutPanel1.Controls.Add(chkRetainGroups, 1, 13);
            tableLayoutPanel1.Controls.Add(gcbList, 1, 6);
            tableLayoutPanel1.Controls.Add(dsbListItems, 1, 12);
            tableLayoutPanel1.Controls.Add(ctbFlatChecks, 1, 11);
            tableLayoutPanel1.Controls.Add(ctbCheckboxes, 1, 10);
            tableLayoutPanel1.Controls.Add(gcbEditable, 1, 7);
            tableLayoutPanel1.Controls.Add(ctbImages, 1, 9);
            tableLayoutPanel1.Controls.Add(ctbNormal, 1, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 18;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(524, 585);
            tableLayoutPanel1.TabIndex = 26;
            // 
            // DemoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 585);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DemoForm";
            Text = "DropDownControls Demo";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private GroupedComboBox gcbEditable;
        private Label label1;
        private Label label2;
        private GroupedComboBox gcbList;
        private ImageList imageList;
        private Label label6;
        private RadioButton rbVS;
        private RadioButton rbPlain;
        private ComboBox cmbList;
        private Label label7;
        private DataGridView dataGridView1;
        private DropDownControls.GroupedComboBoxColumn Column1;
        private DropDownControls.ComboTreeBoxColumn Column2;
        private FlowLayoutPanel flowLayoutPanel1;
        private ComboTreeBox ctbNormal;
        private Label label3;
        private ComboTreeBox ctbCheckboxes;
        private Label label4;
        private ComboTreeBox ctbImages;
        private Label label5;
        private ComboTreeBox ctbFlatChecks;
        private Label label8;
        private Label label9;
        private DropDownSearchBox dsbListItems;
        private Label label10;
        private DropDownSearchBox dsbExternal;
        private CheckBox chkRetainGroups;
        private Label label11;
        private RadioButton rbDisabled;
        private RadioButton rbEnabled;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label12;
        private ComboBox cmbEditable;
        private TableLayoutPanel tableLayoutPanel1;
    }
}