﻿using System;
using System.IO;
using System.Collections;
using Aspose.OMR;

namespace Aspose.OCR.Examples.CSharp.PerformingandManagingOCR
{
    class LoadTemplateFromUrl
    {
        public static void Run()
        {
            // ExStart:LoadTemplateFromUrl   
            string templateUrl = "https://Github.com/asposeocr/Aspose_OCR_NET/raw/master/Examples/Data/OCR/questions.amr";
            string imageUrl = "https://Github.com/asposeocr/Aspose_OCR_NET/raw/master/Examples/Data/OCR/answers.jpg";

            // Initialize an instance of OmrTemplate by loading the OMR template from URL
            OmrTemplate template = OmrTemplate.LoadFromUrl(templateUrl);

            // image loading from url
            OmrImage image = OmrImage.LoadFromUrl(imageUrl);

            // continue working with template and image as usual
            OmrEngine engine = new OmrEngine(template);
            OmrProcessingResult result = engine.ExtractData(new OmrImage[] { image });

            // Get all page data into an instance of Hashtable
            Hashtable[] pages = result.PageData;
            // Loop over all the pages
            foreach (Hashtable page in pages)
            {
                // Display key and value
                foreach (string key in page.Keys)
                {
                    Console.WriteLine("[KEY] " + key + " => " + "[VALUE] " + page[key]);
                }
            }
            // ExEnd:LoadTemplateFromUrl   
        } 
    }
}
