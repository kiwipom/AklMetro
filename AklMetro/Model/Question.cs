using System.Collections.Generic;

namespace AklMetro.Model
{
    public class Question
    {
        public int question_id { get; set; }
        public long creation_date { get; set; }
        public long last_activity_date { get; set; }
        public int score { get; set; }
        public int answer_count { get; set; }
        public string title { get; set; }
        public List<string> tags  { get; set; }
        public int view_count { get; set; }
        public Owner owner { get; set; }
        public string link  { get; set; }
        public bool is_answered { get; set; }
    }
}