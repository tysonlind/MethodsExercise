using System.Globalization;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //EXERCISE ---------------------- 1 ----------------------
            Console.WriteLine("Hi, I'd like to tell you a story, but first, let's choose some characters to be in our story!");
            Console.WriteLine("Tell me what you'd like the name of the hero of this story to be.");

            var hero = Console.ReadLine();

            Console.WriteLine($"{hero} is a great name for a hero! Now tell me what the name of the villain should be.");

            var villain = Console.ReadLine();

            Console.WriteLine($"Oooh, it gives me chills just hearing the name {villain}! You're great at storytelling! Now tell me a location!");

            var location = Console.ReadLine();

            Console.WriteLine($"{location}... what an interesting place for our story to unfold! Now tell me the name of an animal.");

            var animal = Console.ReadLine();

            Console.WriteLine("Alright, now let's think of a good adjective.");

            var adjective = Console.ReadLine();

            Console.WriteLine($"{adjective} is a funny word, this will be great. Finally, give me a color.");

            var color = Console.ReadLine();

            Console.WriteLine("Okay, here's your story!");

            Console.WriteLine($"It was a Tuesday... {hero} had just returned home to {location} to find a terrifying scene! {villain} had attacked {location} and killed" +
                $" every last {animal}! But alas, {hero} knew what must be done... {villain} had to be stopped... before he used this great sacrifice to create the great {color} wand of {adjective} desolation!" +
                $" {hero} rushed from {location} to the tower of Moar and get the {adjective} sword of divinity. It was the only weapon that stood a chance at stopping {villain}... Just as {hero} was" +
                $" on his way out of town, a wounded {animal} hobbled up to him... and with its last breath, he heard it speak 'save yourself... {villain} is too powerful'... we mighty {animal}s" +
                $" didn't stand a chance against him and we are exceptionally {adjective}... {hero} was moved by the {animal}'s words. {hero} knew they could not let this sacrifice go in vain. It was" +
                $" time to take action. {hero} rushed to the tower of Moar, where the {adjective} sword of divinity was stored in the chamber at the peak of the tower. This is the end of your free trial." +
                $" Please subscribe for $2.99 to get the rest of your story! ");

            var result1 = Add(2, 3);
            var result2 = Subtract(4, 2);
            var result3 = Multiply(5, 6);
            var result4 = Divide(12, 6);
            var result5 = Add(2, 4, 6);

            Console.WriteLine($"Adding 2 and 3: {result1}, Subtracting 4 from 2: {result2}, Multiplying 5 by 6: {result3}, Dividing 12 by 6: {result4}, Adding 2, 4, and 6:  {result5}");

        }
        public static int Add(params int[] nums)
        {
            var acc = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                acc = acc + nums[i];

            }
            return acc;
        }
        public static int Subtract(params int[] nums)
        {
            var acc = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                acc = acc - nums[i];
            }
            return acc;
        }
        public static int Multiply(params int[] nums)
        {
            var acc = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                acc = acc * nums[i];
            }
            return acc;
        }
        public static int Divide(params int[] nums)
        {
            var acc = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                acc = acc / nums[i];
            }
            return acc;
        }

        
    }
}
