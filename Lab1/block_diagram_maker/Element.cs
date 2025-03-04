using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace block_diagram_maker
{
    internal abstract class Element
    {   
        public Panel hitbox;
        public Label label;
        public Color color;
        public int border_size;
        public static Element selected;
        public abstract void Create(Panel panel);
        protected abstract void Draw(object sender, PaintEventArgs e);
        protected abstract void Select(object sender, MouseEventArgs e);
        public abstract Element Clone();
    }
}
