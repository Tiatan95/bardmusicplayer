﻿namespace FFBardMusicPlayer {
	partial class BmpProcessSelect {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.ProcessList = new System.Windows.Forms.FlowLayoutPanel();
			this.HeaderText = new System.Windows.Forms.Label();
			this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
			this.RefreshButton = new System.Windows.Forms.Button();
			this.QuitButton = new System.Windows.Forms.Button();
			this.ProcessScroll = new System.Windows.Forms.Panel();
			this.AllProcessCheck = new System.Windows.Forms.CheckBox();
			this.ProcessScroll.SuspendLayout();
			this.SuspendLayout();
			// 
			// ProcessList
			// 
			this.ProcessList.AutoSize = true;
			this.ProcessList.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.ProcessList.Location = new System.Drawing.Point(0, 0);
			this.ProcessList.Margin = new System.Windows.Forms.Padding(0);
			this.ProcessList.Name = "ProcessList";
			this.ProcessList.Size = new System.Drawing.Size(131, 190);
			this.ProcessList.TabIndex = 0;
			// 
			// HeaderText
			// 
			this.HeaderText.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.HeaderText.Location = new System.Drawing.Point(1, 6);
			this.HeaderText.Name = "HeaderText";
			this.HeaderText.Size = new System.Drawing.Size(178, 18);
			this.HeaderText.TabIndex = 1;
			this.HeaderText.Text = "Select process";
			this.HeaderText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ToolTip
			// 
			this.ToolTip.AutomaticDelay = 100;
			// 
			// RefreshButton
			// 
			this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.RefreshButton.Location = new System.Drawing.Point(3, 236);
			this.RefreshButton.Margin = new System.Windows.Forms.Padding(0);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(107, 20);
			this.RefreshButton.TabIndex = 2;
			this.RefreshButton.Text = "Refresh";
			this.RefreshButton.UseVisualStyleBackColor = true;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// QuitButton
			// 
			this.QuitButton.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.QuitButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.QuitButton.Location = new System.Drawing.Point(110, 236);
			this.QuitButton.Margin = new System.Windows.Forms.Padding(0);
			this.QuitButton.Name = "QuitButton";
			this.QuitButton.Size = new System.Drawing.Size(65, 20);
			this.QuitButton.TabIndex = 3;
			this.QuitButton.Text = "Cancel";
			this.QuitButton.UseVisualStyleBackColor = true;
			this.QuitButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// ProcessScroll
			// 
			this.ProcessScroll.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
			| System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.ProcessScroll.AutoScroll = true;
			this.ProcessScroll.Controls.Add(this.ProcessList);
			this.ProcessScroll.Location = new System.Drawing.Point(19, 24);
			this.ProcessScroll.Margin = new System.Windows.Forms.Padding(0);
			this.ProcessScroll.Name = "ProcessScroll";
			this.ProcessScroll.Size = new System.Drawing.Size(148, 190);
			this.ProcessScroll.TabIndex = 4;
			// 
			// AllProcessCheck
			// 
			this.AllProcessCheck.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.AllProcessCheck.Location = new System.Drawing.Point(19, 215);
			this.AllProcessCheck.Name = "AllProcessCheck";
			this.AllProcessCheck.Size = new System.Drawing.Size(148, 21);
			this.AllProcessCheck.TabIndex = 5;
			this.AllProcessCheck.Text = "Show all processes";
			this.AllProcessCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.AllProcessCheck.UseVisualStyleBackColor = true;
			this.AllProcessCheck.CheckedChanged += new System.EventHandler(this.AllProcessCheck_CheckedChanged);
			// 
			// BmpProcessSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(180, 260);
			this.Controls.Add(this.AllProcessCheck);
			this.Controls.Add(this.QuitButton);
			this.Controls.Add(this.HeaderText);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.ProcessScroll);
			this.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "BmpProcessSelect";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Shown += new System.EventHandler(this.RefreshList);
			this.Enter += new System.EventHandler(this.RefreshList);
			this.ProcessScroll.ResumeLayout(false);
			this.ProcessScroll.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel ProcessList;
		private System.Windows.Forms.Label HeaderText;
		private System.Windows.Forms.ToolTip ToolTip;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.Button QuitButton;
		private System.Windows.Forms.Panel ProcessScroll;
		private System.Windows.Forms.CheckBox AllProcessCheck;
	}
}