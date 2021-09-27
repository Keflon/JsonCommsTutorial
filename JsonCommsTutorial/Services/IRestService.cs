using System.Threading.Tasks;

namespace JsonCommsTutorial.Services
{
    public interface IRestService
    {
        Task<TResponse> GetAsync<TResponse>(string url);
        // TODO:
        Task<TResponse> PostAsync<TRequest, TResponse>(TRequest request, string url);
    }
}