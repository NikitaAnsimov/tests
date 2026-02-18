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
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TXTtask
            // 
            this.TXTtask.Location = new System.Drawing.Point(12, 72);
            this.TXTtask.Name = "TXTtask";
            this.TXTtask.Size = new System.Drawing.Size(100, 20);
            this.TXTtask.TabIndex = 2;
            this.TXTtask.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btdADD
            // 
            this.btdADD.BackColor = System.Drawing.Color.Lime;
            this.btdADD.ForeColor = System.Drawing.Color.Brown;
            this.btdADD.Location = new System.Drawing.Point(-1, 211);
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
            this.label1.Location = new System.Drawing.Point(13, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите задачу";
            // 
            // cldTasks
            // 
            this.cldTasks.FormattingEnabled = true;
            this.cldTasks.Location = new System.Drawing.Point(12, 111);
            this.cldTasks.Name = "cldTasks";
            this.cldTasks.Size = new System.Drawing.Size(120, 94);
            this.cldTasks.TabIndex = 6;
            // 
            // bitDelete
            // 
            this.bitDelete.BackColor = System.Drawing.Color.Crimson;
            this.bitDelete.ForeColor = System.Drawing.Color.Chartreuse;
            this.bitDelete.Location = new System.Drawing.Point(80, 211);
            this.bitDelete.Name = "bitDelete";
            this.bitDelete.Size = new System.Drawing.Size(75, 23);
            this.bitDelete.TabIndex = 7;
            this.bitDelete.Text = "Delet";
            this.bitDelete.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "задач:0|выполнено 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 450);
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
    }
}

