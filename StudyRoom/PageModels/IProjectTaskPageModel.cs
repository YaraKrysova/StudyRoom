using CommunityToolkit.Mvvm.Input;
using StudyRoom.Models;

namespace StudyRoom.PageModels;

public interface IProjectTaskPageModel
{
    IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
    bool IsBusy { get; }
}