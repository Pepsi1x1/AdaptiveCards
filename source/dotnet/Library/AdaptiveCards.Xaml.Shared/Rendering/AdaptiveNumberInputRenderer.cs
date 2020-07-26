// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
using System.Windows;
#if WPF
using System.Windows.Controls;
#elif XAMARIN
using Xamarin.Forms;
using FrameworkElement = Xamarin.Forms.View;
#endif

namespace AdaptiveCards.Rendering.Wpf
{
    public static class AdaptiveNumberInputRenderer
    {
        public static FrameworkElement Render(AdaptiveNumberInput input, AdaptiveRenderContext context)
        {
            var textBox = new TextBox() { Text = input.Value.ToString() };
            textBox.SetPlaceholder(input.Placeholder);
            textBox.Style = context.GetStyle($"Adaptive.Input.Text.Number");
            textBox.SetContext(input);

            context.InputValues.Add(input.Id, new AdaptiveNumberInputValue(input, textBox));

            return textBox;
        }
    }
}
