using System;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Markup;

namespace CustomCellEditors {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            grid.ItemsSource = new ProductList();
        }
    }
    public class IntToDoubleConverter : MarkupExtension, IValueConverter {

        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }

        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return Convert.ToDouble(value);
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return Convert.ToInt32(value);
        }
    }
}

