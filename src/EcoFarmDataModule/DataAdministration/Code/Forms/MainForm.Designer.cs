﻿namespace DataAdministration
{
	partial class MainForm
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
			this.ButtonTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ButtonTest
			// 
			this.ButtonTest.Location = new System.Drawing.Point(227, 75);
			this.ButtonTest.Name = "ButtonTest";
			this.ButtonTest.Size = new System.Drawing.Size(114, 33);
			this.ButtonTest.TabIndex = 0;
			this.ButtonTest.Text = "Test";
			this.ButtonTest.UseVisualStyleBackColor = true;
			this.ButtonTest.Click += new System.EventHandler(this.ButtonTest_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.ButtonTest);
			this.Name = "MainForm";
			this.Text = "Эко-ферма Модуль Управления Данными";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button ButtonTest;

#endregion
	}
}