using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace block_diagram_maker
{
    internal class Action : Element
    {
        public Action(Point pos, Size element_size, int border_size, Color color, string text)
        {
            Panel new_hitbox = new Panel();

            int x = pos.X;
            int y = pos.Y;
            new_hitbox.Location = new Point(x, y);

            int w = element_size.Width;
            int h = element_size.Height;
            new_hitbox.Size = new Size(w, h);

            new_hitbox.BackColor = Color.Transparent;

            new_hitbox.Paint += new System.Windows.Forms.PaintEventHandler(Draw);
            new_hitbox.MouseDown += new System.Windows.Forms.MouseEventHandler(Select);


            byte r = color.R;
            byte g = color.G;
            byte b = color.B;

            Color new_color = Color.FromArgb(r, g, b);


            Label new_text = new Label();
            
            new_text.Location = new Point(border_size, h / 2);
            new_text.Text = text;
            new_text.BackColor = Color.Transparent;
            new_text.AutoSize = true;

            new_hitbox.Controls.Add(new_text);

            this.border_size = border_size;
            this.hitbox = new_hitbox;
            this.color = new_color;
            this.label = new_text;    
        }

        public override void Create(Panel panel)
        {   
            panel.Controls.Add(this.hitbox);
        }

        protected override void Draw(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(this.color, this.border_size);

            e.Graphics.DrawRectangle(pen, this.border_size / 2, this.border_size / 2, this.hitbox.Size.Width - this.border_size, this.hitbox.Size.Height - this.border_size);
        }
        protected override void Select(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (selected != null) selected.hitbox.BackColor = Color.Transparent;
                this.hitbox.BackColor = Color.Pink;
                selected = this;
            }
        }

        public override Element Clone()
        {
            return new Action(this.hitbox.Location, this.hitbox.Size, this.border_size, this.color, this.label.Text);
        }
    }
}
