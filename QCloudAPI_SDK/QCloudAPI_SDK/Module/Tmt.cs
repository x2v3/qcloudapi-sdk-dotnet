using System;
using System.Collections.Generic;
using System.Text;
using QCloudAPI_SDK.Common;

namespace QCloudAPI_SDK.Module
{
    public class Tmt : BaseV20180321
    {
        public Tmt()
        {
            serverHost = "tmt.tencentcloudapi.com";
            defaultRegion = "ap-beijing";
        }
    }
}