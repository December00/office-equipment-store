using MySql.Data.MySqlClient;
using Mysqlx.Datatypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_продавца_офисной_техники.Classes
{
    public class User
    {
        public string login;
        string password;
        public User(string login, string pas)
        {
            this.login = login;
            this.password = pas;
        }
        public bool Authorization()
        {
            DB db = new DB();

            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pas` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
                return false;
            }
        }
        private bool IsEnterValid()
        {
            if (login == "" || password == "")
            {
                MessageBox.Show("Поля должны быть заполнены");
                return false;
            }
            if (login.Contains(' ') || password.Contains(' '))
            {
                MessageBox.Show("Поля не должны содержать пробел");
                return false;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Пароль должен иметь хотя бы 8 символов");
                return false;
            }
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует");
                return false;
            }
            else
            {
                return true;
            }
        }
        public void Registration()
        {
            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pas`) VALUES (@login, @pas)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
            command.Parameters.Add("@pas", MySqlDbType.VarChar).Value = password;

            db.openConnection();

            if (IsEnterValid())
            {
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Аккаунт успешно зарегистрирован");
                else
                    MessageBox.Show("Ошибка создания аккаунта");

            }
            db.closeConnection();
        }
    }
}
