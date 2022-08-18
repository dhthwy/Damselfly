﻿using System;
using System.Net.Http;
using System.Net.Http.Json;
using Damselfly.Core.Models;
using Damselfly.Core.ScopedServices.Interfaces;

namespace Damselfly.Core.ScopedServices;

public class ClientFolderService : BaseClientService, IFolderService
{
    public ClientFolderService(HttpClient client, ClientNotificationsService notificationService) : base(client)
    {
        Console.WriteLine($"Initialising notifications: {notificationService}");
        _notificationService = notificationService;
    }

    private readonly ClientNotificationsService _notificationService;
    public event Action OnChange;

    public async Task<ICollection<Folder>> GetFolders()
    {
        return await httpClient.GetFromJsonAsync<ICollection<Folder>>("/api/folders");
    }
}

