using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using halloween_story.Server.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace halloween_story.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoryController : ControllerBase
    {
        private readonly ILogger<StoryController> logger;
        private readonly StoryDbContext storyDbContext;

        public StoryController(ILogger<StoryController> logger, StoryDbContext storyDbContext)
        {
            this.logger = logger;
            this.storyDbContext = storyDbContext;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return storyDbContext.StoryItems.OrderBy(s => s.Id).Select(s => s.Sentence).ToList();
        }

        [HttpPost]
        public IEnumerable<string> Post([FromBody] string sentence)
        {
            if (!string.IsNullOrWhiteSpace(sentence) && sentence.Length > 5)
            {
                storyDbContext.StoryItems.Add(new StoryItem { Sentence = sentence.Trim(), DateCreated = DateTime.Now });
                storyDbContext.SaveChanges();
            }
            return Get();
        }
    }
}