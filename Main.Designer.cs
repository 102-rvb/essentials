
namespace _102_Essentials
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.CloseApplication = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Logout = new System.Windows.Forms.Button();
            this.ServerSidePanel = new System.Windows.Forms.Button();
            this.KickPanel = new System.Windows.Forms.Button();
            this.BanPanel = new System.Windows.Forms.Button();
            this.LogsPanel = new System.Windows.Forms.Button();
            this.TopPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.TopPanel.Controls.Add(this.CloseApplication);
            this.TopPanel.Controls.Add(this.Title);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(474, 27);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // CloseApplication
            // 
            this.CloseApplication.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CloseApplication.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.CloseApplication.FlatAppearance.BorderSize = 0;
            this.CloseApplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseApplication.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApplication.ForeColor = System.Drawing.Color.Red;
            this.CloseApplication.Location = new System.Drawing.Point(449, 0);
            this.CloseApplication.Name = "CloseApplication";
            this.CloseApplication.Size = new System.Drawing.Size(25, 24);
            this.CloseApplication.TabIndex = 9;
            this.CloseApplication.Text = "X";
            this.CloseApplication.UseVisualStyleBackColor = false;
            this.CloseApplication.Click += new System.EventHandler(this.CloseApplication_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 26);
            this.Title.TabIndex = 10;
            this.Title.Text = "Ритуальные услуги харкора";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.Logout);
            this.panel1.Controls.Add(this.ServerSidePanel);
            this.panel1.Controls.Add(this.KickPanel);
            this.panel1.Controls.Add(this.BanPanel);
            this.panel1.Controls.Add(this.LogsPanel);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 284);
            this.panel1.TabIndex = 1;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Logout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.Logout.FlatAppearance.BorderSize = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(5, 253);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(102, 23);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Выйти";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_click);
            // 
            // ServerSidePanel
            // 
            this.ServerSidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ServerSidePanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ServerSidePanel.FlatAppearance.BorderSize = 0;
            this.ServerSidePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ServerSidePanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServerSidePanel.ForeColor = System.Drawing.Color.White;
            this.ServerSidePanel.Location = new System.Drawing.Point(5, 95);
            this.ServerSidePanel.Name = "ServerSidePanel";
            this.ServerSidePanel.Size = new System.Drawing.Size(102, 23);
            this.ServerSidePanel.TabIndex = 5;
            this.ServerSidePanel.Text = "Server Side";
            this.ServerSidePanel.UseVisualStyleBackColor = false;
            // 
            // KickPanel
            // 
            this.KickPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.KickPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.KickPanel.FlatAppearance.BorderSize = 0;
            this.KickPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KickPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KickPanel.ForeColor = System.Drawing.Color.White;
            this.KickPanel.Location = new System.Drawing.Point(5, 65);
            this.KickPanel.Name = "KickPanel";
            this.KickPanel.Size = new System.Drawing.Size(102, 23);
            this.KickPanel.TabIndex = 4;
            this.KickPanel.Text = "Кик";
            this.KickPanel.UseVisualStyleBackColor = false;
            // 
            // BanPanel
            // 
            this.BanPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BanPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.BanPanel.FlatAppearance.BorderSize = 0;
            this.BanPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BanPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BanPanel.ForeColor = System.Drawing.Color.White;
            this.BanPanel.Location = new System.Drawing.Point(5, 35);
            this.BanPanel.Name = "BanPanel";
            this.BanPanel.Size = new System.Drawing.Size(102, 23);
            this.BanPanel.TabIndex = 3;
            this.BanPanel.Text = "Бан";
            this.BanPanel.UseVisualStyleBackColor = false;
            // 
            // LogsPanel
            // 
            this.LogsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogsPanel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.LogsPanel.FlatAppearance.BorderSize = 0;
            this.LogsPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogsPanel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogsPanel.ForeColor = System.Drawing.Color.White;
            this.LogsPanel.Location = new System.Drawing.Point(5, 5);
            this.LogsPanel.Name = "LogsPanel";
            this.LogsPanel.Size = new System.Drawing.Size(102, 23);
            this.LogsPanel.TabIndex = 2;
            this.LogsPanel.Text = "Логи";
            this.LogsPanel.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(474, 308);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopPanel);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.TopPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button CloseApplication;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LogsPanel;
        private System.Windows.Forms.Button KickPanel;
        private System.Windows.Forms.Button BanPanel;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button ServerSidePanel;
    }
}