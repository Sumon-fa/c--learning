
namespace queues
{
    class Program
    {
        static void Main(string[] args)
        {


            /*   Queue<int> myQueue = new Queue<int>();
               myQueue.Enqueue(1);
               Console.WriteLine(myQueue.Peek());
               myQueue.Enqueue(2);
               Console.WriteLine(myQueue.Peek());
               myQueue.Enqueue(3);
               Console.WriteLine(myQueue.Peek());*/

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in ReceivedOrderFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }


            foreach (Order o in ReceivedOrderFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                Order currentOrder = ordersQueue.Dequeue();
                currentOrder.ProcessOrder();
            }
            static Order[] ReceivedOrderFromBranch1()
            {

                Order[] orders = new Order[]{
                new Order(1,6),
                new Order(2,8),
                new Order(3,9),
            };
                return orders;
            }

            static Order[] ReceivedOrderFromBranch2()
            {

                Order[] orders = new Order[]{
                new Order(4,7),
                new Order(5,11),
                new Order(6,912),
            };
                return orders;
            }


        }
        class Order
        {
            public int OrderId { get; set; }
            public int OrderQuantity { get; set; }

            public Order(int orderId, int orderQuantity)
            {
                OrderId = orderId;
                OrderQuantity = orderQuantity;
            }

            public void ProcessOrder()
            {
                Console.WriteLine($"order {OrderId} Processed");
            }

        }
    }
}