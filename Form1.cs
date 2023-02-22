using System.Linq;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class WeatherForm : Form
    {
        private WeatherDatabase _weather;

        public WeatherForm()
        {
            InitializeComponent();

            _weather = new WeatherDatabase();
            _weather.Initialize();
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            WeatherDataGrid.DataSource = _weather.Weathers.ToList();
            filtr.Items.AddRange( new object[3]
            {
                
                MeasureUnits.Celsius,
                MeasureUnits.Fahrenheit,
                MeasureUnits.Kelvin
            });
            
        }

        private void textBox1_TextChanged(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(poisk.Text))
            {
                WeatherDataGrid.DataSource = _weather.Weathers.ToList();
            }
            else
            {
                var gorod = _weather.Weathers.Where(s => s.CityName.ToLower().Contains(poisk.Text.ToLower())).ToList();
                WeatherDataGrid.DataSource = gorod;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
            MeasureUnits m = new MeasureUnits();
            switch (filtr.SelectedItem)
            {
                case MeasureUnits.Celsius:
                    m = MeasureUnits.Celsius;
                    break;
                case MeasureUnits.Kelvin:
                    m = MeasureUnits.Kelvin;
                    break;
                case MeasureUnits.Fahrenheit: 
                    m = MeasureUnits.Fahrenheit;
                    break;
            }
            
            var ed = _weather.Weathers.Where(s => s.MeasureUnit == m).ToList();
            WeatherDataGrid.DataSource = ed;

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            var grad = _weather.Weathers.Where(s => s.Temperature > 0).ToList();    
            WeatherDataGrid.DataSource = grad;
        }

        private void sbroc_Click(object sender, System.EventArgs e)
        {
            WeatherDataGrid.DataSource = _weather.Weathers.ToList();
            return;
        }

        private void sortirovka_Click(object sender, System.EventArgs e)
        {
            var sort = _weather.Weathers.OrderBy(s => s.Temperature).ToList();
            WeatherDataGrid.DataSource = sort;
        }
    }
}