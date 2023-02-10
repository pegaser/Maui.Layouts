namespace Homework
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            Loaded += MainPage_Loaded;
        }
        private void MainPage_Loaded(object sender, EventArgs e)
        {
            Grid absoluteGrid = new Grid();
            absoluteGrid.HeightRequest = 200;
            RowDefinition row1 = new RowDefinition() { Height = 30 };
            RowDefinition row2 = new RowDefinition() { Height = 30 };
            RowDefinition row3 = new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) };
            absoluteGrid.AddRowDefinition(row1);
            absoluteGrid.AddRowDefinition(row2);
            absoluteGrid.AddRowDefinition(row3);

            ColumnDefinition column1 = new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Auto) };
            ColumnDefinition column2 = new ColumnDefinition() { Width = 100 };
            absoluteGrid.AddColumnDefinition(column1);
            absoluteGrid.AddColumnDefinition(column2);

            BoxView myBox1 = new BoxView() { Color = Colors.Violet, Margin = 5, WidthRequest=400};
            BoxView myBox2 = new BoxView() { Color = Colors.Violet, Margin = 5 };
            BoxView myBox3 = new BoxView() { Color = Colors.Fuchsia, Margin = 5 };
            BoxView myBox4 = new BoxView() { Color = Colors.Fuchsia, Margin = 5 };
            BoxView myBox5 = new BoxView() { Color = Colors.Lime, Margin = 5 };
            BoxView myBox6 = new BoxView() { Color = Colors.Lime, Margin = 5 };

            absoluteGrid.Add(myBox1, 0, 0);
            absoluteGrid.Add(myBox2, 1, 0);
            absoluteGrid.Add(myBox3, 0, 1);
            absoluteGrid.Add(myBox4, 1, 1);
            absoluteGrid.Add(myBox5, 0, 2);
            absoluteGrid.Add(myBox6, 1, 2);

            rootLayout.Children.Add(absoluteGrid);
        }
    }
}