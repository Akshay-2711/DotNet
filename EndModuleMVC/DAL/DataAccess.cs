namespace DAL;
using Test.BOL;
using MySql.Data.MySqlClient;

public class DataAccess
{
    public static string constring=@"server=localhost;port=3306;user=root;password=aksh123;database=transflower";

    public static List<Product> GetAllProducts()
    {
        List<Product> product =new List<Product>();
        MySqlConnection con=new MySqlConnection();
        con.ConnectionString=constring;

        try{
            con.Open();
            string query="select * from product";
            MySqlCommand cmd=new MySqlCommand(query,con);
            MySqlDataReader reader=cmd.ExecuteReader();
            while(reader.Read())
            {
                int id=int.Parse(reader["id"].ToString());
                string name=reader["pname"].ToString();
                double price=double.Parse(reader["price"].ToString());
                string brand=reader["pbrand"].ToString();

                Product p=new Product{
                    Id=id,
                    Pname=name,
                    Price=price,
                    Pbrand=brand
                };
                product.Add(p);
            }

        }
        catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return product;
    }

    public static Product GetproductById(int id)
    {
        Product prod=null;
        MySqlConnection con= new MySqlConnection(constring);
        try{
            con.Open();
            string query="select * from product where id="+id;
            MySqlCommand cmd=new MySqlCommand(query,con);
            MySqlDataReader reader=cmd.ExecuteReader();

            if(reader.Read()){
                id=int.Parse(reader["id"].ToString());
                string name=reader["pname"].ToString();
                double price=double.Parse(reader["price"].ToString());
                string brand=reader["pbrand"].ToString();

                prod=new Product{
                     Id=id,
                    Pname=name,
                    Price=price,
                    Pbrand=brand
                };

            }
        }catch(Exception e){
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return prod;

    }

    public static bool InsertProduct(int id,string pname,double price,string pbrand)
    {
        MySqlConnection con=new MySqlConnection(constring);
        
        try{
            con.Open();
           // "insert into product values(id,pname,price,pbrand);
            string query=$"insert into product values('{id}','{pname}','{price}','{pbrand}')";
            MySqlCommand cmd = new MySqlCommand(query,con);
            int row=cmd.ExecuteNonQuery();
            if(row==0)
            {
                return false;
            }
        }catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
        return true;
    }

    public static void Delete(int id)
    {
        MySqlConnection con=new MySqlConnection(constring);
        try{
            con.Open();
            string query="delete from product where id="+id;
            MySqlCommand cmd=new MySqlCommand(query,con);
            cmd.ExecuteNonQuery();

        }catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
    }
}
