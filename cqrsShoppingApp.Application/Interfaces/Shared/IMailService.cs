using cqrsShoppingApp.Application.DTOs.Mail;
using System.Threading.Tasks;

namespace cqrsShoppingApp.Application.Shared
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}