# C# Fundamentals

C# is a programming language where .NET is a framework for building applications. The .NET framework consists of two components, the **CLR (Common Language Runtime)** and the **Class Library** for building applications.

## 1. CLR

When we compile our C# code, it is first converted to **IL (Intermediate Language)** code. The **CLR** takes the IL code and converts it to native code. CLR is essentially an application in memory whose job is to convert IL code to native code. This process happens during runtime and it is called **Just-In-Time compilation (JIT)**.

## 2. Architecture of .NET Applications

At a very high level, when you build an application with C#, your application consist of building blocks called **Classes**. These classes collaborate with one another, and as a result, these classes provide functionality.

Classes are containers that have **attributes** and **methods**. Attributes represent the state of the application; Methods represent the behaviour.

Classes are contained in a **Namespace**. A Namespace helps us to organize our classes by housing related classes and therefore, making it more maintainable.

Namespaces are contained in an **Assembly**. Physically, it is a file on disk as either an executable file, or a **DLL (Dynamically Linked Library)**. An Assembly is a single unit of deployment.

### File Structure

When generating a console application, an **AssemblyInfo.cs** file is created. AssemblyInfo.cs is the identification for the assembly that will be produced as a result of compiling the application. Under the **References** folder, we find assemblies that the application depends on so that it can execute and do its job. **App.Config** is an XML file that we use to store the configuration of the application. As an example, we can store the database connection string for a database in App.Config.

## 3. Variables and Constants

A **Variable** is a name given to a storage location in memory. A **constant** is an **immutable** value where it is known at compile time, and its value cannot be changed during the lifetime of the application. We use constants to create safety in our application where we don't want any logic to change the value by mistake.

### Primitive Types

| Type              | C#            | .NET Type     | Bytes         | Range                   |
| -------------     | ------------- | ------------- | ------------- | -------------           |
| Integral Numbers  | byte          | Byte          | 1             | 0 to 255                |
|                   | short         | int16         | 2             | -32,768 to 32,767       |
|                   | int           | int32         | 4             | -2,1B to 2.1B           |
|                   | long          | int64         | 8             | ...                     |
| Real Numbers      | float (1,2f)  | Single        | 4             | -3,4x10^38 to 3,4x10^38 |
|                   | double        | Double        | 8             | ...                     |
|                   | decimal (1,2m)| Decimal       | 16            | -7,9x10^28 to 7,9x10^28 |
| Character         | char          | Char          | 2             | Unicode Characters      |
| Boolean           | bool          | Boolean       | 1             | True/False              | 


### Non-Primitive Types

| Type          |
| ------------- |
| String        |
| Array         |
| Enum          |
| Class         |

### Overflow

An **Overflow** is when we exceed the boundary of a data type.

```
byte number = 255;
number = number + 1;
```

### Scope

**Scope** is when a variable or constant has meaning and is accessible.

## 4. Type Conversion

An **Explicit** conversion is one which has to be stated explicitly, an **Implicit** conversion is one which can be used implicitly, in other words; without the code having to state it.

### Implicit Type Conversion

**Implicit conversion** is the conversion **from a derived class into a base class**, like converting a byte to an int, or an int to a float.

```
byte b = 1;          //                            00000001
int i = b;           // 00000000 00000000 00000000 00000001

int i = 1;
float f = i; // We are implicitly telling the compiler to cast this int to a float.
```

### Explicit Type Conversion

**Explicit conversion** is the conversion that may cause data loss. Explicit conversion converts from a **base class into a derived class**.

```
int i = 1;
// byte b = 1; // This won't compile
byte b = (byte)i; // We are explicitly telling the compiler to cast this int to a byte.

float f = 1.0f;
int i = (int)f; // We are explicitly telling the compiler to cast this float to an int.
```

### Non-Compatible Types

To convert non-compatible types we need to use either **int.Parse()** or **Convert.ToInt32**.
The difference between Parse and Convert is that when we try to **Parse** a null value, the compiler will throw an ArgumentNullException; **Convert** will return a zero.

```
string s = "1";
// int i = (int)s; This won't compile
int i = Convert.ToInt32(s);
// or
int j = int.Parse(s);
```
## Operators

### Arithmatic

