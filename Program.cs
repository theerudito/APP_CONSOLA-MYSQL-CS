namespace MySQL_APP
{
  class Program
  {
    static void Main(string[] args)
    {
      ConsultasNaruto consulta = new ConsultasNaruto();
      // GET ALL CHARACTERS
      consulta.getAllCharacters();

      // GET CHARACTER BY ID
      consulta.getCharacter(2);

      // INSERT CHARACTER
      consulta.insertCharacter(new Naruto { name = "Sarawer", clan = "Uchweriha", age = "15" });

      // UPDATE CHARACTER
      consulta.updateCharacter(new Naruto { id = 7, name = "Sarada", clan = "Uchiha", age = "10" });
    
      // DELETE CHARACTER
      consulta.deleteCharacter(8);
    } 
  }
}
