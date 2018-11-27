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
        int A = 2, B = 2, C = 2, D = 2, E = 2;
        private void Add_Click(object sender, EventArgs e)
        {
            // + click button to add new text box
            AddNewTextBox();
            AddNewTextBox2();
            AddNewComboBox();
            AddButton();
            DelButton();
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
            cb.Name = "comboBox" + this.C.ToString();
            cb.Text = "";
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
        private void DeleteButton(object sender, EventArgs e)
        {
            Button Del = (sender as Button);
            string name = Del.Name;
            name = name.Replace("Del", "");
            Control[] cntrls1 = this.Controls.Find("tbCName" + name, false);
            Control[] cntrls2 = this.Controls.Find("tbData" + name, false);
            Control[] cntrls3 = this.Controls.Find("comboBox" + name, false);
            Control[] cntrls4 = this.Controls.Find("Button" + name, false);
            TextBox txt = cntrls1[0] as TextBox;
            TextBox txt2 = cntrls2[0] as TextBox;
            ComboBox cb = cntrls3[0] as ComboBox;
            Button Bt = cntrls4[0] as Button;
            if (this.Controls.Contains(txt))
            {
                this.Controls.Remove(Bt);
                this.Controls.Remove(cb);
                this.Controls.Remove(txt2);
                this.Controls.Remove(txt);
                this.Controls.Remove(Del);
            }
        }
        #endregion
        private void Correction1(object sender, EventArgs e)
        {
            Control.ControlCollection controlList = this.Controls;
            int i = 2, j = 2, k = 0, l = 2, m = 2, n = 2;
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
                }
            }
            A = A - 1;
            B--;
            C--;
            D--;
            E--;
        }
        private void ClearRText_Click(object sender, EventArgs e)
        {
            Rtext.Text = string.Empty;
            Rtext.Text += "[";
        }
        public void Calculation()
        {
            #region Create arrays from inputs to calculate 
            List<kvObject> kvObjList = new List<kvObject>();

            Control.ControlCollection controlList = this.Controls;

            List<string> Array1 = new List<string>();
            List<string> Array2 = new List<string>();
            List<string> ComBox = new List<string>();

            int i = 1, j = 1, k = 0, l = 1;
            foreach (Control item in controlList)
            {
                //Keys
                if (item.Name == "tbCName" + i.ToString())
                {
                    Array1.Add(item.Text);
                    i++;
                }

                //Values
                if (item.Name == "tbData" + j.ToString())
                {
                    Array2.Add(item.Text);
                    j++;
                }
                //String or Int
                if (item.Name == "comboBox" + l.ToString())
                {
                    ComBox.Add(item.Text);
                    l++;
                }
            }

            //Creates objects from keys and values

            // **** kvObjList.Select(x => x.Key).ToArray<string>();****
            string[] ArrayJ1 = Array1.ToArray();
            string[] ArrayJ2 = Array2.ToArray();
            string[] CombBox = ComBox.ToArray();
            #endregion
            #region String Or Int
            int[] ArrayJ3 = new int[Array1.Count];
            string[] ArrayJ4 = new string[Array1.Count];
            foreach (string val in Array2)
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
                        }

                    }
                    else if (CombBox[q] == "int")
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
            else if (o == 0)
            {
                MessageBox.Show("Add JSON to create JSON");
            }
        }
        private void AddJson_Click_1(object sender, EventArgs e)
        {

            Calculation();
            Rtext.Text += ",";
            o++;
        }

    }
}
