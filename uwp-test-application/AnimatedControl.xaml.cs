using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace uwp_test_application
{
    public sealed partial class AnimatedControl : UserControl
    {
        public AnimatedControl()
        {
            this.InitializeComponent();
            Loaded += AnimatedControl_Loaded;
        }

        private void AnimatedControl_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Delay((new Random()).Next(0, 500)).ContinueWith(RunAnimation);
        }

        private async void RunAnimation(Task arg1)
        {
            await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                gradientAnimation.Begin();
            });
        }
    }
}
