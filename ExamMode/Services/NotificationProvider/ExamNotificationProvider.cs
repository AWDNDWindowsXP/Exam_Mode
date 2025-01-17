using ClassIsland.Core.Abstractions.Services;
using ClassIsland.Shared.Interfaces;
using MaterialDesignThemes.Wpf;
using Microsoft.Extensions.Hosting;

namespace ExamNotificationProviders.Services.NotificationProviders;

public class ExamNotificationProvider : INotificationProvider, IHostedService
{
    public string Name { get; set; } = "考试提醒提供方";
    public string Description { get; set; } = "考试提醒";
    public Guid ProviderGuid { get; set; } = new Guid("DD3BC389-BEA9-40B7-912B-C7C37390A101");
    public object? SettingsElement { get; set; }
    public object? IconElement { get; set; } = new PackIcon()
    {
        Kind = PackIconKind.TextBoxEdit,
        Width = 24,
        Height = 24
    };
    private INotificationHostService NotificationHostService { get; }

    public ExamNotificationProvider(INotificationHostService notificationHostService)
    {
        NotificationHostService = notificationHostService;
        NotificationHostService.RegisterNotificationProvider(this);
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
    }

    public async Task StopAsync(CancellationToken cancellationToken)
    {
    }
}