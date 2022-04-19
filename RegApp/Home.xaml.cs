using System.Collections.Generic;
using System.Windows;
using RegApp.Core;

namespace RegApp
{
    public partial class Home : Window
    {
        public Storage _storage { get; set; }
        public List<User> _users { get; set; }
        public User currentUser { get; set; }
        public Home(Storage storage, User user)
        {
            InitializeComponent();
            _storage = storage;
            _users = _storage.Users;
            currentUser = user;

            curUser.Text = $"Текущий пользователь {currentUser.Login}";
        }
        
    }
}