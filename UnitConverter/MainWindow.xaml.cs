using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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
            string currentType = UnitTypeComboBox.SelectedItem.ToString().Split(new string[] { ": " }, StringSplitOptions.None).Last();
            Unit1TextBox.Text = "";
            Unit2TextBox.Text = "";
            Unit1ComboBox.Items.Clear();
            Unit2ComboBox.Items.Clear();

            switch (currentType) {

                case "Mass":
                    for(int i=0; i<Enum.GetNames(typeof(MassEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((MassEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((MassEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 2;
                    Unit2ComboBox.SelectedIndex = 1;
                    break;

                case "Temperature":
                    for (int i = 0; i < Enum.GetNames(typeof(TemperatureEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((TemperatureEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((TemperatureEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 0;
                    Unit2ComboBox.SelectedIndex = 1;
                    break;

                case "Length":
                    for (int i = 0; i < Enum.GetNames(typeof(LengthEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((LengthEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((LengthEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 1;
                    Unit2ComboBox.SelectedIndex = 2;
                    break;

                case "Area":
                    for (int i = 0; i < Enum.GetNames(typeof(AreaEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((AreaEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((AreaEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 1;
                    Unit2ComboBox.SelectedIndex = 0;
                    break;

                case "Pressure":
                    for (int i = 0; i < Enum.GetNames(typeof(PressureEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((PressureEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((PressureEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 0;
                    Unit2ComboBox.SelectedIndex = 2;
                    break;

                case "Speed":
                    for (int i = 0; i < Enum.GetNames(typeof(SpeedEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((SpeedEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((SpeedEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 0;
                    Unit2ComboBox.SelectedIndex = 1;
                    break;

                case "Time":
                    for (int i = 0; i < Enum.GetNames(typeof(TimeEnum)).Length; i++) {
                        Unit1ComboBox.Items.Add(EnumDescription.GetEnumDescription((TimeEnum)i));
                        Unit2ComboBox.Items.Add(EnumDescription.GetEnumDescription((TimeEnum)i));
                    }
                    Unit1ComboBox.SelectedIndex = 2;
                    Unit2ComboBox.SelectedIndex = 1;
                    break;
            }
        }

        private void ConvertButton_Click(object sender, RoutedEventArgs e) {
            Unit2TextBox.Text = "";
            if (double.TryParse(Unit1TextBox.Text, out double unitValue)) {
                try {
                    if (Unit2ComboBox.Text.Equals(Unit1ComboBox.Text)) {
                        Unit2TextBox.Text = Unit1TextBox.Text;
                    }
                    else {
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

                            case "Area":
                                Unit2TextBox.Text = convert.areaConvert().ToString();
                                break;

                            case "Pressure":
                                Unit2TextBox.Text = convert.pressureConvert().ToString();
                                break;

                            case "Speed":
                                Unit2TextBox.Text = convert.speedConvert().ToString();
                                break;

                            case "Time":
                                Unit2TextBox.Text = convert.timeConvert().ToString();
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