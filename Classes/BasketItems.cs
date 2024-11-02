using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_продавца_офисной_техники.Classes
{
    public class BasketItems
    {
        public string login;
        public TechniqueList items = new TechniqueList();
        public BasketItems(string login)
        {
            this.login = login;
            FillByLogin();
        }
        public void Add(Technique technique)
        {
            if (items.curLength >= 3)
            {
                MessageBox.Show("Нельзя добавить больше 3 товаров в корзину");
                return;
            }
    
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("INSERT INTO `basket` (login, type, manufacturer, model, description, cost, amount) VALUES (@login, @type, @manufacturer, @model, @description, @cost, @amount)", db.getConnection());
            command.Parameters.AddWithValue("@login", this.login);
            command.Parameters.AddWithValue("@type", technique.type);
            command.Parameters.AddWithValue("@manufacturer", technique.manufacturer);
            command.Parameters.AddWithValue("@model", technique.model);
            command.Parameters.AddWithValue("@description", technique.description);
            command.Parameters.AddWithValue("@cost", technique.cost);
            command.Parameters.AddWithValue("@amount", 1);
            items.curLength++;
            
            command.ExecuteNonQuery();
            db.closeConnection();
            
           
        }
        public void FillByLogin()
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT type, manufacturer, model, description, cost, amount FROM basket WHERE login = @login", db.getConnection());
            command.Parameters.AddWithValue("@login", this.login);
            MySqlDataReader reader = command.ExecuteReader();
            items.curLength = 0;
            while (reader.Read())
            {
                items.list[items.curLength] = new Technique(
                    reader["type"].ToString(),
                    reader["manufacturer"].ToString(),
                    reader["model"].ToString(),
                    reader["description"].ToString(),
                    reader.GetInt32("cost"),
                    reader.GetInt32("amount")
                );
                items.curLength++;
            }

            reader.Close();
            db.closeConnection();
        }
        public void ClearBasketByLogin()
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM basket WHERE login = @login", db.getConnection());
            command.Parameters.AddWithValue("@login", this.login);

            
            int rowsAffected = command.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                
                items.curLength = 0; 
            }
            else
            {
                MessageBox.Show("Корзина уже пуста");
            }
            db.closeConnection();  
            
        }
    }
    
}
