using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALIAS.Controls
{
    public partial class ArtTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        //Constructor
        public ArtTextBox()
        {
            InitializeComponent();
        }

        //Events


        // Generate properties from the fields (выделить поля нажать пкм и выбрать "ьыстрые действия и рефакторинг" а потом "инкапсулировать поля и исп св-ва")
        public Color BorderColor
        {
            get
            {
                return borderColor; 
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            } 
        }

        //Overriden methods

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border of the textbox
            using (Pen penBorder = new Pen(BorderColor, BorderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else // Normal Style
                    graph.DrawRectangle(penBorder,0,0,this.Width-0.5F,this.Height-0.5F);
            }
        }

        //To update and set a proper Height on user textbox
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode) // to reduce cost at runtime
                UpdateControlHeight();
        }

        //set a proper height at runtime. A finishing touch
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        //метод устанавливает высоту
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }
    }
}
