using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QueueKoleksiyonUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Queue kuyruk = new Queue();
        private int sira = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            sira++;
            kuyruk.Enqueue(sira);
            Listele();
        }

        private void Listele()
        {
            listBox1.Items.Clear();
            foreach (int sira in kuyruk)
            {
                listBox1.Items.Add(sira);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kuyruk.Dequeue();
            Listele();
        }
    }
}