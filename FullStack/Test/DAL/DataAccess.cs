namespace Test.DAL;
using System.Data;
using MySql.Data.MySqlClient;
using Test.Model;


public class DataAccess
{

    public static string constring=@"server=localhost;port=3306;user=root;password=aksh123;database=transflower";

    public static List<Employees>  GetAllEmployees(){

        List<Employees> emp=new List<Employees>();

        MySqlConnection con=new MySqlConnection();

        con.ConnectionString=constring;

        try{
            string query="select * from employees";
            DataSet ds=new DataSet();
            MySqlCommand cmd=new MySqlCommand(query,con);
            MySqlDataAdapter da=new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt=ds.Tables[0];
            DataRowCollection rows=dt.Rows;
            foreach (DataRow row in rows)
            {
                int id=int.Parse(row["id"].ToString());
                string firstname=row["firstName"].ToString();
                string lastname=row["lastName"].ToString();
                string email=row["email"].ToString();
                string password=row["password"].ToString();
                
                Employees empy=new Employees{
                    Id=id,
                    FirstName=firstname,
                    LastName=lastname,
                    Email=email,
                    Password=password

                };
                emp.Add(empy);
            }
        }catch(Exception e){
            Console.WriteLine(e);
        }
    return emp;

    }
    
    public static Employees GetEmployeeById(int id)
    {
        Employees empid=null;
        MySqlConnection con=new MySqlConnection(constring);

        try{
            con.Open();
            string query ="select * from employees where id=" +id;
            MySqlCommand command=new MySqlCommand(query,con);
            MySqlDataReader reader=command.ExecuteReader();

            if(reader.Read())
            {
                id=int.Parse(reader["id"].ToString());
                string firstname=reader["firstName"].ToString();
                string lastname=reader["lastName"].ToString();
                string email=reader["email"].ToString();
                string password=reader["password"].ToString();

                empid=new Employees{
                    Id=id,
                    FirstName=firstname,
                    LastName=lastname,
                    Email=email,
                    Password=password
                };
            }
        }catch(Exception e){
              Console.WriteLine(e);
        }
        finally{
            con.Close();    
        }

        return empid;

    }

    public static void InsertEmployee(Employees emp)
    {
        MySqlConnection con=new MySqlConnection(constring);

        try{
            con.Open();
            string query=$"insert into employees(firstName,lastName,email,address) values('{emp.FirstName}','{emp.LastName}','{emp.Email}','{emp.Address}')";
            MySqlCommand command=new MySqlCommand(query,con);
            MySqlDataReader reader=command.ExecuteReader();
            //command.ExecuteNonQuery();
            
        }catch(Exception e){    
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }

    }

    public static void DeleteEmployee(int id){
        MySqlConnection con=new MySqlConnection(constring);

        try{
            con.Open();
            string query="delete from employees where id="+id;
            MySqlCommand command=new MySqlCommand(query,con);
            command.ExecuteNonQuery();
            con.Close();
        }catch(Exception e)
        {
            Console.WriteLine(e);
        }
        finally{
            con.Close();
        }
    }

}