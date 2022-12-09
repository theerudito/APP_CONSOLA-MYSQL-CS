
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

    public void getCharacter(int id)
    {
      conexion.openConection();
      string query = $"SELECT * FROM Naruto.characters WHERE id = {id}";
      MySqlCommand command = new MySqlCommand(query, conexion.openConection());
      MySqlDataReader reader = command.ExecuteReader();
      while (reader.Read())
      {
        Console.WriteLine(reader["id"] + " - " + reader["name"] + " - " + reader["clan"] + " - " + reader["age"]);
      }
      conexion.closeConection();
    }

    public void insertCharacter(Naruto character)
    {
      conexion.openConection();
      string query = $"INSERT INTO Naruto.characters (name, clan, age) VALUES ('{character.name}', '{character.clan}', '{character.age}')";
      MySqlCommand command = new MySqlCommand(query, conexion.openConection());
      command.ExecuteNonQuery();
      Console.WriteLine("Registro insertado");
      conexion.closeConection();
    }

    public void updateCharacter(Naruto character)
    {
      conexion.openConection();
      string query = $"UPDATE Naruto.characters SET name = '{character.name}', clan = '{character.clan}', age = '{character.age}' WHERE id = {character.id}";
      MySqlCommand command = new MySqlCommand(query, conexion.openConection());
      command.ExecuteNonQuery();
      Console.WriteLine("Registro actualizado");
      conexion.closeConection();
    }

    public void deleteCharacter(int id)
    {
      conexion.openConection();
      string query = $"DELETE FROM Naruto.characters WHERE id = {id}";
      MySqlCommand command = new MySqlCommand(query, conexion.openConection());
      command.ExecuteNonQuery();
      Console.WriteLine("Registro eliminado");
      conexion.closeConection();

    }
  }
}