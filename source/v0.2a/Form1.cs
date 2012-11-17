using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace TGM_reader
{
    public partial class Form1 : Form
    {
        int size = -1;
        string[] nodes = new string[200];
        int linenum = 0;
        string line;
        string v;
        string file;
        string filename;
        string text;
        Regex g = new Regex(@"Geometry=\(*");
        int u = 0;
        int i = 0;
        string[] results2 = new string[33];
        string[] results3 = new string[33];
        string[] results4 = new string[33];
        string[] resultso2 = new string[33];
        string[] resultso3 = new string[33];
        string[] resultso4 = new string[33];
        TextBox[] txtNodeNames = new TextBox[33];
        TextBox[] txtNodeNames2 = new TextBox[33];
        TextBox[] txtNodeNames3 = new TextBox[33];
        Regex g2 = new Regex(@"\-?\d{1}\.?[0-9]*");
        Regex g3 = new Regex(@"\,\-\d{1}\.[0-9]*\,");
        Regex g4 = new Regex(@"\,\d{1}\.[0-9]*\)");
        double math;
        int n = -2;
        string[] writeresult = new string[33];

        public Form1()
        {
            InitializeComponent();
            
            
        }
        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
      
            

            
        
        private void btnOpen_Click(object sender, EventArgs e)
        {
            //class Program

            //{
            //static void Main()
            //{
            textBox1.Text = "";
           // if (i > 0)
            //{
                int r1=0;
                while (r1 < linenum)
                {
                    this.Controls.Remove(txtNodeNames[r1]);
                    this.Controls.Remove(txtNodeNames2[r1]);
                    this.Controls.Remove(txtNodeNames3[r1]);
                    r1++;
                }
            //}
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                filename = openFileDialog1.FileName;
                try
                {
                    text = File.ReadAllText(file);
                    size = text.Length;
                    //textBox1.Text = text;
                }
                catch (IOException)
                {
                }
            }
            
            
             // (@"Geometry=\(($)*");
            textBox_fn.Text = filename;
            using (StreamReader r = new StreamReader(filename))
            {
                linenum = 0;
                while ((line = r.ReadLine()) != null)
                {

                    // X.
                    // Try to match each line against the Regex.
                    Match m = g.Match(line);
                    if (m.Success)
                    {

                        // Y.
                        // Write original ine and the value.

                        v = m.Groups[linenum].Value;
                        //textBox1.AppendText(line);
                        //textBox1.AppendText("\t"+v);
                        
                        if (line != null)
                        {
                            nodes[linenum] = line;
                        }
                        
                        linenum++;
                    }
                }
                u = 0;
                i = 0;


                    while (i <= (linenum/2)) {// nodes.Length; )
                    //try
                    //{
                        
                        Match m2 = g2.Match(nodes[u]);
                        
                        Match m3 = g3.Match(nodes[u]);
                        
                        Match m4 = g4.Match(nodes[u]);
                        //textBoxNode0_2.Text = m2.Groups[0].Value;
                        results2[u] = m2.Groups[0].Value;
                        //textBoxNo0.Text = results2[u];
                        results3[u] = m3.Groups[0].Value;
                        results4[u] = m4.Groups[0].Value;
                        results3[u] = Regex.Replace(results3[u], "\\,", "");
                        results4[u] = Regex.Replace(results4[u], "\\)", "");
                        results4[u] = Regex.Replace(results4[u], "\\,", "");
                        txtNodeNames[u] = new TextBox();
                        txtNodeNames2[u] = new TextBox();
                        txtNodeNames3[u] = new TextBox();
                            //string m2name = m2.Groups[i].Value;
                            //var txt = new TextBox();
                            //txtNodeNames[i] = txt;
                            this.Controls.Add(txtNodeNames[u]);
                            this.Controls.Add(txtNodeNames2[u]);
                            this.Controls.Add(txtNodeNames3[u]);
                            //txtNodeNames[u].Name = "txtbox"+u;
                            txtNodeNames[u].Text = results2[u];
                            txtNodeNames2[u].Text = results3[u];
                            txtNodeNames3[u].Text = results4[u];
                            if (u < 17)
                            {
                                txtNodeNames[u].Location = new Point(227, 27 + (u * 28));
                                txtNodeNames2[u].Location = new Point(337, 27 + (u * 28));
                                txtNodeNames3[u].Location = new Point(447, 27 + (u * 28));
                            }
                            else {
                                txtNodeNames[u].Location = new Point(347, 27 + ((u-16) * 28));
                                txtNodeNames2[u].Location = new Point(437, 27 + ((u - 16) * 28));
                                txtNodeNames3[u].Location = new Point(547, 27 + ((u - 16) * 28));
                            }
                            txtNodeNames[u].Visible = true;
                            txtNodeNames2[u].Visible = true;
                            textBox1.AppendText(nodes[u] + Environment.NewLine);
                            //textBoxNode0_1.Text = nodes[u];
                            u++;                      
                            i++;
                    }

                    //n = -1;
                    n = u;
                    u=u-2;
                    textBox1.AppendText(" " + Environment.NewLine);
                while (u >= 0){
                    math=0;
                    math = Double.Parse(results2[u], System.Globalization.CultureInfo.InvariantCulture);
                    math = math * -1;
                    results2[n] = Convert.ToString(math);
                    textBox1.AppendText("Geometry=("+results2[n] +","+results3[u]+","+results4[u]+")"+Environment.NewLine);
                    
                    u--;
                    n++;
                    //n=n-2;
                }

                        /*  if (i == 1)
                          {
                              textBoxNode0.Text = v2;
                              textBoxNode0_1.Text = Regex.Replace(v3, "\\,", "");
                              textBoxNode0_2.Text = Regex.Replace(v4, "\\)", "");
                          }
                          if (i == 2)
                          {
                              textBoxNode1.Text = v2;
                              textBoxNode1_1.Text = Regex.Replace(v3, "\\,", "");
                              textBoxNode1_2.Text = Regex.Replace(v4, "\\)", "");
                          }
                      }
                      textBox1.AppendText(nodes[i]);*/
                  /*  catch
                    {
                        if (line == null)
                        {
                            break;
                        }
                    }
                    finally
                    {
                        if (line == null)
                        {

                        }
                    }
                    } */
                    
            }
            button_generate.Enabled = true;
       //  abs runProgram = new Program();
            }
        //}  
        //}



        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                file = openFileDialog1.FileName;
                filename = saveFileDialog1.FileName;
                //string line = null;
                int linew=0;
                string[] tgm = new string[5000];
                int rline=0;
                u=0;
                using (StreamReader reader = new StreamReader(file))
                {
                    while ((tgm[rline]=reader.ReadLine()) != null)
                            {
                              //  tgm[rline] = reader.;
                        Match mw = g.Match(tgm[rline]);
                        if (mw.Success)
                        {

                            tgm[rline] = writeresult[u];
                            u++;

                        }
                        //sline++;
                                rline++;
                            }
                   // int sline=0;
                    while (linew <= rline)
                    {
                        
                        
                       
                            using (StreamWriter w = new StreamWriter(filename, true))
                            {
                                w.WriteLine(tgm[linew]);
                                textBox1.AppendText(tgm[linew]+"\r\n");
                            }
                        linew++;
                            
                        }
                    
                        
                    
                }
            }
            
        }



            
            
            
            /*  int size = -1;
              DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
              if (result == DialogResult.OK) // Test result.
              {
                  string file = openFileDialog1.FileName;
                  filename = openFileDialog1.FileName;
                  try
                  {
                      string text = File.ReadAllText(file);
                      size = text.Length;
                      textBox1.Text = text;
                  }
                  catch (IOException)
                  {
                  }
              }*/
        

        private void button_Generate_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            u = 0;
            n = 0;
            while (u <= linenum /2)
            {
                resultso2[u] = txtNodeNames[u].Text;
                resultso3[u] = txtNodeNames2[u].Text;
                resultso4[u] = txtNodeNames3[u].Text;

                u++;
            }
            u = u-1;
            n = (linenum / 2);
                    while (u >= 0){
                    math=0;
                    math = Double.Parse(resultso2[u], System.Globalization.CultureInfo.InvariantCulture);
                    math = math * -1;
                    resultso2[n] = Convert.ToString(math);
                    resultso3[n] = resultso3[u];
                    resultso4[n] = resultso4[u];
                    n++;
                    u--;
            }
            n = 0;
            while (n < linenum)
            {
                textBox1.AppendText("Geometry=(" + resultso2[n] + "," + resultso3[n] + "," + resultso4[n] + ")" + Environment.NewLine);
                writeresult[n] = ("Geometry=(" + resultso2[n] + "," + resultso3[n] + "," + resultso4[n] + ")");
                n++;
            }
            btnSave.Enabled = true;
        }
    }
}
