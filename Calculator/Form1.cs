using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    
    public partial class FormMain : Form
    {
        
        [System.Runtime.InteropServices.DllImport("user32.dll")]


        static extern bool HideCaret(IntPtr hWnd);

        RichTextBox resultbox;
        int resultBoxTextSize = 24;

        struct ButtonStruct
        {
            public char Content;
            public bool IsBold;
            public bool IsNumber;
            public bool IsdecimalSeparator;
            public bool IsPlusMinusSign;
            
            public ButtonStruct(char content, bool IsBold, bool IsNumber=false, bool decimalseparator=false, bool sign=false)//costruttore della struct. IsNumber=false è un default
            {
                this.Content = content;
                this.IsBold = IsBold;
                this.IsNumber = IsNumber;
                this.IsdecimalSeparator = decimalseparator;
                this.IsPlusMinusSign = sign;
                

            }
            public override string ToString()
            {
                //permette di andare a ridefinire il comportamento di tostring() sulla struct in Content
                return Content.ToString();
            }
        }

        private ButtonStruct[,] buttons =
        {
            { new ButtonStruct('%', false),  new ButtonStruct('Œ', false),  new ButtonStruct('C', false),  new ButtonStruct('', false) },
            { new ButtonStruct('⅟', false),  new ButtonStruct('²', false),  new ButtonStruct('⎷', false),  new ButtonStruct('÷', false) },
            { new ButtonStruct('7', true, true),  new ButtonStruct('8', true, true),  new ButtonStruct('9', true, true),  new ButtonStruct('×', false) },
            { new ButtonStruct('4', true, true),  new ButtonStruct('5', true, true),  new ButtonStruct('6', true, true),  new ButtonStruct('-', false) },
            { new ButtonStruct('1', true, true),  new ButtonStruct('2', true, true),  new ButtonStruct('3', true, true),  new ButtonStruct('+', false) },
            { new ButtonStruct('±', false, false, false, true),  new ButtonStruct('0', true, true),  new ButtonStruct(',', false, false, true),  new ButtonStruct('=', false) }
        };
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            
            MakeResultBox();
            MakeButtons(buttons);
        }

        private void MakeResultBox()
        {
            
            resultbox = new RichTextBox();
            resultbox.ReadOnly = true;
            resultbox.SelectionAlignment = HorizontalAlignment.Right;//allineamento a destra
            resultbox.Font = new Font("Segoe UI", resultBoxTextSize, FontStyle.Regular);
            resultbox.Width = this.Width - 16; //this.width=largheza della form
            resultbox.Height = 120;
            resultbox.Text = "0";
            resultbox.ReadOnly = true;
            resultbox.TabStop = false;
            resultbox.GotFocus += Resultbox_HideCaretHandler;
            resultbox.MouseDown += Resultbox_HideCaretHandler;
            resultbox.SelectionChanged += Resultbox_HideCaretHandler;
            resultbox.TextChanged += Resultbox_TextChanged;
        

            this.Controls.Add(resultbox);
            

        }

        private void Resultbox_TextChanged(object sender, EventArgs e)
        {
            HideCaret(resultbox.Handle);
            int newSize = resultBoxTextSize - resultbox.Text.Length + 12;
            if (newSize > 8 && newSize < resultBoxTextSize+1) 
            {
                resultbox.Font = new Font("Segoe UI", newSize, FontStyle.Regular);
            }

            if (resultbox.Text.Length >= 6)
                resultbox.Text += ".";
            
        }

        private void Resultbox_HideCaretHandler(object sender, EventArgs e)
        {
            HideCaret(resultbox.Handle);

        }


        private void MakeButtons(ButtonStruct[,] buttons)
        {
            int buttonWidth = 82, buttonHeight = 60;
            int posX = 0;
            int posY = 110;
            //creazione dinamica dei bottoni
            for (int i = 0; i < buttons.GetLength(0); i++)
            {
                for (int j = 0; j < buttons.GetLength(1); j++)
                {
                    ButtonStruct myButtonStruct = buttons[i, j];//struttura
                    Button myButton = new Button();//bottone
                    FontStyle mybuttonstyle = myButtonStruct.IsBold ? FontStyle.Bold : FontStyle.Regular;//versione più compatta dell' if else
                    
                    myButton.Font = new Font("Segoe UI", 16, mybuttonstyle);
                    myButton.Text = buttons[i, j].ToString(); //override di ToString il programma legge Content.ToString();
                    myButton.Width = buttonWidth;
                    myButton.Height = buttonHeight;
                    this.Controls.Add(myButton);
                    myButton.Left = posX;
                    myButton.Top = posY;
                    myButton.Tag = myButtonStruct;//tag è un object, quindi si può mettere quello che si vuole. Tag permette di dare un attributo
                    myButton.Click += Button_Click;
                    posX += buttonWidth;
                }
                posX = 0;
                posY += buttonHeight;
            }
        }

        private void Button_Click(object sender, EventArgs e)//sender: colui che ci ha mandato qui una volta attivato l'evento
        {
            Button clickedbutton = (Button)sender;
            ButtonStruct clickedbuttonstruct = (ButtonStruct)clickedbutton.Tag;

            if (clickedbuttonstruct.IsNumber)
            {
                if (resultbox.Text == "0")
                    resultbox.Text = "";
                resultbox.Text += clickedbutton.Text;
                
            }
            else
            {
                if (clickedbuttonstruct.IsdecimalSeparator)
                {
                    if (!(resultbox.Text.Contains(clickedbuttonstruct.Content)))
                        resultbox.Text += clickedbutton.Text;
                }
                
                if (clickedbuttonstruct.IsPlusMinusSign && resultbox.Text!="0")
                    resultbox.Text = resultbox.Text.StartsWith("-") ? resultbox.Text.Replace("-", "") : "-" + resultbox.Text;
                else
                {
                    switch (clickedbuttonstruct.Content)
                    {
                        case 'C':
                            resultbox.Text = "0";
                            break;
                        case '':
                            resultbox.Text = resultbox.Text.Remove(resultbox.Text.Length - 1);
                            if (resultbox.Text.Length == 0 || resultbox.Text=="-" || resultbox.Text=="-0")
                                resultbox.Text = "0";
                            
                            break;
                    }
                }
                    
                       
                
                
            }
            



        }

        private void FormMain_Activated(object sender, EventArgs e)
        {
            resultbox.TabStop = true;
        }

        
    }
}
