namespace Windows_Forms_App
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCircleArea = new System.Windows.Forms.Button();
            this.btnTriangleArea = new System.Windows.Forms.Button();
            this.btnHexagonArea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRaduis = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeitght = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtHexagonWidth = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "รัศมี";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "ความสูง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ความยาวฐาน";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ความยาวฐาน";
            // 
            // btnCircleArea
            // 
            this.btnCircleArea.Location = new System.Drawing.Point(209, 21);
            this.btnCircleArea.Name = "btnCircleArea";
            this.btnCircleArea.Size = new System.Drawing.Size(148, 54);
            this.btnCircleArea.TabIndex = 4;
            this.btnCircleArea.Text = "คำนวนพื้นที่วงกลม";
            this.btnCircleArea.UseVisualStyleBackColor = true;
            this.btnCircleArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTriangleArea
            // 
            this.btnTriangleArea.Location = new System.Drawing.Point(209, 40);
            this.btnTriangleArea.Name = "btnTriangleArea";
            this.btnTriangleArea.Size = new System.Drawing.Size(148, 54);
            this.btnTriangleArea.TabIndex = 5;
            this.btnTriangleArea.Text = "คำนวนพื้นที่สามเหลี่ยม";
            this.btnTriangleArea.UseVisualStyleBackColor = true;
            this.btnTriangleArea.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHexagonArea
            // 
            this.btnHexagonArea.Location = new System.Drawing.Point(209, 30);
            this.btnHexagonArea.Name = "btnHexagonArea";
            this.btnHexagonArea.Size = new System.Drawing.Size(148, 54);
            this.btnHexagonArea.TabIndex = 6;
            this.btnHexagonArea.Text = "คำนวนพื้นที่รูปหกเหลี่ยม";
            this.btnHexagonArea.UseVisualStyleBackColor = true;
            this.btnHexagonArea.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(448, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 35);
            this.label5.TabIndex = 7;
            this.label5.Text = "พื้นที่ (ตารางหน่วย)";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.txtRaduis);
            this.groupBox1.Controls.Add(this.btnCircleArea);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(46, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 91);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คำนวนพื้นที่วงกลม";
            // 
            // txtRaduis
            // 
            this.txtRaduis.Location = new System.Drawing.Point(92, 42);
            this.txtRaduis.Name = "txtRaduis";
            this.txtRaduis.Size = new System.Drawing.Size(100, 22);
            this.txtRaduis.TabIndex = 9;
            this.txtRaduis.TextChanged += new System.EventHandler(this.txtRaduis_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.txtWidth);
            this.groupBox2.Controls.Add(this.txtHeitght);
            this.groupBox2.Controls.Add(this.btnTriangleArea);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(46, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 138);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "คำนวนพื้นที่สามเหลี่ยม";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(92, 84);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 22);
            this.txtWidth.TabIndex = 11;
            // 
            // txtHeitght
            // 
            this.txtHeitght.Location = new System.Drawing.Point(92, 40);
            this.txtHeitght.Name = "txtHeitght";
            this.txtHeitght.Size = new System.Drawing.Size(100, 22);
            this.txtHeitght.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Highlight;
            this.groupBox3.Controls.Add(this.txtHexagonWidth);
            this.groupBox3.Controls.Add(this.btnHexagonArea);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(46, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(363, 102);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "คำนวนพื้นที่รูปหกเหลี่ยม";
            // 
            // txtHexagonWidth
            // 
            this.txtHexagonWidth.Location = new System.Drawing.Point(92, 46);
            this.txtHexagonWidth.Name = "txtHexagonWidth";
            this.txtHexagonWidth.Size = new System.Drawing.Size(100, 22);
            this.txtHexagonWidth.TabIndex = 12;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lblResult.ForeColor = System.Drawing.Color.Red;
            this.lblResult.Location = new System.Drawing.Point(448, 33);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(303, 181);
            this.lblResult.TabIndex = 11;
            this.lblResult.Text = "...";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCircleArea;
        private System.Windows.Forms.Button btnTriangleArea;
        private System.Windows.Forms.Button btnHexagonArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtRaduis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeitght;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtHexagonWidth;
        private System.Windows.Forms.Label lblResult;
    }
}

