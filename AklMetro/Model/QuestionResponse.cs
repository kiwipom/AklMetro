using System.Collections.Generic;

namespace AklMetro.Model
{
    public class QuestionResponse
    {
        public List<Question> items { get; set; }
        public int quota_remaining { get; set; }
        public int quota_max { get; set; }
        public bool has_more { get; set; }
    }
}