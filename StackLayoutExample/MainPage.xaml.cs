namespace StackLayoutExample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var a = new BoxView() { Color = Colors.Aquamarine, WidthRequest = 30 };
            var b = new BoxView() { Color = Colors.Azure, WidthRequest = 30 };
            var c = new BoxView() { Color = Colors.Beige, WidthRequest = 30 };

            MyStack.Children.Add(a);
            MyStack.Children.Add(b);
            MyStack.Children.Add(c);

        }
    }
}