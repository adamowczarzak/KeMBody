using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace KeMBody.UI.CustomControls
{
    public class NumericUpDown : Control
    {
        static NumericUpDown()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(NumericUpDown), new
               FrameworkPropertyMetadata(typeof(NumericUpDown)));
        }

    }
}
