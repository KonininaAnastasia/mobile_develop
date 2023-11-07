namespace wfaSearchCity
{
    public partial class Form1 : Form
    {
        private string[] cities;

        public Form1()
        {
            InitializeComponent();

            cities = Properties.Resources.goroda.Split('\n'); //вместо Environment.NewLine можно использовать \n
            edSearch.TextChanged += edSearch_TextChanged;

            this.Text += $" : {cities.Count()}";
        }

        private void edSearch_TextChanged(object? sender, EventArgs e)
        {
            var r = cities
                .Where(v => v.ToUpper().Contains(edSearch.Text.ToUpper()))
                .OrderBy(v => v)
                .Take(100)
                .ToArray();
            edResult.Text = string.Join(Environment.NewLine, r);
        }
    }
}