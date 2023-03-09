using Sitecore.ContentSearch;
using Sitecore.ContentSearch.SearchTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Feature.Blog.Models
{
    public class BlogSearchModel : SearchResultItem
    {
        [IndexField("_name")]
        public virtual string ItemName { get; set; }
        [IndexField("_uniqueid")]
        public virtual string ItemPath { get; set; }
        [IndexField("title_t")]
        public virtual string Title { get; set; } // Custom field on my template
        [IndexField("category_t")]
        public virtual string Category { get; set; } // Custom field on my template
        [IndexField("date_t")]
        public virtual DateTime Date { get; set; } // Custom field on my template
        [IndexField("smallimage")]
        public virtual string SmallImage { get; set; } // Custom field on my template
        [IndexField("bigimage")]
        public virtual string BigImage { get; set; } // Custom field on my template
        [IndexField("shorttext_t")]
        public virtual string ShortText { get; set; } // Custom field on my template
        [IndexField("longtext_t")]
        public virtual string LongText { get; set; } // Custom field on my template
        [IndexField("tags_t")]
        public virtual string Tags { get; set; } // Custom field on my template
    }
    public class SearchResult
    {
        public string ItemName { get; set; }
        public string ItemPath { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }
        public string SmallImage { get; set; }
        public string BigImage { get; set; }
        public string ShortText { get; set; }
        public string LongText { get; set; }
        public string Tags { get; set; }
    }
    /// <summary>
    /// Custom search result model for binding to front end
    /// </summary>
    public class SearchResults
    {
        public List<SearchResult> Results { get; set; }
    }
}
