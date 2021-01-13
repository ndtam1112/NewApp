using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using View.Classess;
using View.Utils;

namespace View.Database
{
    public class Productdatabase
    {
        public static Image_Product GetImageProductByID(string id)
        {
            Image_Product pr = new Image_Product();
            string sqlQuery = $"select * from _tb_image where _id_product=@id;";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@id", id);
                Connection.rd = Connection.cmd.ExecuteReader();
                if (Connection.rd.Read())
                {
                    pr.Id_product = Connection.rd.GetValue(0).ToString();
                    pr.Size_product = Connection.rd.GetValue(1).ToString();
                    pr.Amount_product = Connection.rd.GetValue(2).ToString();
                    pr.Image_product = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(3));
                    return pr;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get Product " + e.Message);
                return pr;
            }
            finally
            {
                Connection.rd.Close();
                Connection.CloseConnection();
            }
            return pr;

        }
        public static bool UpdateStatusHistory(string phone, string status, string id)
        {
            try
            {
                string sqlQuery = "update _tb_history set _status_product = @Status, _id_product = @Id where _phone_number = @Phone;";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Id", id);
                Connection.cmd.Parameters.AddWithValue("@Phone", phone);
                Connection.cmd.Parameters.AddWithValue("@Status", 1);
                Connection.cmd.ExecuteScalar();
                MessageBox.Show("Update status successfully!");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("update to status: " + e.Message);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
        }

        public static void DeleteToHistory(string id)
        {
            string sqlQuery = $"DELETE FROM _tb_history WHERE _id_product = @id;";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@id", id);
                Connection.cmd.ExecuteScalar();

            }
            catch (Exception e)
            {
                MessageBox.Show("Error delete Product " + e.Message);

            }
            finally
            {

                Connection.CloseConnection();
            }


        }

