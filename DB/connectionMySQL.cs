using MySql.Data.MySqlClient;

namespace MySQL_APP
{
  internal class connectionMySQL : connectionDB
  {
    private MySqlConnection connection;
    public string cadenaConexion;
    public connectionMySQL()
    {
      cadenaConexion = $"server={server};database={database};user={user};password={password}";
      connection = new MySqlConnection(cadenaConexion);
    }

    public MySqlConnection openConection()
    {
      try
      {
        if (connection.State != System.Data.ConnectionState.Open)
        {
          connection.Open();
          Console.WriteLine("Conexión exitosa");
        }
      }
      catch (MySqlException ex)
      {
        Console.WriteLine(ex.Message);
      }
      return connection;
    }
    public MySqlConnection closeConection()
    {
      try
      {
        if (connection.State != System.Data.ConnectionState.Closed)
        {
          connection.Close();
          Console.WriteLine("Conexión cerrada");
        }
      }
      catch (MySqlException ex)
      {
        Console.WriteLine(ex.Message);
      }
      return connection;
    }
  }

}