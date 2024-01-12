using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http.Json;
using System.Text.Json;

namespace LicensePlateGenerator
{    public partial class Form1 : Form
    {
        public Form1()
        {
            // Read the config file
            config = JsonSerializer.Deserialize<ConfigJson>(File.ReadAllText(Application.StartupPath + "config.json"));
            Console.WriteLine("TESTE: " + config.licenseType.Count.ToString());
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnGenerate_Click(sender, e);
        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the image when no selection is made
            previewBox.Image = null;

            // Get the selected item from the ComboBox
            string selectedItem = cbType.SelectedItem.ToString();

            // Show the corresponding image based on the selected item
            foreach( LicenseType lt in config.licenseType)
            {
                if(lt.name == selectedItem)
                {
                    previewBox.Image = Image.FromFile(Application.StartupPath + lt.imagePath);
                    break;
                }
            }
        }

        public class ConfigJson
        {
            public List<LicenseType> licenseType { get; set; }
            public List<string> scales { get; set; }
            public List<string> separators { get; set; }
            public string logoImage { get; set; }
        }

        public class LicenseType
        {
            public string name { get; set; }
            public string imagePath { get; set; }
            public string fontColor { get; set; }
            public Dictionary<string, ScaleDetails> scales { get; set; }
        }

        public class ScaleDetails
        {
            public int fontSize { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public int yearMonthFontSize { get; set; }
            public int yearWidth { get; set; }
            public int yearHeight { get; set; }
            public int monthWidth { get; set; }
            public int monthHeight { get; set; }
            public int offsetWith { get; set; }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private ConfigJson config;
    }
}