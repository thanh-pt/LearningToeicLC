namespace LearningToeicLC
{
    partial class ToeicLC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToeicLC));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMarkEnd = new System.Windows.Forms.Button();
            this.btnMarkStart = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.progressBorder = new System.Windows.Forms.Panel();
            this.pinEnd = new System.Windows.Forms.Panel();
            this.pinStart = new System.Windows.Forms.Panel();
            this.progressInside = new System.Windows.Forms.Panel();
            this.txtTiming = new System.Windows.Forms.Label();
            this.txtMediaFileName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSeekdown = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numSeekDuration = new System.Windows.Forms.NumericUpDown();
            this.btnPlayPause = new System.Windows.Forms.Button();
            this.btnSeekup = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.tickerTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNewStartTime = new System.Windows.Forms.TextBox();
            this.txtNewEndTime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxSavedItem = new System.Windows.Forms.ListBox();
            this.SelectedItem = new System.Windows.Forms.GroupBox();
            this.txtNote = new System.Windows.Forms.RichTextBox();
            this.progressBorderSession = new System.Windows.Forms.Panel();
            this.progressInsideSession = new System.Windows.Forms.Panel();
            this.btnDeleteSelected = new System.Windows.Forms.Button();
            this.btnFullPlay = new System.Windows.Forms.Button();
            this.btnPlaySelected = new System.Windows.Forms.Button();
            this.btnUpdateSelected = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCurrentEnd = new System.Windows.Forms.TextBox();
            this.txtCurrentStart = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnJsonGenerate = new System.Windows.Forms.Button();
            this.btnOpenProject = new System.Windows.Forms.Button();
            this.btnCreateProject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.progressBorder.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeekDuration)).BeginInit();
            this.SelectedItem.SuspendLayout();
            this.progressBorderSession.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtMediaFileName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 79);
            this.panel1.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.btnMarkEnd);
            this.panel4.Controls.Add(this.btnMarkStart);
            this.panel4.Location = new System.Drawing.Point(6, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 32);
            this.panel4.TabIndex = 7;
            // 
            // btnMarkEnd
            // 
            this.btnMarkEnd.Location = new System.Drawing.Point(75, 3);
            this.btnMarkEnd.Name = "btnMarkEnd";
            this.btnMarkEnd.Size = new System.Drawing.Size(66, 23);
            this.btnMarkEnd.TabIndex = 1;
            this.btnMarkEnd.Text = "Mark End";
            this.btnMarkEnd.UseVisualStyleBackColor = true;
            this.btnMarkEnd.Click += new System.EventHandler(this.btnMarkEnd_Click);
            // 
            // btnMarkStart
            // 
            this.btnMarkStart.Location = new System.Drawing.Point(3, 3);
            this.btnMarkStart.Name = "btnMarkStart";
            this.btnMarkStart.Size = new System.Drawing.Size(66, 23);
            this.btnMarkStart.TabIndex = 0;
            this.btnMarkStart.Text = "Mark Start";
            this.btnMarkStart.UseVisualStyleBackColor = true;
            this.btnMarkStart.Click += new System.EventHandler(this.btnMarkStart_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.progressBorder);
            this.panel5.Controls.Add(this.txtTiming);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 13);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(702, 19);
            this.panel5.TabIndex = 6;
            // 
            // progressBorder
            // 
            this.progressBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBorder.BackColor = System.Drawing.Color.Silver;
            this.progressBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBorder.Controls.Add(this.pinEnd);
            this.progressBorder.Controls.Add(this.pinStart);
            this.progressBorder.Controls.Add(this.progressInside);
            this.progressBorder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBorder.Location = new System.Drawing.Point(81, 3);
            this.progressBorder.Name = "progressBorder";
            this.progressBorder.Size = new System.Drawing.Size(618, 12);
            this.progressBorder.TabIndex = 3;
            this.progressBorder.Click += new System.EventHandler(this.progressBorder_Click);
            // 
            // pinEnd
            // 
            this.pinEnd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pinEnd.BackColor = System.Drawing.Color.Crimson;
            this.pinEnd.Location = new System.Drawing.Point(315, 0);
            this.pinEnd.Name = "pinEnd";
            this.pinEnd.Size = new System.Drawing.Size(3, 12);
            this.pinEnd.TabIndex = 6;
            this.pinEnd.Click += new System.EventHandler(this.pinEnd_Click);
            // 
            // pinStart
            // 
            this.pinStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pinStart.BackColor = System.Drawing.Color.Lime;
            this.pinStart.Location = new System.Drawing.Point(68, 0);
            this.pinStart.Name = "pinStart";
            this.pinStart.Size = new System.Drawing.Size(3, 12);
            this.pinStart.TabIndex = 5;
            this.pinStart.Click += new System.EventHandler(this.pinStart_Click);
            // 
            // progressInside
            // 
            this.progressInside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.progressInside.BackColor = System.Drawing.Color.DarkCyan;
            this.progressInside.Location = new System.Drawing.Point(1, 1);
            this.progressInside.Name = "progressInside";
            this.progressInside.Size = new System.Drawing.Size(287, 8);
            this.progressInside.TabIndex = 4;
            this.progressInside.Click += new System.EventHandler(this.progressInside_Click);
            // 
            // txtTiming
            // 
            this.txtTiming.AutoSize = true;
            this.txtTiming.Location = new System.Drawing.Point(3, 3);
            this.txtTiming.Name = "txtTiming";
            this.txtTiming.Size = new System.Drawing.Size(72, 13);
            this.txtTiming.TabIndex = 1;
            this.txtTiming.Text = "00:00 / 00:00";
            // 
            // txtMediaFileName
            // 
            this.txtMediaFileName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMediaFileName.Location = new System.Drawing.Point(0, 0);
            this.txtMediaFileName.Name = "txtMediaFileName";
            this.txtMediaFileName.Size = new System.Drawing.Size(702, 13);
            this.txtMediaFileName.TabIndex = 5;
            this.txtMediaFileName.Text = "Media FileName";
            this.txtMediaFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtMediaFileName.TextChanged += new System.EventHandler(this.txtMediaFileName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnSeekdown);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.btnPlayPause);
            this.panel3.Controls.Add(this.btnSeekup);
            this.panel3.Location = new System.Drawing.Point(162, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 32);
            this.panel3.TabIndex = 4;
            // 
            // btnSeekdown
            // 
            this.btnSeekdown.Location = new System.Drawing.Point(3, 3);
            this.btnSeekdown.Name = "btnSeekdown";
            this.btnSeekdown.Size = new System.Drawing.Size(75, 23);
            this.btnSeekdown.TabIndex = 0;
            this.btnSeekdown.Text = "Seekdown";
            this.btnSeekdown.UseVisualStyleBackColor = true;
            this.btnSeekdown.Click += new System.EventHandler(this.btnSeekdown_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.numSeekDuration);
            this.panel2.Location = new System.Drawing.Point(246, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(127, 23);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Seek duration:";
            // 
            // numSeekDuration
            // 
            this.numSeekDuration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numSeekDuration.Location = new System.Drawing.Point(81, 1);
            this.numSeekDuration.Name = "numSeekDuration";
            this.numSeekDuration.Size = new System.Drawing.Size(43, 20);
            this.numSeekDuration.TabIndex = 0;
            this.numSeekDuration.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnPlayPause
            // 
            this.btnPlayPause.Location = new System.Drawing.Point(84, 3);
            this.btnPlayPause.Name = "btnPlayPause";
            this.btnPlayPause.Size = new System.Drawing.Size(75, 23);
            this.btnPlayPause.TabIndex = 1;
            this.btnPlayPause.Text = "Play/Pause";
            this.btnPlayPause.UseVisualStyleBackColor = true;
            this.btnPlayPause.Click += new System.EventHandler(this.btnPlayPause_Click);
            // 
            // btnSeekup
            // 
            this.btnSeekup.Location = new System.Drawing.Point(165, 3);
            this.btnSeekup.Name = "btnSeekup";
            this.btnSeekup.Size = new System.Drawing.Size(75, 23);
            this.btnSeekup.TabIndex = 2;
            this.btnSeekup.Text = "Seekup";
            this.btnSeekup.UseVisualStyleBackColor = true;
            this.btnSeekup.Click += new System.EventHandler(this.btnSeekup_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(7, 70);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(150, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Mp3 File";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // tickerTimer
            // 
            this.tickerTimer.Tick += new System.EventHandler(this.tickerTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "End:";
            // 
            // txtNewStartTime
            // 
            this.txtNewStartTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewStartTime.Location = new System.Drawing.Point(60, 12);
            this.txtNewStartTime.Name = "txtNewStartTime";
            this.txtNewStartTime.Size = new System.Drawing.Size(82, 20);
            this.txtNewStartTime.TabIndex = 0;
            // 
            // txtNewEndTime
            // 
            this.txtNewEndTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewEndTime.Location = new System.Drawing.Point(60, 38);
            this.txtNewEndTime.Name = "txtNewEndTime";
            this.txtNewEndTime.Size = new System.Drawing.Size(82, 20);
            this.txtNewEndTime.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name:";
            // 
            // txtNewName
            // 
            this.txtNewName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNewName.Location = new System.Drawing.Point(60, 64);
            this.txtNewName.Name = "txtNewName";
            this.txtNewName.Size = new System.Drawing.Size(82, 20);
            this.txtNewName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(67, 90);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxSavedItem
            // 
            this.listBoxSavedItem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxSavedItem.FormattingEnabled = true;
            this.listBoxSavedItem.Location = new System.Drawing.Point(499, 13);
            this.listBoxSavedItem.Name = "listBoxSavedItem";
            this.listBoxSavedItem.Size = new System.Drawing.Size(193, 264);
            this.listBoxSavedItem.TabIndex = 1;
            this.listBoxSavedItem.SelectedIndexChanged += new System.EventHandler(this.listBoxSavedItem_SelectedIndexChanged);
            // 
            // SelectedItem
            // 
            this.SelectedItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItem.Controls.Add(this.txtNote);
            this.SelectedItem.Controls.Add(this.progressBorderSession);
            this.SelectedItem.Controls.Add(this.btnDeleteSelected);
            this.SelectedItem.Controls.Add(this.btnFullPlay);
            this.SelectedItem.Controls.Add(this.btnPlaySelected);
            this.SelectedItem.Controls.Add(this.btnUpdateSelected);
            this.SelectedItem.Controls.Add(this.label5);
            this.SelectedItem.Controls.Add(this.txtCurrentName);
            this.SelectedItem.Controls.Add(this.label6);
            this.SelectedItem.Controls.Add(this.txtCurrentEnd);
            this.SelectedItem.Controls.Add(this.txtCurrentStart);
            this.SelectedItem.Controls.Add(this.label7);
            this.SelectedItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectedItem.Location = new System.Drawing.Point(167, 13);
            this.SelectedItem.Name = "SelectedItem";
            this.SelectedItem.Size = new System.Drawing.Size(326, 261);
            this.SelectedItem.TabIndex = 5;
            this.SelectedItem.TabStop = false;
            this.SelectedItem.Text = "Selected Item";
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNote.Location = new System.Drawing.Point(8, 90);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(312, 113);
            this.txtNote.TabIndex = 7;
            this.txtNote.Text = "";
            this.txtNote.TextChanged += new System.EventHandler(this.txtNote_TextChanged);
            // 
            // progressBorderSession
            // 
            this.progressBorderSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBorderSession.BackColor = System.Drawing.Color.Silver;
            this.progressBorderSession.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.progressBorderSession.Controls.Add(this.progressInsideSession);
            this.progressBorderSession.Cursor = System.Windows.Forms.Cursors.Hand;
            this.progressBorderSession.Location = new System.Drawing.Point(6, 212);
            this.progressBorderSession.Name = "progressBorderSession";
            this.progressBorderSession.Size = new System.Drawing.Size(314, 12);
            this.progressBorderSession.TabIndex = 3;
            this.progressBorderSession.Click += new System.EventHandler(this.progressBorderSession_Click);
            // 
            // progressInsideSession
            // 
            this.progressInsideSession.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.progressInsideSession.BackColor = System.Drawing.Color.DarkCyan;
            this.progressInsideSession.Location = new System.Drawing.Point(1, 1);
            this.progressInsideSession.Name = "progressInsideSession";
            this.progressInsideSession.Size = new System.Drawing.Size(49, 8);
            this.progressInsideSession.TabIndex = 4;
            this.progressInsideSession.Click += new System.EventHandler(this.progressInsideSession_Click);
            // 
            // btnDeleteSelected
            // 
            this.btnDeleteSelected.ForeColor = System.Drawing.Color.Crimson;
            this.btnDeleteSelected.Location = new System.Drawing.Point(166, 37);
            this.btnDeleteSelected.Name = "btnDeleteSelected";
            this.btnDeleteSelected.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSelected.TabIndex = 5;
            this.btnDeleteSelected.Text = "Delete";
            this.btnDeleteSelected.UseVisualStyleBackColor = true;
            this.btnDeleteSelected.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnFullPlay
            // 
            this.btnFullPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnFullPlay.Location = new System.Drawing.Point(104, 232);
            this.btnFullPlay.Name = "btnFullPlay";
            this.btnFullPlay.Size = new System.Drawing.Size(92, 23);
            this.btnFullPlay.TabIndex = 3;
            this.btnFullPlay.Text = "Full Play";
            this.btnFullPlay.UseVisualStyleBackColor = true;
            this.btnFullPlay.Click += new System.EventHandler(this.btnFullPlay_Click);
            // 
            // btnPlaySelected
            // 
            this.btnPlaySelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlaySelected.Location = new System.Drawing.Point(6, 232);
            this.btnPlaySelected.Name = "btnPlaySelected";
            this.btnPlaySelected.Size = new System.Drawing.Size(92, 23);
            this.btnPlaySelected.TabIndex = 3;
            this.btnPlaySelected.Text = "Play Session";
            this.btnPlaySelected.UseVisualStyleBackColor = true;
            this.btnPlaySelected.Click += new System.EventHandler(this.btnPlaySelected_Click);
            // 
            // btnUpdateSelected
            // 
            this.btnUpdateSelected.Location = new System.Drawing.Point(166, 10);
            this.btnUpdateSelected.Name = "btnUpdateSelected";
            this.btnUpdateSelected.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateSelected.TabIndex = 4;
            this.btnUpdateSelected.Text = "Update";
            this.btnUpdateSelected.UseVisualStyleBackColor = true;
            this.btnUpdateSelected.Click += new System.EventHandler(this.btnUpdateSelected_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Start:";
            // 
            // txtCurrentName
            // 
            this.txtCurrentName.Location = new System.Drawing.Point(60, 64);
            this.txtCurrentName.Name = "txtCurrentName";
            this.txtCurrentName.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentName.TabIndex = 2;
            this.txtCurrentName.TextChanged += new System.EventHandler(this.txtCurrentName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "End:";
            // 
            // txtCurrentEnd
            // 
            this.txtCurrentEnd.Location = new System.Drawing.Point(60, 38);
            this.txtCurrentEnd.Name = "txtCurrentEnd";
            this.txtCurrentEnd.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentEnd.TabIndex = 1;
            this.txtCurrentEnd.TextChanged += new System.EventHandler(this.txtCurrentEnd_TextChanged);
            // 
            // txtCurrentStart
            // 
            this.txtCurrentStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentStart.Location = new System.Drawing.Point(60, 12);
            this.txtCurrentStart.Name = "txtCurrentStart";
            this.txtCurrentStart.Size = new System.Drawing.Size(100, 20);
            this.txtCurrentStart.TabIndex = 0;
            this.txtCurrentStart.TextChanged += new System.EventHandler(this.txtCurrentStart_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNewName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNewEndTime);
            this.groupBox1.Controls.Add(this.txtNewStartTime);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(7, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 124);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Item";
            // 
            // btnJsonGenerate
            // 
            this.btnJsonGenerate.Location = new System.Drawing.Point(7, 99);
            this.btnJsonGenerate.Name = "btnJsonGenerate";
            this.btnJsonGenerate.Size = new System.Drawing.Size(150, 23);
            this.btnJsonGenerate.TabIndex = 7;
            this.btnJsonGenerate.Text = "Save Project";
            this.btnJsonGenerate.UseVisualStyleBackColor = true;
            this.btnJsonGenerate.Click += new System.EventHandler(this.btnJsonGenerate_Click);
            // 
            // btnOpenProject
            // 
            this.btnOpenProject.Location = new System.Drawing.Point(7, 41);
            this.btnOpenProject.Name = "btnOpenProject";
            this.btnOpenProject.Size = new System.Drawing.Size(150, 23);
            this.btnOpenProject.TabIndex = 0;
            this.btnOpenProject.Text = "Open Project";
            this.btnOpenProject.UseVisualStyleBackColor = true;
            this.btnOpenProject.Click += new System.EventHandler(this.btnOpenProject_Click);
            // 
            // btnCreateProject
            // 
            this.btnCreateProject.Location = new System.Drawing.Point(7, 12);
            this.btnCreateProject.Name = "btnCreateProject";
            this.btnCreateProject.Size = new System.Drawing.Size(150, 23);
            this.btnCreateProject.TabIndex = 0;
            this.btnCreateProject.Text = "Create Project";
            this.btnCreateProject.UseVisualStyleBackColor = true;
            this.btnCreateProject.Click += new System.EventHandler(this.btnCreateProject_Click);
            // 
            // ToeicLC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 361);
            this.Controls.Add(this.btnJsonGenerate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SelectedItem);
            this.Controls.Add(this.listBoxSavedItem);
            this.Controls.Add(this.btnCreateProject);
            this.Controls.Add(this.btnOpenProject);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 400);
            this.Name = "ToeicLC";
            this.Text = "Learning Toeic LC";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.progressBorder.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeekDuration)).EndInit();
            this.SelectedItem.ResumeLayout(false);
            this.SelectedItem.PerformLayout();
            this.progressBorderSession.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTiming;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numSeekDuration;
        private System.Windows.Forms.Button btnSeekdown;
        private System.Windows.Forms.Button btnSeekup;
        private System.Windows.Forms.Button btnPlayPause;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label txtMediaFileName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer tickerTimer;
        private System.Windows.Forms.Panel progressBorder;
        private System.Windows.Forms.Panel progressInside;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewName;
        private System.Windows.Forms.TextBox txtNewEndTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewStartTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSavedItem;
        private System.Windows.Forms.GroupBox SelectedItem;
        private System.Windows.Forms.Button btnDeleteSelected;
        private System.Windows.Forms.Button btnUpdateSelected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCurrentEnd;
        private System.Windows.Forms.TextBox txtCurrentStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnMarkEnd;
        private System.Windows.Forms.Button btnMarkStart;
        private System.Windows.Forms.Panel pinStart;
        private System.Windows.Forms.Panel pinEnd;
        private System.Windows.Forms.Button btnPlaySelected;
        private System.Windows.Forms.Panel progressBorderSession;
        private System.Windows.Forms.Panel progressInsideSession;
        private System.Windows.Forms.Button btnJsonGenerate;
        private System.Windows.Forms.Button btnOpenProject;
        private System.Windows.Forms.Button btnCreateProject;
        private System.Windows.Forms.RichTextBox txtNote;
        private System.Windows.Forms.Button btnFullPlay;
    }
}

