namespace Expense_Tracker
{
    partial class IncomeForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            income_dataGridView = new DataGridView();
            label1 = new Label();
            panel2 = new Panel();
            income_clearBtn = new Button();
            income_updateBtn = new Button();
            income_deleteBtn = new Button();
            income_addBtn = new Button();
            income_description = new TextBox();
            income_date = new DateTimePicker();
            income_income = new TextBox();
            income_item = new TextBox();
            income_category = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)income_dataGridView).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(income_dataGridView);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 210);
            panel1.TabIndex = 0;
            // 
            // income_dataGridView
            // 
            income_dataGridView.AllowUserToAddRows = false;
            income_dataGridView.AllowUserToDeleteRows = false;
            income_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            income_dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            income_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            income_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            income_dataGridView.EnableHeadersVisualStyles = false;
            income_dataGridView.Location = new Point(7, 25);
            income_dataGridView.Name = "income_dataGridView";
            income_dataGridView.ReadOnly = true;
            income_dataGridView.RowHeadersVisible = false;
            income_dataGridView.Size = new Size(605, 182);
            income_dataGridView.TabIndex = 1;
            income_dataGridView.CellClick += income_dataGridView_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 7);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "Income List";
            // 
            // panel2
            // 
            panel2.Controls.Add(income_clearBtn);
            panel2.Controls.Add(income_updateBtn);
            panel2.Controls.Add(income_deleteBtn);
            panel2.Controls.Add(income_addBtn);
            panel2.Controls.Add(income_description);
            panel2.Controls.Add(income_date);
            panel2.Controls.Add(income_income);
            panel2.Controls.Add(income_item);
            panel2.Controls.Add(income_category);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 229);
            panel2.Name = "panel2";
            panel2.Size = new Size(615, 180);
            panel2.TabIndex = 1;
            // 
            // income_clearBtn
            // 
            income_clearBtn.Location = new Point(157, 141);
            income_clearBtn.Name = "income_clearBtn";
            income_clearBtn.Size = new Size(75, 23);
            income_clearBtn.TabIndex = 15;
            income_clearBtn.Text = "Clear";
            income_clearBtn.UseVisualStyleBackColor = true;
            // 
            // income_updateBtn
            // 
            income_updateBtn.Location = new Point(308, 141);
            income_updateBtn.Name = "income_updateBtn";
            income_updateBtn.Size = new Size(75, 23);
            income_updateBtn.TabIndex = 14;
            income_updateBtn.Text = "Update";
            income_updateBtn.UseVisualStyleBackColor = true;
            // 
            // income_deleteBtn
            // 
            income_deleteBtn.Location = new Point(389, 141);
            income_deleteBtn.Name = "income_deleteBtn";
            income_deleteBtn.Size = new Size(75, 23);
            income_deleteBtn.TabIndex = 13;
            income_deleteBtn.Text = "Delete";
            income_deleteBtn.UseVisualStyleBackColor = true;
            // 
            // income_addBtn
            // 
            income_addBtn.Location = new Point(76, 141);
            income_addBtn.Name = "income_addBtn";
            income_addBtn.Size = new Size(75, 23);
            income_addBtn.TabIndex = 12;
            income_addBtn.Text = "Add";
            income_addBtn.UseVisualStyleBackColor = true;
            // 
            // income_description
            // 
            income_description.Location = new Point(368, 13);
            income_description.Multiline = true;
            income_description.Name = "income_description";
            income_description.Size = new Size(175, 59);
            income_description.TabIndex = 11;
            // 
            // income_date
            // 
            income_date.Location = new Point(368, 91);
            income_date.Name = "income_date";
            income_date.Size = new Size(200, 23);
            income_date.TabIndex = 10;
            // 
            // income_income
            // 
            income_income.Location = new Point(85, 94);
            income_income.Name = "income_income";
            income_income.Size = new Size(147, 23);
            income_income.TabIndex = 9;
            // 
            // income_item
            // 
            income_item.Location = new Point(85, 55);
            income_item.Name = "income_item";
            income_item.Size = new Size(147, 23);
            income_item.TabIndex = 8;
            // 
            // income_category
            // 
            income_category.FormattingEnabled = true;
            income_category.Location = new Point(85, 13);
            income_category.Name = "income_category";
            income_category.Size = new Size(147, 23);
            income_category.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(328, 94);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 6;
            label6.Text = "Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(292, 13);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 5;
            label5.Text = "Description:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 102);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 4;
            label4.Text = "Income: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 63);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 21);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 2;
            label2.Text = "Category: ";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IncomeForm";
            Size = new Size(621, 422);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)income_dataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView income_dataGridView;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox income_description;
        private DateTimePicker income_date;
        private TextBox income_income;
        private TextBox income_item;
        private ComboBox income_category;
        private Label label6;
        private Label label5;
        private Button income_clearBtn;
        private Button income_updateBtn;
        private Button income_deleteBtn;
        private Button income_addBtn;
    }
}
