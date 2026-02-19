using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
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
            UpdateStats();
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
            if (text.Length > 30)
            {
                MessageBox.Show("слишком длинная задача(макс.30 символов)", "надо меньше пж пж", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTtask.Focus();
                return;
            }
            cldTasks.Items.Add(text,false);
            TXTtask.Clear();
            TXTtask.Focus();
        }
        private void UpdateStats()
        {
            int total = cldTasks.Items.Count;
            int done = 0;
            for(int i = 0; i < total; i++)
                if (cldTasks.GetItemChecked(i))
                    done++;
            label2.Text = $"Задач: {total} | Выполнено: {done}";
        }

        private void cldTasks_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke (new Action(UpdateStats));
        }

        private void bitDelete_Click(object sender, EventArgs e)
        {
            int index = cldTasks.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Выберите задачу в списке", "Удаление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            cldTasks.Items.RemoveAt(index);
            UpdateStats();
        }
        private void SaveToFile(string path)
        {
            using (var sw = new StreamWriter(path, false))
            {
                for (int i = 0; i < cldTasks.Items.Count; i++)
                {
                    bool isDone = cldTasks.GetItemChecked(i);
                    string text = cldTasks.Items[i]?.ToString() ?? "";
                    text = text.Replace("\t", " ").Replace("\r", " ").Replace("\n", " ");
                    sw.WriteLine($"{(isDone ? 1 : 0)}\t{text}");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Todo files (*.todo)|*.todo | Text files(*.txt)|*.txt|All files(*.*)|*.*";
                sfd.FileName = "task.todo";

                if(sfd.ShowDialog() != DialogResult.OK)
                    return;

                SaveToFile(sfd.FileName);

                MessageBox.Show("Сохранено", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        private void button_delete_all_Click(object sender, EventArgs e)
        {
            int index = cldTasks.Items.Count -1;
            while (index > -1)
            {
                cldTasks.Items.RemoveAt(index);
                --index;
            }
            UpdateStats();
        }
    }
}
