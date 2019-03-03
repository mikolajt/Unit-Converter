using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UnitConverter {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private bool handle = true;

        public MainWindow() {
            InitializeComponent();
        }

        private void UnitTypeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ComboBox cmb = sender as ComboBox;
            handle = !cmb.IsDropDownOpen;
            Handle();
        }

        private void Handle() {
            ComboBoxLists cbl = new ComboBoxLists(UnitTypeComboBox.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last());
            List<string> cblList = cbl.CreateList();
            Unit1ComboBox.ItemsSource = cblList;
            Unit2ComboBox.ItemsSource = cblList;
            Unit1ComboBox.SelectedIndex = 0;
            Unit2ComboBox.SelectedIndex = 1;
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e) {
            Unit2TextBox.Text = "";
            if (double.TryParse(Unit1TextBox.Text, out double lol)) {
                try {
                    if (Unit2ComboBox.Text.Equals(Unit1ComboBox.Text)) {
                        Unit2TextBox.Text = Unit1TextBox.Text;
                    }
                    else {
                        Double.TryParse(Unit1TextBox.Text, out double unitValue);
                        Convert convert = new Convert(Unit1ComboBox.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last(), Unit2ComboBox.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last(), unitValue);
                        switch (UnitTypeComboBox.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last()) {

                            case "Mass":
                                Unit2TextBox.Text = convert.MassConvert().ToString();
                                break;

                            case "Temperature":
                                Unit2TextBox.Text = convert.TemperatureConvert().ToString();
                                break;

                            case "Length":
                                Unit2TextBox.Text = convert.lengthConvert().ToString();
                                break;
                        }
                    }
                }
                catch (NegativeValueException nve) {
                    MessageBox.Show(nve.Message);
                }
            }

            else MessageBox.Show("Error: Wrong Input");


        }
    }
}