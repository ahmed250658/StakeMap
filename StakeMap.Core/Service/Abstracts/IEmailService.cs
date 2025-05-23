namespace StakeMap.Core.Service.Abstracts
{
    public interface IEmailService
    {
        public Task SendEmail(string receptor, string subject, string body);
    }
}
