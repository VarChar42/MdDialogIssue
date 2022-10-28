using System.Windows;
using System.Windows.Controls;
using MaterialDesignThemes.Wpf;

namespace MdDialogIssue;

public partial class TestPage : Page
{
    public TestPage()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        DialogHost.Show(new TestUserControl(), "TestDialog");
    }
}