using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crawler
{
    public partial class Form1 : Form
    {
        String Rstring;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebRequest myWebRequest;
            WebResponse myWebResponse;
            String URL = textBox1.Text;

            myWebRequest = WebRequest.Create(URL);
            myWebResponse = myWebRequest.GetResponse();//Returns a response from an Internet resource

            Stream streamResponse = myWebResponse.GetResponseStream();//return the data stream from the internet
                                                                      //and save it in the stream

            StreamReader sreader = new StreamReader(streamResponse);//reads the data stream
            Rstring = sreader.ReadToEnd();//reads it to the end
            String Links = GetContent(Rstring);//gets the links only

            textBox2.Text = Rstring;
            textBox3.Text = Links;
            streamResponse.Close();
            sreader.Close();
            myWebResponse.Close();




        }

        public ISet<string> GetNewLinks(string content)
        {
            Regex regexLink = new Regex("(?<=<a\\s*?href=(?:'|\"))[^'\"]*?(?=(?:'|\"))");

            ISet<string> newLinks = new HashSet<string>();
            foreach (var match in regexLink.Matches(content))
            {
                if (!newLinks.Contains(match.ToString()))
                    newLinks.Add(match.ToString());
            }

            return newLinks;
        }
    }
}