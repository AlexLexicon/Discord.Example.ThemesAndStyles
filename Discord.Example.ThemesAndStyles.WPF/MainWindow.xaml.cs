using System.Collections.Generic;
using System.Windows;

namespace Discord.Example.ThemesAndStyles.WPF;
public partial class MainWindow : Window
{
    public MainWindow()
    {
        MyComboBoxItems = new List<string>
        {
            "Item 1",
            "Item 2",
            "Item 3",
        };

        InitializeComponent();
    }

    public List<string> MyComboBoxItems { get; }
}
