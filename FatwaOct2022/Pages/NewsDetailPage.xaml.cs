using FatwaOct2022.Models;

namespace FatwaOct2022;

public partial class NewsDetailPage : ContentPage
{
    private string uri;
    public NewsDetailPage(Root root)
    {
        BindingContext = this;
        InitializeComponent();
        ImgNews.Source = ImageSource.FromUri(new Uri(root.Image));
        LblTitle.Text = root.Title.ToString();
        LblContent.Text = root.Content.ToString();
        uri = root.Url.ToString();
    }

    //private async void TbShare_Clicked(object sender, EventArgs e)
    //{
    //    await Share.RequestAsync(new ShareTextRequest
    //    {
    //        Uri = uri,
    //        Title = "Share"
    //    });

    //}
}