using CorelXTools.Core.MenuSystem;
using CorelXTools.Core;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace CorelXTools.UI
{
    public partial class MainToolbar : UserControl
    {

        private void SubMenu_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is MenuItem menuItem)
            {
                if (menuItem.DataContext is MenuItemModel item)
                {
                    ModuleManager.Open(item.Action);
                }
            }
        }

        private void MenuButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            if (sender is Button button)
            {
                button.ContextMenu.PlacementTarget = button;
                button.ContextMenu.IsOpen = true;
            }
        }

        public ObservableCollection<MenuItemModel> MenuItems
        {
            get;
            set;
        }


        public MainToolbar()
        {
            InitializeComponent();


            MenuItems =
                new ObservableCollection<MenuItemModel>(
                    MenuProvider.GetMainMenu()
                );


            DataContext = this;

        }

    }
}