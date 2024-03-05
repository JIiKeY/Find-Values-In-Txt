namespace Become_A_Developer_2024_View
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
			this.openFile_Btn = new System.Windows.Forms.Button();
			this.listBox = new System.Windows.Forms.ListBox();
			this.findValues_Btn = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.panel4 = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFile_Btn
			// 
			this.openFile_Btn.BackColor = System.Drawing.SystemColors.Window;
			this.openFile_Btn.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.openFile_Btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.openFile_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.openFile_Btn.Location = new System.Drawing.Point(0, 4);
			this.openFile_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.openFile_Btn.Name = "openFile_Btn";
			this.openFile_Btn.Size = new System.Drawing.Size(437, 43);
			this.openFile_Btn.TabIndex = 0;
			this.openFile_Btn.Text = "Відкрити файл";
			this.openFile_Btn.UseVisualStyleBackColor = false;
			this.openFile_Btn.Click += new System.EventHandler(this.OpenFileBtn_Click);
			// 
			// listBox1
			// 
			this.listBox.BackColor = System.Drawing.SystemColors.Window;
			this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listBox.ForeColor = System.Drawing.SystemColors.InfoText;
			this.listBox.FormattingEnabled = true;
			this.listBox.HorizontalScrollbar = true;
			this.listBox.ItemHeight = 18;
			this.listBox.Location = new System.Drawing.Point(0, 0);
			this.listBox.Margin = new System.Windows.Forms.Padding(4);
			this.listBox.Name = "listBox1";
			this.listBox.Size = new System.Drawing.Size(437, 288);
			this.listBox.TabIndex = 1;
			// 
			// findValues_Btn
			// 
			this.findValues_Btn.BackColor = System.Drawing.SystemColors.Window;
			this.findValues_Btn.Dock = System.Windows.Forms.DockStyle.Top;
			this.findValues_Btn.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.findValues_Btn.ForeColor = System.Drawing.SystemColors.ControlText;
			this.findValues_Btn.Location = new System.Drawing.Point(0, 0);
			this.findValues_Btn.Margin = new System.Windows.Forms.Padding(4);
			this.findValues_Btn.Name = "findValues_Btn";
			this.findValues_Btn.Size = new System.Drawing.Size(437, 44);
			this.findValues_Btn.TabIndex = 2;
			this.findValues_Btn.Text = "Пошук значень";
			this.findValues_Btn.UseVisualStyleBackColor = false;
			this.findValues_Btn.Click += new System.EventHandler(this.FindValues_Btn_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.Window;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(28, 383);
			this.panel1.TabIndex = 3;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Window;
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(465, 0);
			this.panel2.Margin = new System.Windows.Forms.Padding(4);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(27, 383);
			this.panel2.TabIndex = 4;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.openFile_Btn);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(28, 0);
			this.panel3.Margin = new System.Windows.Forms.Padding(4);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(437, 47);
			this.panel3.TabIndex = 5;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.findValues_Btn);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel4.Location = new System.Drawing.Point(28, 335);
			this.panel4.Margin = new System.Windows.Forms.Padding(4);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(437, 48);
			this.panel4.TabIndex = 6;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.listBox);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(28, 47);
			this.panel5.Margin = new System.Windows.Forms.Padding(4);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(437, 288);
			this.panel5.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(492, 383);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пошук значень";
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button openFile_Btn;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.Button findValues_Btn;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
	}
}

