using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalcUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            Slider slide = sender as Slider;
            txtQuanity.Text = slide.Value.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = widthInput.Text;
            width = double.Parse(widthString);
            heightString = heightInput.Text;
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            lengthOutput.Text = woodLength.ToString();
            areaOutput.Text = glassArea.ToString();
        }

        private void widthInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string value = widthInput.Text;
            double number;
            if (Double.TryParse(value, out number))
            {
                if (number > 0)
                {
                    widthInput.BorderBrush = new SolidColorBrush(Colors.Gray);
                }
                else
                {
                    widthInput.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
            else
            {
                widthInput.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }

        private void heightInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            string value = heightInput.Text;
            double number;
            if (Double.TryParse(value, out number))
            {
                if (number > 0)
                {
                    heightInput.BorderBrush = new SolidColorBrush(Colors.Gray);
                }
                else
                {
                    heightInput.BorderBrush = new SolidColorBrush(Colors.Red);
                }
            }
            else
            {
                heightInput.BorderBrush = new SolidColorBrush(Colors.Red);
            }
        }
    }
}
