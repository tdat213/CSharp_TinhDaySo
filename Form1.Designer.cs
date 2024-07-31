namespace CSharp_TinhDaySo
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
            components = new System.ComponentModel.Container();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTong = new TextBox();
            txtTich = new TextBox();
            txtTongChan = new TextBox();
            txtTongLe = new TextBox();
            btnTinh = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // txtStart
            // 
            txtStart.Location = new Point(332, 40);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(72, 23);
            txtStart.TabIndex = 0;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(551, 40);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(70, 23);
            txtEnd.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 52);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Giới hạn dãy số";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(263, 43);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Số bắt đầu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(479, 43);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Số kết thúc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 103);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 1;
            label4.Text = "Kết Quả:";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(73, 144);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 1;
            label5.Text = "Tổng các số";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(73, 181);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 1;
            label6.Text = "Tích các số";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(73, 219);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 1;
            label7.Text = "Tổng các số chẵn";
            label7.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(73, 255);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 1;
            label8.Text = "Tổng các số lẻ";
            label8.Click += label1_Click;
            // 
            // txtTong
            // 
            txtTong.Location = new Point(254, 141);
            txtTong.Name = "txtTong";
            txtTong.ReadOnly = true;
            txtTong.Size = new Size(206, 23);
            txtTong.TabIndex = 0;
            txtTong.TextChanged += textBox3_TextChanged;
            // 
            // txtTich
            // 
            txtTich.Location = new Point(254, 178);
            txtTich.Name = "txtTich";
            txtTich.ReadOnly = true;
            txtTich.Size = new Size(206, 23);
            txtTich.TabIndex = 0;
            // 
            // txtTongChan
            // 
            txtTongChan.Location = new Point(254, 216);
            txtTongChan.Name = "txtTongChan";
            txtTongChan.ReadOnly = true;
            txtTongChan.Size = new Size(206, 23);
            txtTongChan.TabIndex = 0;
            // 
            // txtTongLe
            // 
            txtTongLe.Location = new Point(254, 252);
            txtTongLe.Name = "txtTongLe";
            txtTongLe.ReadOnly = true;
            txtTongLe.Size = new Size(206, 23);
            txtTongLe.TabIndex = 0;
            // 
            // btnTinh
            // 
            btnTinh.BackColor = Color.Yellow;
            btnTinh.Location = new Point(325, 315);
            btnTinh.Name = "btnTinh";
            btnTinh.Size = new Size(87, 37);
            btnTinh.TabIndex = 2;
            btnTinh.Text = "Tính";
            btnTinh.UseVisualStyleBackColor = false;
            btnTinh.Click += btnTinh_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTinh);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtEnd);
            Controls.Add(txtTongLe);
            Controls.Add(txtTongChan);
            Controls.Add(txtTich);
            Controls.Add(txtTong);
            Controls.Add(txtStart);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStart;
        private TextBox txtEnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTong;
        private TextBox txtTich;
        private TextBox txtTongChan;
        private TextBox txtTongLe;
        private Button btnTinh;
        private ErrorProvider errorProvider1;
    }
}
