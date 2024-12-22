using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_продавца_офисной_техники.Classes
{
    
    public class Technique
    {
        public string type;
        public string manufacturer;
        public string model;
        public string description;
        public int cost;
        public int amount;
        public Technique(string type, string manufacturer, string model, string description, int cost, int amount)
        {
            this.type = type;
            this.manufacturer = manufacturer;
            this.model = model;
            this.description = description;
            this.cost = cost;
            this.amount = amount;
        }
        public void Update()
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand updateCommand = new MySqlCommand(
                    "UPDATE warehouse SET type = @type, manufacturer = @manufacturer, model = @model, description = @description, cost = @cost, amount = @amount " +
                    "WHERE manufacturer = @manufacturer AND model = @model", db.getConnection());

            updateCommand.Parameters.AddWithValue("@type", type);
            updateCommand.Parameters.AddWithValue("@manufacturer", manufacturer);
            updateCommand.Parameters.AddWithValue("@model", model);
            updateCommand.Parameters.AddWithValue("@description", description);
            updateCommand.Parameters.AddWithValue("@cost", cost);
            updateCommand.Parameters.AddWithValue("@amount", amount);

            updateCommand.ExecuteNonQuery();
            db.closeConnection();
        }
        public void Add()
        {
            DB db = new DB();
            db.openConnection();

            try
            {
                MySqlCommand insertCommand = new MySqlCommand(
                    "INSERT INTO warehouse (type, manufacturer, model, description, cost, amount) " +
                    "VALUES (@type, @manufacturer, @model, @description, @cost, @amount)", db.getConnection());

                insertCommand.Parameters.AddWithValue("@type", type);
                insertCommand.Parameters.AddWithValue("@manufacturer", manufacturer);
                insertCommand.Parameters.AddWithValue("@model", model);
                insertCommand.Parameters.AddWithValue("@description", description);
                insertCommand.Parameters.AddWithValue("@cost", cost);
                insertCommand.Parameters.AddWithValue("@amount", amount);

                int rowsAffected = insertCommand.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Товар добавлен");
                }
                else
                {
                    MessageBox.Show("Ошибка добавления товара");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }
    }
    
    public class TechniqueList
    {
        public Technique[] list = new Technique[100];
        public int maxLength = 0;
        public int curLength = 0;
        public void Fill()
        {
            curLength = 0;
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT type, manufacturer, model, description, cost, amount FROM warehouse", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read()) 
            {
                list[curLength] = new Technique(
                    reader["type"].ToString(),
                    reader["manufacturer"].ToString(),
                    reader["model"].ToString(),
                    reader["description"].ToString(),
                    reader.GetInt32("cost"),
                    reader.GetInt32("amount")
                );
                curLength++;
            }
            maxLength = curLength;
            reader.Close();
            db.closeConnection();
        }
        public void FillByType(string type)
        {
            Array.Clear(list, 0, curLength);
            curLength = 0;
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT type, manufacturer, model, description, cost, amount FROM warehouse", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                if (reader["type"].ToString() == type)
                {
                    list[curLength] = new Technique(
                        reader["type"].ToString(),
                        reader["manufacturer"].ToString(),
                        reader["model"].ToString(),
                        reader["description"].ToString(),
                        reader.GetInt32("cost"),
                        reader.GetInt32("amount")
                    );
                    curLength++;
                }
                
            }
            reader.Close();
            db.closeConnection();
        }
        private void Swap(int index1, int index2)
        {
            Technique temp = list[index1];
            list[index1] = list[index2];
            list[index2] = temp;
        }
        public void ListSortByCost()
        {
            int left = 0;
            int right = curLength - 1;

            while (left <= right)
            {
                for (int i = right; i > left; --i)
                {
                    if (list[i-1].cost > list[i].cost)
                    {
                        Swap(i - 1, i);
                    }
                }
                ++left;

                for (int i = left; i < right; ++i)
                {
                    if (list[i].cost > list[i+1].cost)
                    {
                        Swap(i, i + 1);
                    }
                }
                --right;
            }
        }
        public void ListReverseSortByCost()
        {
            int left = 0;
            int right = curLength - 1;

            while (left <= right)
            {
                for (int i = right; i > left; --i)
                {
                    if (list[i - 1].cost < list[i].cost)
                    {
                        Swap(i - 1, i);
                    }
                }
                ++left;

                for (int i = left; i < right; ++i)
                {
                    if (list[i].cost < list[i + 1].cost)
                    {
                        Swap(i, i + 1);
                    }
                }
                --right;
            }
        }
        public TechniqueList Search(string s)
        {
            TechniqueList searchList = new TechniqueList();
            for(int i = 0; i < curLength; i++)
            {
                if(((list[i].manufacturer + " " + list[i].model)).ToLower().Contains(s.ToLower()))
                {
                    searchList.list[searchList.curLength] = list[i];
                    searchList.curLength++;
                }
            }
            return searchList;
        }
    }
}


