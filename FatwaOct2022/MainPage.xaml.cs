namespace FatwaOct2022;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }


    private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
    {
        activityindicator.IsRunning = true;
    }

    private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
    {
        activityindicator.IsRunning = false;
    }

}