**Postfix Increment** - First, the value of a is assigned to b, and then a will be incremented.

```
int a = 1;
int b = a++;  // a = 2, b = 1
```

**Prefix Increment** - First, the value of a is incremented, then the value is assigned to b.

```
int a = 1;
int b = ++a  // a = 2, b = 2
```

## Non-Primitive Types

### Classes

A **class** is a type, also known as a blueprint, from which we create objects. Am **object** is an instace of a class.

Classes are treated differently from primitive types in that **we need to use the new operator to explicitly allocate memory for it**.

```
Person person = new Person();
```

### Static Modifier

**Without the static** keyword, you have to create an instance of the class for wherever, and whenever it is needed. This means that there is memory allocated fo each instance of the class. **With the static keyword**, a static member is accessible from the class itself; any code path can access it, provided it references the namespace. It behaves like a **Singleton** except, you can't inherit with a static class.

```
public class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

// We cannot create an instance of a static class.
// var calc = new Calculator();
// var result = calc.Add(1, 2);

// We now have direct access to the method due to the member being static.
int result = Calculator.Add(1, 2);
```

**Without static**, when you create three instances of a class, each object will have the add method, and each object will be allocated memory.
calc1     calc2     calc3
Add()     Add()     Add()

**With static**, we use the static modifier when we want to represent a concept that only a single instance should exist in memory.

### Struct

Structs combine related fields and methods together. **You should use a Struct when you want to define a small, lightweight object**.

```
public struct RGBColour
{
    public int Red;
    public int Green;
    public int Blue;
}
```

### Arrays

An array is a data structure to store **a collection of variables of the same type**. Arrays have a fixed size and it can not be changed. It is also zero based.

```
int number1;
int number2;
int number3;

int [] numbers = new int [3] {1, 2, 3}; // The number three in the square brackets represents the size of the array.
```

### Strings

A **string is a sequence of characters**. We use double quotes for strings, and single quotes for characters. Strings are also **immutable**, meaning that they can not be changed after you create it. There are methods in the string class that allows us to manipulate strings and modify their values, but all of these methods return a new string, meaning that the original string is not changed. This is what is meant by immutable. 

**All primitives map to a struct, but strings map to a class, hence it being a Non-Primitive.**

string is a type in C#.
String is a type in the .NET framework.

### Enums

An enum is a data type that represents a set of name/value pairs (constants). You should use enums when you have a number of related constants. Internally, an enum is an integer.

```
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}
```

We can use the enum with dot notation.
```
var method = ShippingMethod.Express;
```

### Reference Types and Value Types

All **primitive types are structure**. We use structures for small types, like RGB colours and points. All structures are small types, they take no more than 8 bytes. It is internally defined as a structure in .NET.

In terms of memory management, **classes and structures** are treated differently at runtime . **Structures are what we call value types while classes are reference types**. 

With **Value** types, a part of the memory call **stack** is allocated for the variable. When the variable goes out of scope, it will immediately get removed from the stack by runtime, or CLR.

An integer is a **value type**. When we copy a value type to another variable, a copy of the value is stored in the target location in memory, in a **stack**.

Stack
a:10

b:10

b represents a new location in the stack. The variables a, and b, are **completely independent** from one another. **Making a change to one does not affect the other**.

With **Reference** types, you have to explicitly allocate the memory yourself. The **new** operator tells the runtime to allocate memory to this object. This memory allocation happens on a **Heap**, which is more sustainable than a **Stack**, simply because it is more flexible in terms of dynamically allocating and de-allocating memory as needed. When the object goes out of scope, it will still exist in the heap up until it is removed by Garbage Collection, which is done by CLR.


An array is a class, so it is a reference type. When we copy an array to another variable, we are actually just copying the address of the array to the other variable. This means that both arrats are using the same memory address to read that specific memory block.  This implies that if a value is changed in the first, or second array, it will reflect in the other array because the change was done in a memory address that both array are dependt on.

Heap                                                                     Stack

0x00416A // The address of the memory block     <-------------------------array1 (0x00416A) // The memory address is copied.
[1][2][3] // the array                                                  \ array2 (0x00416A) // the memory address is copied.

As can be seen, the memory address is copied, not the actual value.