using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using RegApp.Core;

namespace RegApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public static Storage _storage = new Storage();
        public static List<User> _users = _storage.Users;
        public User currentUser = null;
        
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;

            
        }

        private void MainWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void ButtonLogin_OnClick(object sender, RoutedEventArgs e)
        {
            var login = LoginBox.Text;
            var password = PassBox.Password;

            if (User.CheckLoginCredetionals(login, password, _users) & login != "Username")
            {

                currentUser = User.LogIn(login, password, _users);
                Home home = new Home(_storage, currentUser);
                this.Hide();
                home.ShowDialog();
                this.Show();
                //MessageBox.Show($"Успешный вход. Пользователь: {currentUser.Login}"); 
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
            
            
            
        }
        
        private void ButtonRegister_OnClick(object sender, RoutedEventArgs e)
        {
            var login = LoginBox.Text;
            var password = PassBox.Password;

            if (User.LoginExistsCheck(login, _users))
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
            }
            else
            {
                User.Registration(login, password, _users);
                MessageBox.Show($"Успешная регистрация. Логин: {login}. Пароль: {password}");
                _storage.SaveData();
            }
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}