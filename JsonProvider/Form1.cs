using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;






namespace JsonProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Rtext.Text += "[";
        }
        #region Add New Text
        int A = 2, B = 2, C = 2, D = 2, E = 2, F = 2;
        private void Add_Click(object sender, EventArgs e)
        {
            // + click button to add new text box
            AddNewTextBox();
            AddNewTextBox2();
            AddNewComboBox();
            AddButton();
            DelButton();
            AddNewCheckBox();
        }
        List<TextBox> TextBoxAdded = new List<TextBox>();
        public System.Windows.Forms.TextBox AddNewTextBox()
        {
            // new column name text box
            System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt);
            txt.Top = (A * 28);
            txt.Left = 15;
            txt.Name = "tbCName" + this.A.ToString();
            txt.Text = "";
            A = A + 1;
            TextBoxAdded.Insert(0, txt);
            return txt;
        }
        List<TextBox> TextBoxAdded2 = new List<TextBox>();
        public System.Windows.Forms.TextBox AddNewTextBox2()
        {
            // new data text box
            System.Windows.Forms.TextBox txt2 = new System.Windows.Forms.TextBox();
            this.Controls.Add(txt2);
            txt2.Top = (B * 28);
            txt2.Left = 121;
            txt2.Name = "tbData" + this.B.ToString();
            txt2.Text = "";
            B = B + 1;
            TextBoxAdded2.Insert(0, txt2);
            return txt2;
        }
        List<ComboBox> ComboBoxAdded = new List<ComboBox>();
        public System.Windows.Forms.ComboBox AddNewComboBox()
        {
            /// new  comboBox (string or int)
            System.Windows.Forms.ComboBox cb = new System.Windows.Forms.ComboBox();
            this.Controls.Add(cb);
            cb.Top = (C * 28);
            cb.Left = 227;
            cb.Items.Add("string");
            cb.Items.Add("int");
            cb.Items.Add("decimal");
            cb.Name = "comboBox" + this.C.ToString();
            cb.Text = "";
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
            C = C + 1;
            ComboBoxAdded.Insert(0, cb);
            return cb;
        }
        List<Button> buttonsAdded = new List<Button>();
        public Button AddButton()
        {
            Button Bt = new Button();
            this.Controls.Add(Bt);
            Bt.Name = "Button" + D.ToString();
            Bt.Text = "+";
            Bt.Top = (D * 28);
            Bt.Left = 354;
            Bt.Size = new Size(23, 23);
            D++;
            buttonsAdded.Insert(0, Bt);
            Bt.Click += (s, r) =>
            {
                AddButton();
                AddNewTextBox();
                AddNewTextBox2();
                AddNewComboBox();
                DelButton();
                AddNewCheckBox();
            };
            return Bt;
        }
        public Button DelButton()
        {
            Button Del = new Button();
            this.Controls.Add(Del);
            Del.Name = "Del" + E.ToString();
            Del.Text = "-";
            Del.Top = (E * 28);
            Del.Left = 380;
            Del.Size = new Size(23, 23);
            E++;
            Del.Click += new EventHandler(DeleteButton);
            Del.Click += new EventHandler(Correction1);
            return Del;
        }
        List<CheckBox> CheckBoxAdded = new List<CheckBox>();
        public CheckBox AddNewCheckBox()
        {
            CheckBox chB = new CheckBox();
            this.Controls.Add(chB);
            chB.Top = (F * 28);
            chB.Left = 420;
            chB.Name = "Randm" + this.F.ToString();
            chB.Text = "";
            F = F + 1;
            CheckBoxAdded.Insert(0, chB);
            chB.Click += new EventHandler(Randm1_CheckedChanged);
            return chB;
        }
        private void DeleteButton(object sender, EventArgs e)
        {
            Button Del = (sender as Button);
            string name = Del.Name;
            name = name.Replace("Del", "");
            Control[] cntrls1 = this.Controls.Find("tbCName" + name, false);
            Control[] cntrls2 = this.Controls.Find("tbData" + name, false);
            Control[] cntrls3 = this.Controls.Find("comboBox" + name, false);
            Control[] cntrls4 = this.Controls.Find("Button" + name, false);
            Control[] cntrls5 = this.Controls.Find("Randm" + name, false);
            TextBox txt = cntrls1[0] as TextBox;
            TextBox txt2 = cntrls2[0] as TextBox;
            ComboBox cb = cntrls3[0] as ComboBox;
            Button Bt = cntrls4[0] as Button;
            CheckBox chB = cntrls5[0] as CheckBox;
            if (this.Controls.Contains(txt))
            {
                this.Controls.Remove(Bt);
                this.Controls.Remove(cb);
                this.Controls.Remove(txt2);
                this.Controls.Remove(txt);
                this.Controls.Remove(Del);
                this.Controls.Remove(chB);
            }
        }
        #endregion
        private void Correction1(object sender, EventArgs e)
        {
            Control.ControlCollection controlList = this.Controls;
            int i = 2, j = 2, k = 0, l = 2, m = 2, n = 2, p = 2;
            for (int q = 2; q < A; q++)
            {

                foreach (Control item in controlList)
                {
                    if (item.Name == "tbCName1")
                    {
                        item.Name = "tbCName1";
                    }
                    if (item.Name == "tbCName" + q.ToString())
                    {
                        item.Name = "tbCName" + i.ToString();
                        item.Top = 28 * i;
                        i = i + 1;
                    }
                    if (item.Name == "tbData" + q.ToString())
                    {
                        item.Name = "tbData" + j.ToString();
                        item.Top = 28 * j;
                        j++;
                    }
                    if (item.Name == "comboBox" + q.ToString())
                    {
                        item.Name = "comboBox" + l.ToString();
                        item.Top = 28 * l;
                        l++;
                    }
                    if (item.Name == "Button" + q.ToString())
                    {
                        item.Name = "Button" + m.ToString();
                        item.Top = 28 * m;
                        m++;
                    }
                    if (item.Name == "Del" + q.ToString())
                    {
                        item.Name = "Del" + n.ToString();
                        item.Top = 28 * n;
                        n++;
                    }
                    if (item.Name == "Randm" + q.ToString())
                    {
                        item.Name = "Randm" + p.ToString();
                        item.Top = 28 * p;
                        p++;
                    }
                }
            }
            A = A - 1;
            B--;
            C--;
            D--;
            E--;
            F--;
        }
        private void ClearRText_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public void Clear()
        {

            Rtext.Text = string.Empty;
            Rtext.Text += "[";

        }
        private void Randm1_CheckedChanged(object sender, EventArgs e)
        {
            var selectedCheckbox = ((System.Windows.Forms.CheckBox)sender);
            var index = selectedCheckbox.Name.Replace("Randm", "");
            var control = (System.Windows.Forms.TextBox)this.Controls.Find("tbData" + index, false).First();
            if (selectedCheckbox.Checked) control.Enabled = false;
            else control.Enabled = true;
        }
        public static string GenerateRnd(int length, Random random)
        {
            string characters = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }
        public void Calculation()
        {
            #region Create arrays from inputs to calculate 
            List<kvObject> kvObjList = new List<kvObject>();

            Control.ControlCollection controlList = this.Controls;

            //List<string> Array1 = new List<string>();
            //List<string> Array2 = new List<string>();
            //List<string> ComBox = new List<string>();
            //List<string> ChBox = new List<string>();

            //var control1 = (System.Windows.Forms.TextBox)this.Controls.Find("tbCName" + indexStr, false).First();
            //var control2 = (System.Windows.Forms.TextBox)this.Controls.Find("tbData" + indexStr, false).First();
            //var control3 = (System.Windows.Forms.TextBox)this.Controls.Find("comboBox" + indexStr, false).First();
            //var control4 = (System.Windows.Forms.TextBox)this.Controls.Find("Randm" + indexStr, false).First();

            //Array1.Add(control1.Text);
            //Array2.Add(control2.Text);
            //ComBox.Add(control3.Text);
            //ChBox.Add(control4.Text);

            List<string> Array1 = new List<string>();
            List<string> Array2 = new List<string>();
            List<string> ComBox = new List<string>();
            List<string> ChBox = new List<string>();
            int i = 1, j = 1, k = 0, l = 1, m = 1;
            foreach (Control item in controlList)
            {
                if (item.Name == "tbCName" + i.ToString())
                {
                    Array1.Add(item.Text);
                    i++;
                }
                if (item.Name == "tbData" + j.ToString())
                {
                    Array2.Add(item.Text);
                    j++;
                }
                if (item.Name == "comboBox" + l.ToString())
                {
                    ComBox.Add(item.Text);
                    l++;
                }
                if (item.Name == "Randm" + m.ToString())
                {
                    ChBox.Add(((CheckBox)item).Checked.ToString());
                    m++;
                }
            }


            //Creates objects from keys and values
            // **** kvObjList.Select(x => x.Key).ToArray<string>();****
            string[] ArrayJ1 = Array1.ToArray();
            string[] ArrayJ2 = Array2.ToArray();
            string[] CombBox = ComBox.ToArray();
            string[] ChecBox = ChBox.ToArray();
            #endregion
            for (int r = 0; r < Array1.Count; r++)
            {
                if (ChecBox[r] == "True")
                {
                    if (CombBox[r] == "string")
                    {
                        Random rnd = new Random();
                        string[] coupon = new string[Array1.Count];
                        for (int g = 0; g < coupon.Length; g++)
                        {
                            coupon[g] = GenerateRnd(15, rnd);
                        }
                        ArrayJ2[r] = coupon[r];
                    }
                    else if (CombBox[r] == "int")
                    {
                        int[] Num = new int[Array1.Count];
                        Random NumGen = new Random();
                        for (int g = 0; g < Num.Length; g++)
                        {
                            Num[g] = NumGen.Next(1, 1000000000);
                        }
                        ArrayJ2[r] = Num[r].ToString();
                    }
                }
            }
            #region String Or Int
            
            int[] ArrayJ3 = new int[Array1.Count];
            string[] ArrayJ4 = new string[Array1.Count];
            foreach (string val in ArrayJ2)
            {
                bool success = Int32.TryParse(val, out int number);
                if (success)
                {
                    ArrayJ3[k] = Convert.ToInt32(val.ToString());
                    // MessageBox.Show(k.ToString() + "=>" + ArrayJ3[k] + "=>int");
                }
                else
                {
                    ArrayJ4[k] = val.ToString();
                    // MessageBox.Show(k.ToString() + "=>" + ArrayJ4[k] + "=>string");
                }
                k++;
            }
            #endregion
            #region Calculation

            Rtext.Text += "{" + Environment.NewLine;
            for (int q = 0; q < Array1.Count; q++)
            {
                if (ArrayJ1[q].ToString() == "" || ArrayJ2[q].ToString() == "" || CombBox[q] == "")
                {
                    MessageBox.Show("Empty Text Box" + (q + 1) + ".line");
                    Clear();
                    break;
                }
                else
                {
                    if (CombBox[q] == "string")
                    {
                        try
                        {
                            string Json = "\"" + ArrayJ1[q].ToString() + "\"" + ":" + "\"" + ArrayJ4[q].ToString() + "\"";
                            Rtext.Text += Json;
                            //MessageBox.Show(Json);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Empty Text Box" + (q + 1) + ".line or wrong combobox item selected");
                            Clear();
                            break;
                        }
                    }
                    else if (CombBox[q] == "int")
                    {
                        if (ArrayJ3[q].ToString() == ArrayJ2[q].ToString())
                        {
                            try
                            {
                                string Json = "\"" + ArrayJ1[q].ToString() + "\"" + ":" + ArrayJ3[q].ToString();
                                Rtext.Text += Json;
                                //MessageBox.Show(Json);
                            }
                            catch
                            {
                                MessageBox.Show("Empty Text Box" + (q + 1) + ".line");
                                Clear();
                                break;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Value is not integer!!!" + (q + 1) + ".line");
                            Clear();
                            break;
                        }

                    }
                    if (q < (Array1.Count - 1))
                    {
                        Rtext.Text += ",";
                    }
                }
            }
            Rtext.Text += Environment.NewLine + "}";
            #endregion
        }
        int o = 0;
        private void Create_Click_1(object sender, EventArgs e)
        {
            if (o >= 1)
            {
                string s = Rtext.Text;
                if (s.Length > 1)
                {
                    s = s.Substring(0, s.Length - 1);
                }
                Rtext.Text = s;
                Rtext.Text += "]";
                System.IO.File.WriteAllText(@"" + TextJson.Text + ".json", Rtext.Text);
            }
            else if (o == 0) MessageBox.Show("Add JSON to create JSON");
        }
        private void AddJson_Click_1(object sender, EventArgs e)
        {
            //var clickedButton = ((System.Windows.Forms.Button)sender);
            //var indexStr = clickedButton.Name.Replace("Button", "");
            //Calculation(indexStr);

            Calculation();
            Rtext.Text += ",";
            o++;
        }
    }
}
