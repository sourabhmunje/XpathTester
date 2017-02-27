using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpathTester
{
    public partial class Introduction : Form
    {
        Assembly assembly = Assembly.GetExecutingAssembly();
        public Introduction()
        {
            InitializeComponent();
            panel1.Visible = false;
            pictureBox1.BackgroundImage = XpathTester.Resource1.Xpath_main_image;
            panelstart.Visible = true;
            this.buttonplay.Image = XpathTester.Resource1.Try_now_;
            this.buttonreturn.Image = XpathTester.Resource1.Return;
            this.buttonrules.Image = XpathTester.Resource1.Tutorial;
            this.buttonsyntax.Image = XpathTester.Resource1.Syntax_title;
            this.buttonexample.Image = XpathTester.Resource1.Examples;
            this.buttonnodes.Image = XpathTester.Resource1.Nodes_Title;
            this.buttonoperators.Image = XpathTester.Resource1.Operators_title;
            this.buttonaxes.Image = XpathTester.Resource1.Axes_title;
            this.buttonintro.Image = XpathTester.Resource1.Introduction;
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = XpathTester.Resource1.Syntax;
            panel1.Visible = false;
        }

        private void buttonrules_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panelstart.Visible = false;
        }

        private void buttonexample_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = XpathTester.Resource1.xmlexample;
        }

        private void buttonintro_Click(object sender, EventArgs e)
        {
            //buttonintro_Click.OnMouseHover();
            pictureBox1.BackgroundImage = XpathTester.Resource1.Intro_1;
        }
        private void OnMouseHover()
        {
            buttonintro.BringToFront();
        }


        private void buttonnodes_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = XpathTester.Resource1.Nodes_1;
        }

        private void buttonoperators_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = XpathTester.Resource1.Operators;
        }

        private void buttonsyntax_Click(object sender, EventArgs e)
        {

            pictureBox1.BackgroundImage = XpathTester.Resource1.Syntax;
        }

        private void buttonreturn_Click(object sender, EventArgs e)
        {
            
            panel1.Visible = false;
            panelstart.Visible = true;
            pictureBox1.BackgroundImage = XpathTester.Resource1.Xpath_main_image;
        }

        private void buttonplay_Click(object sender, EventArgs e)
        {

            this.Hide();
            baseForm baseform = new baseForm();
            this.Owner = baseform;
            baseform.Show();
            
        }
        private void buttonplay__MouseEnter(object sender, EventArgs e)
        {
            //Code for Image Appearance.
            buttonplay.Text = "Enter";
        }

        private void buttonplay_MouseLeave(object sender, EventArgs e)
        {
            //Code for Image Appearance.
            buttonplay.Text = "Normal";
        }

        private void Introduction_Load(object sender, EventArgs e)
        {

        }

        private void buttonaxes_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = XpathTester.Resource1.Axes_desc;
        }
        
    }
}
