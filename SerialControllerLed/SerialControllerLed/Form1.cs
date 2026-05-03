using System.IO.Ports;

namespace SerialControllerLed
{
    public partial class Screen : Form
    {
        SerialPort myPort = null;
        public Screen()
        {
            InitializeComponent();
            buttonOnRed.Enabled = false;
            buttonOffRed.Enabled = false;
            buttonOnBlue.Enabled = false;
            buttonOffBlue.Enabled = false;
        }

        private void Screen_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (myPort != null && myPort.IsOpen)
            {
                myPort.Close();
                myPort.Dispose();
            }
            base.OnFormClosing(e);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem == null)
            {
                MessageBox.Show("Выберите COM-порт");
                return;
            }

            string selectedPort = comboBoxPorts.SelectedItem.ToString();

            if (selectedPort == "Порты не найдены")
            {
                MessageBox.Show("Нет доступных COM-портов");
                return;
            }

            try
            {
                // Теперь используем myPort, объявленную в классе
                myPort = new SerialPort(selectedPort);
                myPort.BaudRate = 9600;
                myPort.Open();

                MessageBox.Show($"Подключено к {selectedPort}!");

                // Включаем кнопки ON/OFF после подключения
                buttonOnRed.Enabled = true;
                buttonOffRed.Enabled = true;
                buttonOnBlue.Enabled = true;
                buttonOffBlue.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void buttonOnRed_Click(object sender, EventArgs e)
        {
            if (myPort != null && myPort.IsOpen)
            {
                myPort.Write("ONRED\n");
            }
            else
            {
                MessageBox.Show("Нет подключения к порту!");
            }
        }

        private void buttonOffRed_Click(object sender, EventArgs e)
        {
            if (myPort != null && myPort.IsOpen)
            {
                myPort.Write("OFFRED\n");
            }
            else
            {
                MessageBox.Show("Нет подключения к порту!");
            }
        }

        private void buttonOnBlue_Click(object sender, EventArgs e)
        {
            if (myPort != null && myPort.IsOpen)
            {
                myPort.Write("ONBLUE\n");
            }
            else
            {
                MessageBox.Show("Нет подключения к порту!");
            }
        }

        private void buttonOffBlue_Click(object sender, EventArgs e)
        {
            if (myPort != null && myPort.IsOpen)
            {
                myPort.Write("OFFBLUE\n");
            }
            else
            {
                MessageBox.Show("Нет подключения к порту!");
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();  // ← Очищаем старые порты

            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);

            if (comboBoxPorts.Items.Count > 0)
                comboBoxPorts.SelectedIndex = 0;
            else
                comboBoxPorts.Text = "Порты не найдены";
        }
    }
}
