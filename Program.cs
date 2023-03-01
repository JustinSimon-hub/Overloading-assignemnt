namespace MethodOverloading
{

/*
    ## Exercise 1:

+ Create a method named Add, that accepts two integers and returns the sum of those two integers
+ Now create an overload of the Add method to account for being able to add two decimals together
+ Now create another overload of the Add method that returns a string and accepts 3 parameters: 2 integers and 1 boolean
+ If the boolean parameter is equal to true, the Add method will return the sum of the 2 numbers plus the word “dollars” at the end of the string.
+ You must also account for the appropriate grammar of the string - so it can’t be “1 dollars”

For example:
```
“5 dollars”

"1 dollar”

“16 dollars”
```

[Teacher's Answer](https://drive.google.com/file/d/1eXswxCDzGSArtbqcSoVeB9Tnl-NMzhqz/view)
*/

    public class Program
    {

        public static int Add (int x, int y)
        {
            return x + y;
        }
        public static float Add ( float x, float y)
        {
            return x + y;
        }
        public static void Add ( int x, int y, bool z)
        {
            int answer = x + y;
          if ( z == true && answer != 1)
          {
            
            Console.WriteLine($"{answer} dollars");
          }
          else if ( answer == 1 && z == true)
          {
            
            Console.WriteLine($"{answer} dollar");
          }
          else 
          {
            Console.WriteLine("Please modify parameters");
          }
        }
        static void Main(string[] args)
        {
            Add(1,1,true);
            
        }
    }
}