        public static bool InsertToHistory(string id, string phone, byte status, string size, int quantity, int price)
        {
            bool check = false;
            string sqlQuery = $"Insert into _tb_history values(@id,@phone,@status,@size,@quantity,@sumprice);";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@id", id);
                Connection.cmd.Parameters.AddWithValue("@phone", phone);
                Connection.cmd.Parameters.AddWithValue("@quantity", quantity);
                Connection.cmd.Parameters.AddWithValue("@size", size);
                Connection.cmd.Parameters.AddWithValue("@status", status);
                Connection.cmd.Parameters.AddWithValue("@sumprice", price);

                Connection.cmd.ExecuteScalar();
                check = true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Error InsertToHistory " + e.Message);
                check = false;
            }
            finally
            {
                Connection.CloseConnection();
            }
            return check;

        }
        public static bool insertProduct(string id, string name, string price, string category)
        {

            string sqlQuery = $"insert into _tb_product values(@_id_product,@_name_product,@_price_product,@_category_product);";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@_id_product", id);
                Connection.cmd.Parameters.AddWithValue("@_name_product", name);
                Connection.cmd.Parameters.AddWithValue("@_price_product", price);
                Connection.cmd.Parameters.AddWithValue("@_category_product", category);
                Connection.cmd.ExecuteScalar();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error InsertProduct " + e.Message);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        public static void insertImage(string id, string size, string amount, BitmapImage image)
        {

            string sqlQuery = $"Insert into _tb_image values(@_id_product,@_size_product,@_amount_product,@_image_product);";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@_id_product", id);
                Connection.cmd.Parameters.AddWithValue("@_size_product", size);
                Connection.cmd.Parameters.AddWithValue("@_amount_product", amount);
                Connection.cmd.Parameters.AddWithValue("@_image_product", Helpers.ConvertImageToByte(image));
                Connection.cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error InsertImage " + e.Message);

            }
            finally
            {
                Connection.CloseConnection();
            }
        }

        public static bool UpdateToProduct(string id, string name, string price)
        {
            try
            {
                string sqlQuery = "update _tb_product set _name_product = @_name_product, _price_product = @_price_product where _id_product = @_id_product;";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@_id_product", id);
                Connection.cmd.Parameters.AddWithValue("@_name_product", name);
                Connection.cmd.Parameters.AddWithValue("@_price_product", price);
                Connection.cmd.ExecuteScalar();
                
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("update to product: " + e.Message);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
        }
        public static bool UpdateToImage(string id, string amount)
        {
            try
            {
                string sqlQuery = "update _tb_product set _amount_product = @_amount_product where _id_product = @_id_product;";
                Connection.OpenConnection();
                Connection.cmd.CommandType = System.Data.CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@_id_product", id);
                Connection.cmd.Parameters.AddWithValue("@_amount_product", amount);
                
                Connection.cmd.ExecuteScalar();
                MessageBox.Show("Update product successfully!");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("update to product: " + e.Message);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
        }


        public static List<Product> GetProductByType(string type)
        {
            List<Product> list = new List<Product>();

            string sqlQuery = $"select _tb_product._id_product,_tb_product._name_product,_tb_product._category_product,_tb_product._price_product,_tb_image._image_product from _tb_product,_tb_image where _tb_product._id_product = _tb_image._id_product and _tb_product._category_product = @type; ";
            try
            {

                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@type", type);
                Connection.rd = Connection.cmd.ExecuteReader();
                byte check = 0;
                while (Connection.rd.Read())
                {
                    check++;
                    if (check == 1 && check < 3)
                    {
                        Product pr = new Product();
                        pr.Id_product = Connection.rd.GetValue(0).ToString();
                        pr.Name_product = Connection.rd.GetValue(1).ToString();
                        pr.Price_product = double.Parse(Connection.rd.GetValue(3).ToString());
                        pr.Category_product = Connection.rd.GetValue(2).ToString();
                        pr.Image_product = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(4));
                        list.Add(pr);
                    }
                    else
                    {
                        if (check == 3) check = 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get list Product " + e.Message);

            }
            finally
            {
                Connection.rd.Close();
                Connection.CloseConnection();
            }
            return list;
        }
        public static bool checkProduct(string id)
        {
            string sqlQuery = $"select count(*) from _tb_product where _id_product=@id";
            try
            {
                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@id", id);

                int count = Convert.ToInt32(Connection.cmd.ExecuteScalar().ToString());
                if (count != 0)
                {
                    
                    return false;
                }
                else
                {
                    
                    return true;

                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error connecting...", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            finally
            {
                Connection.CloseConnection();
            }
        }



        public static List<History> GetProductInHistory(string phone)
        {
            List<History> list = new List<History>();

            string sqlQuery = $"select _tb_product._id_product,_tb_product._name_product,_tb_history._price_sum,_tb_history._size_product,_tb_history._amount_product,_tb_image._image_product from _tb_product,_tb_history,_tb_image where _tb_product._id_product = _tb_history._id_product and _tb_image._id_product = _tb_history._id_product and _tb_history._phone_number = @phone;";
            try
            {

                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@phone", phone);

                Connection.rd = Connection.cmd.ExecuteReader();
                byte check = 0;
                while (Connection.rd.Read())
                {
                    check++;
                    if (check == 1 && check < 3)
                    {
                        History pr = new History();
                        pr.Id_product = Connection.rd.GetValue(0).ToString();
                        pr.Name_product = Connection.rd.GetValue(1).ToString();
                        pr.Price_product = Convert.ToInt32(Connection.rd.GetValue(2).ToString());
                        pr.Size_product = Connection.rd.GetValue(3).ToString();
                        pr.Amount_product = Convert.ToInt32(Connection.rd.GetValue(4).ToString());
                        pr.Phone_number = phone;
                        pr.Status_product = 0;
                        pr.Image_product = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(5));
                        list.Add(pr);
                    }
                    else
                    {
                        if (check == 3) check = 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error GetProductInHistory " + e.Message);

            }
            finally
            {
                Connection.rd.Close();
                Connection.CloseConnection();
            }
            return list;
        }


        public static ProductDetailModel GetDetailProductByID(string id)
        {
            ProductDetailModel pr = new ProductDetailModel();
            string sqlQuery = $"select _tb_product._id_product,_tb_product._name_product,_tb_product._category_product,_tb_product._price_product,_tb_image._image_product from _tb_product,_tb_image where _tb_product._id_product = _tb_image._id_product and _tb_image._id_product=@Id;";
            try
            {

                Connection.OpenConnection();
                Connection.cmd.CommandType = CommandType.Text;
                Connection.cmd.CommandText = sqlQuery;
                Connection.cmd.Parameters.Clear();
                Connection.cmd.Parameters.AddWithValue("@Id", id);
                Connection.rd = Connection.cmd.ExecuteReader();
                byte check = 0;
                while (Connection.rd.Read())
                {
                    check++;
                    pr.Id_product = Connection.rd.GetValue(0).ToString();
                    pr.Name_product = Connection.rd.GetValue(1).ToString();
                    pr.Price_product = double.Parse(Connection.rd.GetValue(3).ToString());
                    pr.Category_product = Connection.rd.GetValue(2).ToString();
                    if (check == 1)
                        pr.Image_product = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(4));
                    if (check == 2)
                        pr.Image_product1 = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(4));
                    if (check == 3)
                        pr.Image_product2 = Helpers.ConvertByteToImageBitmap((byte[])Connection.rd.GetValue(4));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error get Product " + e.Message);

            }
            finally
            {
                Connection.rd.Close();
                Connection.CloseConnection();
            }
            return pr;
        }
    }

}
