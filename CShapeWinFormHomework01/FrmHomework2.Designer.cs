namespace CShapeWinFormHomework01
{
    partial class FrmHomework2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework2));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbScore = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.tbMidtermScore = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.tbStudentNum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbStudentNum = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lbTotalScore = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(179, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "โปรแกรมผลการเรียน";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbScore);
            this.groupBox1.Controls.Add(this.tbFinal);
            this.groupBox1.Controls.Add(this.tbMidtermScore);
            this.groupBox1.Controls.Add(this.tbFullName);
            this.groupBox1.Controls.Add(this.tbStudentNum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(73, 85);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(467, 156);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ข้อมูลนักศึกษา";
            // 
            // tbScore
            // 
            this.tbScore.Location = new System.Drawing.Point(125, 125);
            this.tbScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbScore.Name = "tbScore";
            this.tbScore.Size = new System.Drawing.Size(300, 19);
            this.tbScore.TabIndex = 9;
            this.tbScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbScore_KeyPress);
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(125, 99);
            this.tbFinal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(300, 19);
            this.tbFinal.TabIndex = 8;
            this.tbFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFinal_KeyPress);
            // 
            // tbMidtermScore
            // 
            this.tbMidtermScore.Location = new System.Drawing.Point(125, 73);
            this.tbMidtermScore.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMidtermScore.Name = "tbMidtermScore";
            this.tbMidtermScore.Size = new System.Drawing.Size(300, 19);
            this.tbMidtermScore.TabIndex = 7;
            this.tbMidtermScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMidtermScore_KeyPress);
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(125, 49);
            this.tbFullName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(300, 19);
            this.tbFullName.TabIndex = 6;
            this.tbFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFullName_KeyPress);
            // 
            // tbStudentNum
            // 
            this.tbStudentNum.Location = new System.Drawing.Point(125, 21);
            this.tbStudentNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbStudentNum.Name = "tbStudentNum";
            this.tbStudentNum.Size = new System.Drawing.Size(300, 19);
            this.tbStudentNum.TabIndex = 5;
            this.tbStudentNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStudentNum_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "คะแนนเก็บ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 102);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "คะแนนปลายภาค";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "คะแนนกลางภาค";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ชื่อ-สกุล";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "รหัสนักศึกษา";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(134, 370);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "ชื่อ-สกุล";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(114, 343);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "รหัสนักศึกษา";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(146, 423);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "เกรด";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(120, 396);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "คะแนนรวม";
            // 
            // lbStudentNum
            // 
            this.lbStudentNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbStudentNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbStudentNum.Location = new System.Drawing.Point(189, 339);
            this.lbStudentNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStudentNum.Name = "lbStudentNum";
            this.lbStudentNum.Size = new System.Drawing.Size(285, 21);
            this.lbStudentNum.TabIndex = 14;
            this.lbStudentNum.Text = "XXXXXXXXXX";
            this.lbStudentNum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbGrade
            // 
            this.lbGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbGrade.Location = new System.Drawing.Point(189, 419);
            this.lbGrade.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(285, 21);
            this.lbGrade.TabIndex = 15;
            this.lbGrade.Text = "XXXXXXXXXX";
            this.lbGrade.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTotalScore
            // 
            this.lbTotalScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbTotalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbTotalScore.Location = new System.Drawing.Point(189, 392);
            this.lbTotalScore.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalScore.Name = "lbTotalScore";
            this.lbTotalScore.Size = new System.Drawing.Size(285, 21);
            this.lbTotalScore.TabIndex = 16;
            this.lbTotalScore.Text = "XXXXXXXXXX";
            this.lbTotalScore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbFullName
            // 
            this.lbFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lbFullName.Location = new System.Drawing.Point(189, 366);
            this.lbFullName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(285, 21);
            this.lbFullName.TabIndex = 17;
            this.lbFullName.Text = "XXXXXXXXXX";
            this.lbFullName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btExit
            // 
            this.btExit.Image = global::CShapeWinFormHomework01.Properties.Resources.IrfKwMMGbmrQP8fqKtA4EH0QAAAABJRU5ErkJggg;
            this.btExit.Location = new System.Drawing.Point(399, 254);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(75, 66);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = global::CShapeWinFormHomework01.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_cancel_48;
            this.btCancel.Location = new System.Drawing.Point(265, 254);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 66);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCal
            // 
            this.btCal.Image = global::CShapeWinFormHomework01.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_48;
            this.btCal.Location = new System.Drawing.Point(131, 254);
            this.btCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(75, 66);
            this.btCal.TabIndex = 3;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // FrmHomework2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 463);
            this.Controls.Add(this.lbFullName);
            this.Controls.Add(this.lbTotalScore);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lbStudentNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHomework2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบ้าน 2";
            this.Load += new System.EventHandler(this.FrmHomework2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbScore;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.TextBox tbMidtermScore;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.TextBox tbStudentNum;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbStudentNum;
        private System.Windows.Forms.Label lbGrade;
        private System.Windows.Forms.Label lbTotalScore;
        private System.Windows.Forms.Label lbFullName;
    }
}