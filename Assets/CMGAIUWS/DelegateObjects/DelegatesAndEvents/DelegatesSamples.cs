namespace CMGAIUWS.DelegateObjects.DelegatesAndEvents
{
    public class DelegatesSamples
    {
        /*
         * The "in" keyword is used to specify that a generic type parameter is contravariant.
         * Contravariance allows you to use a more derived type (a subtype) than originally specified.
         * Meaning T can be used in input positions (e.g., method parameters).
         * This is useful in scenarios where you want to pass a derived type to a method that expects a base type.
         * # Example:
         * You can pass a class Person as well as one called Animal, given that Person extends Animal.
         * This is possible because the in keyword makes the generic type parameter T contravariant,
         * allowing you to use a more derived type (Person) where a base type (Animal) is expected.
         */
        public delegate int ComparisonSample<in T>(T left, T right);
        
        /*
         * The "out" keyword is used to specify that a generic type parameter is covariant.
         * Covariance allows you to use a more generic type than originally specified.
         * Meaning T can only be used in output positions (e.g., return types).
         * This is useful in scenarios where you want to pass a base type to a method that expects a more derived type.
         * # Example:
         * You can pass a class Animal as well as one called Person, given that Person extends Animal.
         * This is possible because the out keyword makes the generic type parameter T covariant,
         * allowing you to use a more generic type (Animal) where a derived type (Person) is expected.
         */
        public delegate T CovariantDelegate<out T>();
    }
}