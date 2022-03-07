using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using DriveSyncDesktop.ApiModels;

namespace DriveSyncDesktop.Service;

public class RCloneApiService
{
    private static readonly HttpClient HttpClient = new();
    private readonly string _url;

    public RCloneApiService(string url)
    {
        _url = url;
    }

    public async Task<RemoteListsApiModel?> GetRemotes()
    {
        var response = await HttpClient.PostAsync($"{_url}/config/listremotes", null);
        return await response.Content.ReadFromJsonAsync<RemoteListsApiModel>();
    }

    public async Task RemoveConfig(DeleteConfigApiModel model)
    {
        await HttpClient.PostAsJsonAsync($"http://localhost:3000", model);
    }
}