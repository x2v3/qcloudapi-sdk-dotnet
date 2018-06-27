using System;
using System.Collections.Generic;
using System.Text;

namespace QCloudAPI_SDK.Module
{
    public class ImageRecognition : BaseV20180321
    {
        public ImageRecognition()
        {
            serverHost = "recognition.image.myqcloud.com";
        }
    }

    public class GeneralImageRecognition : ImageRecognition
    {
        public GeneralImageRecognition()
        {
            serverUri = "/ocr/general";
        }
    }
}