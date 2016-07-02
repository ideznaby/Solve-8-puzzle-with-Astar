namespace AstarVisual
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
            this.firststate = new System.Windows.Forms.TableLayoutPanel();
            this.fblank = new System.Windows.Forms.Button();
            this.f8 = new System.Windows.Forms.Button();
            this.f7 = new System.Windows.Forms.Button();
            this.f6 = new System.Windows.Forms.Button();
            this.f5 = new System.Windows.Forms.Button();
            this.f4 = new System.Windows.Forms.Button();
            this.f3 = new System.Windows.Forms.Button();
            this.f2 = new System.Windows.Forms.Button();
            this.f1 = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            this.Goalstate = new System.Windows.Forms.TableLayoutPanel();
            this.g8 = new System.Windows.Forms.Button();
            this.g7 = new System.Windows.Forms.Button();
            this.g6 = new System.Windows.Forms.Button();
            this.g5 = new System.Windows.Forms.Button();
            this.g4 = new System.Windows.Forms.Button();
            this.g3 = new System.Windows.Forms.Button();
            this.g2 = new System.Windows.Forms.Button();
            this.g1 = new System.Windows.Forms.Button();
            this.gblank = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firststate.SuspendLayout();
            this.Goalstate.SuspendLayout();
            this.SuspendLayout();
            // 
            // firststate
            // 
            this.firststate.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.firststate.ColumnCount = 3;
            this.firststate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.firststate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.firststate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.firststate.Controls.Add(this.fblank, 2, 2);
            this.firststate.Controls.Add(this.f8, 1, 2);
            this.firststate.Controls.Add(this.f7, 0, 2);
            this.firststate.Controls.Add(this.f6, 2, 1);
            this.firststate.Controls.Add(this.f5, 1, 1);
            this.firststate.Controls.Add(this.f4, 0, 1);
            this.firststate.Controls.Add(this.f3, 2, 0);
            this.firststate.Controls.Add(this.f2, 1, 0);
            this.firststate.Controls.Add(this.f1, 0, 0);
            this.firststate.Location = new System.Drawing.Point(116, 12);
            this.firststate.Name = "firststate";
            this.firststate.RowCount = 3;
            this.firststate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.firststate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.firststate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.firststate.Size = new System.Drawing.Size(302, 302);
            this.firststate.TabIndex = 1;
            // 
            // fblank
            // 
            this.fblank.AllowDrop = true;
            this.fblank.Location = new System.Drawing.Point(206, 206);
            this.fblank.Name = "fblank";
            this.fblank.Size = new System.Drawing.Size(94, 94);
            this.fblank.TabIndex = 12;
            this.fblank.Text = "-";
            this.fblank.UseVisualStyleBackColor = true;
            this.fblank.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.fblank.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.fblank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f8
            // 
            this.f8.AllowDrop = true;
            this.f8.Location = new System.Drawing.Point(105, 206);
            this.f8.Name = "f8";
            this.f8.Size = new System.Drawing.Size(94, 94);
            this.f8.TabIndex = 11;
            this.f8.Text = "8";
            this.f8.UseVisualStyleBackColor = true;
            this.f8.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f8.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f7
            // 
            this.f7.AllowDrop = true;
            this.f7.Location = new System.Drawing.Point(4, 206);
            this.f7.Name = "f7";
            this.f7.Size = new System.Drawing.Size(94, 94);
            this.f7.TabIndex = 10;
            this.f7.Text = "7";
            this.f7.UseVisualStyleBackColor = true;
            this.f7.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f7.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f6
            // 
            this.f6.AllowDrop = true;
            this.f6.Location = new System.Drawing.Point(206, 105);
            this.f6.Name = "f6";
            this.f6.Size = new System.Drawing.Size(94, 94);
            this.f6.TabIndex = 9;
            this.f6.Text = "6";
            this.f6.UseVisualStyleBackColor = true;
            this.f6.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f6.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f5
            // 
            this.f5.AllowDrop = true;
            this.f5.Location = new System.Drawing.Point(105, 105);
            this.f5.Name = "f5";
            this.f5.Size = new System.Drawing.Size(94, 94);
            this.f5.TabIndex = 8;
            this.f5.Text = "5";
            this.f5.UseVisualStyleBackColor = true;
            this.f5.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f5.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f4
            // 
            this.f4.AllowDrop = true;
            this.f4.Location = new System.Drawing.Point(4, 105);
            this.f4.Name = "f4";
            this.f4.Size = new System.Drawing.Size(94, 94);
            this.f4.TabIndex = 7;
            this.f4.Text = "4";
            this.f4.UseVisualStyleBackColor = true;
            this.f4.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f4.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f3
            // 
            this.f3.AllowDrop = true;
            this.f3.Location = new System.Drawing.Point(206, 4);
            this.f3.Name = "f3";
            this.f3.Size = new System.Drawing.Size(94, 94);
            this.f3.TabIndex = 6;
            this.f3.Text = "3";
            this.f3.UseVisualStyleBackColor = true;
            this.f3.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f3.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f2
            // 
            this.f2.AllowDrop = true;
            this.f2.Location = new System.Drawing.Point(105, 4);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(94, 94);
            this.f2.TabIndex = 5;
            this.f2.Text = "2";
            this.f2.UseVisualStyleBackColor = true;
            this.f2.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f2.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // f1
            // 
            this.f1.AllowDrop = true;
            this.f1.Location = new System.Drawing.Point(4, 4);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(94, 94);
            this.f1.TabIndex = 4;
            this.f1.Text = "1";
            this.f1.UseVisualStyleBackColor = true;
            this.f1.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.f1.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.f1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(524, 430);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(95, 35);
            this.Solve.TabIndex = 3;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // Goalstate
            // 
            this.Goalstate.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.Goalstate.ColumnCount = 3;
            this.Goalstate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Goalstate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Goalstate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Goalstate.Controls.Add(this.g8, 1, 2);
            this.Goalstate.Controls.Add(this.g7, 0, 2);
            this.Goalstate.Controls.Add(this.g6, 2, 1);
            this.Goalstate.Controls.Add(this.g5, 1, 1);
            this.Goalstate.Controls.Add(this.g4, 0, 1);
            this.Goalstate.Controls.Add(this.g3, 2, 0);
            this.Goalstate.Controls.Add(this.g2, 1, 0);
            this.Goalstate.Controls.Add(this.g1, 0, 0);
            this.Goalstate.Controls.Add(this.gblank, 2, 2);
            this.Goalstate.Location = new System.Drawing.Point(726, 12);
            this.Goalstate.Name = "Goalstate";
            this.Goalstate.RowCount = 3;
            this.Goalstate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Goalstate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Goalstate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.Goalstate.Size = new System.Drawing.Size(302, 302);
            this.Goalstate.TabIndex = 4;
            // 
            // g8
            // 
            this.g8.AllowDrop = true;
            this.g8.Location = new System.Drawing.Point(105, 206);
            this.g8.Name = "g8";
            this.g8.Size = new System.Drawing.Size(94, 94);
            this.g8.TabIndex = 11;
            this.g8.Text = "8";
            this.g8.UseVisualStyleBackColor = true;
            this.g8.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g8.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g7
            // 
            this.g7.AllowDrop = true;
            this.g7.Location = new System.Drawing.Point(4, 206);
            this.g7.Name = "g7";
            this.g7.Size = new System.Drawing.Size(94, 94);
            this.g7.TabIndex = 10;
            this.g7.Text = "7";
            this.g7.UseVisualStyleBackColor = true;
            this.g7.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g7.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g6
            // 
            this.g6.AllowDrop = true;
            this.g6.Location = new System.Drawing.Point(206, 105);
            this.g6.Name = "g6";
            this.g6.Size = new System.Drawing.Size(94, 94);
            this.g6.TabIndex = 9;
            this.g6.Text = "6";
            this.g6.UseVisualStyleBackColor = true;
            this.g6.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g6.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g5
            // 
            this.g5.AllowDrop = true;
            this.g5.Location = new System.Drawing.Point(105, 105);
            this.g5.Name = "g5";
            this.g5.Size = new System.Drawing.Size(94, 94);
            this.g5.TabIndex = 8;
            this.g5.Text = "5";
            this.g5.UseVisualStyleBackColor = true;
            this.g5.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g5.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g4
            // 
            this.g4.AllowDrop = true;
            this.g4.Location = new System.Drawing.Point(4, 105);
            this.g4.Name = "g4";
            this.g4.Size = new System.Drawing.Size(94, 94);
            this.g4.TabIndex = 7;
            this.g4.Text = "4";
            this.g4.UseVisualStyleBackColor = true;
            this.g4.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g4.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g3
            // 
            this.g3.AllowDrop = true;
            this.g3.Location = new System.Drawing.Point(206, 4);
            this.g3.Name = "g3";
            this.g3.Size = new System.Drawing.Size(94, 94);
            this.g3.TabIndex = 6;
            this.g3.Text = "3";
            this.g3.UseVisualStyleBackColor = true;
            this.g3.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g3.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g2
            // 
            this.g2.AllowDrop = true;
            this.g2.Location = new System.Drawing.Point(105, 4);
            this.g2.Name = "g2";
            this.g2.Size = new System.Drawing.Size(94, 94);
            this.g2.TabIndex = 5;
            this.g2.Text = "2";
            this.g2.UseVisualStyleBackColor = true;
            this.g2.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g2.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // g1
            // 
            this.g1.AllowDrop = true;
            this.g1.Location = new System.Drawing.Point(4, 4);
            this.g1.Name = "g1";
            this.g1.Size = new System.Drawing.Size(94, 94);
            this.g1.TabIndex = 4;
            this.g1.Text = "1";
            this.g1.UseVisualStyleBackColor = true;
            this.g1.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.g1.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.g1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // gblank
            // 
            this.gblank.AllowDrop = true;
            this.gblank.Location = new System.Drawing.Point(206, 206);
            this.gblank.Name = "gblank";
            this.gblank.Size = new System.Drawing.Size(94, 94);
            this.gblank.TabIndex = 13;
            this.gblank.Text = "-";
            this.gblank.UseVisualStyleBackColor = true;
            this.gblank.DragDrop += new System.Windows.Forms.DragEventHandler(this.f1_DragDrop);
            this.gblank.DragEnter += new System.Windows.Forms.DragEventHandler(this.f1_DragEnter);
            this.gblank.MouseDown += new System.Windows.Forms.MouseEventHandler(this.f1_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "firststate :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "goalstate :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Goalstate);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.firststate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.firststate.ResumeLayout(false);
            this.Goalstate.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel firststate;
        private System.Windows.Forms.Button f8;
        private System.Windows.Forms.Button f7;
        private System.Windows.Forms.Button f6;
        private System.Windows.Forms.Button f5;
        private System.Windows.Forms.Button f4;
        private System.Windows.Forms.Button f3;
        private System.Windows.Forms.Button f2;
        private System.Windows.Forms.Button f1;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.TableLayoutPanel Goalstate;
        private System.Windows.Forms.Button g8;
        private System.Windows.Forms.Button g7;
        private System.Windows.Forms.Button g6;
        private System.Windows.Forms.Button g5;
        private System.Windows.Forms.Button g4;
        private System.Windows.Forms.Button g3;
        private System.Windows.Forms.Button g2;
        private System.Windows.Forms.Button g1;
        private System.Windows.Forms.Button fblank;
        private System.Windows.Forms.Button gblank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

