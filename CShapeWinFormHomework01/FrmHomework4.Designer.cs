namespace CShapeWinFormHomework01
{
    partial class FrmHomework4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHomework4));
            this.label1 = new System.Windows.Forms.Label();
            this.rbJava = new System.Windows.Forms.RadioButton();
            this.rbAndroid = new System.Windows.Forms.RadioButton();
            this.rbIos = new System.Windows.Forms.RadioButton();
            this.rbPhp = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tbPeople = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btExit = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btCal = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbPeopleJoin = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbCostName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(125, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "โปรแกรมคำนวณค่าอบรม สัมมนา";
            // 
            // rbJava
            // 
            this.rbJava.AutoSize = true;
            this.rbJava.Location = new System.Drawing.Point(76, 82);
            this.rbJava.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbJava.Name = "rbJava";
            this.rbJava.Size = new System.Drawing.Size(214, 17);
            this.rbJava.TabIndex = 4;
            this.rbJava.TabStop = true;
            this.rbJava.Text = "อารบ Java Developer (คนละ 1,000 บาท)";
            this.rbJava.UseVisualStyleBackColor = true;
            // 
            // rbAndroid
            // 
            this.rbAndroid.AutoSize = true;
            this.rbAndroid.Location = new System.Drawing.Point(76, 109);
            this.rbAndroid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbAndroid.Name = "rbAndroid";
            this.rbAndroid.Size = new System.Drawing.Size(229, 17);
            this.rbAndroid.TabIndex = 5;
            this.rbAndroid.TabStop = true;
            this.rbAndroid.Text = "อบรม Android Developer (คนละ 1,200 บาท)";
            this.rbAndroid.UseVisualStyleBackColor = true;
            // 
            // rbIos
            // 
            this.rbIos.AutoSize = true;
            this.rbIos.Location = new System.Drawing.Point(76, 136);
            this.rbIos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbIos.Name = "rbIos";
            this.rbIos.Size = new System.Drawing.Size(209, 17);
            this.rbIos.TabIndex = 6;
            this.rbIos.TabStop = true;
            this.rbIos.Text = "อารม IOS Developer (คนละ 1,400 บาท)";
            this.rbIos.UseVisualStyleBackColor = true;
            // 
            // rbPhp
            // 
            this.rbPhp.AutoSize = true;
            this.rbPhp.Location = new System.Drawing.Point(76, 162);
            this.rbPhp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbPhp.Name = "rbPhp";
            this.rbPhp.Size = new System.Drawing.Size(215, 17);
            this.rbPhp.TabIndex = 7;
            this.rbPhp.TabStop = true;
            this.rbPhp.Text = "อบรม PHP Developer (คนละ 1,800 บาท)";
            this.rbPhp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "จำนวนคนที่เข้าอบรม";
            // 
            // tbPeople
            // 
            this.tbPeople.Location = new System.Drawing.Point(129, 209);
            this.tbPeople.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPeople.Name = "tbPeople";
            this.tbPeople.Size = new System.Drawing.Size(156, 20);
            this.tbPeople.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "คน";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(76, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(194, 81);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "หมายเหตุ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "- กรณีเข้าอบรม 5 คนขึ้นไป ลด 10%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 23);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "- กรณีเข้าอบรม 2 - 4 คน ลด 5%";
            // 
            // btExit
            // 
            this.btExit.Image = global::CShapeWinFormHomework01.Properties.Resources.IrfKwMMGbmrQP8fqKtA4EH0QAAAABJRU5ErkJggg;
            this.btExit.Location = new System.Drawing.Point(214, 332);
            this.btExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(56, 57);
            this.btExit.TabIndex = 19;
            this.btExit.Text = "ปิดหน้าจอ";
            this.btExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btCancel
            // 
            this.btCancel.Image = global::CShapeWinFormHomework01.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_cancel_48;
            this.btCancel.Location = new System.Drawing.Point(144, 332);
            this.btCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(56, 57);
            this.btCancel.TabIndex = 18;
            this.btCancel.Text = "ยกเลิก";
            this.btCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btCal
            // 
            this.btCal.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCal.Image = global::CShapeWinFormHomework01.Properties.Resources.Oxygen_Icons_org_Oxygen_Actions_dialog_ok_apply_48;
            this.btCal.Location = new System.Drawing.Point(76, 332);
            this.btCal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCal.Name = "btCal";
            this.btCal.Size = new System.Drawing.Size(56, 57);
            this.btCal.TabIndex = 17;
            this.btCal.Text = "คำนวณ";
            this.btCal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btCal.UseVisualStyleBackColor = true;
            this.btCal.Click += new System.EventHandler(this.btCal_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lbResult);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbPeopleJoin);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbCostName);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(334, 82);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(239, 309);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Red;
            this.lbResult.Location = new System.Drawing.Point(4, 265);
            this.lbResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(231, 20);
            this.lbResult.TabIndex = 26;
            this.lbResult.Text = "XXXX";
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(69, 221);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "ค่าอบรมที่ต้องชำระ";
            // 
            // lbPeopleJoin
            // 
            this.lbPeopleJoin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPeopleJoin.ForeColor = System.Drawing.Color.Red;
            this.lbPeopleJoin.Location = new System.Drawing.Point(8, 176);
            this.lbPeopleJoin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPeopleJoin.Name = "lbPeopleJoin";
            this.lbPeopleJoin.Size = new System.Drawing.Size(227, 20);
            this.lbPeopleJoin.TabIndex = 24;
            this.lbPeopleJoin.Text = "XXXX";
            this.lbPeopleJoin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(86, 134);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "จำนวนผู้เข้า";
            // 
            // lbCostName
            // 
            this.lbCostName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostName.ForeColor = System.Drawing.Color.Red;
            this.lbCostName.Location = new System.Drawing.Point(4, 94);
            this.lbCostName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCostName.Name = "lbCostName";
            this.lbCostName.Size = new System.Drawing.Size(231, 20);
            this.lbCostName.TabIndex = 22;
            this.lbCostName.Text = "XXXX";
            this.lbCostName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(86, 56);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "เข้าอบรมหัวข้อ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(73, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 26);
            this.label5.TabIndex = 21;
            this.label5.Text = "สรุปข้อมูล";
            // 
            // FrmHomework4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btCal);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPeople);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbPhp);
            this.Controls.Add(this.rbIos);
            this.Controls.Add(this.rbAndroid);
            this.Controls.Add(this.rbJava);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHomework4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "โปรแกรมการบ้าน 4";
            this.Load += new System.EventHandler(this.FrmHomework4_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbJava;
        private System.Windows.Forms.RadioButton rbAndroid;
        private System.Windows.Forms.RadioButton rbIos;
        private System.Windows.Forms.RadioButton rbPhp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPeople;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbCostName;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbPeopleJoin;
        private System.Windows.Forms.Label label9;
    }
}