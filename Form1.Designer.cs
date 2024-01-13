using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace LicensePlateGenerator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLicensePlate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbScale = new System.Windows.Forms.ComboBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.cbSeparator = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(12, 585);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(566, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gerar Matrícula";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLicensePlate
            // 
            this.txtLicensePlate.Location = new System.Drawing.Point(113, 226);
            this.txtLicensePlate.Name = "txtLicensePlate";
            this.txtLicensePlate.Size = new System.Drawing.Size(108, 23);
            this.txtLicensePlate.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Escala:";
            // 
            // cbScale
            // 
            this.cbScale.FormattingEnabled = true;
            this.cbScale.Location = new System.Drawing.Point(113, 352);
            this.cbScale.Name = "cbScale";
            this.cbScale.Size = new System.Drawing.Size(108, 23);
            this.cbScale.TabIndex = 4;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(113, 390);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(108, 23);
            this.cbType.TabIndex = 5;
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 393);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de Matrícula:";
            // 
            // previewBox
            // 
            this.previewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.previewBox.Location = new System.Drawing.Point(113, 464);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(343, 77);
            this.previewBox.TabIndex = 7;
            this.previewBox.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox1.Location = new System.Drawing.Point(235, 229);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(343, 185);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mês:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ano:";
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.Location = new System.Drawing.Point(12, 682);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(2, 17);
            this.lbStatus.TabIndex = 14;
            // 
            // cbMonth
            // 
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(113, 255);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(108, 23);
            this.cbMonth.TabIndex = 15;
            // 
            // cbYear
            // 
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(113, 287);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(108, 23);
            this.cbYear.TabIndex = 16;
            // 
            // cbSeparator
            // 
            this.cbSeparator.FormattingEnabled = true;
            this.cbSeparator.Location = new System.Drawing.Point(113, 316);
            this.cbSeparator.Name = "cbSeparator";
            this.cbSeparator.Size = new System.Drawing.Size(108, 23);
            this.cbSeparator.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Separador:";
            // 
            // pbLogo
            // 
            this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbLogo.Location = new System.Drawing.Point(44, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(500, 170);
            this.pbLogo.TabIndex = 19;
            this.pbLogo.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(285, 671);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(293, 12);
            this.label7.TabIndex = 20;
            this.label7.Text = "Esta aplicação foi desenvolvida gratuitamente e disponibilizada no GitHub";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(301, 684);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(277, 12);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://github.com/tiagomerinosantos/LicensePlateGenerator/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 704);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbSeparator);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.previewBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.cbScale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLicensePlate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Gerador de Matrículas Portuguesas";
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            PopulateData();

        }

        #endregion

        /// <summary>
        /// Populates data for various controls in the form, such as loading the logo, adding items to ComboBoxes, and setting default selections.
        /// </summary>
        private void PopulateData()
        {
            //Load Logo
            pbLogo.Image = Image.FromFile(Application.StartupPath + config.logoImage);

            // Add items to the ComboBox Scale
            cbScale.Items.AddRange(config.scales.ToArray());
            cbScale.SelectedIndex = 0;

            // Add items to the ComboBox Type
            foreach (LicenseType lt in config.licenseType)
            {
                cbType.Items.Add(lt.name);
            }
            cbType.SelectedIndex = 0;

            // Add items to the ComboBox Separator
            foreach(string s in config.separators)
            {
                cbSeparator.Items.Add(s);
            }
            cbSeparator.SelectedIndex = 0;

            // Add items to the ComboBox Month
            for (int i = 1; i < 13; i++)
            {
                cbMonth.Items.Add(i.ToString().PadLeft(2,'0'));
            }
            cbMonth.SelectedIndex = 0;

            // Add items to the ComboBox Month
            for (int i = 0; i < 100; i++)
            {
                cbYear.Items.Add(i.ToString().PadLeft(2, '0'));
            }
            cbYear.SelectedIndex = 0;
        }

        /// <summary>
        /// Resizes an Image to the specified width and height using high-quality bicubic interpolation.
        /// </summary>
        /// <param name="image">The Image to be resized.</param>
        /// <param name="width">The desired width of the resized image.</param>
        /// <param name="height">The desired height of the resized image.</param>
        /// <returns>A Bitmap representing the resized image.</returns>
        private Bitmap ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(resizedImage))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return resizedImage;
        }

        /// <summary>
        /// Verifies whether the provided license plate text is valid.
        /// </summary>
        /// <param name="licensePlateText">The license plate text to be verified.</param>
        /// <returns>
        ///   <c>true</c> if the license plate text is valid; otherwise, <c>false</c>.
        /// </returns>
        private Boolean VerifyEmptyFields(String licensePlateText)
        {
            if (string.IsNullOrWhiteSpace(licensePlateText))
            {
                MessageBox.Show("Tem de preencher o campo Matrícula.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (licensePlateText.Length != 6)
            {
                MessageBox.Show("A Matrícula tem de ter 6 caracteres.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Loads the background photo template and associated font color based on the selected license plate type.
        /// </summary>
        /// <returns>
        /// A tuple containing the file path to the background template and the font color as a Color object.
        /// </returns>
        private (String, Color) LoadBackground()
        {
            // Load the background photo template
            string backgroundTemplatePath = "";
            Color color = Color.Black;

            foreach (LicenseType lt in config.licenseType)
            {
                if (lt.name == cbType.SelectedItem.ToString())
                {
                    backgroundTemplatePath = Application.StartupPath + lt.imagePath;
                    color = Color.FromName(lt.fontColor);
                    break;
                }
            }
            return (backgroundTemplatePath, color);
        }

        /// <summary>
        /// Generates a new image with license plate text based on the provided background template and details.
        /// </summary>
        /// <param name="backgroundTemplatePath">The file path to the background template image.</param>
        /// <param name="color">The font color for the license plate text.</param>
        /// <param name="licensePlateText">The license plate text to be displayed on the image.</param>
        /// <returns>A Bitmap representing the generated image with the license plate text.</returns>
        private Bitmap GenerateImage(string backgroundTemplatePath, Color color, string licensePlateText)
        {
            Bitmap backgroundTemplate = new Bitmap(backgroundTemplatePath);
            ScaleDetails sDetais =  new ScaleDetails();

            foreach (LicenseType lt in config.licenseType)
            {
                if (lt.name == cbType.SelectedItem.ToString())
                {
                    sDetais.fontSize = lt.scales[cbScale.Text].fontSize;
                    sDetais.width = lt.scales[cbScale.Text].width;
                    sDetais.height = lt.scales[cbScale.Text].height;
                    sDetais.yearMonthFontSize = lt.scales[cbScale.Text].yearMonthFontSize;
                    sDetais.yearWidth = lt.scales[cbScale.Text].yearWidth;
                    sDetais.yearHeight = lt.scales[cbScale.Text].yearHeight;
                    sDetais.monthWidth = lt.scales[cbScale.Text].monthWidth;
                    sDetais.monthHeight = lt.scales[cbScale.Text].monthHeight;
                    sDetais.offsetWith = lt.scales[cbScale.Text].offsetWith;
                    backgroundTemplate = ResizeImage(new Bitmap(backgroundTemplatePath), sDetais.width, sDetais.height);
                    break;
                }
            }

            // Create a graphics object from the background image
            using (Graphics g = Graphics.FromImage(backgroundTemplate))
            {
                // Set up font and brush for the license plate text
                Font font = new Font("Bahnschrift SemiBold", sDetais.fontSize);
                SolidBrush brush = new SolidBrush(color);

                // Calculate the position to center the text on the image
                float x = ((backgroundTemplate.Width - g.MeasureString(licensePlateText, font).Width) / 2) + sDetais.offsetWith;
                float y = ((backgroundTemplate.Height - g.MeasureString(licensePlateText, font).Height) / 2) +2;
                
                // Draw the license plate text on the image
                g.DrawString(licensePlateText, font, brush, x, y);
            }

           
            if (sDetais.yearMonthFontSize != 0)
            {
                // Create a graphics object from the background image for year
                using (Graphics g = Graphics.FromImage(backgroundTemplate))
                {
                    // Set up font and brush for the license plate text
                    Font font = new Font("Bahnschrift SemiBold", sDetais.yearMonthFontSize);
                    SolidBrush brush = new SolidBrush(color);

                    // Draw the license plate text on the image
                    g.DrawString(cbYear.SelectedItem.ToString(), font, brush, sDetais.yearWidth, sDetais.yearHeight);
                }

                // Create a graphics object from the background image for Month
                using (Graphics g = Graphics.FromImage(backgroundTemplate))
                {
                    // Set up font and brush for the license plate text
                    Font font = new Font("Bahnschrift SemiBold", sDetais.yearMonthFontSize);
                    SolidBrush brush = new SolidBrush(color);

                    // Draw the license plate text on the image
                    g.DrawString(cbMonth.SelectedItem.ToString(), font, brush, sDetais.monthWidth, sDetais.monthHeight);
                }
            }

            return backgroundTemplate;
        }

        /// <summary>
        /// Allows the user to select an output folder and saves the generated image with license plate text.
        /// </summary>
        /// <param name="backgroundTemplate">The Bitmap containing the generated image.</param>
        /// <param name="licensePlateText">The license plate text used in the image filename.</param>
        private void SaveImage(Bitmap backgroundTemplate, string licensePlateText)
        {
            // Allow the user to select the output folder
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Get the selected folder path
                    string outputPath = folderDialog.SelectedPath;

                    // Save the generated image to the selected folder
                    string outputFileName = $"{licensePlateText}_{cbType.Text}_{cbScale.Text.Replace(":", "-")}.png";
                    string outputPathAndFileName = System.IO.Path.Combine(outputPath, outputFileName);

                    // Save the generated image
                    backgroundTemplate.Save(outputPathAndFileName, System.Drawing.Imaging.ImageFormat.Png);
                    backgroundTemplate.Dispose();

                    // Display a success message
                    lbStatus.Text = "Imagem gerada com sucesso";
                }
                else
                {
                    // Display a message indicating that the user canceled the operation
                    lbStatus.Text = "Operação cancelada";
                }
            }
        }

        /// <summary>
        /// Event handler for the Click event of btnGenerate.
        /// Generates an image based on the provided license plate text and saves it to a user-selected folder.
        /// </summary>
        /// <param name="sender">The object that triggered the event (btnGenerate).</param>
        /// <param name="e">An instance of the EventArgs class containing event data.</param>
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string licensePlateText = txtLicensePlate.Text.Replace(" ", "").Replace("-", "").Trim().ToUpper();
                // Display a generate message
                lbStatus.Text = "A gerar imagem...";

                //Verify Empty Fields
                if (!VerifyEmptyFields(licensePlateText))
                {
                    return;
                }

                //Verify Separator
                string separator = "";
                if (!cbSeparator.Text.Equals("Vazio"))
                {
                    separator = cbSeparator.Text.PadLeft(2, Char.Parse(" ")).PadRight(3, Char.Parse(" "));
                }

                licensePlateText = licensePlateText.Substring(0, 2) + separator + licensePlateText.Substring(2, 2) + separator + licensePlateText.Substring(4, 2);
                //Get background image
                (string backgroundTemplatePath, Color color) = LoadBackground();

                //Generate image
                Bitmap backgroundTemplate = GenerateImage(backgroundTemplatePath, color, licensePlateText);

                //Save image
                SaveImage(backgroundTemplate, licensePlateText.Replace(separator, "-"));
            }
            catch(Exception ex)
            {
                MessageBox.Show("Existiu um erro ao gerar a imagem. Detalhes: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        
        private Label label1;
        private Button button1;
        private TextBox txtLicensePlate;
        private Label label2;
        private ComboBox cbScale;
        private ComboBox cbType;
        private Label label3;
        private PictureBox previewBox;
        private FolderBrowserDialog folderBrowserDialog1;
        private RichTextBox richTextBox1;
        private Label label4;
        private Label label5;
        private Label lbStatus;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private ComboBox cbSeparator;
        private Label label6;
        private PictureBox pbLogo;
        private Label label7;
        private LinkLabel linkLabel1;
    }
}