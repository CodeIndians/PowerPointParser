using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;
using System.Xml;
using Microsoft.Office.Interop.PowerPoint;
using Application = Microsoft.Office.Interop.PowerPoint.Application;
using Shape = Microsoft.Office.Interop.PowerPoint.Shape;
using System.IO;
using Newtonsoft.Json;

namespace SimplePowerpointParserApplication
{
    public class SlideData
    {
        public int SlideIndex { get; set; }
        public List<ShapeData> ShapeDataList { get; set; }
    }
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnParsePPT_Click(object sender, EventArgs e)
        {
            // Get input file path from the text box
            string inputFilePath = TBSourceFile.Text;

            // Get output file path from the text box
            string outputFilePath = TBOutputFile.Text;

            if (string.IsNullOrEmpty(inputFilePath) || string.IsNullOrEmpty(outputFilePath))
            {
                MessageBox.Show("Please enter both input and output file paths.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create an instance of PowerPoint Application
            Application powerPointApp = new Application();

            // Open the PowerPoint presentation
            Presentation presentation = powerPointApp.Presentations.Open(inputFilePath, MsoTriState.msoFalse, MsoTriState.msoFalse, MsoTriState.msoFalse);

            // Create a list to store slide data
            List<SlideData> slideDataList = new List<SlideData>();

            // Iterate through each slide and extract text
            foreach (Slide slide in presentation.Slides)
            {
                // Create a list to store shape data
                List<ShapeData> shapeDataList = new List<ShapeData>();

                // Iterate through each shape in the slide
                foreach (Shape shape in slide.Shapes)
                {
                    // Extract shape information (type, coordinates, text)
                    ShapeData shapeData = new ShapeData
                    {
                        ShapeType = shape.AutoShapeType.ToString(),
                        Coordinates = new Rect
                        {
                            Left = shape.Left,
                            Top = shape.Top,
                            Width = shape.Width,
                            Height = shape.Height
                        },
                        Text = shape.TextFrame.TextRange.Text
                    };

                    // Add shape data to the list
                    shapeDataList.Add(shapeData);
                }

                // Add slide data to the list
                slideDataList.Add(new SlideData
                {
                    SlideIndex = slide.SlideIndex,
                    ShapeDataList = shapeDataList
                });
            }

            // Close the PowerPoint presentation
            presentation.Close();

            // Quit PowerPoint application
            powerPointApp.Quit();

            // Convert slide data to JSON format
            string jsonData = JsonConvert.SerializeObject(slideDataList, Newtonsoft.Json.Formatting.Indented);

            try
            {
                // Save JSON data to the specified output file
                File.WriteAllText(outputFilePath, jsonData);

                MessageBox.Show("Parsing completed and JSON data saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving JSON data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnBrowsePPT_Click(object sender, EventArgs e)
        {
            // Show the file dialog to select a PowerPoint file
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PowerPoint Files|*.pptx;*.ppt",
                Title = "Select a PowerPoint File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected file path to the input file text box
                TBSourceFile.Text = openFileDialog.FileName;
            }
        }

        private void BtnBrouwseOutput_Click(object sender, EventArgs e)
        {
            // Show the folder dialog to select the output folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Select the Output Folder"
            };

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the selected folder path to the output folder text box
                TBOutputFile.Text = folderBrowserDialog.SelectedPath + "\\Output.JSON";
            }
        }
    }
    public class ShapeData
    {
        public string ShapeType { get; set; }
        public Rect Coordinates { get; set; }
        public string Text { get; set; }
    }

    public class Rect
    {
        public double Left { get; set; }
        public double Top { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
    }
}
