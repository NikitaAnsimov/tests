using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btdADD_Click(object sender, EventArgs e)
        {
            AddTaskFromInput();
        }
        private void AddTaskFromInput()
        {
            string text = (TXTtask.Text ??"").Trim();
            if(string.IsNullOrWhiteSpace(text))
            {
                
                MessageBox.Show("Введите текс задачи", "Добавление",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                TXTtask.Focus();
                return;
            }
            if (text.Length > 200)
            {
                MessageBox.Show("слишком длинная задача(макс.200 символов)", "ты чикатило", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTtask.Focus();
                return;
            }
            cldTasks.Items.Add(text,false);
            TXTtask.Clear();
            TXTtask.Focus();
        }
    }
}
