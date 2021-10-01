using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using System.Threading.Tasks;

namespace NCM_Utilities.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            Button B1 = this.Get<Button>("Button_GetInfo"); B1.Content = "解析";
        }

        public async void Button_GetInfo(object sender, RoutedEventArgs e)
        {
            bool IfSucceed = true;
            var button = (Button)sender;


            //datagrid.
            

            if (IfSucceed)
            {
                button.Content = "解析成功√"; ;
                await Task.Delay(3000);
                button.Content = "解析";
            }


        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
