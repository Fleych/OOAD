namespace FilmCatalog
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox_filmlist = new ListBox();
            label_filmlist = new Label();
            label_filmname = new Label();
            label_genre = new Label();
            label_description = new Label();
            pictureBox_image = new PictureBox();
            label_memory = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).BeginInit();
            SuspendLayout();
            // 
            // listBox_filmlist
            // 
            listBox_filmlist.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            listBox_filmlist.FormattingEnabled = true;
            listBox_filmlist.ItemHeight = 30;
            listBox_filmlist.Items.AddRange(new object[] { "1+1", "Интерстеллар", "Побег из Шоушенка", "Джентльмены", "Остров проклятых" });
            listBox_filmlist.Location = new Point(12, 57);
            listBox_filmlist.Name = "listBox_filmlist";
            listBox_filmlist.Size = new Size(209, 454);
            listBox_filmlist.TabIndex = 0;
            listBox_filmlist.SelectedIndexChanged += listBox_filmlist_SelectedIndexChanged;
            // 
            // label_filmlist
            // 
            label_filmlist.AutoSize = true;
            label_filmlist.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_filmlist.Location = new Point(12, 9);
            label_filmlist.Name = "label_filmlist";
            label_filmlist.Size = new Size(195, 30);
            label_filmlist.TabIndex = 1;
            label_filmlist.Text = "Каталог фильмов";
            // 
            // label_filmname
            // 
            label_filmname.AutoSize = true;
            label_filmname.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label_filmname.Location = new Point(543, 57);
            label_filmname.Name = "label_filmname";
            label_filmname.Size = new Size(0, 30);
            label_filmname.TabIndex = 2;
            // 
            // label_genre
            // 
            label_genre.AutoSize = true;
            label_genre.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label_genre.Location = new Point(546, 105);
            label_genre.Name = "label_genre";
            label_genre.Size = new Size(0, 30);
            label_genre.TabIndex = 3;
            // 
            // label_description
            // 
            label_description.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label_description.Location = new Point(546, 147);
            label_description.Name = "label_description";
            label_description.Size = new Size(399, 364);
            label_description.TabIndex = 4;
            // 
            // pictureBox_image
            // 
            pictureBox_image.Location = new Point(227, 57);
            pictureBox_image.Name = "pictureBox_image";
            pictureBox_image.Size = new Size(300, 450);
            pictureBox_image.TabIndex = 5;
            pictureBox_image.TabStop = false;
            // 
            // label_memory
            // 
            label_memory.AutoSize = true;
            label_memory.Location = new Point(767, 21);
            label_memory.Name = "label_memory";
            label_memory.Size = new Size(132, 15);
            label_memory.TabIndex = 6;
            label_memory.Text = "Используемая память:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 530);
            Controls.Add(label_memory);
            Controls.Add(pictureBox_image);
            Controls.Add(label_description);
            Controls.Add(label_genre);
            Controls.Add(label_filmname);
            Controls.Add(label_filmlist);
            Controls.Add(listBox_filmlist);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox_filmlist;
        private Label label_filmlist;
        private Label label_filmname;
        private Label label_genre;
        private Label label_description;
        private PictureBox pictureBox_image;
        private Label label_memory;
        private System.Windows.Forms.Timer timer1;
    }
}
