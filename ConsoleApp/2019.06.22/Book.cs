namespace _2019._06._22
{
    internal class Book
    {
        public string Name { get; set; }

        public Book(int number)
        {
            this.Name = "Interesting book" + number;
        }
    }
}
