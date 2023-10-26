namespace Uploading_SqlServer_SQLite_Project
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
            itemCodeBox = new TextBox();
            itemPriceBox = new TextBox();
            itemNewPriceBox = new TextBox();
            btn1 = new Button();
            uplaodBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 36);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "ItemCode";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 99);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "ItemPrice";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 157);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "NewPrice";
            // 
            // itemCodeBox
            // 
            itemCodeBox.Location = new Point(200, 28);
            itemCodeBox.Name = "itemCodeBox";
            itemCodeBox.Size = new Size(124, 23);
            itemCodeBox.TabIndex = 3;
            // 
            // itemPriceBox
            // 
            itemPriceBox.Location = new Point(200, 91);
            itemPriceBox.Name = "itemPriceBox";
            itemPriceBox.Size = new Size(124, 23);
            itemPriceBox.TabIndex = 4;
            // 
            // itemNewPriceBox
            // 
            itemNewPriceBox.Location = new Point(200, 157);
            itemNewPriceBox.Name = "itemNewPriceBox";
            itemNewPriceBox.Size = new Size(124, 23);
            itemNewPriceBox.TabIndex = 5;
            // 
            // btn1
            // 
            btn1.Location = new Point(126, 353);
            btn1.Name = "btn1";
            btn1.Size = new Size(144, 23);
            btn1.TabIndex = 6;
            btn1.Text = "Save Data";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // uplaodBtn
            // 
            uplaodBtn.Location = new Point(490, 353);
            uplaodBtn.Name = "uplaodBtn";
            uplaodBtn.Size = new Size(144, 23);
            uplaodBtn.TabIndex = 7;
            uplaodBtn.Text = "Upload To FTP";
            uplaodBtn.UseVisualStyleBackColor = true;
            uplaodBtn.Click += uplaodBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uplaodBtn);
            Controls.Add(btn1);
            Controls.Add(itemNewPriceBox);
            Controls.Add(itemPriceBox);
            Controls.Add(itemCodeBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btn1;
        private TextBox itemCodeBox;
        private TextBox itemPriceBox;
        private TextBox itemNewPriceBox;
        private Button uplaodBtn;
    }
}