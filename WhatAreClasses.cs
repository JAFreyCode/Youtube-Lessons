using UnityEngine;

// The using directive allows you to use types defined in a namespace without specifying the fully qualified namespace of that type.
// In its basic form, the using directive imports all the types from a single namespace, as shown in the following example: using UnityEngine above.
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive

namespace ExampleNamespace
{
    //The namespace keyword is used to declare a scope that contains a set of related objects.
    //You can use a namespace to organize code elements and to create globally unique types.
    //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/namespace

    // The `public` keyword makes this class accessible from other classes and scripts.
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/public

    // If `private` were used, the class would only be accessible within the same scope.
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/private

    // Adding `static` (e.g., `public static` or `private static`) is useful for grouping
    // methods or constants that do not require an instance of the class to be used.
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/static

    // A class is a blueprint for creating objects in C#.
    // It defines properties (data) and methods (behavior) that represent the object's characteristics and actions.
    // Classes support core object-oriented programming principles like encapsulation, reusability, and inheritance.
    // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/class

    // The `: MonoBehaviour` syntax indicates that this class inherits from Unity's MonoBehaviour class.
    // This inheritance allows the class to be used as a Unity script, enabling it to:
    // - Be attached to GameObjects in the scene.
    // - Use Unity-specific lifecycle methods (e.g., Start, Update, OnCollisionEnter).
    // Note: A class can inherit from other classes, not just MonoBehaviour, depending on its needs.
    // https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/inheritance

    /*
     * A class definition typically includes:
     * - An access modifier (e.g., `public`, `private`) to control its visibility.
     * - The `class` keyword, which defines this as a class.
     * - A name for the class (e.g., "YoutubeLearning").
     * - While a inheritance is optional depending on the use case.
     * 
     * Example:
     * public class YoutubeLearning : MonoBehaviour
     * {
     *     // Class body (methods, properties, fields, etc.) goes here.
     * }
     */
    public class YoutubeLearning : MonoBehaviour
    {
        // Class body would go here.
    }

    // In C#, top-level classes cannot be private, but nested classes can be.
    // For example, you can have a private nested class within a public class.

    public class ClassContainingPrivateClasses : MonoBehaviour
    {
        // This is a private class inside a public class.
        // The private class is only accessible within this containing class.
        // And of course this can also be done in a static class such as the one below.
        private class HiddenClass
        {
            // Class body for the private class goes here.
        }
    }

    // Example of a static class
    // Static classes cannot be instantiated and are typically used to group utility methods or constants.

    public static class ClassContainingMainMethods
    {
        // Static classes cannot have instance methods.
        // All methods inside a static class must be static.
    }
}
