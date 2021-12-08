using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;
namespace ChatServer

{
    public interface IClient
    {
        public delegate void UpdateDelegate(object o);
        public UpdateDelegate onUpdate;
        {
            get;
            set;
        }
        User u;
        ChatManager chat;
        private void AddUser(User user);
        private void RemUser(User user);
        void notify(object o);
    }
}
