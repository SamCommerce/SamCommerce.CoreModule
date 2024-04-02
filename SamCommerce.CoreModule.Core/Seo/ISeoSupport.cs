using SamCommerce.Platform.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace SamCommerce.CoreModule.Core.Seo
{
    public interface ISeoSupport : IEntity
    {
        string SeoObjectType { get; }
        IList<SeoInfo> SeoInfos { get; set; }
    }
}
