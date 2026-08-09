using System.Windows;
using System.Windows.Input;


namespace CorelXTools.UI
{
    public partial class ToolWindow : Window
    {


        public ToolWindow()
        {
            InitializeComponent();
        }



        public void SetContent(object content)
        {
            ContentArea.Content = content;
        }




        public void SetTitle(string title)
        {
            TitleText.Text = title;
        }




        private void TitleBar_MouseDown(
            object sender,
            MouseButtonEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }

        }




        private void Close_Click(
            object sender,
            RoutedEventArgs e)
        {

            Close();

        }




        private void Minimize_Click(
            object sender,
            RoutedEventArgs e)
        {

            WindowState = WindowState.Minimized;

        }


    }
}