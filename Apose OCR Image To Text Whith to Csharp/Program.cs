using System;

namespace Apose_OCR_Image_To_Text_Whith_to_Csharp
{
    internal class Program
    {
        public static object RunExamples { get; private set; }

        static void Main(string[] args)
        {

            // For complete examples and data files, please go to https://github.com/aspose-ocr/Aspose.OCR-for-.NET
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_OCR();

            // Initialize an instance of AsposeOcr
            AsposeOcr api = new AsposeOcr();

            // Recognize image
            string result = api.RecognizeLine(dataDir + "sample_line.png");

            // Display the recognized text
            Console.WriteLine(result);

        }
    }
}
