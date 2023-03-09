using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Numerics;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace _8086gui_memory
{
    public partial class Form1 : Form
    {
        static string[] registerNames = { "AH", "AL", "BH", "BL", "CH", "CL", "DH", "DL" };
        static string[] operationNames = { "MOV", "XCHG", "NOT", "INC", "DEC", "AND", "OR", "XOR", "ADD", /* "SUB"*/ };
        public Form1()
        {
            initMemory();
            InitializeComponent();
            opSelector.Items.AddRange(operationNames);
            opSelector.SelectedItem = "MOV";
        }
        void initMemory()
        {
            BitArray ba = new BitArray(8);
            for(int i=0; i<ba.Length; i++)
            {
                ba[i] = false;
            }
            for (int i=0;i<65543;i++)
            {
                regValues[i] = ba;
            }
        }
        BitArray[] regValues = new BitArray[65_543];
        bool userError = false;
       BitArray hexToBin(string input)
        {
            try
            {
                string hexData;
                if (input.Length == 1) hexData = "0" + input;
                else hexData = input;
                BitArray ba = new BitArray(8);
                for (int i = 0; i < hexData.Length; i++)
                {
                    byte b = byte.Parse(hexData[i].ToString(), NumberStyles.HexNumber);
                    for (int j = 0; j < 4; j++)
                    {
                        ba.Set(i * 4 + j, (b & (1 << (3 - j))) != 0);
                    }
                }
                return ba;
            }
            catch(Exception e)
            {
                userError = true;
                MessageBox.Show("SprawdŸ poprawnoœæ danych wprowadzanych do rejestrów i spróbuj ponownie", "B³¹d",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        
        string binToHex(BitArray input)
        {
            StringBuilder sb = new StringBuilder(input.Length / 4);

            for (int i = 0; i < input.Length; i += 4)
            {
                int v = (input[i] ? 8 : 0) |
                        (input[i + 1] ? 4 : 0) |
                        (input[i + 2] ? 2 : 0) |
                        (input[i + 3] ? 1 : 0);

                sb.Append(v.ToString("x1")); 
            }

            return sb.ToString().ToUpper();
        }
        static int parseHex(string input)
        {
            try
            {
                int conv = Convert.ToInt32(input, 16);
                return conv;
            }
            catch (Exception e)
            {
                return -1;
            }
        }
        void movOperation(int reg1, int reg2)
        {
            //Debug.WriteLine("Przenoszê " + reg1 + " na miejsce " + reg2);
            regValues[reg2] = regValues[reg1];
        }
        void xchgOperation(int reg1, int reg2)
        {
            BitArray temp = regValues[reg1];
            regValues[reg1] = regValues[reg2];
            regValues[reg2] = temp;
        }
        void notOperation(int reg1)
        {
            int i = 7;
            while (i >= 0) 
            {
                if (regValues[reg1][i]) regValues[reg1][i] = false;
                else regValues[reg1][i] = true;
                i--;
            }
        }
        void incOperation(int reg1)
        {
            int i = 7;
            bool overflow = false;
            while (i >= 0)
            {
                if (regValues[reg1][i] == false)
                {
                    regValues[reg1][i] = true;
                    break;
                }
                else
                {
                    overflow = true;
                    regValues[reg1][i] = false;
                    i--;
                }
            }
        }
        void decOperation(int reg1)
        {
            int i = 7;
            while (i >= 0)
            {
                if (regValues[reg1][i])
                {
                    regValues[reg1][i] = false;
                    break;
                }
                if (!regValues[reg1][i])
                {
                    regValues[reg1][i] = true;
                }
                i--;
            }
        }
        void andOperation(int reg1, int reg2)
        {
            BitArray temp1 = regValues[reg1];
            BitArray temp2 = regValues[reg2];
            int i = 7;
            while (i >= 0)
            {
                if (temp1[i] && temp2[i]) temp1[i] = true;
                else temp1[i] = false;
                i--;
            }
            regValues[reg2] = temp2;
            regValues[reg1] = temp1;
        }
        void orOperation(int reg1, int reg2)
        {
            BitArray temp1 = regValues[reg1];
            BitArray temp2 = regValues[reg2];
            int i = 7;
            while (i >= 0)
            {
                if (temp1[i] || temp2[i]) temp1[i] = true;
                else temp1[i] = false;
                i--;
            }
            regValues[reg2] = temp2;
            regValues[reg1] = temp1;
        }

        void xorOperation(int reg1, int reg2)
        {
            BitArray temp1 = regValues[reg1];
            BitArray temp2 = regValues[reg2];
            int i = 7;
            while (i >= 0)
            {
                if (temp1[i] && temp2[i]) temp1[i] = false;
                else if (temp1[i] || temp2[i]) temp1[i] = true;
                else temp1[i] = false;
                i--;
            }
            regValues[reg2] = temp2;
            regValues[reg1] = temp1;
        }

        void addOperation(int reg1, int reg2)
        {
            BitArray temp1 = regValues[reg1];
            BitArray temp2 = regValues[reg2];
            bool carry = false;
            int i = 7;
            while (i >= 0)
            {
                if (!temp1[i] && !temp2[i] && !carry)
                {
                    temp1[i] = false;
                }
                else if ((!temp1[i] && temp2[i] && !carry) || (temp1[i] && !temp2[i] && !carry)){
                    temp1[i] = true;
                }
                else if (temp1[i] && temp2[i] && !carry)
                {
                    temp1[i] = false;
                    carry = true;
                }
                else if (temp1[i] && temp2[i] && carry)
                {
                    temp1[i] = true; 
                    carry = true;
                }
                else if ((temp1[i] && !temp2[i] && carry) || (!temp1[i] && temp2[i] && carry)){
                    temp1[i] = false;
                    carry= true;
                }
                else if (!temp1[i] && !temp2[i] && carry)
                {
                    temp1[i] = true;
                    carry = false;
                }
                i--;
            }
            regValues[reg2] = temp2;
            regValues[reg1] = temp1;
        }
        //void subOperation(int reg1, int reg2)
        //{
        //    BitArray temp1= regValues[reg1];
        //    BitArray temp2= regValues[reg2];
        //    int i
        //}

        bool oneArgOperation = false;
        private void commitOperationButton_Click(object sender, EventArgs e)
        {
            userError= false;
            //pobranie danych z rejestru
            regValues[0] = hexToBin(ahInput.Text);
            regValues[1] = hexToBin(alInput.Text);
            regValues[2] = hexToBin(bhInput.Text);
            regValues[3] = hexToBin(blInput.Text);
            regValues[4] = hexToBin(chInput.Text);
            regValues[5] = hexToBin(clInput.Text);
            regValues[6] = hexToBin(dhInput.Text);
            regValues[7] = hexToBin(dlInput.Text);

            int reg1 = -1;
            int reg2 = -1;

            bool reg1ok = true;
            bool reg2ok = true;
            if (!userError)
            {
                string reg1input = regSelector1.Text;
                string reg2input = regSelector2.Text;

                if (Array.IndexOf(registerNames, reg1input.ToUpper()) != -1)
                {
                    reg1 = Array.IndexOf(registerNames, reg1input.ToUpper());

                }
                else if (reg1input != "" && ((parseHex(reg1input) != -1 && parseHex(reg1input) <= 65535) /*|| reg1input[0] == '['*/))
                {
                    reg1 = parseHex(reg1input) + 7;
                }
                else
                {
                    reg1ok = false;
                    MessageBox.Show("SprawdŸ argument 1 operacji", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (!oneArgOperation && reg1ok)
                {
                        if (Array.IndexOf(registerNames, reg2input.ToUpper()) != -1)
                        {
                            Debug.WriteLine(Array.IndexOf(registerNames, reg2input.ToUpper()));
                            reg2 = Array.IndexOf(registerNames, reg2input.ToUpper());

                        }
                        else if (reg2input != "" && (parseHex(reg2input) != -1 && int.Parse(parseHex(reg2input).ToString()) <= 65535 /*|| reg2input[0] == '['*/))
                        {
                            // Debug.WriteLine(parseHex(reg2input));
                            reg2 = parseHex(reg2input) + 7;
                        }
                        else
                        {
                        MessageBox.Show("SprawdŸ argument 2 operacji", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reg2ok = false;
                        }
                    }
                if (reg1ok && reg2ok && !userError)
                {

                    switch (opSelector.SelectedIndex)
                    {
                        case 0: movOperation(reg1, reg2); break;
                        case 1: xchgOperation(reg1, reg2); break;
                        case 2: notOperation(reg1); break;
                        case 3: incOperation(reg1); break;
                        case 4: decOperation(reg1); break;
                        case 5: andOperation(reg1,reg2);break;
                        case 6: orOperation(reg1,reg2); break;
                        case 7: xorOperation(reg1,reg2); break;
                        case 8: addOperation(reg1,reg2); break;
                    }
                    if (!userError)
                    {
                        ahInput.Text = binToHex(regValues[0]);
                        alInput.Text = binToHex(regValues[1]);
                        bhInput.Text = binToHex(regValues[2]);
                        blInput.Text = binToHex(regValues[3]);
                        chInput.Text = binToHex(regValues[4]);
                        clInput.Text = binToHex(regValues[5]);
                        dhInput.Text = binToHex(regValues[6]);
                        dlInput.Text = binToHex(regValues[7]);
                    }
                }
            }
        }

        private void opSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (new[] { 2, 3, 4 }.Contains(opSelector.SelectedIndex))
            {
                regSelector2.Enabled = false;
                oneArgOperation = true;
            }
            else
            {
                regSelector2.Enabled = true;
                oneArgOperation = false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = memoryInput.Text;
            if (input!=null && parseHex(input) != -1 && parseHex(input) <= 65535)
            {
                memoryOutput.Text = binToHex(regValues[parseHex(input) + 7]).ToString();
            }
            else
            {
                memoryOutput.Text = "B³¹d adresu";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string input = memoryInput1.Text;
            string data = memoryOutput1.Text;
            if (System.Text.RegularExpressions.Regex.IsMatch(data, @"\A\b[0-9a-fA-F]+\b\Z") && input != null && parseHex(input) != -1 && parseHex(input) <= 65535)
            {
                try
                {
                    regValues[parseHex(input) + 7] = hexToBin(memoryOutput1.Text);
                    memoryOutput1.Text = "OK!";
                }
                catch (Exception e1)
                {
                    memoryOutput1.Text = "B³¹d danych";
                }
            }
            else
            {
                memoryOutput1.Text = "B³¹d danych";
            }
        }
    }
}