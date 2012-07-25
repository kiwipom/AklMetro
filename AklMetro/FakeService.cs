using System;
using System.Threading.Tasks;
using Windows.Storage;

namespace AklMetro
{
    class FakeService : IService
    {
        public async Task<string> GetQuestionsAsync()
        {
            var folder = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var file = await folder.GetFileAsync(@"Assets\questions.json");

            return await FileIO.ReadTextAsync(file);
        }
    }
}
