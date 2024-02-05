using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Threading;
using SukiUI.Utilities.Background;
using System;
using System.Timers;

namespace SukiUI.Controls;

public class SukiBackground : Grid
{
    public bool AnimationEnabled { get; private set; } = false;

    private readonly SukiTheme _theme;

    public SukiBackground()
    {
        Background = Brushes.Black;
        _theme = SukiTheme.GetInstance();
        _theme.RegisterBackground(this);
    }
}