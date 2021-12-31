﻿namespace Client.Static;

public static class APIEndpoints
{
#if DEBUG
    private const string ServerBaseUrl = "https://localhost:7062";
#else
    private const string ServerBaseUrl = "https://wasmwithaspnetcoreminicourse-server-test.azurewebsites.net";
#endif

    internal const string PostsAll = $"{ServerBaseUrl}/posts/all";
    internal const string PostsCreate = $"{ServerBaseUrl}/posts/create";

    internal static string PostsById(int id) => $"{ServerBaseUrl}/posts/by-id/{id}";    
    internal static string PostsUpdate(int id) => $"{ServerBaseUrl}/posts/update/{id}";
    internal static string PostsDelete(int id) => $"{ServerBaseUrl}/posts/delete/{id}";
}