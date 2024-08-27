namespace dotTerm
{
    partial class serialCommunicationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(serialCommunicationForm));
            refreshButton = new Button();
            comPortComboBox = new ComboBox();
            selectButton = new Button();
            baudrateComboBox = new ComboBox();
            baudrateLock = new CheckBox();
            dataLock = new CheckBox();
            dataComboBox = new ComboBox();
            parityLock = new CheckBox();
            parityComboBox = new ComboBox();
            stopBitComboBox = new ComboBox();
            stopBitLock = new CheckBox();
            flowControlComboBox = new ComboBox();
            flowControlLock = new CheckBox();
            baudrateDefaultButton = new Button();
            dataDefaultButton = new Button();
            parityDefaultButton = new Button();
            stopBitDefaultButton = new Button();
            flowControlDefaultButton = new Button();
            allDefaultButton = new Button();
            controlSettingsGroupBox = new GroupBox();
            controlSettingsHardResetButton = new Button();
            controlSettingsResetButton = new Button();
            flowControlLabel = new Label();
            stopBit = new Label();
            label3 = new Label();
            dataLabel = new Label();
            baudrateLabel = new Label();
            startButton = new Button();
            stopButton = new Button();
            receivedDataLabel = new Label();
            sendCommandTextBox = new TextBox();
            sendCommandButton = new Button();
            connectivityTextBox = new TextBox();
            connectivityCheckButton = new Button();
            allLockButton = new Button();
            resetButton = new Button();
            optionsGroupBox = new GroupBox();
            timeoutReadTextBox = new TextBox();
            timeoutWriteTextBox = new TextBox();
            readTimeoutBox = new CheckBox();
            writeTimeoutBox = new CheckBox();
            rtsEnableBox = new CheckBox();
            dtrEnableBox = new CheckBox();
            logButton = new Button();
            systemTextBox = new RichTextBox();
            systemLabel = new Label();
            receivedDataBoxClearButton = new Button();
            receivedDataBox = new RichTextBox();
            timerLabel = new Label();
            connectionTimeLabel = new Label();
            controlSettingsGroupBox.SuspendLayout();
            optionsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.White;
            refreshButton.ForeColor = Color.Black;
            refreshButton.Location = new Point(12, 12);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(54, 23);
            refreshButton.TabIndex = 1;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // comPortComboBox
            // 
            comPortComboBox.BackColor = Color.White;
            comPortComboBox.FormattingEnabled = true;
            comPortComboBox.Location = new Point(72, 13);
            comPortComboBox.Name = "comPortComboBox";
            comPortComboBox.Size = new Size(104, 23);
            comPortComboBox.TabIndex = 2;
            comPortComboBox.Text = "COM";
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.White;
            selectButton.ForeColor = Color.Black;
            selectButton.Location = new Point(182, 13);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(46, 23);
            selectButton.TabIndex = 3;
            selectButton.Text = "Select";
            selectButton.UseVisualStyleBackColor = false;
            selectButton.Click += selectButton_Click;
            // 
            // baudrateComboBox
            // 
            baudrateComboBox.BackColor = Color.White;
            baudrateComboBox.FormattingEnabled = true;
            baudrateComboBox.Items.AddRange(new object[] { "", "110", "300", "600", "1200", "2400", "4800", "9600", "14400", "19200", "38400", "57600", "115200", "230400", "460800", "921600" });
            baudrateComboBox.Location = new Point(81, 22);
            baudrateComboBox.Name = "baudrateComboBox";
            baudrateComboBox.Size = new Size(61, 23);
            baudrateComboBox.TabIndex = 4;
            // 
            // baudrateLock
            // 
            baudrateLock.AutoSize = true;
            baudrateLock.BackColor = SystemColors.Window;
            baudrateLock.Location = new Point(148, 27);
            baudrateLock.Name = "baudrateLock";
            baudrateLock.Size = new Size(15, 14);
            baudrateLock.TabIndex = 5;
            baudrateLock.UseVisualStyleBackColor = false;
            baudrateLock.CheckedChanged += baudrateLock_CheckedChanged;
            // 
            // dataLock
            // 
            dataLock.AutoSize = true;
            dataLock.Location = new Point(148, 55);
            dataLock.Name = "dataLock";
            dataLock.Size = new Size(15, 14);
            dataLock.TabIndex = 6;
            dataLock.UseVisualStyleBackColor = true;
            dataLock.CheckedChanged += dataLock_CheckedChanged;
            // 
            // dataComboBox
            // 
            dataComboBox.BackColor = Color.White;
            dataComboBox.FormattingEnabled = true;
            dataComboBox.Items.AddRange(new object[] { "", "7", "8" });
            dataComboBox.Location = new Point(81, 51);
            dataComboBox.Name = "dataComboBox";
            dataComboBox.Size = new Size(61, 23);
            dataComboBox.TabIndex = 7;
            // 
            // parityLock
            // 
            parityLock.AutoSize = true;
            parityLock.Location = new Point(148, 84);
            parityLock.Name = "parityLock";
            parityLock.Size = new Size(15, 14);
            parityLock.TabIndex = 8;
            parityLock.UseVisualStyleBackColor = true;
            parityLock.CheckedChanged += parityLock_CheckedChanged;
            // 
            // parityComboBox
            // 
            parityComboBox.BackColor = Color.White;
            parityComboBox.FormattingEnabled = true;
            parityComboBox.Items.AddRange(new object[] { "", "none", "odd", "even", "mark", "space" });
            parityComboBox.Location = new Point(81, 79);
            parityComboBox.Name = "parityComboBox";
            parityComboBox.Size = new Size(61, 23);
            parityComboBox.TabIndex = 9;
            // 
            // stopBitComboBox
            // 
            stopBitComboBox.BackColor = Color.White;
            stopBitComboBox.FormattingEnabled = true;
            stopBitComboBox.Items.AddRange(new object[] { "", "1", "2", "none" });
            stopBitComboBox.Location = new Point(81, 108);
            stopBitComboBox.Name = "stopBitComboBox";
            stopBitComboBox.Size = new Size(61, 23);
            stopBitComboBox.TabIndex = 10;
            // 
            // stopBitLock
            // 
            stopBitLock.AutoSize = true;
            stopBitLock.Location = new Point(148, 113);
            stopBitLock.Name = "stopBitLock";
            stopBitLock.Size = new Size(15, 14);
            stopBitLock.TabIndex = 11;
            stopBitLock.UseVisualStyleBackColor = true;
            stopBitLock.CheckedChanged += stopBitLock_CheckedChanged;
            // 
            // flowControlComboBox
            // 
            flowControlComboBox.BackColor = Color.White;
            flowControlComboBox.FormattingEnabled = true;
            flowControlComboBox.Items.AddRange(new object[] { "", "xon/xoff", "rts/cts", "dsr/dtr", "none" });
            flowControlComboBox.Location = new Point(82, 137);
            flowControlComboBox.Name = "flowControlComboBox";
            flowControlComboBox.Size = new Size(61, 23);
            flowControlComboBox.TabIndex = 12;
            // 
            // flowControlLock
            // 
            flowControlLock.AutoSize = true;
            flowControlLock.Location = new Point(148, 142);
            flowControlLock.Name = "flowControlLock";
            flowControlLock.Size = new Size(15, 14);
            flowControlLock.TabIndex = 13;
            flowControlLock.UseVisualStyleBackColor = true;
            flowControlLock.CheckedChanged += flowControlLock_CheckedChanged;
            // 
            // baudrateDefaultButton
            // 
            baudrateDefaultButton.BackColor = Color.White;
            baudrateDefaultButton.ForeColor = Color.Black;
            baudrateDefaultButton.Location = new Point(169, 21);
            baudrateDefaultButton.Name = "baudrateDefaultButton";
            baudrateDefaultButton.Size = new Size(53, 23);
            baudrateDefaultButton.TabIndex = 14;
            baudrateDefaultButton.Text = "Default";
            baudrateDefaultButton.UseVisualStyleBackColor = false;
            baudrateDefaultButton.Click += baudrateDefaultButton_Click;
            // 
            // dataDefaultButton
            // 
            dataDefaultButton.BackColor = Color.White;
            dataDefaultButton.ForeColor = Color.Black;
            dataDefaultButton.Location = new Point(169, 51);
            dataDefaultButton.Name = "dataDefaultButton";
            dataDefaultButton.Size = new Size(53, 23);
            dataDefaultButton.TabIndex = 15;
            dataDefaultButton.Text = "Default";
            dataDefaultButton.UseVisualStyleBackColor = false;
            dataDefaultButton.Click += dataDefaultButton_Click;
            // 
            // parityDefaultButton
            // 
            parityDefaultButton.BackColor = Color.White;
            parityDefaultButton.ForeColor = Color.Black;
            parityDefaultButton.Location = new Point(169, 79);
            parityDefaultButton.Name = "parityDefaultButton";
            parityDefaultButton.Size = new Size(53, 23);
            parityDefaultButton.TabIndex = 16;
            parityDefaultButton.Text = "Default";
            parityDefaultButton.UseVisualStyleBackColor = false;
            parityDefaultButton.Click += parityDefaultButton_Click;
            // 
            // stopBitDefaultButton
            // 
            stopBitDefaultButton.BackColor = Color.White;
            stopBitDefaultButton.ForeColor = Color.Black;
            stopBitDefaultButton.Location = new Point(169, 108);
            stopBitDefaultButton.Name = "stopBitDefaultButton";
            stopBitDefaultButton.Size = new Size(53, 23);
            stopBitDefaultButton.TabIndex = 17;
            stopBitDefaultButton.Text = "Default";
            stopBitDefaultButton.UseVisualStyleBackColor = false;
            stopBitDefaultButton.Click += stopBitDefaultButton_Click;
            // 
            // flowControlDefaultButton
            // 
            flowControlDefaultButton.BackColor = Color.White;
            flowControlDefaultButton.ForeColor = Color.Black;
            flowControlDefaultButton.Location = new Point(169, 137);
            flowControlDefaultButton.Name = "flowControlDefaultButton";
            flowControlDefaultButton.Size = new Size(53, 23);
            flowControlDefaultButton.TabIndex = 18;
            flowControlDefaultButton.Text = "Default";
            flowControlDefaultButton.UseVisualStyleBackColor = false;
            flowControlDefaultButton.Click += flowControlDefaultButton_Click;
            // 
            // allDefaultButton
            // 
            allDefaultButton.BackColor = Color.FromArgb(200, 55, 55);
            allDefaultButton.ForeColor = Color.Snow;
            allDefaultButton.Location = new Point(12, 42);
            allDefaultButton.Name = "allDefaultButton";
            allDefaultButton.Size = new Size(75, 23);
            allDefaultButton.TabIndex = 0;
            allDefaultButton.Text = "Default All";
            allDefaultButton.UseVisualStyleBackColor = false;
            allDefaultButton.Click += allDefaultButton_Click;
            // 
            // controlSettingsGroupBox
            // 
            controlSettingsGroupBox.BackColor = Color.WhiteSmoke;
            controlSettingsGroupBox.Controls.Add(controlSettingsHardResetButton);
            controlSettingsGroupBox.Controls.Add(controlSettingsResetButton);
            controlSettingsGroupBox.Controls.Add(flowControlLabel);
            controlSettingsGroupBox.Controls.Add(stopBit);
            controlSettingsGroupBox.Controls.Add(label3);
            controlSettingsGroupBox.Controls.Add(dataLabel);
            controlSettingsGroupBox.Controls.Add(baudrateLabel);
            controlSettingsGroupBox.Controls.Add(flowControlDefaultButton);
            controlSettingsGroupBox.Controls.Add(baudrateComboBox);
            controlSettingsGroupBox.Controls.Add(baudrateLock);
            controlSettingsGroupBox.Controls.Add(stopBitDefaultButton);
            controlSettingsGroupBox.Controls.Add(dataLock);
            controlSettingsGroupBox.Controls.Add(parityDefaultButton);
            controlSettingsGroupBox.Controls.Add(dataComboBox);
            controlSettingsGroupBox.Controls.Add(dataDefaultButton);
            controlSettingsGroupBox.Controls.Add(parityLock);
            controlSettingsGroupBox.Controls.Add(baudrateDefaultButton);
            controlSettingsGroupBox.Controls.Add(parityComboBox);
            controlSettingsGroupBox.Controls.Add(flowControlLock);
            controlSettingsGroupBox.Controls.Add(stopBitComboBox);
            controlSettingsGroupBox.Controls.Add(flowControlComboBox);
            controlSettingsGroupBox.Controls.Add(stopBitLock);
            controlSettingsGroupBox.Location = new Point(1, 99);
            controlSettingsGroupBox.Name = "controlSettingsGroupBox";
            controlSettingsGroupBox.Size = new Size(232, 194);
            controlSettingsGroupBox.TabIndex = 20;
            controlSettingsGroupBox.TabStop = false;
            controlSettingsGroupBox.Text = "Control Settings";
            // 
            // controlSettingsHardResetButton
            // 
            controlSettingsHardResetButton.BackColor = Color.White;
            controlSettingsHardResetButton.ForeColor = Color.Black;
            controlSettingsHardResetButton.Location = new Point(6, 165);
            controlSettingsHardResetButton.Name = "controlSettingsHardResetButton";
            controlSettingsHardResetButton.Size = new Size(78, 23);
            controlSettingsHardResetButton.TabIndex = 25;
            controlSettingsHardResetButton.Text = "Hard Reset";
            controlSettingsHardResetButton.UseVisualStyleBackColor = false;
            controlSettingsHardResetButton.Click += controlSettingsHardResetButton_Click;
            // 
            // controlSettingsResetButton
            // 
            controlSettingsResetButton.BackColor = Color.White;
            controlSettingsResetButton.ForeColor = Color.Black;
            controlSettingsResetButton.Location = new Point(179, 165);
            controlSettingsResetButton.Name = "controlSettingsResetButton";
            controlSettingsResetButton.Size = new Size(47, 23);
            controlSettingsResetButton.TabIndex = 24;
            controlSettingsResetButton.Text = "Reset";
            controlSettingsResetButton.UseVisualStyleBackColor = false;
            controlSettingsResetButton.Click += controlSettingsResetButton_Click;
            // 
            // flowControlLabel
            // 
            flowControlLabel.AutoSize = true;
            flowControlLabel.Location = new Point(2, 142);
            flowControlLabel.Name = "flowControlLabel";
            flowControlLabel.Size = new Size(78, 15);
            flowControlLabel.TabIndex = 23;
            flowControlLabel.Text = "Flow Control:";
            // 
            // stopBit
            // 
            stopBit.AutoSize = true;
            stopBit.Location = new Point(2, 112);
            stopBit.Name = "stopBit";
            stopBit.Size = new Size(51, 15);
            stopBit.TabIndex = 22;
            stopBit.Text = "Stop Bit:";
            // 
            // label3
            // 
            label3.AccessibleDescription = "parityLabel";
            label3.AutoSize = true;
            label3.Location = new Point(2, 84);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 21;
            label3.Text = "Parity:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Location = new Point(2, 54);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new Size(34, 15);
            dataLabel.TabIndex = 20;
            dataLabel.Text = "Data:";
            // 
            // baudrateLabel
            // 
            baudrateLabel.AutoSize = true;
            baudrateLabel.Location = new Point(2, 26);
            baudrateLabel.Name = "baudrateLabel";
            baudrateLabel.Size = new Size(63, 15);
            baudrateLabel.TabIndex = 19;
            baudrateLabel.Text = "Baud Rate:";
            // 
            // startButton
            // 
            startButton.BackColor = Color.White;
            startButton.ForeColor = Color.Black;
            startButton.Location = new Point(12, 429);
            startButton.Name = "startButton";
            startButton.Size = new Size(54, 23);
            startButton.TabIndex = 21;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // stopButton
            // 
            stopButton.BackColor = Color.White;
            stopButton.Enabled = false;
            stopButton.ForeColor = Color.Black;
            stopButton.Location = new Point(161, 429);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(58, 23);
            stopButton.TabIndex = 22;
            stopButton.Text = "Stop";
            stopButton.UseVisualStyleBackColor = false;
            stopButton.Click += stopButton_Click;
            // 
            // receivedDataLabel
            // 
            receivedDataLabel.AutoSize = true;
            receivedDataLabel.BackColor = Color.Transparent;
            receivedDataLabel.BorderStyle = BorderStyle.FixedSingle;
            receivedDataLabel.ForeColor = Color.Black;
            receivedDataLabel.Location = new Point(509, 61);
            receivedDataLabel.Name = "receivedDataLabel";
            receivedDataLabel.Size = new Size(83, 17);
            receivedDataLabel.TabIndex = 24;
            receivedDataLabel.Text = "Received Data";
            // 
            // sendCommandTextBox
            // 
            sendCommandTextBox.BackColor = Color.White;
            sendCommandTextBox.BorderStyle = BorderStyle.FixedSingle;
            sendCommandTextBox.Enabled = false;
            sendCommandTextBox.Location = new Point(328, 429);
            sendCommandTextBox.Name = "sendCommandTextBox";
            sendCommandTextBox.Size = new Size(157, 23);
            sendCommandTextBox.TabIndex = 25;
            sendCommandTextBox.KeyPress += sendCommandTextBox_KeyPress;
            // 
            // sendCommandButton
            // 
            sendCommandButton.BackColor = Color.White;
            sendCommandButton.Enabled = false;
            sendCommandButton.ForeColor = Color.Black;
            sendCommandButton.Location = new Point(491, 429);
            sendCommandButton.Name = "sendCommandButton";
            sendCommandButton.Size = new Size(101, 23);
            sendCommandButton.TabIndex = 26;
            sendCommandButton.Text = "Send Command";
            sendCommandButton.UseVisualStyleBackColor = false;
            sendCommandButton.Click += sendCommandButton_Click;
            // 
            // connectivityTextBox
            // 
            connectivityTextBox.BackColor = Color.FromArgb(200, 55, 55);
            connectivityTextBox.BorderStyle = BorderStyle.None;
            connectivityTextBox.ForeColor = Color.White;
            connectivityTextBox.Location = new Point(150, 42);
            connectivityTextBox.Name = "connectivityTextBox";
            connectivityTextBox.ReadOnly = true;
            connectivityTextBox.Size = new Size(78, 16);
            connectivityTextBox.TabIndex = 27;
            connectivityTextBox.Text = "Disconnected";
            connectivityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // connectivityCheckButton
            // 
            connectivityCheckButton.BackColor = Color.FromArgb(55, 55, 200);
            connectivityCheckButton.Enabled = false;
            connectivityCheckButton.ForeColor = Color.Snow;
            connectivityCheckButton.Location = new Point(150, 70);
            connectivityCheckButton.Name = "connectivityCheckButton";
            connectivityCheckButton.Size = new Size(78, 23);
            connectivityCheckButton.TabIndex = 29;
            connectivityCheckButton.Text = "Refresh";
            connectivityCheckButton.UseVisualStyleBackColor = false;
            connectivityCheckButton.Click += connectivityCheckButton_Click;
            // 
            // allLockButton
            // 
            allLockButton.BackColor = Color.FromArgb(200, 55, 55);
            allLockButton.ForeColor = Color.Snow;
            allLockButton.Location = new Point(12, 70);
            allLockButton.Name = "allLockButton";
            allLockButton.Size = new Size(75, 23);
            allLockButton.TabIndex = 30;
            allLockButton.Text = "Lock All";
            allLockButton.UseVisualStyleBackColor = false;
            allLockButton.Click += allLockButton_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = Color.White;
            resetButton.Enabled = false;
            resetButton.ForeColor = Color.Black;
            resetButton.Location = new Point(72, 429);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(83, 23);
            resetButton.TabIndex = 28;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // optionsGroupBox
            // 
            optionsGroupBox.Controls.Add(timeoutReadTextBox);
            optionsGroupBox.Controls.Add(timeoutWriteTextBox);
            optionsGroupBox.Controls.Add(readTimeoutBox);
            optionsGroupBox.Controls.Add(writeTimeoutBox);
            optionsGroupBox.Controls.Add(rtsEnableBox);
            optionsGroupBox.Controls.Add(dtrEnableBox);
            optionsGroupBox.Location = new Point(3, 299);
            optionsGroupBox.Name = "optionsGroupBox";
            optionsGroupBox.Size = new Size(230, 124);
            optionsGroupBox.TabIndex = 31;
            optionsGroupBox.TabStop = false;
            optionsGroupBox.Text = "Options";
            // 
            // timeoutReadTextBox
            // 
            timeoutReadTextBox.Enabled = false;
            timeoutReadTextBox.Location = new Point(133, 93);
            timeoutReadTextBox.Name = "timeoutReadTextBox";
            timeoutReadTextBox.Size = new Size(77, 23);
            timeoutReadTextBox.TabIndex = 5;
            // 
            // timeoutWriteTextBox
            // 
            timeoutWriteTextBox.Enabled = false;
            timeoutWriteTextBox.Location = new Point(133, 68);
            timeoutWriteTextBox.Name = "timeoutWriteTextBox";
            timeoutWriteTextBox.Size = new Size(77, 23);
            timeoutWriteTextBox.TabIndex = 4;
            // 
            // readTimeoutBox
            // 
            readTimeoutBox.AutoSize = true;
            readTimeoutBox.Location = new Point(6, 97);
            readTimeoutBox.Name = "readTimeoutBox";
            readTimeoutBox.Size = new Size(126, 19);
            readTimeoutBox.TabIndex = 3;
            readTimeoutBox.Text = "Read Timeout (ms)";
            readTimeoutBox.UseVisualStyleBackColor = true;
            readTimeoutBox.CheckedChanged += readTimeoutBox_CheckedChanged;
            // 
            // writeTimeoutBox
            // 
            writeTimeoutBox.AutoSize = true;
            writeTimeoutBox.Location = new Point(6, 72);
            writeTimeoutBox.Name = "writeTimeoutBox";
            writeTimeoutBox.Size = new Size(128, 19);
            writeTimeoutBox.TabIndex = 2;
            writeTimeoutBox.Text = "Write Timeout (ms)";
            writeTimeoutBox.UseVisualStyleBackColor = true;
            writeTimeoutBox.CheckedChanged += writeTimeoutBox_CheckedChanged;
            // 
            // rtsEnableBox
            // 
            rtsEnableBox.AutoSize = true;
            rtsEnableBox.Location = new Point(6, 47);
            rtsEnableBox.Name = "rtsEnableBox";
            rtsEnableBox.Size = new Size(179, 19);
            rtsEnableBox.TabIndex = 1;
            rtsEnableBox.Text = "Enable RTS (Request To Send)";
            rtsEnableBox.UseVisualStyleBackColor = true;
            // 
            // dtrEnableBox
            // 
            dtrEnableBox.AutoSize = true;
            dtrEnableBox.Location = new Point(6, 22);
            dtrEnableBox.Name = "dtrEnableBox";
            dtrEnableBox.Size = new Size(205, 19);
            dtrEnableBox.TabIndex = 0;
            dtrEnableBox.Text = "Enable DTR  (Data Terminal Ready)";
            dtrEnableBox.UseVisualStyleBackColor = true;
            // 
            // logButton
            // 
            logButton.BackColor = Color.White;
            logButton.Enabled = false;
            logButton.ForeColor = Color.Black;
            logButton.Location = new Point(234, 429);
            logButton.Name = "logButton";
            logButton.Size = new Size(35, 23);
            logButton.TabIndex = 32;
            logButton.Text = "Log";
            logButton.UseVisualStyleBackColor = false;
            logButton.Click += logButton_Click;
            // 
            // systemTextBox
            // 
            systemTextBox.BackColor = Color.White;
            systemTextBox.ForeColor = Color.Black;
            systemTextBox.Location = new Point(234, 14);
            systemTextBox.Name = "systemTextBox";
            systemTextBox.ReadOnly = true;
            systemTextBox.Size = new Size(358, 46);
            systemTextBox.TabIndex = 33;
            systemTextBox.Text = "";
            // 
            // systemLabel
            // 
            systemLabel.AutoSize = true;
            systemLabel.BackColor = Color.White;
            systemLabel.BorderStyle = BorderStyle.FixedSingle;
            systemLabel.ForeColor = Color.Black;
            systemLabel.Location = new Point(545, 14);
            systemLabel.Name = "systemLabel";
            systemLabel.Size = new Size(47, 17);
            systemLabel.TabIndex = 34;
            systemLabel.Text = "System";
            // 
            // receivedDataBoxClearButton
            // 
            receivedDataBoxClearButton.BackColor = Color.White;
            receivedDataBoxClearButton.Enabled = false;
            receivedDataBoxClearButton.ForeColor = Color.Black;
            receivedDataBoxClearButton.Location = new Point(275, 429);
            receivedDataBoxClearButton.Name = "receivedDataBoxClearButton";
            receivedDataBoxClearButton.Size = new Size(47, 23);
            receivedDataBoxClearButton.TabIndex = 35;
            receivedDataBoxClearButton.Text = "Clear";
            receivedDataBoxClearButton.UseVisualStyleBackColor = false;
            receivedDataBoxClearButton.Click += receivedDataBoxClearButton_Click;
            // 
            // receivedDataBox
            // 
            receivedDataBox.BackColor = Color.White;
            receivedDataBox.BorderStyle = BorderStyle.FixedSingle;
            receivedDataBox.Enabled = false;
            receivedDataBox.ForeColor = Color.Black;
            receivedDataBox.Location = new Point(234, 79);
            receivedDataBox.Name = "receivedDataBox";
            receivedDataBox.ReadOnly = true;
            receivedDataBox.Size = new Size(358, 344);
            receivedDataBox.TabIndex = 23;
            receivedDataBox.Text = "";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = Color.Transparent;
            timerLabel.ForeColor = Color.Black;
            timerLabel.Location = new Point(341, 63);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(49, 15);
            timerLabel.TabIndex = 36;
            timerLabel.Text = "00.00.00";
            // 
            // connectionTimeLabel
            // 
            connectionTimeLabel.AutoSize = true;
            connectionTimeLabel.BackColor = Color.Transparent;
            connectionTimeLabel.ForeColor = Color.Black;
            connectionTimeLabel.Location = new Point(234, 63);
            connectionTimeLabel.Name = "connectionTimeLabel";
            connectionTimeLabel.Size = new Size(101, 15);
            connectionTimeLabel.TabIndex = 37;
            connectionTimeLabel.Text = "Connection Time:";
            // 
            // serialCommunicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(604, 461);
            Controls.Add(connectionTimeLabel);
            Controls.Add(timerLabel);
            Controls.Add(receivedDataBoxClearButton);
            Controls.Add(systemLabel);
            Controls.Add(systemTextBox);
            Controls.Add(logButton);
            Controls.Add(optionsGroupBox);
            Controls.Add(allLockButton);
            Controls.Add(connectivityCheckButton);
            Controls.Add(resetButton);
            Controls.Add(connectivityTextBox);
            Controls.Add(allDefaultButton);
            Controls.Add(sendCommandButton);
            Controls.Add(sendCommandTextBox);
            Controls.Add(receivedDataLabel);
            Controls.Add(receivedDataBox);
            Controls.Add(stopButton);
            Controls.Add(startButton);
            Controls.Add(controlSettingsGroupBox);
            Controls.Add(selectButton);
            Controls.Add(comPortComboBox);
            Controls.Add(refreshButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "serialCommunicationForm";
            Text = "dotTerm";
            Load += serialCommunicationForm_Load;
            controlSettingsGroupBox.ResumeLayout(false);
            controlSettingsGroupBox.PerformLayout();
            optionsGroupBox.ResumeLayout(false);
            optionsGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button refreshButton;
        private ComboBox comPortComboBox;
        private Button selectButton;
        private ComboBox baudrateComboBox;
        private CheckBox baudrateLock;
        private CheckBox dataLock;
        private ComboBox dataComboBox;
        private CheckBox parityLock;
        private ComboBox parityComboBox;
        private ComboBox stopBitComboBox;
        private CheckBox stopBitLock;
        private ComboBox flowControlComboBox;
        private CheckBox flowControlLock;
        private Button baudrateDefaultButton;
        private Button dataDefaultButton;
        private Button parityDefaultButton;
        private Button stopBitDefaultButton;
        private Button flowControlDefaultButton;
        private Button allDefaultButton;
        private GroupBox controlSettingsGroupBox;
        private Button startButton;
        private Button stopButton;
        private Label receivedDataLabel;
        private TextBox sendCommandTextBox;
        private Button sendCommandButton;
        private TextBox connectivityTextBox;
        private Button connectivityCheckButton;
        private Button allLockButton;
        private Button resetButton;
        private GroupBox optionsGroupBox;
        private CheckBox dtrEnableBox;
        private CheckBox rtsEnableBox;
        private TextBox timeoutWriteTextBox;
        private CheckBox readTimeoutBox;
        private CheckBox writeTimeoutBox;
        private TextBox timeoutReadTextBox;
        private Label baudrateLabel;
        private Label dataLabel;
        private Label label3;
        private Label flowControlLabel;
        private Label stopBit;
        private Button logButton;
        private RichTextBox systemTextBox;
        private Label systemLabel;
        private Button receivedDataBoxClearButton;
        private Button controlSettingsHardResetButton;
        private Button controlSettingsResetButton;
        private RichTextBox receivedDataBox;
        private Label timerLabel;
        private Label connectionTimeLabel;
    }
}
