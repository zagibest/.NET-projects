﻿namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            splitContainer1 = new SplitContainer();
            buttonDelete = new Button();
            buttonSubtract = new Button();
            buttonAdd = new Button();
            button0 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            ResultBox = new TextBox();
            buttonEquals = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(2, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonEquals);
            splitContainer1.Panel1.Controls.Add(ResultBox);
            splitContainer1.Panel1.Controls.Add(buttonDelete);
            splitContainer1.Panel1.Controls.Add(buttonSubtract);
            splitContainer1.Panel1.Controls.Add(buttonAdd);
            splitContainer1.Panel1.Controls.Add(button0);
            splitContainer1.Panel1.Controls.Add(button7);
            splitContainer1.Panel1.Controls.Add(button8);
            splitContainer1.Panel1.Controls.Add(button9);
            splitContainer1.Panel1.Controls.Add(button4);
            splitContainer1.Panel1.Controls.Add(button5);
            splitContainer1.Panel1.Controls.Add(button6);
            splitContainer1.Panel1.Controls.Add(button3);
            splitContainer1.Panel1.Controls.Add(button2);
            splitContainer1.Panel1.Controls.Add(button1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(listView1);
            splitContainer1.Size = new Size(878, 482);
            splitContainer1.SplitterDistance = 522;
            splitContainer1.TabIndex = 13;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(323, 112);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 75);
            buttonDelete.TabIndex = 25;
            buttonDelete.Text = "C";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(323, 193);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 75);
            buttonSubtract.TabIndex = 24;
            buttonSubtract.Text = "-";
            buttonSubtract.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(323, 274);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 75);
            buttonAdd.TabIndex = 23;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Location = new Point(161, 355);
            button0.Name = "button0";
            button0.Size = new Size(75, 75);
            button0.TabIndex = 22;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(242, 112);
            button7.Name = "button7";
            button7.Size = new Size(75, 75);
            button7.TabIndex = 21;
            button7.Text = "9";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(161, 112);
            button8.Name = "button8";
            button8.Size = new Size(75, 75);
            button8.TabIndex = 20;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Location = new Point(80, 112);
            button9.Name = "button9";
            button9.Size = new Size(75, 75);
            button9.TabIndex = 19;
            button9.Text = "7";
            button9.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(242, 193);
            button4.Name = "button4";
            button4.Size = new Size(75, 75);
            button4.TabIndex = 18;
            button4.Text = "6";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(161, 193);
            button5.Name = "button5";
            button5.Size = new Size(75, 75);
            button5.TabIndex = 17;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(80, 193);
            button6.Name = "button6";
            button6.Size = new Size(75, 75);
            button6.TabIndex = 16;
            button6.Text = "4";
            button6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(242, 274);
            button3.Name = "button3";
            button3.Size = new Size(75, 75);
            button3.TabIndex = 15;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(161, 274);
            button2.Name = "button2";
            button2.Size = new Size(75, 75);
            button2.TabIndex = 14;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(80, 274);
            button1.Name = "button1";
            button1.Size = new Size(75, 75);
            button1.TabIndex = 13;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // ResultBox
            // 
            ResultBox.Font = new Font("Segoe UI", 32F, FontStyle.Regular, GraphicsUnit.Point);
            ResultBox.Location = new Point(80, 42);
            ResultBox.Name = "ResultBox";
            ResultBox.Size = new Size(318, 64);
            ResultBox.TabIndex = 26;
            // 
            // buttonEquals
            // 
            buttonEquals.BackColor = SystemColors.MenuHighlight;
            buttonEquals.ForeColor = SystemColors.ButtonFace;
            buttonEquals.Location = new Point(242, 355);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(156, 75);
            buttonEquals.TabIndex = 27;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(64, 90);
            listView1.Name = "listView1";
            listView1.Size = new Size(121, 97);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 483);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TextBox ResultBox;
        private Button buttonDelete;
        private Button buttonSubtract;
        private Button buttonAdd;
        private Button button0;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button buttonEquals;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}