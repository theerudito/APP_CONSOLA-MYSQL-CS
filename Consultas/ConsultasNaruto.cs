
using MySql.Data.MySqlClient;

namespace MySQL_APP
{
  internal class ConsultasNaruto
  {
    connectionMySQL conexion = new connectionMySQL();
    public void getAllCharacters()
    {
      conexion.openConection();
      string query = "SELECT * FROM Naruto.characters";
      MySqlCommand command = new MySqlCommand(query, conexion.openConection());
      MySqlDataReader reader = command.ExecuteReader();
      while (reader.Read())
      {
        Console.WriteLine(reader["id"] + " - " + reader["name"] + " - " + reader["clan"] + " - " + reader["age"]);
      }
      conexion.closeConection();
    }
  }
}