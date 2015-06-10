﻿#region
using System.Collections.Generic;

#endregion

namespace VirtoCommerce.Web.Views.Contents
{
    public class SiteStaticContentContext
    {
        public SiteStaticContentContext()
        {
            
        }
        #region Public Properties
        public Dictionary<string, ContentItem[]> Collections { get; set; }

        public Dictionary<string, object> Config { get; set; }

        public string SourceFolder { get; set; }
        #endregion
    }
}