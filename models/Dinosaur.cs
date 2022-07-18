namespace day_1.models
{
  // access modifier (Public, Internal, Protected, Private)
  public class Dinosaur
  {
    // members (fields**, properties, methods)  
    public string Name { get; private set; }
    public string Diet { get; set; }
    public int Age { get; set; }


    // ChangeName
    // Method access modifier, return type, name, parameters (signature)
    // NOTE void means no return
    public void ChangeName(string name)
    {
      // some buisness logic here
      Name = name;
    }

    public string Speak()
    {
      if (Diet == "Herbivore")
      {
        return "RRRRRrrrrRRRRrrrr";
      }
      else if (Diet == "Carnivore")
      {
        return "RRRAAAAWWWWRRR";
      }
      return "Sup dude";
    }



    // How is this the constructor
    //  - Public
    //  - No Return type
    //  - Name is same as class
    public Dinosaur(string name, string diet, int age)
    {
      Name = name;
      Diet = diet;
      Age = age;
    }

  }
}