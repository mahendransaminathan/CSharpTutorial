

class overridingExample
{
    public class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("Animal speaks");
        }

        public void Eat()
        {
            Console.WriteLine("Animal eats");
        }

        public void Sleep() 
        {
            Console.WriteLine("Animal sleeps");
        }
        
    }
}