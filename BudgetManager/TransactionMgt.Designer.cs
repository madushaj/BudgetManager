namespace BudgetManager
{
    partial class TransactionMgt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionMgt));
            this.btnHome = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioIncome = new System.Windows.Forms.RadioButton();
            this.radioExpense = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.comboRecursionType = new System.Windows.Forms.ComboBox();
            this.dataGridViewTransaction = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.datePickerStart = new System.Windows.Forms.DateTimePicker();
            this.datePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(1331, 6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(71, 66);
            this.btnHome.TabIndex = 0;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHomeClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(495, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transaction Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Value";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(200, 115);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(483, 29);
            this.txtTitle.TabIndex = 4;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(200, 167);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(483, 29);
            this.txtValue.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(729, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Description";
            // 
            // datePickerTransaction
            // 
            this.datePickerTransaction.Location = new System.Drawing.Point(200, 222);
            this.datePickerTransaction.Name = "datePickerTransaction";
            this.datePickerTransaction.Size = new System.Drawing.Size(483, 29);
            this.datePickerTransaction.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(909, 115);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(493, 81);
            this.txtDescription.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category";
            // 
            // radioIncome
            // 
            this.radioIncome.AutoSize = true;
            this.radioIncome.Location = new System.Drawing.Point(1121, 293);
            this.radioIncome.Name = "radioIncome";
            this.radioIncome.Size = new System.Drawing.Size(101, 29);
            this.radioIncome.TabIndex = 12;
            this.radioIncome.TabStop = true;
            this.radioIncome.Text = "Income";
            this.radioIncome.UseVisualStyleBackColor = true;
            // 
            // radioExpense
            // 
            this.radioExpense.AutoSize = true;
            this.radioExpense.Location = new System.Drawing.Point(1283, 293);
            this.radioExpense.Name = "radioExpense";
            this.radioExpense.Size = new System.Drawing.Size(114, 29);
            this.radioExpense.TabIndex = 13;
            this.radioExpense.TabStop = true;
            this.radioExpense.Text = "Expense";
            this.radioExpense.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(729, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Recursion Type";
            // 
            // comboRecursionType
            // 
            this.comboRecursionType.FormattingEnabled = true;
            this.comboRecursionType.Location = new System.Drawing.Point(909, 219);
            this.comboRecursionType.Name = "comboRecursionType";
            this.comboRecursionType.Size = new System.Drawing.Size(493, 32);
            this.comboRecursionType.TabIndex = 15;
            // 
            // dataGridViewTransaction
            // 
            this.dataGridViewTransaction.AllowUserToAddRows = false;
            this.dataGridViewTransaction.AllowUserToDeleteRows = false;
            this.dataGridViewTransaction.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridViewTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransaction.Location = new System.Drawing.Point(42, 506);
            this.dataGridViewTransaction.MultiSelect = false;
            this.dataGridViewTransaction.Name = "dataGridViewTransaction";
            this.dataGridViewTransaction.ReadOnly = true;
            this.dataGridViewTransaction.RowHeadersWidth = 72;
            this.dataGridViewTransaction.RowTemplate.Height = 31;
            this.dataGridViewTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransaction.Size = new System.Drawing.Size(1360, 473);
            this.dataGridViewTransaction.TabIndex = 16;
            this.dataGridViewTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.selectTransaction);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1288, 1015);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 47);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.deleteTransaction);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(1144, 1015);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(109, 47);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.modifyTransaction);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(994, 1015);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(109, 47);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.addTransaction);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(275, 32);
            this.label8.TabIndex = 20;
            this.label8.Text = "Search Transactions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(52, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 25);
            this.label9.TabIndex = 21;
            this.label9.Text = "Start date";
            // 
            // datePickerStart
            // 
            this.datePickerStart.Location = new System.Drawing.Point(200, 447);
            this.datePickerStart.Name = "datePickerStart";
            this.datePickerStart.Size = new System.Drawing.Size(483, 29);
            this.datePickerStart.TabIndex = 22;
            // 
            // datePickerEnd
            // 
            this.datePickerEnd.Location = new System.Drawing.Point(909, 444);
            this.datePickerEnd.Name = "datePickerEnd";
            this.datePickerEnd.Size = new System.Drawing.Size(493, 29);
            this.datePickerEnd.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(733, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 25);
            this.label10.TabIndex = 23;
            this.label10.Text = "End date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 1015);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 47);
            this.button1.TabIndex = 25;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.searchTransaction);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(729, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 25);
            this.label11.TabIndex = 26;
            this.label11.Text = "Transaction Type";
            // 
            // comboCategory
            // 
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(200, 288);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(483, 32);
            this.comboCategory.TabIndex = 27;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(182, 1015);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 47);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.clearFields);
            // 
            // TransactionMgt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1450, 1132);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datePickerEnd);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datePickerStart);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridViewTransaction);
            this.Controls.Add(this.comboRecursionType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioExpense);
            this.Controls.Add(this.radioIncome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.datePickerTransaction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHome);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TransactionMgt";
            this.Padding = new System.Windows.Forms.Padding(5, 5, 5, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.closeForm);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePickerTransaction;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioIncome;
        private System.Windows.Forms.RadioButton radioExpense;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboRecursionType;
        private System.Windows.Forms.DataGridView dataGridViewTransaction;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker datePickerStart;
        private System.Windows.Forms.DateTimePicker datePickerEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.Button btnClear;
    }
}