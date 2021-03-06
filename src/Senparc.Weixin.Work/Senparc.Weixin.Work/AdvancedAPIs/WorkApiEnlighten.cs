﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.NeuChar.ApiHandlers;


namespace Senparc.Weixin.Work.AdvancedAPIs
{
    public class WorkApiEnlighten : ApiEnlighten
    {
        public static ApiEnlighten Instance = new WorkApiEnlighten();


        /// <summary>
        /// 发送文本客服消息
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <param name="openId"></param>
        /// <param name="content"></param>
        /// <returns></returns>
        public override ApiResult SendText(string accessTokenOrAppId, string openId, string content)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 发送图片客服消息
        /// </summary>
        /// <param name="accessTokenOrAppId"></param>
        /// <param name="openId"></param>
        /// <param name="mediaId"></param>
        /// <returns></returns>
        public override ApiResult SendImage(string accessTokenOrAppId, string openId, string mediaId)
        {
            throw new NotImplementedException();
        }
    }
}
