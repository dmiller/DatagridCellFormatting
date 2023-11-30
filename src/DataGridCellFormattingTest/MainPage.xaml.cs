using CommunityToolkit.WinUI.UI.Controls;
using DataGridCellFormattingTest.Lib;
using Microsoft.UI.Xaml.Controls;
using System.Collections.Generic;
using Windows.Networking.NetworkOperators;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataGridCellFormattingTest;

/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        var cs = dg1.CellStyle;
        var rs = dg1.RowStyle;

        bool b = cs.IsSealed;
        bool b2 = rs.IsSealed;

        var ps = cs.Setters;

        dg1.CellStyle = BigBoy;

        cs.Setters.Add(new Microsoft.UI.Xaml.Setter(DataGridCell.PaddingProperty, new Microsoft.UI.Xaml.Thickness(0, 0, 0, 0)));
        cs.Setters.Add(new Microsoft.UI.Xaml.Setter(DataGridCell.MarginProperty, new Microsoft.UI.Xaml.Thickness(0, 0, 0, 0)));
        cs.Setters.Add(new Microsoft.UI.Xaml.Setter(DataGridCell.MinHeightProperty, 10));


        var t = dg1.Template;
        var tt = t.TargetType;


        var rdt = dg1.RowDetailsTemplate;

        var rh = dg1.RowHeight;
        dg1.RowHeight = 10;
   
    }




    public List<Item> Items = new List<Item>()
        {
            new Item() { Name = "Item 1", Value = 1 },
            new Item() { Name = "Item 2", Value = 2 },
            new Item() { Name = "Item 3", Value = 3 },
            new Item() { Name = "Item 4", Value = 4 },
            new Item() { Name = "Item 5", Value = 5 },
            new Item() { Name = "Item 6", Value = 6 },
            new Item() { Name = "Item 7", Value = 7 },
            new Item() { Name = "Item 8", Value = 8 },
            new Item() { Name = "Item 9", Value = 9 },
            new Item() { Name = "Item 10", Value = 10 },
            new Item() { Name = "Item 11", Value = 11 },
            new Item() { Name = "Item 12", Value = 12 },
            new Item() { Name = "Item 13", Value = 13 },
            new Item() { Name = "Item 14", Value = 14 },
            new Item() { Name = "Item 15", Value = 15 },
            new Item() { Name = "Item 16", Value = 16 },
            new Item() { Name = "Item 17", Value = 17 },
            new Item() { Name = "Item 18", Value = 18 },
            new Item() { Name = "Item 19", Value = 19 },
            new Item() { Name = "Item 20", Value = 20 },
            new Item() { Name = "Item 21", Value = 21 },
            new Item() { Name = "Item 22", Value = 22 },
            new Item() { Name = "Item 23", Value = 23 },
            new Item() { Name = "Item 24", Value = 24 },
            new Item() { Name = "Item 25", Value = 25 },
            new Item() { Name = "Item 26", Value = 26 },
            new Item() { Name = "Item 27", Value = 27 },
            new Item() { Name = "Item 28", Value = 28 },

        };

    private void Button_Click(object sender, Microsoft.UI.Xaml.RoutedEventArgs e)
    {
        var t = dg1.Template;
    }

    private void dg1_LoadingRow(object sender, CommunityToolkit.WinUI.UI.Controls.DataGridRowEventArgs e)
    {
        DataGrid dg = sender as DataGrid;
        var r = e.Row;
        r.Padding = new Microsoft.UI.Xaml.Thickness(0, 0, 0, 0);
        r.Margin = new Microsoft.UI.Xaml.Thickness(0, 0, 0, 0);
        r.MinHeight = 10;
    }
}
