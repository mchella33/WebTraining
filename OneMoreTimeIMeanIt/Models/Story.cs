
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneMoreTimeIMeanIt.Models
{
    public class Story
    {
        public int StoryId { get; set; }
        public string StorySubmitted { get; set; }
        public string Submitter { get; set; }

        public Story()
        {
            
        }
    }
    
}