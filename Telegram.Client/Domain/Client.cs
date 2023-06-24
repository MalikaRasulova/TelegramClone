using Telegram.Client.Domain.Enums;
using TelegramChat.Domain;

namespace Telegram.Client.Domain;

public class Client : ModelBase
{
    public string FullName { get; set; }
    public DateTime BrithDate { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public List<Guid> Chats { get; set; }
    public ClientStatus ClientStatus { get; set; }
}