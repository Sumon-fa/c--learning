
using System.Collections;

namespace custom_interface;

class DogShelter : IEnumerable<Dog>
{
    List<Dog> dogs;

    public DogShelter()
    {
        dogs = new List<Dog>(){
            new Dog("tom",true),
            new Dog("siff",false)
        };

    }

    IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
    {
        return dogs.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return dogs.GetEnumerator();
    }
}