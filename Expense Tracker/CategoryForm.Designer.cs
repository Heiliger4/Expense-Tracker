namespace Expense_Tracker
{
    partial class CategoryForm
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
            category_deleteBtn = new Button();
            category_clearBtn = new Button();
            category_updateBtn = new Button();
            category_addBtn = new Button();
            category_status = new ComboBox();
            category_type = new ComboBox();
            category_category = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            category_dataGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)category_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(category_deleteBtn);
            panel1.Controls.Add(category_clearBtn);
            panel1.Controls.Add(category_updateBtn);
            panel1.Controls.Add(category_addBtn);
            panel1.Controls.Add(category_status);
            panel1.Controls.Add(category_type);
            panel1.Controls.Add(category_category);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 396);
            panel1.TabIndex = 0;
            // 
            // category_deleteBtn
            // 
            category_deleteBtn.Location = new Point(91, 244);
            category_deleteBtn.Name = "category_deleteBtn";
            category_deleteBtn.Size = new Size(75, 23);
            category_deleteBtn.TabIndex = 9;
            category_deleteBtn.Text = "Delete";
            category_deleteBtn.UseVisualStyleBackColor = true;
            category_deleteBtn.Click += category_deleteBtn_Click;
            // 
            // category_clearBtn
            // 
            category_clearBtn.Location = new Point(9, 244);
            category_clearBtn.Name = "category_clearBtn";
            category_clearBtn.Size = new Size(75, 23);
            category_clearBtn.TabIndex = 8;
            category_clearBtn.Text = "Clear";
            category_clearBtn.UseVisualStyleBackColor = true;
            category_clearBtn.Click += category_clearBtn_Click;
            // 
            // category_updateBtn
            // 
            category_updateBtn.Location = new Point(91, 201);
            category_updateBtn.Name = "category_updateBtn";
            category_updateBtn.Size = new Size(75, 23);
            category_updateBtn.TabIndex = 7;
            category_updateBtn.Text = "Update";
            category_updateBtn.UseVisualStyleBackColor = true;
            category_updateBtn.Click += category_updateBtn_Click;
            // 
            // category_addBtn
            // 
            category_addBtn.Location = new Point(9, 201);
            category_addBtn.Name = "category_addBtn";
            category_addBtn.Size = new Size(75, 23);
            category_addBtn.TabIndex = 6;
            category_addBtn.Text = "Add";
            category_addBtn.UseVisualStyleBackColor = true;
            category_addBtn.Click += category_addBtn_Click;
            // 
            // category_status
            // 
            category_status.FormattingEnabled = true;
            category_status.Items.AddRange(new object[] { "Active", "Inactive" });
            category_status.Location = new Point(9, 149);
            category_status.Name = "category_status";
            category_status.Size = new Size(157, 23);
            category_status.TabIndex = 5;
            // 
            // category_type
            // 
            category_type.FormattingEnabled = true;
            category_type.Items.AddRange(new object[] { "Income", "Expense" });
            category_type.Location = new Point(9, 90);
            category_type.Name = "category_type";
            category_type.Size = new Size(157, 23);
            category_type.TabIndex = 4;
            // 
            // category_category
            // 
            category_category.Location = new Point(9, 28);
            category_category.Name = "category_category";
            category_category.Size = new Size(157, 23);
            category_category.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 131);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 72);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 1;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 10);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(category_dataGridView);
            panel2.Location = new Point(178, 13);
            panel2.Name = "panel2";
            panel2.Size = new Size(440, 396);
            panel2.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 10);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 10;
            label4.Text = "Categories List";
            // 
            // category_dataGridView
            // 
            category_dataGridView.AllowUserToAddRows = false;
            category_dataGridView.AllowUserToDeleteRows = false;
            category_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            category_dataGridView.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Orange;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Info;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            category_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            category_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            category_dataGridView.EnableHeadersVisualStyles = false;
            category_dataGridView.Location = new Point(3, 31);
            category_dataGridView.Name = "category_dataGridView";
            category_dataGridView.ReadOnly = true;
            category_dataGridView.RowHeadersVisible = false;
            category_dataGridView.Size = new Size(427, 362);
            category_dataGridView.TabIndex = 0;
            category_dataGridView.CellClick += category_dataGridView_CellClick;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(621, 422);
            Load += CategoryForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)category_dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button category_deleteBtn;
        private Button category_clearBtn;
        private Button category_updateBtn;
        private Button category_addBtn;
        private ComboBox category_status;
        private ComboBox category_type;
        private TextBox category_category;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label4;
        private DataGridView category_dataGridView;
    }
}
