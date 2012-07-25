using System.Collections.ObjectModel;
using System.Linq;
using AklMetro.Model;
using Newtonsoft.Json;

namespace AklMetro
{
    public class ViewModel
    {
        private readonly IService _service;

        public ViewModel(IService service)
        {
            _service = service;
            Groups = new ObservableCollection<GroupViewModel<string, Question>>();

            GetDataAsync();
        }

        private async void GetDataAsync()
        {
            var json = await _service.GetQuestionsAsync();
            var response = JsonConvert.DeserializeObject<QuestionResponse>(json);

            var groups = (from item in response.items
                         group item by item.answer_count into g
                         select new {g.Key, Items = g})
                         .OrderBy(g => g.Key);

            foreach (var group in groups)
            {
                Groups.Add(new GroupViewModel<string, Question>(group.Key.ToString(), group.Items));
            }
        }

        public ObservableCollection<GroupViewModel<string, Question>> Groups { get; private set; } 
    }
}