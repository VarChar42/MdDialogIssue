using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace MdDialogIssue;

/// <summary>
///     Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private readonly ObservableCollection<TabItem> mainWindowTabs;

    public MainWindow()
    {
        InitializeComponent();

        mainWindowTabs = new ObservableCollection<TabItem>();
    }

    private void AddPage(Page page, string header, bool selected = false)
    {
        var tabItem = new TabItem
        {
            IsSelected = selected,
            Header = header,
            Content = new Frame
            {
                Content = page
            }
        };
        mainWindowTabs.Add(tabItem); // TestControl.Items.Add(tabItem) fixes the issue
    }

    private void MainWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        TestControl.ItemsSource = mainWindowTabs;
        AddPage(new TestPage(), "TestPage",  true);
    }
}