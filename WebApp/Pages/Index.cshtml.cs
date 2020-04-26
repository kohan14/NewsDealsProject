using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WebApp.Classes;
using WebApp.Data;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IData data;
        private readonly IConfiguration config;
        public Article TestArticle { get; set; }
        public IEnumerable<Article> Articles { get; set; }
        public IndexModel(ILogger<IndexModel> logger, IData data, IConfiguration config)
        {
            _logger = logger;
            this.data = data;
            this.config = config;
        }

        

        public void OnGet()
        {
            Articles = data.GetArticlesFromMemory();
            TestArticle = Articles.FirstOrDefault(a => a.Id == 1);
        }
    }
}
