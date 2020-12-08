using System.IO;
using System.Threading.Tasks;

namespace eShopSolution.Application.Common
{
    /// <summary>
    /// save file and get file
    /// </summary>
    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);
    }
}