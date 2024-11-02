using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АРМ_продавца_офисной_техники.Classes
{
    
    public class Technique
    {
        //public enum TechniqueType { monitor, laptop, printer, PC, headset, TV, other };
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
    }
    //сделать список техники, добавить 9 ячеек и возможность менять страницы, сделать поиск/фильтрацию/сортировку 
    
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
    }
}
