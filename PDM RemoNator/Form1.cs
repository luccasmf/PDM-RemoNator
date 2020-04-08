using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PDM_RemoNator.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDM_RemoNator
{
    public partial class Form1 : Form
    {


        private JObject js;
        private List<string> _subscribers;
        string fileLocation;
        public Form1()
        {
            js = new JObject();
            _subscribers = new List<string>();
           // _items = new List<dynamic>();
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = ofTodos.FileName;
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                js = JObject.Parse(json);

            }
            fileLocation = fileName;
            //read txt file
        }

        
        private void btnLoadAll_Click(object sender, EventArgs e)
        {
            ofTodos.Multiselect = false;
            ofTodos.InitialDirectory = @"C:\\";
            ofTodos.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            ofTodos.CheckFileExists = true;
            ofTodos.CheckPathExists = true;
            ofTodos.ShowDialog();
        }

        private void btnLoadSubs_Click(object sender, EventArgs e)
        {
            ofSubs.Multiselect = false;
            ofSubs.InitialDirectory = @"C:\\";
            ofSubs.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            ofSubs.CheckPathExists = true;
            ofSubs.CheckFileExists = true;
            ofSubs.ShowDialog();
        }

        private void ofSubs_FileOk(object sender, CancelEventArgs e)
        {
            string fileName = ofSubs.FileName;

            using (StreamReader r = new StreamReader(fileName))
            {
                
                while (!r.EndOfStream)
                {
                    var line = r.ReadLine();
                    var values = line.Split(',');

                    _subscribers.Add(values[0]);
                }
            }
        }

        private void btnCreditar_Click(object sender, EventArgs e)
        {
            


            int amountToAdd = int.Parse(textBox1.Text);

           foreach(JToken item in js.Children())
            {
                foreach(JToken it in item.Children())
                {
                    foreach (JToken bets in it.Children())
                    {
                        foreach(JToken jt in bets.Children())
                        {
                            
                            JToken[] jProperties = jt.Children().ToArray();
                            //jProperties[0].Value;

                            if(_subscribers.Contains(jProperties[1].First.ToString()))
                            {
                                int value = int.Parse(jt["amount"].ToString());
                                jt["amount"]= value + amountToAdd;
                            }
                        }
                    }
                }
            }


            string path = Path.GetDirectoryName(fileLocation) + "\\";
            string title = string.Format("Novo Saldo Remos - {0}.json",DateTime.Now.Ticks);
            using (StreamWriter file = File.CreateText(path+title))
            using (JsonTextWriter writer = new JsonTextWriter(file))
            {
                js.WriteTo(writer);
            }

            MessageBox.Show(string.Format("Arquivo salvo em {0}", path + title));

        }
    }
}
