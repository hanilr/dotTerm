using System.IO.Ports;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace dotTerm
{
    public partial class serialCommunicationForm : Form
    {
        public SerialPort serialCom;
        private CancellationTokenSource CancelToken;

        public serialCommunicationForm()
        {
            InitializeComponent();
        }
        private void serialCommunicationForm_Load(object sender, EventArgs e)
        {
            // Set COM Port to First Array Item
            refreshButton_Click(sender, e);

            // Contol Settings Initial Settings
            comPortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            baudrateComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            dataComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            parityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stopBitComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            flowControlComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            if (comPortComboBox.Enabled)
            {
                comPortComboBox.Items.Clear();
                comPortComboBox.Items.AddRange(ports);
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (comPortComboBox.Enabled)
            {
                comPortComboBox.Enabled = false;
                selectButton.Text = "Drop";
            }
            else
            {
                comPortComboBox.Enabled = true;
                selectButton.Text = "Select";
            }
        }

        private void allDefaultButton_Click(object sender, EventArgs e)
        {
            if (!baudrateLock.Checked) baudrateComboBox.Text = "9600";
            if (!dataLock.Checked) dataComboBox.Text = "8";
            if (!parityLock.Checked) parityComboBox.Text = "none";
            if (!stopBitLock.Checked) stopBitComboBox.Text = "1";
            if (!flowControlLock.Checked) flowControlComboBox.Text = "none";

            if (allDefaultButton.BackColor == Color.FromArgb(200, 55, 55))
            {
                allDefaultButton.BackColor = Color.FromArgb(55, 200, 55);
            }
        }

        private void allLockButton_Click(object sender, EventArgs e)
        {
            baudrateLock.Checked = !baudrateLock.Checked;
            dataLock.Checked = !dataLock.Checked;
            parityLock.Checked = !parityLock.Checked;
            stopBitLock.Checked = !stopBitLock.Checked;
            flowControlLock.Checked = !flowControlLock.Checked;

            if (allLockButton.BackColor == Color.FromArgb(55, 200, 55))
            {
                allLockButton.BackColor = Color.FromArgb(200, 55, 55);
            }
            else allLockButton.BackColor = Color.FromArgb(55, 200, 55);
        }

        private void baudrateDefaultButton_Click(object sender, EventArgs e)
        {
            if (baudrateLock.Checked == false) baudrateComboBox.Text = "9600";
        }

        private void dataDefaultButton_Click(object sender, EventArgs e)
        {
            if (dataLock.Checked == false) dataComboBox.Text = "8";
        }

        private void parityDefaultButton_Click(object sender, EventArgs e)
        {
            if (parityLock.Checked == false) parityComboBox.Text = "none";
        }

        private void stopBitDefaultButton_Click(object sender, EventArgs e)
        {
            if (stopBitLock.Checked == false) stopBitComboBox.Text = "1";
        }

        private void flowControlDefaultButton_Click(object sender, EventArgs e)
        {
            if (flowControlLock.Checked == false) flowControlComboBox.Text = "none";
        }

        private void baudrateLock_CheckedChanged(object sender, EventArgs e)
        {
            if (baudrateComboBox.Enabled) baudrateComboBox.Enabled = false;
            else baudrateComboBox.Enabled = true;
        }

        private void dataLock_CheckedChanged(object sender, EventArgs e)
        {
            if (dataComboBox.Enabled) dataComboBox.Enabled = false;
            else dataComboBox.Enabled = true;
        }

        private void parityLock_CheckedChanged(object sender, EventArgs e)
        {
            if (parityComboBox.Enabled) parityComboBox.Enabled = false;
            else parityComboBox.Enabled = true;
        }

        private void stopBitLock_CheckedChanged(object sender, EventArgs e)
        {
            if (stopBitComboBox.Enabled) stopBitComboBox.Enabled = false;
            else stopBitComboBox.Enabled = true;
        }

        private void flowControlLock_CheckedChanged(object sender, EventArgs e)
        {
            if (flowControlComboBox.Enabled) flowControlComboBox.Enabled = false;
            else flowControlComboBox.Enabled = true;
        }

        private async Task connectionTimer(CancellationToken token)
        {
            int t_second = 0, t_minute = 0, t_hour = 0;
            string c_second, c_minute, c_hour;
            try
            {
                while (!token.IsCancellationRequested)
                {
                    t_second += 1;
                    if (t_second == 60)
                    {
                        t_minute += 1;
                        t_second = 0;
                    }
                    if (t_minute == 60)
                    {
                        t_hour += 1;
                        t_minute = 0;
                    }

                    if (t_second < 10) c_second = "0" + t_second.ToString();
                    else c_second = t_second.ToString();
                    if (t_minute < 10) c_minute = "0" + t_minute.ToString();
                    else c_minute = t_minute.ToString();
                    if (t_hour < 10) c_hour = "0" + t_hour.ToString();
                    else c_hour = t_hour.ToString();

                    timerLabel.Text = c_hour + ":" + c_minute + ":" + c_second;
                    await Task.Delay(1000);
                }

                t_second = 0;
                c_second = "";
                t_minute = 0;
                c_minute = "";
                t_hour = 0;
                c_hour = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[!]: {ex.Message}" + Environment.NewLine);
            }
        }

        private async Task ReadAsync(CancellationToken token)
        {
            try
            {
                while (!token.IsCancellationRequested)
                {
                    if (serialCom != null && serialCom.IsOpen)
                    {
                        string com_data = serialCom.ReadExisting();
                        if (!string.IsNullOrEmpty(com_data))
                        {
                            receivedDataBox.AppendText(com_data);
                            receivedDataBox.SelectionStart = receivedDataBox.Text.Length;
                            receivedDataBox.ScrollToCaret();
                        }
                    }
                    int delayTime = writeTimeoutBox.Checked ? int.Parse(timeoutReadTextBox.Text) : 10;
                    await Task.Delay(delayTime, token);
                }
            }
            catch (TimeoutException ex)
            {
                Console.WriteLine($"[!]: {ex.Message}" + Environment.NewLine);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (comPortComboBox.Text.Equals(""))
            {
                if (!systemTextBox.Text.Equals("")) systemTextBox.AppendText(Environment.NewLine);
                systemTextBox.AppendText("[?] Select Port First.");
            }
            else if (baudrateComboBox.Text.Equals(""))
            {
                if (!systemTextBox.Text.Equals("")) systemTextBox.AppendText(Environment.NewLine);
                systemTextBox.AppendText("[?] Select Baud Rate.");
            }
            else if (dataComboBox.Text.Equals(""))
            {
                if (!systemTextBox.Text.Equals("")) systemTextBox.AppendText(Environment.NewLine);
                systemTextBox.AppendText("[?] Select Data.");
            }
            else if (parityComboBox.Text.Equals(""))
            {
                if (!systemTextBox.Text.Equals("")) systemTextBox.AppendText(Environment.NewLine);
                systemTextBox.AppendText("[?] Select Parity.");
            }
            else if (stopBitComboBox.Text.Equals(""))
            {
                if (!systemTextBox.Text.Equals("")) systemTextBox.AppendText(Environment.NewLine);
                systemTextBox.AppendText("[?] Select Stop Bit.");
            }
            else if (flowControlComboBox.Text.Equals(""))
            {
                if (!systemTextBox.Text.Equals("")) systemTextBox.AppendText(Environment.NewLine);
                systemTextBox.AppendText("[?] Select Flow Control.");
            }
            else
            {
                serialCom = new SerialPort();
                serialCom.PortName = comPortComboBox.Text;
                serialCom.BaudRate = int.Parse(baudrateComboBox.Text);
                serialCom.DataBits = int.Parse(dataComboBox.Text);

                if (parityComboBox.Text.Equals("none")) serialCom.Parity = Parity.None;
                else if (parityComboBox.Text.Equals("even")) serialCom.Parity = Parity.Even;
                else if (parityComboBox.Text.Equals("mark")) serialCom.Parity = Parity.Mark;
                else if (parityComboBox.Text.Equals("odd")) serialCom.Parity = Parity.Odd;
                else if (parityComboBox.Text.Equals("space")) serialCom.Parity = Parity.Space;

                if (stopBitComboBox.Text.Equals("1")) serialCom.StopBits = StopBits.One;
                else if (stopBitComboBox.Text.Equals("2")) serialCom.StopBits = StopBits.Two;
                else if (stopBitComboBox.Text.Equals("none")) serialCom.StopBits = StopBits.None;

                if (flowControlComboBox.Text.Equals("none")) serialCom.Handshake = Handshake.None;
                else if (flowControlComboBox.Text.Equals("xon/xoff")) serialCom.Handshake = Handshake.XOnXOff;
                else if (flowControlComboBox.Text.Equals("rts/cts")) serialCom.Handshake = Handshake.RequestToSend;
                else if (flowControlComboBox.Text.Equals("dsr/dtr")) serialCom.Handshake = Handshake.RequestToSendXOnXOff;

                serialCom.DtrEnable = dtrEnableBox.Checked;
                serialCom.RtsEnable = rtsEnableBox.Checked;

                if (writeTimeoutBox.Checked) serialCom.WriteTimeout = int.Parse(timeoutWriteTextBox.Text);
                if (readTimeoutBox.Checked) serialCom.ReadTimeout = int.Parse(timeoutReadTextBox.Text);

                serialCom.Encoding = System.Text.Encoding.ASCII;
                serialCom.Open();

                if (serialCom.IsOpen)
                {
                    if (comPortComboBox.Enabled == true) selectButton_Click(sender, e);

                    connectivityTextBox.BackColor = Color.FromArgb(55, 200, 55);
                    connectivityTextBox.Text = "Connected";
                    if (systemTextBox.Text.Equals("")) systemTextBox.AppendText("[!] Started.");
                    else systemTextBox.AppendText(Environment.NewLine + "[!] Started.");

                    logButton.Enabled = true;
                    stopButton.Enabled = true;
                    resetButton.Enabled = true;
                    receivedDataBox.Enabled = true;
                    sendCommandButton.Enabled = true;
                    sendCommandTextBox.Enabled = true;
                    connectivityCheckButton.Enabled = true;
                    receivedDataBoxClearButton.Enabled = true;
                    refreshButton.Enabled = false;
                    selectButton.Enabled = false;
                    startButton.Enabled = false;

                    CancelToken = new CancellationTokenSource();
                    Task t1 = ReadAsync(CancelToken.Token);
                    Task t2 = connectionTimer(CancelToken.Token);
                }
                else
                {
                    connectivityTextBox.BackColor = Color.FromArgb(55, 55, 200);
                    connectivityTextBox.Text = "ERROR";
                }
            }
            systemTextBox.ScrollToCaret();
        }

        private void connectivityCheckButton_Click(object sender, EventArgs e)
        {
            if (serialCom.IsOpen)
            {
                connectivityTextBox.BackColor = Color.FromArgb(55, 200, 55);
                connectivityTextBox.Text = "Connected";
            }
            else
            {
                connectivityTextBox.BackColor = Color.FromArgb(200, 55, 55);
                connectivityTextBox.Text = "Disconnect";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            if (serialCom.IsOpen) stopButton_Click(sender, e);
            startButton_Click(sender, e);

            if (serialCom.IsOpen)
            {
                string[] lines = systemTextBox.Lines;
                systemTextBox.Lines = lines.Take(lines.Length - 2).ToArray();

                systemTextBox.AppendText(Environment.NewLine + "[!] Restarted.");
                systemTextBox.ScrollToCaret();
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (CancelToken != null) CancelToken.Cancel();
            serialCom.Close();

            if (!serialCom.IsOpen)
            {
                connectivityTextBox.BackColor = Color.FromArgb(200, 55, 55);
                connectivityTextBox.Text = "Disconnect";

                stopButton.Enabled = false;
                resetButton.Enabled = false;
                receivedDataBox.Enabled = false;
                sendCommandButton.Enabled = false;
                sendCommandTextBox.Enabled = false;
                connectivityCheckButton.Enabled = false;
                if (receivedDataBox.Text.Equals("")) receivedDataBoxClearButton.Enabled = false;
                refreshButton.Enabled = true;
                selectButton.Enabled = true;
                startButton.Enabled = true;

                systemTextBox.AppendText(Environment.NewLine + "[!] Stopped.");
                systemTextBox.ScrollToCaret();
            }
            else
            {
                connectivityTextBox.BackColor = Color.FromArgb(55, 55, 200);
                connectivityTextBox.Text = "ERROR";
            }
        }

        private void sendCommandButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialCom != null && serialCom.IsOpen)
                {
                    if (!string.IsNullOrWhiteSpace(sendCommandTextBox.Text))
                    {
                        receivedDataBox.AppendText(sendCommandTextBox.Text + Environment.NewLine);
                        serialCom.Write(sendCommandTextBox.Text + "\n");
                        sendCommandTextBox.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                systemTextBox.AppendText(Environment.NewLine + "[N] Failed: " + ex);
                systemTextBox.ScrollToCaret();
            }
        }

        private void writeTimeoutBox_CheckedChanged(object sender, EventArgs e)
        {
            if (writeTimeoutBox.Checked) timeoutWriteTextBox.Enabled = true;
            else timeoutWriteTextBox.Enabled = false;
        }

        private void readTimeoutBox_CheckedChanged(object sender, EventArgs e)
        {
            if (readTimeoutBox.Checked) timeoutReadTextBox.Enabled = true;
            else timeoutReadTextBox.Enabled = false;
        }

        private void sendCommandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.Enter)) sendCommandButton_Click(sender, e);
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            if (receivedDataBox.Text.Equals(""))
            {
                systemTextBox.AppendText(Environment.NewLine + "[N] No data to log.");
                systemTextBox.ScrollToCaret();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Log saving path:";
                saveFileDialog.DefaultExt = "txt";
                saveFileDialog.AddExtension = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    string log = receivedDataBox.Text;
                    File.WriteAllText(filePath, log);

                    systemTextBox.AppendText(Environment.NewLine + "[Y] Log Saved!");
                    systemTextBox.ScrollToCaret();
                }
            }
        }

        private void receivedDataBoxClearButton_Click(object sender, EventArgs e)
        {
            if (!receivedDataBox.Text.Equals(""))
            {
                receivedDataBox.Clear();
                systemTextBox.AppendText(Environment.NewLine + "[Y] Received Data Cleared.");
                systemTextBox.ScrollToCaret();
                if (!serialCom.IsOpen && receivedDataBox.Text.Equals("")) receivedDataBoxClearButton.Enabled = false;
            }
        }

        private void controlSettingsHardResetButton_Click(object sender, EventArgs e)
        {
            baudrateLock.Checked = false;
            dataLock.Checked = false;
            parityLock.Checked = false;
            stopBitLock.Checked = false;
            flowControlLock.Checked = false;
            controlSettingsResetButton_Click(sender, e);

            if (allLockButton.BackColor == Color.FromArgb(55, 200, 55))
            {
                allLockButton.BackColor = Color.FromArgb(200, 55, 55);
            }
        }

        private void controlSettingsResetButton_Click(object sender, EventArgs e)
        {
            if (!baudrateLock.Checked) baudrateComboBox.Text = "";
            if (!dataLock.Checked) dataComboBox.Text = "";
            if (!parityLock.Checked) parityComboBox.Text = "";
            if (!stopBitLock.Checked) stopBitComboBox.Text = "";
            if (!flowControlLock.Checked) flowControlComboBox.Text = "";
        }
    }
}