using System;

namespace Laba3
{
    partial class fComputer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbStorage = new System.Windows.Forms.TextBox();
            this.tbRAM = new System.Windows.Forms.TextBox();
            this.tbProcessor = new System.Windows.Forms.TextBox();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBrand = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbHasWiFi = new System.Windows.Forms.CheckBox();
            this.chbHasGraphicsCard = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPrice);
            this.groupBox1.Controls.Add(this.tbStorage);
            this.groupBox1.Controls.Add(this.tbRAM);
            this.groupBox1.Controls.Add(this.tbProcessor);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbBrand);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 227);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Загальні дані";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(135, 175);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 20);
            this.tbPrice.TabIndex = 11;
            // 
            // tbStorage
            // 
            this.tbStorage.Location = new System.Drawing.Point(135, 149);
            this.tbStorage.Name = "tbStorage";
            this.tbStorage.Size = new System.Drawing.Size(100, 20);
            this.tbStorage.TabIndex = 10;
            // 
            // tbRAM
            // 
            this.tbRAM.Location = new System.Drawing.Point(135, 119);
            this.tbRAM.Name = "tbRAM";
            this.tbRAM.Size = new System.Drawing.Size(100, 20);
            this.tbRAM.TabIndex = 9;
            // 
            // tbProcessor
            // 
            this.tbProcessor.Location = new System.Drawing.Point(135, 92);
            this.tbProcessor.Name = "tbProcessor";
            this.tbProcessor.Size = new System.Drawing.Size(100, 20);
            this.tbProcessor.TabIndex = 8;
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(135, 64);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(100, 20);
            this.tbModel.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ціна";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Пам\'ять";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Оперативна пам\'ять";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Процесор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бренд";
            // 
            // tbBrand
            // 
            this.tbBrand.Location = new System.Drawing.Point(135, 36);
            this.tbBrand.Name = "tbBrand";
            this.tbBrand.Size = new System.Drawing.Size(100, 20);
            this.tbBrand.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chbHasWiFi);
            this.groupBox2.Controls.Add(this.chbHasGraphicsCard);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 94);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Характеристика";
            // 
            // chbHasWiFi
            // 
            this.chbHasWiFi.AutoSize = true;
            this.chbHasWiFi.Location = new System.Drawing.Point(6, 61);
            this.chbHasWiFi.Name = "chbHasWiFi";
            this.chbHasWiFi.Size = new System.Drawing.Size(60, 17);
            this.chbHasWiFi.TabIndex = 3;
            this.chbHasWiFi.Text = "Є Wi-Fi";
            this.chbHasWiFi.UseVisualStyleBackColor = true;
            // 
            // chbHasGraphicsCard
            // 
            this.chbHasGraphicsCard.AutoSize = true;
            this.chbHasGraphicsCard.Location = new System.Drawing.Point(6, 28);
            this.chbHasGraphicsCard.Name = "chbHasGraphicsCard";
            this.chbHasGraphicsCard.Size = new System.Drawing.Size(91, 17);
            this.chbHasGraphicsCard.TabIndex = 2;
            this.chbHasGraphicsCard.Text = "Є відеокарта";
            this.chbHasGraphicsCard.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(337, 58);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(337, 96);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Скасувати";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // fComputer
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(447, 490);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "fComputer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дані про комп\'ютер";
            this.Load += new System.EventHandler(this.fComputer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbStorage;
        private System.Windows.Forms.TextBox tbRAM;
        private System.Windows.Forms.TextBox tbProcessor;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbHasWiFi;
        private System.Windows.Forms.CheckBox chbHasGraphicsCard;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        public EventHandler textBox1_TextChanged { get; private set; }
        public EventHandler label3_Click { get; private set; }
        public EventHandler label6_Click { get; private set; }
    }
}