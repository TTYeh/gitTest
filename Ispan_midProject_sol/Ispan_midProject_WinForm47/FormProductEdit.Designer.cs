﻿namespace Ispan_midProject_WinForm47
{
    partial class FormProductEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxPN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimeStartSellTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimeEndSellTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonUpdateData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.comboBoxModel = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonPicViewer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAddPicture = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(81, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "產品名稱";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(197, 44);
            this.textBoxProductName.Multiline = true;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(200, 35);
            this.textBoxProductName.TabIndex = 0;
            // 
            // textBoxPN
            // 
            this.textBoxPN.Location = new System.Drawing.Point(197, 102);
            this.textBoxPN.Multiline = true;
            this.textBoxPN.Name = "textBoxPN";
            this.textBoxPN.Size = new System.Drawing.Size(200, 35);
            this.textBoxPN.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(81, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "產品編號";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(197, 163);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(200, 35);
            this.textBoxPrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(81, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "表定價格";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(197, 221);
            this.textBoxCost.Multiline = true;
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(200, 35);
            this.textBoxCost.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(81, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "標準成本";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(31, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "開始販賣時間";
            // 
            // dateTimeStartSellTime
            // 
            this.dateTimeStartSellTime.Location = new System.Drawing.Point(197, 270);
            this.dateTimeStartSellTime.Name = "dateTimeStartSellTime";
            this.dateTimeStartSellTime.Size = new System.Drawing.Size(200, 25);
            this.dateTimeStartSellTime.TabIndex = 9;
            // 
            // dateTimeEndSellTime
            // 
            this.dateTimeEndSellTime.CustomFormat = " ";
            this.dateTimeEndSellTime.Location = new System.Drawing.Point(197, 323);
            this.dateTimeEndSellTime.Name = "dateTimeEndSellTime";
            this.dateTimeEndSellTime.Size = new System.Drawing.Size(200, 25);
            this.dateTimeEndSellTime.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(31, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "停止販賣時間";
            // 
            // buttonUpdateData
            // 
            this.buttonUpdateData.Location = new System.Drawing.Point(301, 508);
            this.buttonUpdateData.Name = "buttonUpdateData";
            this.buttonUpdateData.Size = new System.Drawing.Size(96, 40);
            this.buttonUpdateData.TabIndex = 12;
            this.buttonUpdateData.Text = "更新資料";
            this.buttonUpdateData.UseVisualStyleBackColor = true;
            this.buttonUpdateData.Click += new System.EventHandler(this.buttonUpdateData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(81, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "產品類別";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(197, 371);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(200, 23);
            this.comboBoxCategory.TabIndex = 14;
            // 
            // comboBoxModel
            // 
            this.comboBoxModel.FormattingEnabled = true;
            this.comboBoxModel.Location = new System.Drawing.Point(197, 421);
            this.comboBoxModel.Name = "comboBoxModel";
            this.comboBoxModel.Size = new System.Drawing.Size(200, 23);
            this.comboBoxModel.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(81, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "產品種類";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(95, 508);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(96, 40);
            this.buttonExit.TabIndex = 17;
            this.buttonExit.Text = "離開";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonPicViewer
            // 
            this.buttonPicViewer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonPicViewer.Location = new System.Drawing.Point(197, 459);
            this.buttonPicViewer.Name = "buttonPicViewer";
            this.buttonPicViewer.Size = new System.Drawing.Size(157, 40);
            this.buttonPicViewer.TabIndex = 18;
            this.buttonPicViewer.Text = "點我檢視圖片";
            this.buttonPicViewer.UseVisualStyleBackColor = false;
            this.buttonPicViewer.Click += new System.EventHandler(this.buttonPicViewer_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("標楷體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(81, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 23);
            this.label9.TabIndex = 19;
            this.label9.Text = "產品圖片";
            // 
            // buttonAddPicture
            // 
            this.buttonAddPicture.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonAddPicture.Location = new System.Drawing.Point(360, 459);
            this.buttonAddPicture.Name = "buttonAddPicture";
            this.buttonAddPicture.Size = new System.Drawing.Size(37, 40);
            this.buttonAddPicture.TabIndex = 20;
            this.buttonAddPicture.Text = "+";
            this.buttonAddPicture.UseVisualStyleBackColor = false;
            this.buttonAddPicture.Click += new System.EventHandler(this.buttonAddPicture_Click);
            // 
            // FormProductEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 577);
            this.Controls.Add(this.buttonAddPicture);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonPicViewer);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxModel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonUpdateData);
            this.Controls.Add(this.dateTimeEndSellTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimeStartSellTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.Name = "FormProductEdit";
            this.Text = "FormProductEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxPN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimeStartSellTime;
        private System.Windows.Forms.DateTimePicker dateTimeEndSellTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonUpdateData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.ComboBox comboBoxModel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPicViewer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonAddPicture;
    }
}