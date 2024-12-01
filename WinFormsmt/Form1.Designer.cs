namespace WinFormsmt
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtAge = new TextBox();
            txtHeight = new TextBox();
            txtWeigth = new TextBox();
            btnBMI = new Button();
            lblResult = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(785, 9);
            label1.Name = "label1";
            label1.Size = new Size(384, 70);
            label1.TabIndex = 1;
            label1.Text = "โปรแกรมคำนวณ BMI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(762, 191);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 2;
            label2.Text = "ส่วนสูง CM";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(770, 95);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "ชื่อ - สกุล";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(803, 147);
            label4.Name = "label4";
            label4.Size = new Size(32, 20);
            label4.TabIndex = 4;
            label4.Text = "อายุ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(761, 236);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 5;
            label5.Text = "น้ำหนัก KG";
            // 
            // txtName
            // 
            txtName.Location = new Point(879, 88);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 9;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(879, 140);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(125, 27);
            txtAge.TabIndex = 10;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(879, 184);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(125, 27);
            txtHeight.TabIndex = 11;
            // 
            // txtWeigth
            // 
            txtWeigth.Location = new Point(879, 229);
            txtWeigth.Name = "txtWeigth";
            txtWeigth.Size = new Size(125, 27);
            txtWeigth.TabIndex = 12;
            // 
            // btnBMI
            // 
            btnBMI.Location = new Point(1028, 88);
            btnBMI.Name = "btnBMI";
            btnBMI.Size = new Size(178, 168);
            btnBMI.TabIndex = 13;
            btnBMI.Text = "คำนวณ กด";
            btnBMI.UseVisualStyleBackColor = true;
            btnBMI.Click += btnBMI_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = SystemColors.ControlDark;
            lblResult.Location = new Point(879, 280);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(327, 209);
            lblResult.TabIndex = 14;
            lblResult.Text = "...";
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblResult.Click += label6_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(879, 511);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 15;
            btnClear.Text = "เริ่มใหม่";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 603);
            Controls.Add(btnClear);
            Controls.Add(lblResult);
            Controls.Add(btnBMI);
            Controls.Add(txtWeigth);
            Controls.Add(txtHeight);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtHeight;
        private TextBox txtWeigth;
        private Button btnBMI;
        private Label lblResult;
        private Button btnClear;
    }
}
