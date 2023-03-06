

namespace task
{
    class Car : IMyList<int>
    {


        private List<int> cars = new List<int>();

        public Car()
        {
            cars.Add(0);
            cars.Add(2);
            cars.Add(1);
            cars.Add(0);
        }

        // Check if the list contains a value
        public bool Contains(int value)
        {
            bool x = false;
            for (int i = 0; i < cars.Count; i++)
            {
                if (value == cars[i])
                {
                    x = true;
                }
            }
            return x;
        }

        // Filter the values using a condition


        public int[] Filter(Predicate<int> cond)
        {
            return cars.Where(c => cond(c)).ToArray();
        }
        // Transform the items of the list
        public K[] Map<K>(Func<int, K> map)
        {
            List<K> result = new List<K>();
            foreach (var item in cars)
            {
                result.Add(map(item));
            }
            return result.ToArray();
        }
        // Loop the items and do something

        public void ForEach(Action<int> action)
        {
            foreach (var item in cars)
            {
                action(item);
            }
        }

        // Find first item in the list
        public int FindFirst(int value)
        {
            return cars[0];
        }

        public int FindLast(int value)
        {
            return cars[cars.Count - 1];
        }

        public int FirstOrDefault(Predicate<int> cond)
        {

            return cars.Find(cond);
        }
    }




}