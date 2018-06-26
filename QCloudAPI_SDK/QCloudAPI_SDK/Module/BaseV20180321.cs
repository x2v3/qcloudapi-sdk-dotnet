using System;
using System.Collections.Generic;
using System.Text;

namespace QCloudAPI_SDK.Module
{
    public class BaseV20180321 : Base
    {
        public BaseV20180321()
        {
            serverUri = "/";
        }

        protected override void HookParameters(string actionName, SortedDictionary<string, object> requestParams)
        {
            base.HookParameters(actionName, requestParams);
            requestParams["Version"] = "2018-03-21";
        }
    }
}