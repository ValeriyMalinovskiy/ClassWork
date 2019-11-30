using System;
using System.Data;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        string connectionString =
            "Data Source=(local);Initial Catalog=HR;"
            + "Integrated Security=true";

        // Provide the query string with a parameter placeholder.
        string queryString =
            "SELECT emplyee_id,first_name, last_name,email,phone_number,hire_date,salary from dbo.employees where salary < @salary";

        // Specify the parameter value.
        int paramValue = 10000;

        // Create and open the connection in a using block. This
        // ensures that all resources will be closed and disposed
        // when the code exits.
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            // Create the Command and Parameter objects.
            SqlCommand command = new SqlCommand(queryString, connection);
            command.Parameters.AddWithValue("@salary", paramValue);

            // Open the connection in a try/catch block. 
            // Create and execute the DataReader, writing the result
            // set to the console window.
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                //while (reader.Read())
                //{
                //    Console.WriteLine("{0}\t\t{1}\t\t{2}",
                //        reader[0], reader[1], reader[2]);
                //}
                DataTable myTable = new DataTable();
                myTable.Load(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}