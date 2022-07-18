using System.Collections.Generic;

namespace day_1.models
{
  public class Park
  {


    public List<Dinosaur> Dinos { get; private set; } = new List<Dinosaur>(){
        new Dinosaur("Sarah", "Herbivore", 12),
        new Dinosaur("Mike", "Herbivore", 1),
        new Dinosaur("Sarah", "Herbivore", 10),
        new Dinosaur("Jeffy", "Carnivore", 22)
    };

    public void AddDino(string name, string diet)
    {
      Dinos.Add(new Dinosaur(name, diet, 0));
    }

    public bool RemoveDino(string name)
    {
      Dinosaur found = Dinos.Find(d => d.Name.ToLower() == name.ToLower());
      if (found == null)
      {
        return false;
      }
      Dinos.Remove(found);
      return true;
    }


    public string ParkList()
    {
      string template = "";
      Dinos.ForEach(d => template += $"\n{d.Name} -- {d.Diet} ({d.Age})");
      return template;
    }




  }
}