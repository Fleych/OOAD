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

namespace MiniKompik16
{
    public partial class Form1 : Form
    {
        private Translator translator;
        private Memory memory;
        private CPU cpu;
        private Computer computer;
        public Form1()
        {
            InitializeComponent();
            //With patern

            translator = new Translator();
            memory = new Memory();
            cpu = new CPU();
            computer = new Computer(translator, memory, cpu);

            //Without patern
            /*
            translator = new Translator();
            memory = new Memory();
            cpu = new CPU();
             */
        }

        private void UpdateDisplay()
        {
            //With patern
            label_reg0_value.Text = computer.GetRegisterValue(0).ToString();
            label_reg1_value.Text = computer.GetRegisterValue(1).ToString();
            label_reg2_value.Text = computer.GetRegisterValue(2).ToString();
            label_reg3_value.Text = computer.GetRegisterValue(3).ToString();
            label_reg4_value.Text = computer.GetRegisterValue(4).ToString();
            label_reg5_value.Text = computer.GetRegisterValue(5).ToString();
            label_reg6_value.Text = computer.GetRegisterValue(6).ToString();
            label_reg7_value.Text = computer.GetRegisterValue(7).ToString();
            label_reg8_value.Text = computer.GetRegisterValue(8).ToString();
            label_reg9_value.Text = computer.GetRegisterValue(9).ToString();
            label_reg10_value.Text = computer.GetRegisterValue(10).ToString();
            label_reg11_value.Text = computer.GetRegisterValue(11).ToString();
            label_reg12_value.Text = computer.GetRegisterValue(12).ToString();
            label_reg13_value.Text = computer.GetRegisterValue(13).ToString();
            label_reg14_value.Text = computer.GetRegisterValue(14).ToString();
            label_reg15_value.Text = computer.GetRegisterValue(15).ToString();

            label_line_value.Text = computer.GetCurrentLine().ToString();

            //Without patern
            /*
            label_reg0_value.Text = cpu.Registrs[0].ToString();
            label_reg1_value.Text = cpu.Registrs[1].ToString();
            label_reg2_value.Text = cpu.Registrs[2].ToString();
            label_reg3_value.Text = cpu.Registrs[3].ToString();
            label_reg4_value.Text = cpu.Registrs[4].ToString();
            label_reg5_value.Text = cpu.Registrs[5].ToString();
            label_reg6_value.Text = cpu.Registrs[6].ToString();
            label_reg7_value.Text = cpu.Registrs[7].ToString();
            label_reg8_value.Text = cpu.Registrs[8].ToString();
            label_reg9_value.Text = cpu.Registrs[9].ToString();
            label_reg10_value.Text = cpu.Registrs[10].ToString();
            label_reg11_value.Text = cpu.Registrs[11].ToString();
            label_reg12_value.Text = cpu.Registrs[12].ToString();
            label_reg13_value.Text = cpu.Registrs[13].ToString();
            label_reg14_value.Text = cpu.Registrs[14].ToString();
            label_reg15_value.Text = cpu.Registrs[15].ToString();
            
            label_line_value.Text = cpu.ProgramCounter.ToString();
            */
        }

        private void button_step_Click(object sender, EventArgs e)
        {
            //With patern
            computer.RunProrgam(textBox_instructions.Lines.ToList(), textBox_data.Lines.ToList());

            //Without patern
            /*
            memory.Instructions = translator.TranslateInstuctions(textBox_instructions.Lines.ToList());
            memory.Data = translator.TranslateData(textBox_data.Lines.ToList());
            cpu.Tick(memory);
            */
            UpdateDisplay();
        }

        private void button_restart_Click(object sender, EventArgs e)
        {
            //With patern
            computer.Restart();

            //Without patern
            /*
            memory.Instructions.Clear();
            memory.Data.Clear();
            cpu.Reset();
            */

            UpdateDisplay();
        }
    }
}
