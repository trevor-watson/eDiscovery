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
using System.Xml.Linq;

namespace XMReLUsers
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            //is this a real file?
            if (File.Exists(textboxFilePath.Text))
            {
                //clean up listboxes
                listBox_RemoveEmails.Items.Clear();
                listBox_XMLEmails.Items.Clear();
                //read xml and send emails to the listbox
                string xml = File.ReadAllText(textboxFilePath.Text);
                XDocument xd = XDocument.Parse(xml);
                xd.Root.Element("Users").Elements("RelativityUser").ToList();
                var names = xd.Root.Descendants("Users").Elements("RelativityUser").Elements("EmailAddress").Select(b => b.Value);
                listBox_XMLEmails.Items.AddRange(names.ToArray());
            }
            else
            {
                MessageBox.Show("File does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //this isn't blank, is it?
            if (!string.IsNullOrWhiteSpace(textboxFilePath.Text))
            {
                //send emails to be removed to a list
                var EmailRemove = listBox_RemoveEmails.Items.Cast<String>().ToList();

                //reading the xml again because i never stored it
                string xml = File.ReadAllText(textboxFilePath.Text);
                XDocument xd = XDocument.Parse(xml);
                //iterate though instances of RelativityUser
                foreach (XElement element in xd.Root.Element("Users").Elements("RelativityUser").Reverse())
                {
                    //is this value of EmailAddress in our list?
                    if (EmailRemove.Contains(element.Element("EmailAddress").Value))
                    {
                        //gtfo
                        element.Remove();
                    }
                }

                //get new filenames and save updated XML
                DateTime dt = DateTime.Now;
                string dt_Suffix = dt.ToString("yyyyMMddHHmmss");
                String newFileName = Path.GetDirectoryName(textboxFilePath.Text) + "\\" + Path.GetFileNameWithoutExtension(textboxFilePath.Text) + "_" + dt_Suffix + Path.GetExtension(textboxFilePath.Text);
                String logFileName = Path.GetDirectoryName(textboxFilePath.Text) + "\\" + Path.GetFileNameWithoutExtension(textboxFilePath.Text) + "_" + dt_Suffix + ".log";
                //if something goes wrong just say it didn't work
                try
                {
                    //write new xml file
                    File.WriteAllText(newFileName, xd.ToString());

                    //write new log file
                    System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(logFileName);
                    SaveFile.WriteLine("╔══════════════════════════════════════════════════──────");
                    SaveFile.WriteLine("║	XMReLUsers Log");
                    SaveFile.WriteLine("║	Time: \t" + dt.ToString("M/d/yyyy h:mm:ss tt"));
                    SaveFile.WriteLine("║	Input: \t" + textboxFilePath.Text);
                    SaveFile.WriteLine("║	Output: " + newFileName);
                    SaveFile.WriteLine("╠═══════════════════════════════════╦══════════════──────");
                    SaveFile.WriteLine("║	Removed <RelativityUser> Nodes	║");
                    SaveFile.WriteLine("╚═══════════════════════════════════╝");
                    foreach (var item in listBox_RemoveEmails.Items)
                    {
                        SaveFile.WriteLine(item);
                    }
                    SaveFile.Close();

                    //thumbs up
                    MessageBox.Show("Updated XML file has been saved!" + "\n" + newFileName, "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                catch
                {
                    MessageBox.Show("There was a problem saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                }
            }
            else
            {
                MessageBox.Show("There was a problem saving the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void buttonListRemove_Click(object sender, EventArgs e)
        {
            ListBox_Move(listBox_XMLEmails, listBox_RemoveEmails);
        }
        private void ListBox_Move(ListBox source, ListBox destination)
        {
            ListBox.SelectedObjectCollection sourceItems = source.SelectedItems;
            foreach (var item in sourceItems)
            {
                destination.Items.Add(item);
            }
            while (source.SelectedItems.Count > 0)
            {
                source.Items.Remove(source.SelectedItems[0]);
            }
        }

        private void buttonListKeep_Click(object sender, EventArgs e)
        {
            ListBox_Move(listBox_RemoveEmails, listBox_XMLEmails);
        }

        private void listBox_XMLEmails_DoubleClick(object sender, EventArgs e)
        {
            ListBox_Move(listBox_XMLEmails, listBox_RemoveEmails);
        }

        private void listBox_RemoveEmails_DoubleClick(object sender, EventArgs e)
        {
            ListBox_Move(listBox_RemoveEmails, listBox_XMLEmails);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMassMove_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\blacklist.txt"))
            {
                //add blacklist to list
                List<string> blackList = File.ReadAllLines(Application.StartupPath + @"\blacklist.txt").ToList();

                for (int n = listBox_XMLEmails.Items.Count - 1; n >= 0; --n) // -1 n>=0
                {
                    
                    foreach (var eMail in blackList)
                    {
                        //MessageBox.Show("Count - " + listBox_XMLEmails.Items.Count.ToString() + "//n Index - " + n.ToString());
                        if (listBox_XMLEmails.Items[n].ToString().ToLower().Contains(eMail.ToLower()))
                        {
                            listBox_RemoveEmails.Items.Add(listBox_XMLEmails.Items[n]);
                            listBox_XMLEmails.Items.RemoveAt(n);
                            break;
                        }
                    }
                }
                listBox_XMLEmails.Refresh();
                listBox_RemoveEmails.Refresh();
            }
            else
            {
                MessageBox.Show("The file blacklist.txt was not found in the application directory!" + "\n" + Application.StartupPath + @"\blacklist.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            //if (!string.IsNullOrWhiteSpace(textboxMassMove.Text))
            //{
            //    for (int n = listBox_XMLEmails.Items.Count - 1; n >= 0; --n)
            //    {
            //        if (listBox_XMLEmails.Items[n].ToString().ToLower().Contains(textboxMassMove.Text.ToLower()))
            //        {
            //            listBox_RemoveEmails.Items.Add(listBox_XMLEmails.Items[n]);
            //            listBox_XMLEmails.Items.RemoveAt(n);
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("You must enter a term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            //}
        }
        private void textBox_filePath_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBox_filePath_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] fileNames = (string[])e.Data.GetData(DataFormats.FileDrop);
                textboxFilePath.Lines = fileNames;
            }
        }

        private void buttonWhitelist_Click(object sender, EventArgs e)
        {
            if (File.Exists(Application.StartupPath + @"\whitelist.txt"))
            {
                //add whitelist to list
                List<string> blackList = File.ReadAllLines(Application.StartupPath + @"\whitelist.txt").ToList();

                for (int n = listBox_XMLEmails.Items.Count - 1; n >= 0; --n)
                {
                    int n2 = 0;
                    foreach (var eMail in blackList)
                    {
                        if (!(listBox_XMLEmails.Items[n].ToString().ToLower().Contains(eMail.ToLower())))
                        {
                            n2 = n2 + 1;
                        }
                    }
                    if (n2 > 0)
                    {
                        listBox_RemoveEmails.Items.Add(listBox_XMLEmails.Items[n]);
                        listBox_XMLEmails.Items.RemoveAt(n);
                    }
                }
                listBox_XMLEmails.Refresh();
                listBox_RemoveEmails.Refresh();
            }
            else
            {
                MessageBox.Show("The file whitelist.txt was not found in the application directory!" + "\n" + Application.StartupPath + @"\whitelist.txt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textboxMassMove.Text))
            {
                for (int n = listBox_XMLEmails.Items.Count - 1; n >= 0; --n)
                {
                    if (listBox_XMLEmails.Items[n].ToString().ToLower().Contains(textboxMassMove.Text.ToLower()))
                    {
                        listBox_RemoveEmails.Items.Add(listBox_XMLEmails.Items[n]);
                        listBox_XMLEmails.Items.RemoveAt(n);
                    }
                }
                listBox_XMLEmails.Refresh();
                listBox_RemoveEmails.Refresh();
            }
            else
            {
                MessageBox.Show("You must enter a term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
