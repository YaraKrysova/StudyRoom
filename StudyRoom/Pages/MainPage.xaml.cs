using StudyRoom.Models;
using StudyRoom.PageModels;
using Microsoft.Maui.Controls;

namespace StudyRoom.Pages;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        BindingContext = new PomodoroViewModel();
    }
}