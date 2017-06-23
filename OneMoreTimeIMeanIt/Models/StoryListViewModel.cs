
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneMoreTimeIMeanIt.Models
{
    public class StoryListViewModel
    {
        public List<Story> Stories { get; set; }
        public string StorySubmitted { get; set; }
        public string Submitter { get; set; }

        public StoryListViewModel()
        {
            Stories = new List<Story>();
        }
    }
}