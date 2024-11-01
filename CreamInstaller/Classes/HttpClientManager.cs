﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using HtmlAgilityPack;

namespace CreamInstaller.Classes;

internal static class HttpClientManager
{
    private static HttpClient httpClient;
    internal static void Setup()
    {
        httpClient = new();
        httpClient.DefaultRequestHeaders.Add("user-agent", $"CreamInstaller-{Environment.MachineName}_{Environment.UserDomainName}_{Environment.UserName}");
    }

    internal static async Task<HtmlNodeCollection> GetDocumentNodes(string url, string xpath)
    {
        try
        {
            using HttpRequestMessage request = new(HttpMethod.Get, url);
            using HttpResponseMessage response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();
            using Stream stream = await response.Content.ReadAsStreamAsync();
            using StreamReader reader = new(stream, Encoding.UTF8);
            HtmlDocument document = new();
            document.LoadHtml(reader.ReadToEnd());
            return document.DocumentNode.SelectNodes(xpath);
        }
        catch { return null; }
    }

    internal static async Task<Image> GetImageFromUrl(string url)
    {
        try
        {
            return new Bitmap(await httpClient.GetStreamAsync(url));
        }
        catch { }
        return null;
    }

    internal static async Task ParseSteamStoreDlcAppIds(int appId, List<int> dlcIds)
    {
        // currently this is only really needed to get DLC that release without changing game buildid (very rare)
        // it also finds things which aren't really connected to the game itself, and thus not needed (usually soundtracks, collections, packs, etc.)
        HtmlNodeCollection nodes = await GetDocumentNodes(
                        $"https://store.steampowered.com/dlc/{appId}",
                        "//div[@class='recommendation']/div/a");
        if (nodes is not null)
            foreach (HtmlNode node in nodes)
                if (int.TryParse(node.Attributes?["data-ds-appid"]?.Value, out int dlcAppId) && dlcAppId > 0 && !dlcIds.Contains(dlcAppId))
                    dlcIds.Add(dlcAppId);
    }

    internal static void Dispose() => httpClient.Dispose();
}
