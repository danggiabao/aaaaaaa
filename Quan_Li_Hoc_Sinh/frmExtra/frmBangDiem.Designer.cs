﻿namespace Quan_Li_Hoc_Sinh.frmExtra
{
	partial class frmBangDiem
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvDB = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbmamon = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdiemhk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt15p = new System.Windows.Forms.TextBox();
            this.txthocky = new System.Windows.Forms.TextBox();
            this.btnResetd = new System.Windows.Forms.Button();
            this.cbmahs = new System.Windows.Forms.ComboBox();
            this.txtTimKiemd = new System.Windows.Forms.TextBox();
            this.btnTimKiemd = new System.Windows.Forms.Button();
            this.btnXoad = new System.Windows.Forms.Button();
            this.btnSuad = new System.Windows.Forms.Button();
            this.btnthemd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdiemmieng = new System.Windows.Forms.TextBox();
            this.txt1tiet = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.UseWaitCursor = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cbmamon);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.txtdiemhk);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txt15p);
            this.splitContainer1.Panel2.Controls.Add(this.txthocky);
            this.splitContainer1.Panel2.Controls.Add(this.btnResetd);
            this.splitContainer1.Panel2.Controls.Add(this.cbmahs);
            this.splitContainer1.Panel2.Controls.Add(this.txtTimKiemd);
            this.splitContainer1.Panel2.Controls.Add(this.btnTimKiemd);
            this.splitContainer1.Panel2.Controls.Add(this.btnXoad);
            this.splitContainer1.Panel2.Controls.Add(this.btnSuad);
            this.splitContainer1.Panel2.Controls.Add(this.btnthemd);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtdiemmieng);
            this.splitContainer1.Panel2.Controls.Add(this.txt1tiet);
            this.splitContainer1.Panel2.UseWaitCursor = true;
            this.splitContainer1.Size = new System.Drawing.Size(869, 673);
            this.splitContainer1.SplitterDistance = 392;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvDB);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(869, 392);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Điểm :";
            this.groupBox1.UseWaitCursor = true;
            // 
            // lvDB
            // 
            this.lvDB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader16,
            this.columnHeader1});
            this.lvDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDB.FullRowSelect = true;
            this.lvDB.GridLines = true;
            this.lvDB.HideSelection = false;
            this.lvDB.Location = new System.Drawing.Point(4, 19);
            this.lvDB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvDB.Name = "lvDB";
            this.lvDB.Size = new System.Drawing.Size(861, 369);
            this.lvDB.TabIndex = 2;
            this.lvDB.UseCompatibleStateImageBehavior = false;
            this.lvDB.UseWaitCursor = true;
            this.lvDB.View = System.Windows.Forms.View.Details;
            this.lvDB.SelectedIndexChanged += new System.EventHandler(this.lvDB_SelectedIndexChanged);
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Mã Học Sinh";
            this.columnHeader10.Width = 92;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Mã Môn Học";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 100;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Học Kỳ";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 50;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Điểm miệng";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 100;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Điểm 15p";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 100;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Điểm 1 tiết";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader16.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Điểm học kỳ";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // cbmamon
            // 
            this.cbmamon.FormattingEnabled = true;
            this.cbmamon.Location = new System.Drawing.Point(33, 91);
            this.cbmamon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmamon.Name = "cbmamon";
            this.cbmamon.Size = new System.Drawing.Size(197, 24);
            this.cbmamon.TabIndex = 49;
            this.cbmamon.UseWaitCursor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(520, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 48;
            this.label8.Text = "Điểm học kỳ : ";
            this.label8.UseWaitCursor = true;
            // 
            // txtdiemhk
            // 
            this.txtdiemhk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemhk.Location = new System.Drawing.Point(524, 92);
            this.txtdiemhk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiemhk.Name = "txtdiemhk";
            this.txtdiemhk.Size = new System.Drawing.Size(197, 23);
            this.txtdiemhk.TabIndex = 46;
            this.txtdiemhk.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 44;
            this.label6.Text = "Điểm 1 tiết";
            this.label6.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 119);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = "Học Kỳ : ";
            this.label7.UseWaitCursor = true;
            // 
            // txt15p
            // 
            this.txt15p.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt15p.Location = new System.Drawing.Point(289, 91);
            this.txt15p.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt15p.Name = "txt15p";
            this.txt15p.Size = new System.Drawing.Size(197, 23);
            this.txt15p.TabIndex = 42;
            this.txt15p.UseWaitCursor = true;
            // 
            // txthocky
            // 
            this.txthocky.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthocky.Location = new System.Drawing.Point(33, 139);
            this.txthocky.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthocky.Name = "txthocky";
            this.txthocky.Size = new System.Drawing.Size(197, 23);
            this.txthocky.TabIndex = 41;
            this.txthocky.UseWaitCursor = true;
            // 
            // btnResetd
            // 
            this.btnResetd.Location = new System.Drawing.Point(675, 224);
            this.btnResetd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResetd.Name = "btnResetd";
            this.btnResetd.Size = new System.Drawing.Size(153, 28);
            this.btnResetd.TabIndex = 38;
            this.btnResetd.Text = "Reset";
            this.btnResetd.UseVisualStyleBackColor = true;
            this.btnResetd.UseWaitCursor = true;
            // 
            // cbmahs
            // 
            this.cbmahs.FormattingEnabled = true;
            this.cbmahs.Location = new System.Drawing.Point(33, 33);
            this.cbmahs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbmahs.Name = "cbmahs";
            this.cbmahs.Size = new System.Drawing.Size(197, 24);
            this.cbmahs.TabIndex = 37;
            this.cbmahs.UseWaitCursor = true;
            // 
            // txtTimKiemd
            // 
            this.txtTimKiemd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiemd.Location = new System.Drawing.Point(524, 28);
            this.txtTimKiemd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiemd.Name = "txtTimKiemd";
            this.txtTimKiemd.Size = new System.Drawing.Size(211, 23);
            this.txtTimKiemd.TabIndex = 36;
            this.txtTimKiemd.UseWaitCursor = true;
            // 
            // btnTimKiemd
            // 
            this.btnTimKiemd.Location = new System.Drawing.Point(744, 26);
            this.btnTimKiemd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiemd.Name = "btnTimKiemd";
            this.btnTimKiemd.Size = new System.Drawing.Size(100, 28);
            this.btnTimKiemd.TabIndex = 35;
            this.btnTimKiemd.Text = "Tìm Kiếm";
            this.btnTimKiemd.UseVisualStyleBackColor = true;
            this.btnTimKiemd.UseWaitCursor = true;
            // 
            // btnXoad
            // 
            this.btnXoad.Location = new System.Drawing.Point(443, 224);
            this.btnXoad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoad.Name = "btnXoad";
            this.btnXoad.Size = new System.Drawing.Size(153, 28);
            this.btnXoad.TabIndex = 34;
            this.btnXoad.Text = "Xóa";
            this.btnXoad.UseVisualStyleBackColor = true;
            this.btnXoad.UseWaitCursor = true;
            // 
            // btnSuad
            // 
            this.btnSuad.Location = new System.Drawing.Point(236, 224);
            this.btnSuad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuad.Name = "btnSuad";
            this.btnSuad.Size = new System.Drawing.Size(153, 28);
            this.btnSuad.TabIndex = 33;
            this.btnSuad.Text = "Sửa";
            this.btnSuad.UseVisualStyleBackColor = true;
            this.btnSuad.UseWaitCursor = true;
            // 
            // btnthemd
            // 
            this.btnthemd.Location = new System.Drawing.Point(23, 224);
            this.btnthemd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnthemd.Name = "btnthemd";
            this.btnthemd.Size = new System.Drawing.Size(153, 28);
            this.btnthemd.TabIndex = 32;
            this.btnthemd.Text = "Thêm";
            this.btnthemd.UseVisualStyleBackColor = true;
            this.btnthemd.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Điểm 15p :";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(285, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Điểm miệng : ";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mã Môn Học : ";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mã Học Sinh : ";
            this.label1.UseWaitCursor = true;
            // 
            // txtdiemmieng
            // 
            this.txtdiemmieng.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdiemmieng.Location = new System.Drawing.Point(289, 34);
            this.txtdiemmieng.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtdiemmieng.Name = "txtdiemmieng";
            this.txtdiemmieng.Size = new System.Drawing.Size(197, 23);
            this.txtdiemmieng.TabIndex = 25;
            this.txtdiemmieng.UseWaitCursor = true;
            // 
            // txt1tiet
            // 
            this.txt1tiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1tiet.Location = new System.Drawing.Point(289, 139);
            this.txt1tiet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt1tiet.Name = "txt1tiet";
            this.txt1tiet.Size = new System.Drawing.Size(197, 23);
            this.txt1tiet.TabIndex = 24;
            this.txt1tiet.UseWaitCursor = true;
            // 
            // frmBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBangDiem";
            this.Size = new System.Drawing.Size(869, 673);
            this.Load += new System.EventHandler(this.frmBangDiem_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListView lvDB;
		private System.Windows.Forms.ColumnHeader columnHeader10;
		private System.Windows.Forms.ColumnHeader columnHeader11;
		private System.Windows.Forms.ColumnHeader columnHeader12;
		private System.Windows.Forms.ColumnHeader columnHeader13;
		private System.Windows.Forms.ColumnHeader columnHeader14;
		private System.Windows.Forms.ColumnHeader columnHeader16;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtdiemhk;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txt15p;
		private System.Windows.Forms.TextBox txthocky;
		private System.Windows.Forms.Button btnResetd;
		private System.Windows.Forms.ComboBox cbmahs;
		private System.Windows.Forms.TextBox txtTimKiemd;
		private System.Windows.Forms.Button btnTimKiemd;
		private System.Windows.Forms.Button btnXoad;
		private System.Windows.Forms.Button btnSuad;
		private System.Windows.Forms.Button btnthemd;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtdiemmieng;
		private System.Windows.Forms.TextBox txt1tiet;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ComboBox cbmamon;
	}
}
