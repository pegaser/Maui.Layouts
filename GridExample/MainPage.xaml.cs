namespace GridExample
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
            RowDefinition row1= new RowDefinition() { Height= 30 };
            RowDefinition row2 = new RowDefinition() { Height = new GridLength(1, GridUnitType.Auto) };
            absoluteGrid.AddRowDefinition(row1);
            absoluteGrid.AddRowDefinition(row2);

            ColumnDefinition column1 = new ColumnDefinition() { Width = 400 };
            absoluteGrid.AddColumnDefinition(column1);

            BoxView myBox1 = new BoxView() { Color = Colors.Violet, Margin = 5 };
            BoxView myBox2 = new BoxView() { Color = Colors.Violet, Margin = 5 };

            absoluteGrid.Add(myBox1, 0, 0);
            absoluteGrid.Add(myBox2, 0, 2);

            rootLayout.Children.Add(absoluteGrid);
        }
    }
}