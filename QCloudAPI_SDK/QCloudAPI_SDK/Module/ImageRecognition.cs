using System;
using System.Collections.Generic;
using System.Text;
using QCloudAPI_SDK.Common;

namespace QCloudAPI_SDK.Module
{
    public class ImageRecognition : BaseV20180321
    {
        public ImageRecognition()
        {
            serverHost = "recognition.image.myqcloud.com";
        }

        public int Appid { get; set; }

        public override string Call(string actionName, SortedDictionary<string, object> requestParams, string fileName = null, string reqMethod = null)
        {
            var text = Sign.MakeImageMultiSignPlainText(Appid.ToString(), secretId);
            var auth = Sign.Signature(text, secretKey);
            additionalHeaders.Add(new KeyValuePair<string, string>("Authorization", auth));
            return base.Call(actionName, requestParams, fileName, reqMethod);
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