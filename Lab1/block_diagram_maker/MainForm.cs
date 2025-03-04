using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace block_diagram_maker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        static List<Element> elements = new List<Element>();

        static Arrow sample_arrow = new Arrow(new Point(0, 0), new Size(100, 100), 1, Color.Black, "New Arrow");
        static StartStop sample_start_stop = new StartStop(new Point(0, 0), new Size(100, 100), 4, Color.Red, "New Start/Stop");
        static Action sample_action = new Action(new Point(0, 0), new Size(100, 100), 4, Color.Black, "New Action");
        static Condition sample_condition = new Condition(new Point(0, 0), new Size(100, 100), 4, Color.Black, "New Condition");

        static Element buffer = sample_action;

        private void ToolStripButton_Arrow_Click(object sender, EventArgs e)
        {
            buffer = sample_arrow;

            ToolStripButton_Arrow.Checked = true;
            ToolStripButton_StartStop.Checked = false;
            ToolStripButton_Action.Checked = false;
            ToolStripButton_Condition.Checked = false;
        }

        private void ToolStripButton_StartStop_Click(object sender, EventArgs e)
        {
            buffer = sample_start_stop;

            ToolStripButton_Arrow.Checked = false;
            ToolStripButton_StartStop.Checked = true;
            ToolStripButton_Action.Checked = false;
            ToolStripButton_Condition.Checked = false;
        }

        private void ToolStripButton_Action_Click(object sender, EventArgs e)
        {
            buffer = sample_action;

            ToolStripButton_Arrow.Checked = false;
            ToolStripButton_StartStop.Checked = false;
            ToolStripButton_Action.Checked = true;
            ToolStripButton_Condition.Checked = false;
        }

        private void ToolStripButton_Condition_Click(object sender, EventArgs e)
        {
            ToolStripButton_Arrow.Checked = false;
            ToolStripButton_StartStop.Checked = false;
            ToolStripButton_Action.Checked = false;
            ToolStripButton_Condition.Checked = true;

            buffer = sample_condition;
        }

        private void Panel_Draw_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //With pattern
                
                Element new_element = buffer.Clone();
                elements.Add(new_element);
                new_element.hitbox.Location = new Point(e.X, e.Y);
                new_element.Create(Panel_Draw);

                //

                //Without pattern
                /*
                if (buffer is Arrow)
                {
                    Arrow new_element = new Arrow(new Point(e.X, e.Y), buffer.hitbox.Size, buffer.border_size, buffer.color, buffer.label.Text);
                    elements.Add(new_element);
                    new_element.Create(Panel_Draw);
                }
                if (buffer is StartStop)
                {
                    StartStop new_element = new StartStop(new Point(e.X, e.Y), buffer.hitbox.Size, buffer.border_size, buffer.color, buffer.label.Text);
                    elements.Add(new_element);
                    new_element.Create(Panel_Draw);
                }
                if (buffer is Action)
                {
                    Action new_element = new Action(new Point(e.X, e.Y), buffer.hitbox.Size, buffer.border_size, buffer.color, buffer.label.Text);
                    elements.Add(new_element);
                    new_element.Create(Panel_Draw);
                }
                if (buffer is Condition)
                {
                    Condition new_element = new Condition(new Point(e.X, e.Y), buffer.hitbox.Size, buffer.border_size, buffer.color, buffer.label.Text);
                    elements.Add(new_element);
                    new_element.Create(Panel_Draw);
                }
                */
                //
            }
        }

        private void ToolStripButton_ColorBlack_Click(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.color = Color.Black;
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.color = Color.Black;
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            { 
                sample_action.color = Color.Black;
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.color = Color.Black;
                buffer = sample_condition;
            }
        }

        private void ToolStripButton_ColorRed_Click(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.color = Color.Red;
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.color = Color.Red;
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.color = Color.Red;
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.color = Color.Red;
                buffer = sample_condition;
            }
        }

        private void ToolStripButton_ColorGreen_Click(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.color = Color.Green;
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.color = Color.Green;
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.color = Color.Green;
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.color = Color.Green;
                buffer = sample_condition;
            }
        }

        private void ToolStripButton_ColorBlue_Click(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.color = Color.Blue;
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.color = Color.Blue;
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.color = Color.Blue;
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.color = Color.Blue;
                buffer = sample_condition;
            }
        }

        private void ToolStripTextBox_Width_TextChanged(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.hitbox.Width = int.Parse(ToolStripTextBox_Width.Text);
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.hitbox.Width = int.Parse(ToolStripTextBox_Width.Text);
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.hitbox.Width = int.Parse(ToolStripTextBox_Width.Text);
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.hitbox.Width = int.Parse(ToolStripTextBox_Width.Text);
                buffer = sample_condition;
            }
        }

        private void ToolStripTextBox_Height_TextChanged(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.hitbox.Height = int.Parse(ToolStripTextBox_Height.Text);
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.hitbox.Height = int.Parse(ToolStripTextBox_Height.Text);
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.hitbox.Height = int.Parse(ToolStripTextBox_Height.Text);
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.hitbox.Height = int.Parse(ToolStripTextBox_Height.Text);
                buffer = sample_condition;
            }
        }

        private void ToolStripTextBox_BorderSize_TextChanged(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.border_size = int.Parse(ToolStripTextBox_BorderSize.Text);
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.border_size = int.Parse(ToolStripTextBox_BorderSize.Text);
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.border_size = int.Parse(ToolStripTextBox_BorderSize.Text);
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.border_size = int.Parse(ToolStripTextBox_BorderSize.Text);
                buffer = sample_condition;
            }
        }

        private void ToolStripTextBox_Text_TextChanged(object sender, EventArgs e)
        {
            if (ToolStripButton_Arrow.Checked)
            {
                sample_arrow.label.Text = ToolStripTextBox_Text.Text;
                buffer = sample_arrow;
            }
            if (ToolStripButton_StartStop.Checked)
            {
                sample_start_stop.label.Text = ToolStripTextBox_Text.Text;
                buffer = sample_start_stop;
            }
            if (ToolStripButton_Action.Checked)
            {
                sample_action.label.Text = ToolStripTextBox_Text.Text;
                buffer = sample_action;
            }
            if (ToolStripButton_Condition.Checked)
            {
                sample_condition.label.Text = ToolStripTextBox_Text.Text;
                buffer = sample_condition;
            }
        }

        private void ToolStripButton_Copy_Click(object sender, EventArgs e)
        {
            //With pattern
            
            if (Element.selected != null) buffer = Element.selected.Clone();
            
            //Without pattern
            /*  
            if (Element.selected != null)
            {
                if (Element.selected is Arrow) buffer = new Arrow(Element.selected.hitbox.Location, Element.selected.hitbox.Size, Element.selected.border_size, Element.selected.color, Element.selected.label.Text);
                if (Element.selected is StartStop) buffer = new StartStop(Element.selected.hitbox.Location, Element.selected.hitbox.Size, Element.selected.border_size, Element.selected.color, Element.selected.label.Text);
                if (Element.selected is Action) buffer = new Action(Element.selected.hitbox.Location, Element.selected.hitbox.Size, Element.selected.border_size, Element.selected.color, Element.selected.label.Text);
                if (Element.selected is Condition) buffer = new Condition(Element.selected.hitbox.Location, Element.selected.hitbox.Size, Element.selected.border_size, Element.selected.color, Element.selected.label.Text);
            }
            */
            //
        }
    }
}
