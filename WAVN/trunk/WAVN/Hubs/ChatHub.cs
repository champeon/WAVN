using Microsoft.AspNet.SignalR;
//using Microsoft.AspNet.SignalR.Hubs;

namespace WAVN.Hubs
{
    //[HubName("ChatHub")]
    public class ChatHub : Hub//Hub<IClient>
    {
        public void BroadcastMessage(string message)
        {
            Clients.All.NewMessage(message);
        }
    }

    //public interface IClient
    //{
    //    void NewMessage(string message);
    //}
}