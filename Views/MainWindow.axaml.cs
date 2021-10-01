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
            Button B1 = this.Get<Button>("Button_GetInfo"); B1.Content = "����";
        }

        public async void Button_GetInfo(object sender, RoutedEventArgs e)
        {
            bool IfSucceed = true;
            var button = (Button)sender;


            //datagrid.
            

            if (IfSucceed)
            {
                button.Content = "�����ɹ���"; ;
                await Task.Delay(3000);
                button.Content = "����";
            }


        }


        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
