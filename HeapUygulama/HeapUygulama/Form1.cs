using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace HeapUygulama
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Heap h = new Heap(100);
            h.Insert(45);
            h.Insert(35);
            h.Insert(23);
            h.Insert(27);
            h.Insert(21);
            h.Insert(22);
            h.Insert(4);
            h.Insert(19);

            int[] tmpArray = { 6, 9, 1, 2, 5, 8, 7, 10, 33 };

            HeapSort hp = new HeapSort(tmpArray);
            int[] sortedArray = hp.Sort();
            
            foreach (var item in sortedArray)
            {
                Console.WriteLine (item);
            }
            h.Remove(27);
            h.Remove(35);

        }
    }
}
