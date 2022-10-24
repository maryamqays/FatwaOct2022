using FatwaOct2022.Models;

namespace FatwaOct2022;

public partial class NewsDetailPage : ContentPage
{
    //private string uri;
    public NewsDetailPage(Root article)
    {
        InitializeComponent();
        //ImgNews.Source = Root.Image;
        //LblTitle.Text = article.Title;
        //LblContent.Text = article.Content;
        //uri = article.Url;
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