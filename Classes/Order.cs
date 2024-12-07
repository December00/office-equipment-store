using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace АРМ_продавца_офисной_техники.Classes
{
    public class Order
    {
        public int Id;
        public string content;
        public string name;
        public string address;
        public string phoneNumber;
        public int finalCost;
        public Order(string name, string address, string phoneNumber)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.content = "";
            this.finalCost = 0;
        }
        public Order(int id, string content, string name, string address, string phoneNumber, int finalCost)
        {
            Id = id;
            this.content = content;
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.finalCost = finalCost;
        }

        public bool MakeOrder(BasketItems basket)
        {
            
            if (basket != null)
            {
                for (int i = 0; i < basket.items.curLength; i++)
                {
                    var item = basket.items.list[i];
                    content += item.manufacturer + " " + item.model;
                    finalCost += item.cost * item.amount;
                    if (i + 1 != basket.items.curLength)
                    {
                        content += ", ";
                    }

                    DB dB = new DB();
                    dB.openConnection();

                    MySqlCommand checkCommand = new MySqlCommand("SELECT amount FROM warehouse WHERE manufacturer = @manufacturer AND model = @model", dB.getConnection());
                    checkCommand.Parameters.AddWithValue("@manufacturer", item.manufacturer);
                    checkCommand.Parameters.AddWithValue("@model", item.model);

                   
                    int warehouseAmount = 0;
                    using (MySqlDataReader reader = checkCommand.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            warehouseAmount = reader.GetInt32("amount");
                        }
                    }

                    
                    if (warehouseAmount < item.amount)
                    {
                        MessageBox.Show("На складе недостаточно экземпляров: " + item.manufacturer + " " + item.model);
                        dB.closeConnection();
                        return false; 
                    }

                    dB.closeConnection();
                }
                DB db = new DB();

                db.openConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `orders` (content, name, address, phoneNumber, finalCost) VALUES (@content, @name, @address, @phoneNumber, @finalCost)", db.getConnection());
                command.Parameters.AddWithValue("@content", this.content);
                command.Parameters.AddWithValue("@name", this.name);
                command.Parameters.AddWithValue("@address", this.address);
                command.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
                command.Parameters.AddWithValue("@finalCost", this.finalCost);
                command.ExecuteNonQuery();
                for (int i = 0; i < basket.items.curLength; i++)
                {
                    var item = basket.items.list[i];

                    
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE warehouse SET amount = amount - @amount WHERE manufacturer = @manufacturer AND model = @model", db.getConnection());
                    updateCommand.Parameters.AddWithValue("@amount", item.amount);
                    updateCommand.Parameters.AddWithValue("@manufacturer", item.manufacturer);
                    updateCommand.Parameters.AddWithValue("@model", item.model);
                    updateCommand.ExecuteNonQuery();

                    
                }
                db.closeConnection();
                basket.ClearBasketByLogin();
                MessageBox.Show("Заказ оформлен");
                return true;
            } 
            else
            {

                MessageBox.Show("Нельзя оформить заказ с пустой карзиной");
                return false;
            }
        }
        public void DeleteOrder()
        {
            DB db = new DB();
            db.openConnection();
            try
            {
                MySqlCommand command = new MySqlCommand("DELETE FROM orders WHERE ID = @Id", db.getConnection());
                command.Parameters.AddWithValue("@Id", this.Id);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Заказ удалён");
                }
                else
                {
                    MessageBox.Show("Заказ не найден");
                }
            }
            catch (Exception ex ){ MessageBox.Show(ex.ToString()); }

           db.closeConnection();

        }
        public void AcceptOrder() { 
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FileName = $"Order" + Id + ".txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                    
                    string orderInfo = $"Order ID: {Id}\n" +
                                       $"Name: {name}\n" +
                                       $"Address: {address}\n" +
                                       $"Phone Number: {phoneNumber}\n" +
                                       $"Content: {content}\n" +
                                       $"Final Cost: {finalCost}\n";

                    
                    File.WriteAllText(saveFileDialog.FileName, orderInfo);
                    DeleteOrder();
                
            }
        }
    }
    public class OrderList
    {
        public Order[] list = new Order[1000];
        public int curLength = 0;
        public int maxLength = 0;
        public void Fill()
        {
            curLength = 0;
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("SELECT ID, content, name, address, phoneNumber, finalCost FROM orders", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                list[curLength] = new Order(
                    reader.GetInt32("ID"),
                    reader["content"].ToString(),
                    reader["name"].ToString(),
                    reader["address"].ToString(),
                    reader["phoneNumber"].ToString(),
                    reader.GetInt32("finalCost")
                   
                );
                curLength++;
            }
            maxLength = curLength;
            reader.Close();
            db.closeConnection();
        }
    }
}
