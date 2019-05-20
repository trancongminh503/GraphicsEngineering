﻿namespace GraphicsEngineering.GUI
{
	partial class Form2D
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
            this.pnMenuBar = new System.Windows.Forms.Panel();
            this.lblClose = new System.Windows.Forms.Label();
            this.lblMinimaze = new System.Windows.Forms.Label();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.grbCoordinates = new System.Windows.Forms.GroupBox();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.grbScreen = new System.Windows.Forms.GroupBox();
            this.pbDrawingArea = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ckbGridDraw = new GraphicsEngineering.GUI.MyCheckBox();
            this.pnMenuBar.SuspendLayout();
            this.grbCoordinates.SuspendLayout();
            this.grbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMenuBar
            // 
            this.pnMenuBar.BackColor = System.Drawing.Color.SteelBlue;
            this.pnMenuBar.Controls.Add(this.lblClose);
            this.pnMenuBar.Controls.Add(this.lblMinimaze);
            this.pnMenuBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenuBar.Location = new System.Drawing.Point(0, 0);
            this.pnMenuBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnMenuBar.Name = "pnMenuBar";
            this.pnMenuBar.Size = new System.Drawing.Size(1757, 34);
            this.pnMenuBar.TabIndex = 4;
            // 
            // lblClose
            // 
            this.lblClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClose.BackColor = System.Drawing.Color.SteelBlue;
            this.lblClose.Image = global::GraphicsEngineering.GUI.Properties.Resources.closeRound;
            this.lblClose.Location = new System.Drawing.Point(1719, 0);
            this.lblClose.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(37, 34);
            this.lblClose.TabIndex = 1;
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // lblMinimaze
            // 
            this.lblMinimaze.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinimaze.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMinimaze.Image = global::GraphicsEngineering.GUI.Properties.Resources.minimizeRound;
            this.lblMinimaze.Location = new System.Drawing.Point(1681, 0);
            this.lblMinimaze.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinimaze.Name = "lblMinimaze";
            this.lblMinimaze.Size = new System.Drawing.Size(37, 34);
            this.lblMinimaze.TabIndex = 0;
            this.lblMinimaze.Click += new System.EventHandler(this.lblMinimaze_Click);
            // 
            // lblInfo1
            // 
            this.lblInfo1.AllowDrop = true;
            this.lblInfo1.BackColor = System.Drawing.Color.DarkCyan;
            this.lblInfo1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblInfo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo1.Location = new System.Drawing.Point(4, 19);
            this.lblInfo1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(337, 287);
            this.lblInfo1.TabIndex = 0;
            // 
            // grbCoordinates
            // 
            this.grbCoordinates.Controls.Add(this.ckbGridDraw);
            this.grbCoordinates.Controls.Add(this.lblInfo2);
            this.grbCoordinates.Controls.Add(this.btnStop);
            this.grbCoordinates.Controls.Add(this.lblInfo1);
            this.grbCoordinates.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbCoordinates.Location = new System.Drawing.Point(1412, 34);
            this.grbCoordinates.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCoordinates.Name = "grbCoordinates";
            this.grbCoordinates.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCoordinates.Size = new System.Drawing.Size(345, 750);
            this.grbCoordinates.TabIndex = 2;
            this.grbCoordinates.TabStop = false;
            this.grbCoordinates.Text = "Coordinates";
            // 
            // lblInfo2
            // 
            this.lblInfo2.BackColor = System.Drawing.Color.DarkCyan;
            this.lblInfo2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo2.Location = new System.Drawing.Point(4, 306);
            this.lblInfo2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(337, 265);
            this.lblInfo2.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStop.Location = new System.Drawing.Point(133, 599);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(100, 28);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grbScreen
            // 
            this.grbScreen.Controls.Add(this.pbDrawingArea);
            this.grbScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbScreen.Location = new System.Drawing.Point(0, 34);
            this.grbScreen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbScreen.Name = "grbScreen";
            this.grbScreen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbScreen.Size = new System.Drawing.Size(1412, 750);
            this.grbScreen.TabIndex = 3;
            this.grbScreen.TabStop = false;
            this.grbScreen.Text = "Screen";
            // 
            // pbDrawingArea
            // 
            this.pbDrawingArea.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbDrawingArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDrawingArea.Location = new System.Drawing.Point(4, 19);
            this.pbDrawingArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbDrawingArea.Name = "pbDrawingArea";
            this.pbDrawingArea.Size = new System.Drawing.Size(1404, 727);
            this.pbDrawingArea.TabIndex = 0;
            this.pbDrawingArea.TabStop = false;
            this.pbDrawingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbDrawingArea_Paint);
            this.pbDrawingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawingArea_MouseDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ckbGridDraw
            // 
            this.ckbGridDraw.BackColor = System.Drawing.Color.DarkCyan;
            this.ckbGridDraw.Location = new System.Drawing.Point(8, 537);
            this.ckbGridDraw.Margin = new System.Windows.Forms.Padding(4);
            this.ckbGridDraw.Name = "ckbGridDraw";
            this.ckbGridDraw.Padding = new System.Windows.Forms.Padding(4);
            this.ckbGridDraw.Size = new System.Drawing.Size(77, 34);
            this.ckbGridDraw.TabIndex = 3;
            this.ckbGridDraw.Text = "myCheckBox1";
            this.ckbGridDraw.UseVisualStyleBackColor = false;
            this.ckbGridDraw.CheckedChanged += new System.EventHandler(this.ckbGridDraw_CheckedChanged);
            // 
            // Form2D
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1757, 784);
            this.Controls.Add(this.grbScreen);
            this.Controls.Add(this.grbCoordinates);
            this.Controls.Add(this.pnMenuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2D";
            this.Text = "Graphics Engineering";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.Form2D_Load);
            this.pnMenuBar.ResumeLayout(false);
            this.grbCoordinates.ResumeLayout(false);
            this.grbScreen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawingArea)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel pnMenuBar;
		private System.Windows.Forms.Label lblMinimaze;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Label lblInfo1;
		private System.Windows.Forms.GroupBox grbCoordinates;
		private System.Windows.Forms.GroupBox grbScreen;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.PictureBox pbDrawingArea;
		private MyCheckBox ckbGridDraw;
		private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Timer timer1;
    }
}

