using System;
using System.Collections.Generic;
using System.Text;

namespace TeduCoreApp.Data.Interfaces
{
    public interface IHasSeoMetaData
    {
        string SeoPageTitle { set; get; }
        string SelAlias { set; get; }
        string SeoKeywords { get; set; }
        string SeoDescription { get; set; }

    }
}
