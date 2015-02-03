namespace BrainTester
{
    partial class frMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGenerateNumbers = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Numbers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YourResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RealResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrueFalse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOK = new System.Windows.Forms.Button();
            this.lbNumbersToMultiply = new System.Windows.Forms.ListBox();
            this.txtMultiplicationResult = new System.Windows.Forms.TextBox();
            this.tmrOperationTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateNumbers
            // 
            this.btnGenerateNumbers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateNumbers.Location = new System.Drawing.Point(72, 284);
            this.btnGenerateNumbers.Name = "btnGenerateNumbers";
            this.btnGenerateNumbers.Size = new System.Drawing.Size(149, 59);
            this.btnGenerateNumbers.TabIndex = 0;
            this.btnGenerateNumbers.Text = "Generate";
            this.btnGenerateNumbers.UseVisualStyleBackColor = true;
            this.btnGenerateNumbers.Click += new System.EventHandler(this.btnGenerateNumbers_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Lavender;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numbers,
            this.YourResult,
            this.RealResult,
            this.Time,
            this.TrueFalse});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(525, 274);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // Numbers
            // 
            this.Numbers.HeaderText = "Numbers";
            this.Numbers.Name = "Numbers";
            this.Numbers.ReadOnly = true;
            // 
            // YourResult
            // 
            this.YourResult.HeaderText = "Your Result";
            this.YourResult.Name = "YourResult";
            this.YourResult.ReadOnly = true;
            // 
            // RealResult
            // 
            this.RealResult.HeaderText = "Real Result";
            this.RealResult.Name = "RealResult";
            this.RealResult.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time(Sec)";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // TrueFalse
            // 
            this.TrueFalse.HeaderText = "True False";
            this.TrueFalse.Name = "TrueFalse";
            this.TrueFalse.ReadOnly = true;
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Location = new System.Drawing.Point(227, 396);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(149, 27);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lbNumbersToMultiply
            // 
            this.lbNumbersToMultiply.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNumbersToMultiply.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNumbersToMultiply.FormattingEnabled = true;
            this.lbNumbersToMultiply.ItemHeight = 24;
            this.lbNumbersToMultiply.Location = new System.Drawing.Point(72, 349);
            this.lbNumbersToMultiply.Name = "lbNumbersToMultiply";
            this.lbNumbersToMultiply.Size = new System.Drawing.Size(149, 74);
            this.lbNumbersToMultiply.TabIndex = 3;
            // 
            // txtMultiplicationResult
            // 
            this.txtMultiplicationResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMultiplicationResult.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMultiplicationResult.Location = new System.Drawing.Point(227, 349);
            this.txtMultiplicationResult.Name = "txtMultiplicationResult";
            this.txtMultiplicationResult.Size = new System.Drawing.Size(149, 30);
            this.txtMultiplicationResult.TabIndex = 4;
            this.txtMultiplicationResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMultiplicationResult_KeyDown);
            // 
            // tmrOperationTime
            // 
            this.tmrOperationTime.Interval = 1000;
            this.tmrOperationTime.Tick += new System.EventHandler(this.tmrOperationTime_Tick);
            // 
            // frMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(525, 435);
            this.Controls.Add(this.txtMultiplicationResult);
            this.Controls.Add(this.lbNumbersToMultiply);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGenerateNumbers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brain Tester";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateNumbers;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ListBox lbNumbersToMultiply;
        private System.Windows.Forms.TextBox txtMultiplicationResult;
        private System.Windows.Forms.Timer tmrOperationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numbers;
        private System.Windows.Forms.DataGridViewTextBoxColumn YourResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn RealResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrueFalse;
    }
}

