using System;
using AklMetro.Model;
using Windows.System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace AklMetro
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = new ViewModel(new FakeService());
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            zoomedOutGridView.ItemsSource = viewSource.View.CollectionGroups;
        }

        private void OnQuestionClicked(object sender, ItemClickEventArgs e)
        {
            var question = e.ClickedItem as Question;
            if (question == null) return;

            Launcher.LaunchUriAsync(new Uri(question.link));
        }
    }
}
