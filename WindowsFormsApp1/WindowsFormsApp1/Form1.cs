using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаба1прога
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "произведен 1 клик";
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "произведено 2 клика";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            MessageBox.Show(
                    "Не отключайте принтер",
                    "Идет печать",
                MessageBoxButtons.OK);
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            MessageBox.Show(
                    "Печать завершена!",
                    "Внимание!",
                MessageBoxButtons.OK);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            panel1.Text = "ожидание команды пользователя";
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            panel1.Text = "введите команду";
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
            MessageBox.Show(
                    "Создано новое окно",
                    "Внимание!",
                MessageBoxButtons.OK);
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            MessageBox.Show(
                    "скачивание в процессе",
                    "Внимание!",
                MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
