namespace KeyPresser
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxClicker = new System.Windows.Forms.GroupBox();
            this.radioButtonAlternate = new System.Windows.Forms.RadioButton();
            this.checkBoxDoubleClick = new System.Windows.Forms.CheckBox();
            this.btnStopClicker = new System.Windows.Forms.Button();
            this.btnStartClicker = new System.Windows.Forms.Button();
            this.numericUpDownIntervalClicker = new System.Windows.Forms.NumericUpDown();
            this.radioButtonRightClick = new System.Windows.Forms.RadioButton();
            this.radioButtonLeftClick = new System.Windows.Forms.RadioButton();
            this.lblIntervalClicker = new System.Windows.Forms.Label();
            this.groupBoxCursorMover = new System.Windows.Forms.GroupBox();
            this.numericUpDownIntervalCursorMover = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalCursorMover = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblX1 = new System.Windows.Forms.Label();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.lblY1 = new System.Windows.Forms.Label();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.labelPointsList = new System.Windows.Forms.Label();
            this.btnStopCursorMover = new System.Windows.Forms.Button();
            this.btnStartCursorMover = new System.Windows.Forms.Button();
            this.groupBoxTyper = new System.Windows.Forms.GroupBox();
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.btnStopTyper = new System.Windows.Forms.Button();
            this.btnStartTyper = new System.Windows.Forms.Button();
            this.numericUpDownCharacterInterval = new System.Windows.Forms.NumericUpDown();
            this.lblCharacterInterval = new System.Windows.Forms.Label();
            this.numericUpDownIntervalTyper = new System.Windows.Forms.NumericUpDown();
            this.lblIntervalTyper = new System.Windows.Forms.Label();
            this.btnStopAll = new System.Windows.Forms.Button();
            this.btnStartAll = new System.Windows.Forms.Button();
            this.groupBoxClicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalClicker)).BeginInit();
            this.groupBoxCursorMover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalCursorMover)).BeginInit();
            this.flowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            this.groupBoxTyper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacterInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTyper)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxClicker
            // 
            this.groupBoxClicker.Controls.Add(this.radioButtonAlternate);
            this.groupBoxClicker.Controls.Add(this.checkBoxDoubleClick);
            this.groupBoxClicker.Controls.Add(this.btnStopClicker);
            this.groupBoxClicker.Controls.Add(this.btnStartClicker);
            this.groupBoxClicker.Controls.Add(this.numericUpDownIntervalClicker);
            this.groupBoxClicker.Controls.Add(this.radioButtonRightClick);
            this.groupBoxClicker.Controls.Add(this.radioButtonLeftClick);
            this.groupBoxClicker.Controls.Add(this.lblIntervalClicker);
            this.groupBoxClicker.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxClicker.Location = new System.Drawing.Point(12, 12);
            this.groupBoxClicker.Name = "groupBoxClicker";
            this.groupBoxClicker.Size = new System.Drawing.Size(462, 161);
            this.groupBoxClicker.TabIndex = 0;
            this.groupBoxClicker.TabStop = false;
            this.groupBoxClicker.Text = "AUTO CLICKER";
            // 
            // radioButtonAlternate
            // 
            this.radioButtonAlternate.AutoSize = true;
            this.radioButtonAlternate.ForeColor = System.Drawing.Color.Black;
            this.radioButtonAlternate.Location = new System.Drawing.Point(365, 51);
            this.radioButtonAlternate.Name = "radioButtonAlternate";
            this.radioButtonAlternate.Size = new System.Drawing.Size(67, 17);
            this.radioButtonAlternate.TabIndex = 8;
            this.radioButtonAlternate.Text = "Alternate";
            this.radioButtonAlternate.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoubleClick
            // 
            this.checkBoxDoubleClick.AutoSize = true;
            this.checkBoxDoubleClick.ForeColor = System.Drawing.Color.Black;
            this.checkBoxDoubleClick.Location = new System.Drawing.Point(94, 83);
            this.checkBoxDoubleClick.Name = "checkBoxDoubleClick";
            this.checkBoxDoubleClick.Size = new System.Drawing.Size(86, 17);
            this.checkBoxDoubleClick.TabIndex = 7;
            this.checkBoxDoubleClick.Text = "Double Click";
            this.checkBoxDoubleClick.UseVisualStyleBackColor = true;
            // 
            // btnStopClicker
            // 
            this.btnStopClicker.Enabled = false;
            this.btnStopClicker.ForeColor = System.Drawing.Color.Red;
            this.btnStopClicker.Location = new System.Drawing.Point(258, 120);
            this.btnStopClicker.Name = "btnStopClicker";
            this.btnStopClicker.Size = new System.Drawing.Size(107, 23);
            this.btnStopClicker.TabIndex = 6;
            this.btnStopClicker.Text = "STOP (F1)";
            this.btnStopClicker.UseVisualStyleBackColor = true;
            this.btnStopClicker.Click += new System.EventHandler(this.btnStopClicker_Click);
            // 
            // btnStartClicker
            // 
            this.btnStartClicker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartClicker.Location = new System.Drawing.Point(94, 120);
            this.btnStartClicker.Name = "btnStartClicker";
            this.btnStartClicker.Size = new System.Drawing.Size(108, 23);
            this.btnStartClicker.TabIndex = 5;
            this.btnStartClicker.Text = "START (F1)";
            this.btnStartClicker.UseVisualStyleBackColor = true;
            this.btnStartClicker.Click += new System.EventHandler(this.btnStartClicker_Click);
            // 
            // numericUpDownIntervalClicker
            // 
            this.numericUpDownIntervalClicker.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownIntervalClicker.Location = new System.Drawing.Point(216, 18);
            this.numericUpDownIntervalClicker.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownIntervalClicker.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalClicker.Name = "numericUpDownIntervalClicker";
            this.numericUpDownIntervalClicker.Size = new System.Drawing.Size(174, 20);
            this.numericUpDownIntervalClicker.TabIndex = 4;
            this.numericUpDownIntervalClicker.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalClicker.ThousandsSeparator = true;
            this.numericUpDownIntervalClicker.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // radioButtonRightClick
            // 
            this.radioButtonRightClick.AutoSize = true;
            this.radioButtonRightClick.ForeColor = System.Drawing.Color.Black;
            this.radioButtonRightClick.Location = new System.Drawing.Point(216, 51);
            this.radioButtonRightClick.Name = "radioButtonRightClick";
            this.radioButtonRightClick.Size = new System.Drawing.Size(80, 17);
            this.radioButtonRightClick.TabIndex = 3;
            this.radioButtonRightClick.Text = "Right CLick";
            this.radioButtonRightClick.UseVisualStyleBackColor = true;
            // 
            // radioButtonLeftClick
            // 
            this.radioButtonLeftClick.AutoSize = true;
            this.radioButtonLeftClick.Checked = true;
            this.radioButtonLeftClick.ForeColor = System.Drawing.Color.Black;
            this.radioButtonLeftClick.Location = new System.Drawing.Point(94, 51);
            this.radioButtonLeftClick.Name = "radioButtonLeftClick";
            this.radioButtonLeftClick.Size = new System.Drawing.Size(69, 17);
            this.radioButtonLeftClick.TabIndex = 2;
            this.radioButtonLeftClick.TabStop = true;
            this.radioButtonLeftClick.Text = "Left Click";
            this.radioButtonLeftClick.UseVisualStyleBackColor = true;
            // 
            // lblIntervalClicker
            // 
            this.lblIntervalClicker.AutoSize = true;
            this.lblIntervalClicker.ForeColor = System.Drawing.Color.Black;
            this.lblIntervalClicker.Location = new System.Drawing.Point(91, 20);
            this.lblIntervalClicker.Name = "lblIntervalClicker";
            this.lblIntervalClicker.Size = new System.Drawing.Size(67, 13);
            this.lblIntervalClicker.TabIndex = 0;
            this.lblIntervalClicker.Text = "Interval (ms):";
            // 
            // groupBoxCursorMover
            // 
            this.groupBoxCursorMover.Controls.Add(this.numericUpDownIntervalCursorMover);
            this.groupBoxCursorMover.Controls.Add(this.lblIntervalCursorMover);
            this.groupBoxCursorMover.Controls.Add(this.btnReset);
            this.groupBoxCursorMover.Controls.Add(this.flowLayoutPanel);
            this.groupBoxCursorMover.Controls.Add(this.btnAddPoint);
            this.groupBoxCursorMover.Controls.Add(this.labelPointsList);
            this.groupBoxCursorMover.Controls.Add(this.btnStopCursorMover);
            this.groupBoxCursorMover.Controls.Add(this.btnStartCursorMover);
            this.groupBoxCursorMover.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxCursorMover.Location = new System.Drawing.Point(12, 190);
            this.groupBoxCursorMover.Name = "groupBoxCursorMover";
            this.groupBoxCursorMover.Size = new System.Drawing.Size(462, 226);
            this.groupBoxCursorMover.TabIndex = 1;
            this.groupBoxCursorMover.TabStop = false;
            this.groupBoxCursorMover.Text = "CURSOR MOVER";
            // 
            // numericUpDownIntervalCursorMover
            // 
            this.numericUpDownIntervalCursorMover.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownIntervalCursorMover.Location = new System.Drawing.Point(325, 18);
            this.numericUpDownIntervalCursorMover.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownIntervalCursorMover.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalCursorMover.Name = "numericUpDownIntervalCursorMover";
            this.numericUpDownIntervalCursorMover.Size = new System.Drawing.Size(131, 20);
            this.numericUpDownIntervalCursorMover.TabIndex = 15;
            this.numericUpDownIntervalCursorMover.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalCursorMover.ThousandsSeparator = true;
            this.numericUpDownIntervalCursorMover.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblIntervalCursorMover
            // 
            this.lblIntervalCursorMover.AutoSize = true;
            this.lblIntervalCursorMover.ForeColor = System.Drawing.Color.Black;
            this.lblIntervalCursorMover.Location = new System.Drawing.Point(255, 20);
            this.lblIntervalCursorMover.Name = "lblIntervalCursorMover";
            this.lblIntervalCursorMover.Size = new System.Drawing.Size(67, 13);
            this.lblIntervalCursorMover.TabIndex = 14;
            this.lblIntervalCursorMover.Text = "Interval (ms):";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReset.Location = new System.Drawing.Point(216, 85);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(26, 26);
            this.btnReset.TabIndex = 13;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Controls.Add(this.lblX1);
            this.flowLayoutPanel.Controls.Add(this.numericUpDownX1);
            this.flowLayoutPanel.Controls.Add(this.lblY1);
            this.flowLayoutPanel.Controls.Add(this.numericUpDownY1);
            this.flowLayoutPanel.Location = new System.Drawing.Point(10, 43);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(194, 140);
            this.flowLayoutPanel.TabIndex = 0;
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.ForeColor = System.Drawing.Color.Black;
            this.lblX1.Location = new System.Drawing.Point(3, 0);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(23, 13);
            this.lblX1.TabIndex = 13;
            this.lblX1.Text = "X1:";
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.Location = new System.Drawing.Point(32, 3);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownX1.TabIndex = 14;
            this.numericUpDownX1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownX1.ThousandsSeparator = true;
            // 
            // lblY1
            // 
            this.lblY1.AutoSize = true;
            this.lblY1.ForeColor = System.Drawing.Color.Black;
            this.lblY1.Location = new System.Drawing.Point(92, 0);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(23, 13);
            this.lblY1.TabIndex = 15;
            this.lblY1.Text = "Y1:";
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.Location = new System.Drawing.Point(121, 3);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(54, 20);
            this.numericUpDownY1.TabIndex = 16;
            this.numericUpDownY1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownY1.ThousandsSeparator = true;
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddPoint.BackgroundImage")));
            this.btnAddPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddPoint.Location = new System.Drawing.Point(216, 40);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(26, 26);
            this.btnAddPoint.TabIndex = 12;
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.btnAddPoint_Click);
            // 
            // labelPointsList
            // 
            this.labelPointsList.AutoSize = true;
            this.labelPointsList.ForeColor = System.Drawing.Color.Black;
            this.labelPointsList.Location = new System.Drawing.Point(7, 20);
            this.labelPointsList.Name = "labelPointsList";
            this.labelPointsList.Size = new System.Drawing.Size(58, 13);
            this.labelPointsList.TabIndex = 9;
            this.labelPointsList.Text = "Points List:";
            // 
            // btnStopCursorMover
            // 
            this.btnStopCursorMover.Enabled = false;
            this.btnStopCursorMover.ForeColor = System.Drawing.Color.Red;
            this.btnStopCursorMover.Location = new System.Drawing.Point(258, 189);
            this.btnStopCursorMover.Name = "btnStopCursorMover";
            this.btnStopCursorMover.Size = new System.Drawing.Size(107, 23);
            this.btnStopCursorMover.TabIndex = 8;
            this.btnStopCursorMover.Text = "STOP (F2)";
            this.btnStopCursorMover.UseVisualStyleBackColor = true;
            this.btnStopCursorMover.Click += new System.EventHandler(this.btnStopCursorMover_Click);
            // 
            // btnStartCursorMover
            // 
            this.btnStartCursorMover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartCursorMover.Location = new System.Drawing.Point(94, 189);
            this.btnStartCursorMover.Name = "btnStartCursorMover";
            this.btnStartCursorMover.Size = new System.Drawing.Size(108, 23);
            this.btnStartCursorMover.TabIndex = 7;
            this.btnStartCursorMover.Text = "START (F2)";
            this.btnStartCursorMover.UseVisualStyleBackColor = true;
            this.btnStartCursorMover.Click += new System.EventHandler(this.btnStartCursorMover_Click);
            // 
            // groupBoxTyper
            // 
            this.groupBoxTyper.Controls.Add(this.textBoxContent);
            this.groupBoxTyper.Controls.Add(this.lblContent);
            this.groupBoxTyper.Controls.Add(this.btnStopTyper);
            this.groupBoxTyper.Controls.Add(this.btnStartTyper);
            this.groupBoxTyper.Controls.Add(this.numericUpDownCharacterInterval);
            this.groupBoxTyper.Controls.Add(this.lblCharacterInterval);
            this.groupBoxTyper.Controls.Add(this.numericUpDownIntervalTyper);
            this.groupBoxTyper.Controls.Add(this.lblIntervalTyper);
            this.groupBoxTyper.ForeColor = System.Drawing.Color.Blue;
            this.groupBoxTyper.Location = new System.Drawing.Point(12, 436);
            this.groupBoxTyper.Name = "groupBoxTyper";
            this.groupBoxTyper.Size = new System.Drawing.Size(462, 163);
            this.groupBoxTyper.TabIndex = 2;
            this.groupBoxTyper.TabStop = false;
            this.groupBoxTyper.Text = "AUTO TYPER";
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(6, 45);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(196, 83);
            this.textBoxContent.TabIndex = 20;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(7, 25);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(47, 13);
            this.lblContent.TabIndex = 19;
            this.lblContent.Text = "Content:";
            // 
            // btnStopTyper
            // 
            this.btnStopTyper.Enabled = false;
            this.btnStopTyper.ForeColor = System.Drawing.Color.Red;
            this.btnStopTyper.Location = new System.Drawing.Point(258, 134);
            this.btnStopTyper.Name = "btnStopTyper";
            this.btnStopTyper.Size = new System.Drawing.Size(107, 23);
            this.btnStopTyper.TabIndex = 18;
            this.btnStopTyper.Text = "STOP (F3)";
            this.btnStopTyper.UseVisualStyleBackColor = true;
            this.btnStopTyper.Click += new System.EventHandler(this.btnStopTyper_Click);
            // 
            // btnStartTyper
            // 
            this.btnStartTyper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnStartTyper.Location = new System.Drawing.Point(94, 134);
            this.btnStartTyper.Name = "btnStartTyper";
            this.btnStartTyper.Size = new System.Drawing.Size(108, 23);
            this.btnStartTyper.TabIndex = 17;
            this.btnStartTyper.Text = "START (F3)";
            this.btnStartTyper.UseVisualStyleBackColor = true;
            this.btnStartTyper.Click += new System.EventHandler(this.btnStartTyper_Click);
            // 
            // numericUpDownCharacterInterval
            // 
            this.numericUpDownCharacterInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCharacterInterval.Location = new System.Drawing.Point(338, 79);
            this.numericUpDownCharacterInterval.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownCharacterInterval.Name = "numericUpDownCharacterInterval";
            this.numericUpDownCharacterInterval.Size = new System.Drawing.Size(118, 20);
            this.numericUpDownCharacterInterval.TabIndex = 8;
            this.numericUpDownCharacterInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownCharacterInterval.ThousandsSeparator = true;
            this.numericUpDownCharacterInterval.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // lblCharacterInterval
            // 
            this.lblCharacterInterval.AutoSize = true;
            this.lblCharacterInterval.ForeColor = System.Drawing.Color.Black;
            this.lblCharacterInterval.Location = new System.Drawing.Point(213, 81);
            this.lblCharacterInterval.Name = "lblCharacterInterval";
            this.lblCharacterInterval.Size = new System.Drawing.Size(116, 13);
            this.lblCharacterInterval.TabIndex = 7;
            this.lblCharacterInterval.Text = "Character Interval (ms):";
            // 
            // numericUpDownIntervalTyper
            // 
            this.numericUpDownIntervalTyper.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownIntervalTyper.Location = new System.Drawing.Point(338, 43);
            this.numericUpDownIntervalTyper.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownIntervalTyper.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownIntervalTyper.Name = "numericUpDownIntervalTyper";
            this.numericUpDownIntervalTyper.Size = new System.Drawing.Size(118, 20);
            this.numericUpDownIntervalTyper.TabIndex = 6;
            this.numericUpDownIntervalTyper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIntervalTyper.ThousandsSeparator = true;
            this.numericUpDownIntervalTyper.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // lblIntervalTyper
            // 
            this.lblIntervalTyper.AutoSize = true;
            this.lblIntervalTyper.ForeColor = System.Drawing.Color.Black;
            this.lblIntervalTyper.Location = new System.Drawing.Point(213, 45);
            this.lblIntervalTyper.Name = "lblIntervalTyper";
            this.lblIntervalTyper.Size = new System.Drawing.Size(67, 13);
            this.lblIntervalTyper.TabIndex = 5;
            this.lblIntervalTyper.Text = "Interval (ms):";
            // 
            // btnStopAll
            // 
            this.btnStopAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStopAll.ForeColor = System.Drawing.Color.Red;
            this.btnStopAll.Location = new System.Drawing.Point(337, 626);
            this.btnStopAll.Name = "btnStopAll";
            this.btnStopAll.Size = new System.Drawing.Size(107, 23);
            this.btnStopAll.TabIndex = 22;
            this.btnStopAll.Text = "STOP ALL (F5)";
            this.btnStopAll.UseVisualStyleBackColor = true;
            this.btnStopAll.Click += new System.EventHandler(this.btnStopAll_Click);
            // 
            // btnStartAll
            // 
            this.btnStartAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStartAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStartAll.Location = new System.Drawing.Point(47, 626);
            this.btnStartAll.Name = "btnStartAll";
            this.btnStartAll.Size = new System.Drawing.Size(108, 23);
            this.btnStartAll.TabIndex = 21;
            this.btnStartAll.Text = "START ALL (F4)";
            this.btnStartAll.UseVisualStyleBackColor = true;
            this.btnStartAll.Click += new System.EventHandler(this.btnStartAll_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 661);
            this.Controls.Add(this.btnStopAll);
            this.Controls.Add(this.btnStartAll);
            this.Controls.Add(this.groupBoxTyper);
            this.Controls.Add(this.groupBoxCursorMover);
            this.Controls.Add(this.groupBoxClicker);
            this.Name = "FormMain";
            this.Text = "AutoWorker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.groupBoxClicker.ResumeLayout(false);
            this.groupBoxClicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalClicker)).EndInit();
            this.groupBoxCursorMover.ResumeLayout(false);
            this.groupBoxCursorMover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalCursorMover)).EndInit();
            this.flowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            this.groupBoxTyper.ResumeLayout(false);
            this.groupBoxTyper.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCharacterInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntervalTyper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxClicker;
        private System.Windows.Forms.RadioButton radioButtonRightClick;
        private System.Windows.Forms.RadioButton radioButtonLeftClick;
        private System.Windows.Forms.Label lblIntervalClicker;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalClicker;
        private System.Windows.Forms.Button btnStartClicker;
        private System.Windows.Forms.Button btnStopClicker;
        private System.Windows.Forms.CheckBox checkBoxDoubleClick;
        private System.Windows.Forms.RadioButton radioButtonAlternate;
        private System.Windows.Forms.GroupBox groupBoxCursorMover;
        private System.Windows.Forms.Label labelPointsList;
        private System.Windows.Forms.Button btnStopCursorMover;
        private System.Windows.Forms.Button btnStartCursorMover;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.GroupBox groupBoxTyper;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalTyper;
        private System.Windows.Forms.Label lblIntervalTyper;
        private System.Windows.Forms.NumericUpDown numericUpDownCharacterInterval;
        private System.Windows.Forms.Label lblCharacterInterval;
        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Button btnStopTyper;
        private System.Windows.Forms.Button btnStartTyper;
        private System.Windows.Forms.Button btnStopAll;
        private System.Windows.Forms.Button btnStartAll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numericUpDownIntervalCursorMover;
        private System.Windows.Forms.Label lblIntervalCursorMover;


    }
}

