using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalculation
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

        private void QuantitySlider_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var QuantitySlider = sender as Slider;

            var quantity = QuantitySlider.Value;
            SliderValue.Text = quantity.ToString();

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = WidthValue.Text;
            width = double.Parse(widthString);
            heightString = HeightValue.Text;
            height = double.Parse(heightString);


            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            LengthValue.Text = woodLength.ToString() + " feet";
            GlassValue.Text = glassArea.ToString() + " square meters";
            DateValue.Text = DateTime.Now.ToString("dddd, dd, MMMM, yyyy");
            
            }

        private void HeightValue_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string height = HeightValue.Text.Trim();
            for (int i = 0; i < height.Length; i++)
            {
                if (!char.IsNumber(height[i]))
                {
                    MessageBox.Text = "Please enter a vaild number.";
                    HeightValue.Text = "";
                    return;
                }else
                       {
                    MessageBox.Text = "";
                       }
            }
           
        }

        private void WidthValue_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string width = WidthValue.Text.Trim();
            for (int i = 0; i < width.Length; i++)
            {
                if (!char.IsNumber(width[i]))
                {
                    MessageBox.Text = "Please enter a vaild number.";
                    WidthValue.Text = "";
                    return;
                }
                else
                {
                    MessageBox.Text = "";
                }
            }
        }
    }
    }

