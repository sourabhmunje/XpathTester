using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace XpathTester
{
    public partial class baseForm : Form
    {
        public string SourceFileName { get; set; }
        XElement xElement { get; set; }
        XPathDocument xPathDocumnet { get; set;  }
        string xmlString;
        XPathNodeIterator xpathNdIter;
        XmlDocument xmlDocument = new XmlDocument();
        XPathNavigator nav;
        Boolean expand = false;
        
        public baseForm()
        {
            InitializeComponent();
            this.browseBtn.Image = XpathTester.Resource1.Browse;
            this.button1.Image = XpathTester.Resource1.Run_Query;
            this.buttonback.Image = XpathTester.Resource1.Return;
            this.expandAllBtn.Image = XpathTester.Resource1.Expand_All;
            expandAllBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void closeF()
        {
            Application.Exit();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenXmlFile();
        }

        public void ShowXmlFile()
        {
            Uri uri = new Uri(SourceFileName);
            pathXml.Text = uri.ToString();
            xPathDocumnet = new XPathDocument(SourceFileName);
            xmlString = System.IO.File.ReadAllText(SourceFileName);
            xmlDocument.Load(SourceFileName);
            XmlText.Text = xmlString;

            XmlNode xmlnode;
            
            xmlnode = xmlDocument.ChildNodes[1];
            treeView.Nodes.Clear();
            treeView.Nodes.Add(new TreeNode(xmlDocument.DocumentElement.Name));
            TreeNode tNode;
            tNode = treeView.Nodes[0];
            AddNode(xmlnode, tNode);
            expandAllBtn.Enabled = true;
            nav = xmlDocument.CreateNavigator();
            listBox1.Items.Clear();
            getAllNodes(nav);

            QueryBox.Text = "/";            
        }

        private void getAllNodes(XPathNavigator nav)
        {
            XPathNodeIterator iterator = nav.SelectChildren(XPathNodeType.Element);
            while (iterator.MoveNext())
            {
                string nodeName = iterator.Current.Name;
            
                if (!listBox1.Items.Contains(nodeName))
                {
                    listBox1.Items.Add(nodeName);
                }
                if (iterator.Current.HasChildren)
                {
                    getAllNodes(iterator.Current);
                }
            }
        }


        private void OpenXmlFile()
        {

            try
            {
                this.openFileDialog1.Filter = "xml files (*.xml)|*.xml|xsl files (*.xsl;*.xslt)|*.xsl;*.xslt|xsd files (*.xsd)|*.xsd|svg files (*.svg)|*.svg|xhtml files (*.xhtml;*.html;*.htm)|*.xhtml;*.html;*.htm|xaml files (*.xaml)|*.xaml|config files (*.config;*.settings;*.vssettings;*.resx)|*.config;*.settings;*.vssettings;*.resx|project files (*.csproj;*.vbproj;*.user)|*.csproj;*.vbproj;*.user|project files (*.vsdisco;*.webinfo)|*.vsdisco;*.webinfo|project files (*.sitemap;*.browser)|*.sitemap;*.browser|All files (*.*)|*.*";
                this.openFileDialog1.RestoreDirectory = true;
                this.openFileDialog1.FileName = string.Empty;
                
                if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
                    SourceFileName = openFileDialog1.FileName;
                ShowXmlFile();
            }
            catch
            {
                MessageBox.Show("Select a Valid xml file.");
            }

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        

        private void pathXml_TextChanged(object sender, EventArgs e)
        {
            Uri uri = new Uri(pathXml.Text);
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            if (QueryBox.Text == "/")
            {
                nav = xmlDocument.CreateNavigator();
                PopulateLists(nav);
            }
            else if (QueryBox.Text.Contains("//"))
            {
                getAllNodes(xmlDocument.CreateNavigator());
            }
            else
            {
                try
                {
                    string query = QueryBox.Text;
                    if (QueryBox.Text[QueryBox.Text.Length - 1] == '/')
                    {
                        query = QueryBox.Text.Substring(0, QueryBox.Text.Length - 1);
                    }

                    var Nodelist = xmlDocument.SelectNodes(query);

                    foreach (XmlNode x in Nodelist)
                    {
                        if (x.HasChildNodes)
                        {
                            var Childnodes = x.ChildNodes;
                            foreach (XmlNode XChild in Childnodes)
                            {
                                if (XChild.HasChildNodes)
                                {
                                    if (!listBox1.Items.Contains(XChild.Name))
                                    {
                                        listBox1.Items.Add(XChild.Name);
                                    }
                                    if (XChild.HasChildNodes)
                                    {
                                        var XChildNode = XChild.ChildNodes;
                                        foreach (XmlNode y in XChildNode)
                                        {
                                            if (y.HasChildNodes)
                                            {
                                                if (!listBox2.Items.Contains(y.Name))
                                                {
                                                    listBox2.Items.Add(y.Name);
                                                }
                                                if (y.Attributes.Count > 0)
                                                {
                                                    for (int i = 0; i < XChild.Attributes.Count; i++)
                                                    {
                                                        if (!listBox1.Items.Contains(y.Name + "[@" + y.Attributes[i].Name + "='" + "<type " + y.Attributes[i].Name + " value here>" + "']"))
                                                            listBox1.Items.Add(y.Name + "[@" + y.Attributes[i].Name + "='" + "<type " + y.Attributes[i].Name + " value here>" + "']");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (XChild.Attributes.Count > 0)
                                    {
                                        for (int i = 0; i < XChild.Attributes.Count; i++)
                                        {
                                            if (!listBox1.Items.Contains(XChild.Name + "[@" + XChild.Attributes[i].Name + "='" + "<type " + XChild.Attributes[i].Name + " value here>" + "']"))
                                                listBox1.Items.Add(XChild.Name + "[@" + XChild.Attributes[i].Name + "='" + "<type " + XChild.Attributes[i].Name + " value here>" + "']");
                                        }
                                    }
                                }
                            }
                        }
                    }
                
                }
                catch { }
             }
            listBox2.Items.Add("/");
            listBox2.Items.Add("//");
            listBox2.Items.Add("[text()='<Enter the value>']");
            listBox2.Items.Add(" and ");
            listBox2.Items.Add("[contains(text(), '<Enter the value>')]");

        }

        public void PopulateLists(XPathNavigator nav)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            XPathNodeIterator NodeLoop = nav.SelectChildren(XPathNodeType.Element);
            while (NodeLoop.MoveNext())
            {
                string nodeName = NodeLoop.Current.Name;

                if (!listBox1.Items.Contains(nodeName))
                {
                    listBox1.Items.Add(nodeName);
                }
                XPathNodeIterator NodeLoopInner = NodeLoop;
                NodeLoopInner.Current.MoveToFirstChild();
                do
                {
                    nodeName = NodeLoopInner.Current.Name;
                    if (!listBox2.Items.Contains(nodeName))
                    {
                        listBox2.Items.Add(nodeName);
                    }
                } while (NodeLoopInner.MoveNext());
            }



        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (QueryBox.Text == "/")
            {
                try
                {
                    QueryBox.Text = QueryBox.Text + ((ListBox)sender).SelectedItem.ToString();
                }
                catch
                { }
            }
            else
            {
                try
                {
                    QueryBox.Text = QueryBox.Text + "/" + ((ListBox)sender).SelectedItem.ToString();
                }
                catch
                { }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResultBox.Text = "";
            string xpath = QueryBox.Text;

            if (xmlString == null)
            {
                MessageBox.Show("Select a XML file to test the XPath", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(xpath))
            {
                MessageBox.Show("Enter a XPath Query.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                XPathExpression expression = XPathExpression.Compile(xpath);
                xpathNdIter = nav.Select(QueryBox.Text);
                while (xpathNdIter.MoveNext())
                {
                    ResultBox.Text += xpathNdIter.Current.OuterXml + Environment.NewLine;
                }

                if (string.IsNullOrWhiteSpace(ResultBox.Text))
                {
                   
                    ResultBox.Text = "No data to display!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            QueryBox.Text = QueryBox.Text + ((ListBox)sender).SelectedItem.ToString();
        }

        private void AddNode(XmlNode inXmlNode, TreeNode inTreeNode)
        {
            XmlNode xNode;
            TreeNode tNode;
            XmlNodeList nodeList;
            int i = 0;
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNode(xNode.Name));
                    tNode = inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                inTreeNode.Text = inXmlNode.InnerText.ToString();
            }
        }

    

        private void buttonback_Click(object sender, EventArgs e)
        {
            
            Introduction back = new Introduction();
            back.Show();
            this.Owner = back;
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (expand == false)
            {
                expandAllBtn.Image = XpathTester.Resource1.Collapse;
                treeView.ExpandAll();
                expand = true;
            }
            else {
                expandAllBtn.Image = XpathTester.Resource1.Expand_All;
                treeView.CollapseAll();
                expand = false;
            }            
        }

        private void pathXml_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(pathXml.Text);
        }
    }
}
