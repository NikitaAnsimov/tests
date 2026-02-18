namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TXTtask = new System.Windows.Forms.TextBox();
            this.btdADD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cldTasks = new System.Windows.Forms.CheckedListBox();
            this.bitDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TXTtask
            // 
            this.TXTtask.Location = new System.Drawing.Point(34, 45);
            this.TXTtask.Name = "TXTtask";
            this.TXTtask.Size = new System.Drawing.Size(205, 20);
            this.TXTtask.TabIndex = 2;
            this.TXTtask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btdADD
            // 
            this.btdADD.BackColor = System.Drawing.Color.Lime;
            this.btdADD.ForeColor = System.Drawing.Color.Brown;
            this.btdADD.Location = new System.Drawing.Point(17, 203);
            this.btdADD.Name = "btdADD";
            this.btdADD.Size = new System.Drawing.Size(75, 23);
            this.btdADD.TabIndex = 4;
            this.btdADD.Text = "ADD";
            this.btdADD.UseVisualStyleBackColor = false;
            this.btdADD.Click += new System.EventHandler(this.btdADD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите задачу";
            // 
            // cldTasks
            // 
            this.cldTasks.FormattingEnabled = true;
            this.cldTasks.Location = new System.Drawing.Point(34, 84);
            this.cldTasks.Name = "cldTasks";
            this.cldTasks.Size = new System.Drawing.Size(205, 94);
            this.cldTasks.TabIndex = 6;
            this.cldTasks.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cldTasks_ItemCheck);
            // 
            // bitDelete
            // 
            this.bitDelete.BackColor = System.Drawing.Color.Crimson;
            this.bitDelete.ForeColor = System.Drawing.Color.Chartreuse;
            this.bitDelete.Location = new System.Drawing.Point(98, 203);
            this.bitDelete.Name = "bitDelete";
            this.bitDelete.Size = new System.Drawing.Size(75, 23);
            this.bitDelete.TabIndex = 7;
            this.bitDelete.Text = "Delet";
            this.bitDelete.UseVisualStyleBackColor = false;
            this.bitDelete.Click += new System.EventHandler(this.bitDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "задач:0|выполнено 0";
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "SaveButton";
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(189, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "сохранить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 317);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bitDelete);
            this.Controls.Add(this.cldTasks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btdADD);
            this.Controls.Add(this.TXTtask);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TXTtask;
        private System.Windows.Forms.Button btdADD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox cldTasks;
        private System.Windows.Forms.Button bitDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

