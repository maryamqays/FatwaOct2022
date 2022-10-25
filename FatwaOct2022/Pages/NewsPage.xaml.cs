using FatwaOct2022.Models;
using FatwaOct2022.Services;
namespace FatwaOct2022;

public partial class NewsPage : ContentPage
{
    private bool IsNextPage = false;
    public List<Root> ArticlesList { get; set; }



    public NewsPage()
    {
        InitializeComponent();
        ArticlesList = new List<Root>();
        BindingContext = this;

    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        //if (IsNextPage == false)
        //{
            await PassCategory("breaking-news");
        //}

    }


    public async Task PassCategory(string categoryName)
    {
        CvNews.ItemsSource = null;
        ArticlesList.Clear();
        ApiService apiService = new ApiService();
        var newsResult = await apiService.GetNews();

        foreach (var item in newsResult)
        {
            ArticlesList.Add(item);
        }
        CvNews.ItemsSource = ArticlesList;
    }

    private void CvNews_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Root;
        //if (selectedItem == null) return;
        IsNextPage = true;
        Navigation.PushAsync(new NewsDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}