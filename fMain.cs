using System;
using System.Windows.Forms;

namespace Laba3
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Computer computer = new Computer();
            fComputer fc = new fComputer(computer);

            if (fc.ShowDialog() == DialogResult.OK)
            {
                tbComputerInfo.Text += string.Format("Модель: {0}, Процесор: {1}, ОЗП: {2} ГБ, "
                    + "Пам'ять: {3} ГБ, Ціна: {4:0.00} грн\n"
                    + "Додаткові опції: {5} | {6}\n",
                    computer.ModelName,
                    computer.Processor,
                    computer.RAM,
                    computer.Storage,
                    computer.Price,
                    computer.HasGraphicsCard ? "Є відеокарта" : "Немає відеокарти",
                    computer.HasWiFi ? "Є Wi-Fi" : "Немає Wi-Fi");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Припинити роботу застосунку?",
                                "Припинити роботу",
                                MessageBoxButtons.OKCancel,
                                MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
