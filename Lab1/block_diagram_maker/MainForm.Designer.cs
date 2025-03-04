namespace block_diagram_maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolStripButton_Arrow = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_StartStop = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_Action = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_Condition = new System.Windows.Forms.ToolStripButton();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton_ColorBlack = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_ColorRed = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_ColorGreen = new System.Windows.Forms.ToolStripButton();
            this.ToolStripButton_ColorBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_Width = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox_Width = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_Height = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox_Height = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_BorderSize = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox_BorderSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripLabel_Text = new System.Windows.Forms.ToolStripLabel();
            this.ToolStripTextBox_Text = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripButton_Copy = new System.Windows.Forms.ToolStripButton();
            this.Panel_Draw = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripButton_Arrow,
            this.ToolStripButton_StartStop,
            this.ToolStripButton_Action,
            this.ToolStripButton_Condition,
            this.ToolStripSeparator1,
            this.ToolStripButton_ColorBlack,
            this.ToolStripButton_ColorRed,
            this.ToolStripButton_ColorGreen,
            this.ToolStripButton_ColorBlue,
            this.toolStripSeparator2,
            this.ToolStripLabel_Width,
            this.ToolStripTextBox_Width,
            this.toolStripSeparator3,
            this.ToolStripLabel_Height,
            this.ToolStripTextBox_Height,
            this.toolStripSeparator4,
            this.ToolStripLabel_BorderSize,
            this.ToolStripTextBox_BorderSize,
            this.toolStripSeparator5,
            this.ToolStripLabel_Text,
            this.ToolStripTextBox_Text,
            this.toolStripSeparator6,
            this.ToolStripButton_Copy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolStripButton_Arrow
            // 
            this.ToolStripButton_Arrow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_Arrow.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_Arrow.Image")));
            this.ToolStripButton_Arrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_Arrow.Name = "ToolStripButton_Arrow";
            this.ToolStripButton_Arrow.Size = new System.Drawing.Size(56, 22);
            this.ToolStripButton_Arrow.Text = "Arrow →";
            this.ToolStripButton_Arrow.Click += new System.EventHandler(this.ToolStripButton_Arrow_Click);
            // 
            // ToolStripButton_StartStop
            // 
            this.ToolStripButton_StartStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_StartStop.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_StartStop.Image")));
            this.ToolStripButton_StartStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_StartStop.Name = "ToolStripButton_StartStop";
            this.ToolStripButton_StartStop.Size = new System.Drawing.Size(74, 22);
            this.ToolStripButton_StartStop.Text = "Start/Stop ●";
            this.ToolStripButton_StartStop.Click += new System.EventHandler(this.ToolStripButton_StartStop_Click);
            // 
            // ToolStripButton_Action
            // 
            this.ToolStripButton_Action.Checked = true;
            this.ToolStripButton_Action.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripButton_Action.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_Action.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_Action.Image")));
            this.ToolStripButton_Action.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_Action.Name = "ToolStripButton_Action";
            this.ToolStripButton_Action.Size = new System.Drawing.Size(61, 22);
            this.ToolStripButton_Action.Text = "Action ▬";
            this.ToolStripButton_Action.Click += new System.EventHandler(this.ToolStripButton_Action_Click);
            // 
            // ToolStripButton_Condition
            // 
            this.ToolStripButton_Condition.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_Condition.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_Condition.Image")));
            this.ToolStripButton_Condition.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_Condition.Name = "ToolStripButton_Condition";
            this.ToolStripButton_Condition.Size = new System.Drawing.Size(77, 22);
            this.ToolStripButton_Condition.Text = "Condition ⬥";
            this.ToolStripButton_Condition.Click += new System.EventHandler(this.ToolStripButton_Condition_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton_ColorBlack
            // 
            this.ToolStripButton_ColorBlack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_ColorBlack.ForeColor = System.Drawing.Color.Black;
            this.ToolStripButton_ColorBlack.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_ColorBlack.Image")));
            this.ToolStripButton_ColorBlack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_ColorBlack.Name = "ToolStripButton_ColorBlack";
            this.ToolStripButton_ColorBlack.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_ColorBlack.Text = "■";
            this.ToolStripButton_ColorBlack.Click += new System.EventHandler(this.ToolStripButton_ColorBlack_Click);
            // 
            // ToolStripButton_ColorRed
            // 
            this.ToolStripButton_ColorRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_ColorRed.ForeColor = System.Drawing.Color.Red;
            this.ToolStripButton_ColorRed.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_ColorRed.Image")));
            this.ToolStripButton_ColorRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_ColorRed.Name = "ToolStripButton_ColorRed";
            this.ToolStripButton_ColorRed.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_ColorRed.Text = "■";
            this.ToolStripButton_ColorRed.Click += new System.EventHandler(this.ToolStripButton_ColorRed_Click);
            // 
            // ToolStripButton_ColorGreen
            // 
            this.ToolStripButton_ColorGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_ColorGreen.ForeColor = System.Drawing.Color.Green;
            this.ToolStripButton_ColorGreen.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_ColorGreen.Image")));
            this.ToolStripButton_ColorGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_ColorGreen.Name = "ToolStripButton_ColorGreen";
            this.ToolStripButton_ColorGreen.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_ColorGreen.Text = "■";
            this.ToolStripButton_ColorGreen.Click += new System.EventHandler(this.ToolStripButton_ColorGreen_Click);
            // 
            // ToolStripButton_ColorBlue
            // 
            this.ToolStripButton_ColorBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_ColorBlue.ForeColor = System.Drawing.Color.Blue;
            this.ToolStripButton_ColorBlue.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_ColorBlue.Image")));
            this.ToolStripButton_ColorBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_ColorBlue.Name = "ToolStripButton_ColorBlue";
            this.ToolStripButton_ColorBlue.Size = new System.Drawing.Size(23, 22);
            this.ToolStripButton_ColorBlue.Text = "■";
            this.ToolStripButton_ColorBlue.Click += new System.EventHandler(this.ToolStripButton_ColorBlue_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel_Width
            // 
            this.ToolStripLabel_Width.Name = "ToolStripLabel_Width";
            this.ToolStripLabel_Width.Size = new System.Drawing.Size(39, 22);
            this.ToolStripLabel_Width.Text = "Width";
            // 
            // ToolStripTextBox_Width
            // 
            this.ToolStripTextBox_Width.BackColor = System.Drawing.SystemColors.Window;
            this.ToolStripTextBox_Width.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox_Width.Name = "ToolStripTextBox_Width";
            this.ToolStripTextBox_Width.Size = new System.Drawing.Size(25, 25);
            this.ToolStripTextBox_Width.Text = "100";
            this.ToolStripTextBox_Width.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolStripTextBox_Width.TextChanged += new System.EventHandler(this.ToolStripTextBox_Width_TextChanged);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel_Height
            // 
            this.ToolStripLabel_Height.Name = "ToolStripLabel_Height";
            this.ToolStripLabel_Height.Size = new System.Drawing.Size(43, 22);
            this.ToolStripLabel_Height.Text = "Height";
            // 
            // ToolStripTextBox_Height
            // 
            this.ToolStripTextBox_Height.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox_Height.Name = "ToolStripTextBox_Height";
            this.ToolStripTextBox_Height.Size = new System.Drawing.Size(25, 25);
            this.ToolStripTextBox_Height.Text = "100";
            this.ToolStripTextBox_Height.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolStripTextBox_Height.TextChanged += new System.EventHandler(this.ToolStripTextBox_Height_TextChanged);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel_BorderSize
            // 
            this.ToolStripLabel_BorderSize.Name = "ToolStripLabel_BorderSize";
            this.ToolStripLabel_BorderSize.Size = new System.Drawing.Size(64, 22);
            this.ToolStripLabel_BorderSize.Text = "Border size";
            // 
            // ToolStripTextBox_BorderSize
            // 
            this.ToolStripTextBox_BorderSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox_BorderSize.Name = "ToolStripTextBox_BorderSize";
            this.ToolStripTextBox_BorderSize.Size = new System.Drawing.Size(25, 25);
            this.ToolStripTextBox_BorderSize.Text = "4";
            this.ToolStripTextBox_BorderSize.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolStripTextBox_BorderSize.TextChanged += new System.EventHandler(this.ToolStripTextBox_BorderSize_TextChanged);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripLabel_Text
            // 
            this.ToolStripLabel_Text.Name = "ToolStripLabel_Text";
            this.ToolStripLabel_Text.Size = new System.Drawing.Size(28, 22);
            this.ToolStripLabel_Text.Text = "Text";
            // 
            // ToolStripTextBox_Text
            // 
            this.ToolStripTextBox_Text.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ToolStripTextBox_Text.Name = "ToolStripTextBox_Text";
            this.ToolStripTextBox_Text.Size = new System.Drawing.Size(100, 25);
            this.ToolStripTextBox_Text.Text = "New Action";
            this.ToolStripTextBox_Text.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ToolStripTextBox_Text.TextChanged += new System.EventHandler(this.ToolStripTextBox_Text_TextChanged);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // ToolStripButton_Copy
            // 
            this.ToolStripButton_Copy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ToolStripButton_Copy.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripButton_Copy.Image")));
            this.ToolStripButton_Copy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripButton_Copy.Name = "ToolStripButton_Copy";
            this.ToolStripButton_Copy.Size = new System.Drawing.Size(39, 22);
            this.ToolStripButton_Copy.Text = "Copy";
            this.ToolStripButton_Copy.Click += new System.EventHandler(this.ToolStripButton_Copy_Click);
            // 
            // Panel_Draw
            // 
            this.Panel_Draw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Draw.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Panel_Draw.Location = new System.Drawing.Point(12, 52);
            this.Panel_Draw.Name = "Panel_Draw";
            this.Panel_Draw.Size = new System.Drawing.Size(1240, 617);
            this.Panel_Draw.TabIndex = 2;
            this.Panel_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Draw_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Panel_Draw);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(1280, 720);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "MainForm";
            this.Text = "Block Diagram Maker";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel Panel_Draw;
        private System.Windows.Forms.ToolStripButton ToolStripButton_Arrow;
        private System.Windows.Forms.ToolStripButton ToolStripButton_StartStop;
        private System.Windows.Forms.ToolStripButton ToolStripButton_Action;
        private System.Windows.Forms.ToolStripButton ToolStripButton_Condition;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ToolStripButton_ColorRed;
        private System.Windows.Forms.ToolStripButton ToolStripButton_ColorBlack;
        private System.Windows.Forms.ToolStripButton ToolStripButton_ColorGreen;
        private System.Windows.Forms.ToolStripButton ToolStripButton_ColorBlue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel_Width;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox_Width;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel_BorderSize;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox_BorderSize;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel_Text;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox_Text;
        private System.Windows.Forms.ToolStripLabel ToolStripLabel_Height;
        private System.Windows.Forms.ToolStripTextBox ToolStripTextBox_Height;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton ToolStripButton_Copy;
    }
}