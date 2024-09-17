using System;

namespace Laba3
{
    partial class fMain
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
            this.tbComputerInfo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnAddComputer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbComputerInfo
            // 
            this.tbComputerInfo.Location = new System.Drawing.Point(12, 12);
            this.tbComputerInfo.Multiline = true;
            this.tbComputerInfo.Name = "tbComputerInfo";
            this.tbComputerInfo.ReadOnly = true;
            this.tbComputerInfo.Size = new System.Drawing.Size(661, 403);
            this.tbComputerInfo.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnAddComputer
            // 
            this.btnAddComputer.Location = new System.Drawing.Point(679, 12);
            this.btnAddComputer.Name = "btnAddComputer";
            this.btnAddComputer.Size = new System.Drawing.Size(109, 33);
            this.btnAddComputer.TabIndex = 2;
            this.btnAddComputer.Text = "Додати комп\'ютер";
            this.btnAddComputer.UseVisualStyleBackColor = true;
            this.btnAddComputer.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(679, 382);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(109, 33);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Закрити";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddComputer);
            this.Controls.Add(this.tbComputerInfo);
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbComputerInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnAddComputer;
        private System.Windows.Forms.Button btnClose;

        public EventHandler textBox1_TextChanged { get; private set; }
    }
}

