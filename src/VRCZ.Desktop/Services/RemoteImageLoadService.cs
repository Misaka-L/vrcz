using System.Net.Http;
using System.Threading.Tasks;
using Avalonia.Media.Imaging;

namespace VRCZ.Desktop.Services;

public class RemoteImageLoadService(HttpClient httpClient)
{
    public async Task<Bitmap?> LoadImageAsync(string url)
    {
        var response = await httpClient.GetAsync(url);

        if (!response.IsSuccessStatusCode)
            return null;

        var stream = await response.Content.ReadAsStreamAsync();
        return new Bitmap(stream);
    }
}
