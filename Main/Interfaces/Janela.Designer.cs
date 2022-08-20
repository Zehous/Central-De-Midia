namespace Central_De_Midia.Main.Interfaces
{
    partial class Janela
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
            this.PanelHotBar = new System.Windows.Forms.Panel();
            this.LabelClose = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.PanelHotBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHotBar
            // 
            this.PanelHotBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelHotBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PanelHotBar.Controls.Add(this.LabelClose);
            this.PanelHotBar.Controls.Add(this.LabelTitle);
            this.PanelHotBar.Location = new System.Drawing.Point(0, 0);
            this.PanelHotBar.Name = "PanelHotBar";
            this.PanelHotBar.Size = new System.Drawing.Size(1000, 50);
            this.PanelHotBar.TabIndex = 0;
            this.PanelHotBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelHotBar_MouseDown);
            this.PanelHotBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelHotBar_MouseMove);
            // 
            // LabelClose
            // 
            this.LabelClose.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelClose.Location = new System.Drawing.Point(970, 12);
            this.LabelClose.Name = "LabelClose";
            this.LabelClose.Size = new System.Drawing.Size(18, 23);
            this.LabelClose.TabIndex = 2;
            this.LabelClose.Text = "X";
            this.LabelClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LabelClose.Click += new System.EventHandler(this.LabelClose_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Palatino Linotype", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 12);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(149, 23);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Central De Midia";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelContent
            // 
            this.PanelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelContent.Location = new System.Drawing.Point(0, 50);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1000, 600);
            this.PanelContent.TabIndex = 1;
            // 
            // Janela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.PanelContent);
            this.Controls.Add(this.PanelHotBar);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Janela";
            this.Text = "Janela";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.PanelHotBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelHotBar;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel PanelContent;
        private Extensions.ExtendedPanel PanelCloseMenu;
        private System.Windows.Forms.Label LabelClose;
    }
}