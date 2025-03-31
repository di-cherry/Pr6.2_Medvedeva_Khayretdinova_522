using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR6._2
{
    /// <summary>
    /// Логика взаимодействия для RegPage.xaml
    /// </summary>
    public partial class RegPage : Page
    {
        public RegPage()
        {
            InitializeComponent();
        }
        private void BtnRegister_Click(object sender, RoutedEventArgs e)
        {
            Reg(TextBoxFIO.Text, TextBoxLogin.Text, PasswordBox.Password, CmbRole.Text);
        }

        public bool Reg(string fio, string login, string password, string role)
        {
            if (string.IsNullOrEmpty(fio) || string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Заполните все обязательные поля!", "Ошибка");
                return false;
            }

            using (var db = new Entities())
            {
                if (db.Users.Any(u => u.FIO == fio && u.Login == login && u.Password == password && u.Role == role))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка");
                    return false;
                }

                var newUser = new Users
                {
                    FIO = fio,
                    Login = login,
                    Password = password,
                    Role = role,
                };

                db.Users.Add(newUser);
                db.SaveChanges();

                MessageBox.Show("Регистрация прошла успешно!", "Успех");
                return true;

            }
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();

            TextBoxFIO.Clear();
            TextBoxLogin.Clear();
            PasswordBox.Clear();
            CmbRole.SelectedIndex = 0;
        }


    }
}