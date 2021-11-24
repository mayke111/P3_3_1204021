using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P3_3_1204021
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbMouse_Click(object sender, EventArgs e)
        {
            if (rbMouse.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah Gambar Mouse";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar Mouse";
            }
        }

        private void tsbMonitor_Click(object sender, EventArgs e)
        {
            if (rbMonitor.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah Gambar Monitor";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar Monitor";
            }
        }

        private void tsbPrinter_Click(object sender, EventArgs e)
        {
            if (rbPrinter.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah Gambar Printer";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar Printer";
            }
        }

        private void tsbKeyboard_Click(object sender, EventArgs e)
        {
            if (rbKeyboard.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah Gambar Keyboard";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar Keyboard";
            }
        }

        private void tsbScanner_Click(object sender, EventArgs e)
        {
            if (rbScanner.Checked == true)
            {
                tslKetGambar.Text = "Cocok! ini adalah Gambar Scanner";
            }
            else
            {
                tslKetGambar.Text = "Tidak cocok! Anda memilih gambar yang salah\nIni adalah gambar Scanner";
            }
        }
    }
}
