using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text.Json;

namespace LicensePlateGenerator
{    public partial class Form1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// Reads the configuration from the 'config.json' file using JSON deserialization and initializes the form components.
        /// </summary>
        public Form1()
        {
            // Read the config file
            config = JsonSerializer.Deserialize<ConfigJson>(File.ReadAllText(Application.StartupPath + "config.json"));
            Console.WriteLine("TESTE: " + config.licenseType.Count.ToString());
            InitializeComponent();
        }

        /// <summary>
        /// Event handler for the Click event of button1.
        /// Invokes the btnGenerate_Click method to trigger the license plate generation process.
        /// </summary>
        /// <param name="sender">The object that triggered the event (button1).</param>
        /// <param name="e">An instance of the EventArgs class containing event data.</param>

        private void button1_Click(object sender, EventArgs e)
        {
            btnGenerate_Click(sender, e);
        }

        /// <summary>
        /// Event handler for the SelectedIndexChanged event of the cbType (ComboBox).
        /// Shows the corresponding image based on the selected license type.
        /// </summary>
        /// <param name="sender">The object that triggered the event (cbType ComboBox).</param>
        /// <param name="e">An instance of the EventArgs class containing event data.</param>
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

        /// <summary>
        /// Represents the configuration details loaded from a JSON file.
        /// </summary>
        public class ConfigJson
        {
            public List<LicenseType> licenseType { get; set; }
            public List<string> scales { get; set; }
            public List<string> separators { get; set; }
            public string logoImage { get; set; }
        }

        /// <summary>
        /// Represents a type of license plate with associated details such as name, image path, font color, and scales.
        /// </summary>
        public class LicenseType
        {
            public string name { get; set; }
            public string imagePath { get; set; }
            public string fontColor { get; set; }
            public Dictionary<string, ScaleDetails> scales { get; set; }
        }

        /// <summary>
        /// Represents details related to the scale of a generated license plate.
        /// </summary>
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

        /// <summary>
        /// Event handler for the LinkClicked event of linkLabel1.
        /// Opens the default web browser with the specified URL.
        /// </summary>
        /// <param name="sender">The object that triggered the event.</param>
        /// <param name="e">An instance of the LinkLabelLinkClickedEventArgs class containing event data.</param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open the default web browser with the specified URL
            Process.Start("explorer", "https://github.com/tiagomerinosantos/LicensePlateGenerator/");
        }

        private ConfigJson config;
    }
}