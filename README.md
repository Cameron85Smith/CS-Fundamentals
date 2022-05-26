# C# Fundamentals

- [C# Fundamentals](#c--fundamentals)
  * [1. CLR](#1-clr)
  * [2. Architecture of .NET Applications](#2-architecture-of-net-applications)
    + [File Structure](#file-structure)
  * [3. Variables and Constants](#3-variables-and-constants)
    + [Primitive Types](#primitive-types)
    + [Non-Primitive Types](#non-primitive-types)
    + [Overflow](#overflow)
    + [Scope](#scope)
  * [4. Type Conversion](#4-type-conversion)
    + [Implicit Type Conversion](#implicit-type-conversion)
    + [Explicit Type Conversion](#explicit-type-conversion)
    + [Non-Compatible Types](#non-compatible-types)
  * [5. Operators](#5-operators)
    + [Arithmetic](#arithmetic)
  * [6. Non-Primitive Types](#6-non-primitive-types)
    + [Classes](#classes)
    + [Static Modifier](#static-modifier)
    + [Struct](#struct)
    + [Arrays](#arrays)
    + [Strings](#strings)
    + [Formatting](#formatting)
    + [Enums](#enums)
  * [7. Reference Types and Value Types](#7-reference-types-and-value-types)
  * [8. Iteration Statements](#8-iteration-statements)
    + [Conditional Statements](#conditional-statements)
    + [Iteration Statements](#iteration-statements)
  * [9. Random Class](#9-random-class)
  * [10. Multi-Dimension Arrays](#10-multi-dimension-arrays)
  * [11. List](#11-list)
  * [12. StringBuilder](#12-stringbuilder)
  * [13. Working with Files, Directories, and Paths](#13-working-with-files-directories-and-paths)
    + [File classes](#file-classes)
    + [Directory classes](#directory-classes)
    + [Path class](#path-class)

# Introduction

C# is a programming language where .NET is a framework for building applications. The .NET framework consists of two components, the **CLR (Common Language Runtime)** and the **Class Library** for building applications.

## 1. CLR

When we compile our C# code, it is first converted to **IL (Intermediate Language)** code. The **CLR** takes the IL code and converts it to native code. CLR is essentially an application in memory whose job is to convert IL code to native code. This process happens during runtime and it is called **Just-In-Time compilation (JIT)**.

## 2. Architecture of .NET Applications

At a very high level, when you build an application with C#, your application consist of building blocks called **Classes**. These classes collaborate with one another, and as a result, these classes provide functionality.

Classes are containers that have **attributes** and **methods**. Attributes represent the state of the application; Methods represent the behaviour.

Classes are contained in a **Namespace**. A Namespace helps us to organize our classes by housing related classes and therefore, making it more maintainable.

Namespaces are contained in an **Assembly**. Physically, it is a file on disk as either an executable file, or a **DLL (Dynamically Linked Library)**. An Assembly is a single unit of deployment.

### File Structure
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/HelloWorld)

When generating a console application, an **AssemblyInfo.cs** file is created. AssemblyInfo.cs is the identification for the assembly that will be produced as a result of compiling the application. Under the **References** folder, we find assemblies that the application depends on so that it can execute and do its job. **App.Config** is an XML file that we use to store the configuration of the application. As an example, we can store the database connection string for a database in App.Config.

## 3. Variables and Constants
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Variables)

A **Variable** is a name given to a storage location in memory. A **constant** is an **immutable** value where it is known at compile time, and its value cannot be changed during the lifetime of the application. We use constants to create safety in our application where we don't want any logic to change the value by mistake.

### Primitive Types

**All primitives map to a struct**

| Type             | C#             | .NET Type | Bytes | Range                   |
|------------------|----------------|-----------|-------|-------------------------|
| Integral Numbers | byte           | Byte      | 1     | 0 to 255                |
|                  | short          | int16     | 2     | -32,768 to 32,767       |
|                  | int            | int32     | 4     | -2,1B to 2.1B           |
|                  | long           | int64     | 8     | ...                     |
| Real Numbers     | float (1,2f)   | Single    | 4     | -3,4x10^38 to 3,4x10^38 |
|                  | double         | Double    | 8     | ...                     |
|                  | decimal (1,2m) | Decimal   | 16    | -7,9x10^28 to 7,9x10^28 |
| Character        | char           | Char      | 2     | Unicode Characters      |
| Boolean          | bool           | Boolean   | 1     | True/False              | 


### Non-Primitive Types

| Type   |
|--------|
| String |
| Array  |
| Enum   |
| Class  |

### Overflow

An **Overflow** is when we exceed the boundary of a data type.
```
byte number = 255;
number = number + 1;
```

### Scope

**Scope** is when a variable or constant has meaning and is accessible.

## 4. Type Conversion
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/TypeConversion)

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
// int i = (int)s; // This won't compile.
int i = Convert.ToInt32(s);
// or
int j = int.Parse(s);
```
## 5. Operators
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Operators)

### Arithmetic

**Postfix Increment**: First, the value of a is assigned to b, then a will be incremented.
```
int a = 1;
int b = a++;  // a = 2, b = 1
```

**Prefix Increment** - First, the value of a is incremented, then the value is assigned to b.
```
int a = 1;
int b = ++a  // a = 2, b = 2
```

## 6. Non-Primitive Types
[Class Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Classes) | [Array Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Arrays) | [String Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Strings) | [Enum Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Enums) | [Text Exercise](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/TextExercise)

### Classes

A **class** is a type, also known as a blueprint, from which we create objects. An **object** is an instance of a class.
Classes are treated different from primitive types in that **we need to use the new operator to explicitly allocate memory for it**.
```
Person person = new Person();
```

### Static Modifier

**Without the static** keyword, you have to create an instance of the class for wherever, and whenever it is needed. This means that memory is allocated for each instance of the class. **With the static keyword**, you are creating one instance of the class in memory, so it behaves like a **Singleton**, except you can't inherit with a static class. A static member is accessible from the class itself; any code path can access it, provided it references the namespace.
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

**Without static**, when you create three instances of a class, each object will have the Add() method, and each object will be allocated memory.
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

**arrays map to a class, making it a Non-Primitive**
```
int number1;
int number2;
int number3;

// The number three in the square bracket represents the size of the array.
int [] numbers = new int [3] {1, 2, 3};
```

### Strings

A **string is a sequence of characters**. We use double quotes for strings, and single quotes for characters. Strings are also **immutable**, meaning that they can not be changed after you create it. There are methods in the string class that allows us to manipulate strings and modify their values, but all of these methods return a new string, meaning that the original string is not changed. This is what is meant by immutable. 

**strings map to a class, making it a Non-Primitive.**

**string is a C# type.**
**String is a .NET framework type.**

Both are compiled to System.String in IL (Intermediate Language).
System.String is a class and used for accessing string static methods like String.Format(), String.Compare(), etc.

Here, you can see that **string** is used for declaring variable variables whereas **String** is used for access the static method String.Concat() that joins two strings together.
```
using System;  
namespace ConsoleApplication {  
    public class Program {  
        public static void Main(string[] args) {  
            string s = "Hello ";  
            string t = "World";  
            string st = String.Concat(s, t);  
            Console.WriteLine(st);  
        }  
    }  
} 
```

### Formatting
| Format Specifier | Description | Example                            |
|------------------|-------------|------------------------------------|
| c or C           | Currency    | 123456(C) -> $123,456              |
|d or D            | Decimal     | 1234(D6) -> 001234                 |
|e or E            | Exponential | 1052.0329112756(E) -> 1.052033E+003|
|f or F            | Fixed Point | 1234.567(F1) -> 1234.5             |
|x or X            | Hexadecimal | 255(X) -> FF                       |

### Enums

An Enum is a data type that represents a set of name/value pairs (constants). You should use Enum when you have a number of related constants. Internally, an Enum is an integer.
```
public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3
}
```

We can use the Enum with dot notation.
```
var method = ShippingMethod.Express;
```

## 7. Reference Types and Value Types
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/ReferenceValueTypes)

All **primitive types are structures**. We use structures for small types, like RGB colours and points. Structures take no more than 8 bytes. It is internally defined as a structure in .NET.

In terms of memory management, **classes and structures** are treated differently at runtime . **Structures are what we call value types while classes are reference types**. 

With **Value** types, a part of the memory call **stack** is allocated for the variable. When the variable goes out of scope, it will immediately get removed from the stack by runtime, or CLR (Common Language Runtime).

An integer is a **value type**. When we copy a value type to another variable, a copy of the value is stored in the target location in memory, in a **stack**.

b represents a new location in the stack. The variables a, and b, are **completely independent** from one another. **Making a change to one does not affect the other**.

Stack
```
a:10
b:10
```

With **Reference** types, you have to explicitly allocate the memory yourself. The **new** operator tells the runtime to allocate memory to this object. This memory allocation happens on a **Heap**, which is more sustainable than a **Stack**, simply because it is more flexible in terms of dynamically allocating and de-allocating memory as needed. When the object goes out of scope, it will still exist in the heap up until it is removed by Garbage Collection, which is done by CLR (Common Language Runtime).

An array is a class, so it is a reference type. When we copy an array to another variable, we are actually just copying the address of the array to the other variable. This means that both arrays are using the same memory address to read that specific memory block. This implies that if a value is changed in the first, or second array, it will reflect in the other array because the change was done in a memory address that both arrays are dependent on.
```
Heap -------------------------------------------------Stack
0x00416A // The address of the memory block   <-------array1 (0x00416A) // The memory address is copied.
[1][2][3] // the array                              \ array2 (0x00416A) // the memory address is copied.
```

As can be seen, the memory address is copied, not the actual value.

## 8. Iteration Statements
[Iteration Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Iterations) | [Control Flow Exercise](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/ControlFlowExercise) | [Conditional Statement Exercise](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/ConditionalStatementsExercise)

We use a **for loop** when we know how many times we are going to iterate through a collection.
We use a **while loop** when we don't know how many times we are going to do an iteration.

The control flow of your application depends largely on conditional and iteration statements.

### Conditional Statements

- if/else
- switch

### Iteration Statements

- for loops
- foreach loops
- while loops

## 9. Random Class
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Random)

We use the Random class when we want to generate a random value.

## 10. Multi-Dimension Arrays

We have two types of multi-dimension arrays; **Rectangular and Jagged**.

In a Rectangular array, the array has the exact same number of columns.
```
var matrix = new int[3,5]; // One bracket.

      [0 | 1 | 2 | 3 | 4 | 5]
3x5 = [0 | 1 | 2 | 3 | 4 | 5]
      [0 | 1 | 2 | 3 | 4 | 5]
```

In C#, it is easier to implement a Jagged array instead of a Rectangular array becuase C# is optimized for single arrays, and this is what Jagged arrays are based on.
Jagged arrays are arrays with a variable amount of columns.
```
var jagged = new int[3][]; // Two brackets.

[0 | 1 | 2 | 3]
[0 | 1 | 2 | 3 | 4 ]
[0 | 1 | 2 ]
```

## 11. List
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/List) | [Exercise](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/ArrayListExercise)

The difference between an Array and a List is that an Array have a fixed size, where a List has a dynamic size. We use a List when we don't know how many objects we will be working with. A List is a generic type and it is indicated by angle brackets.

```
var numbers = new List<int>();
```

## 12. StringBuilder
[Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/StringBuilder)

The string class is immutable, which means that once you create a string object you cannot change its content. If you're going to do a lot of string manipulation, you can use a StringBuilder.

StringBuilders is a class that is defined in the System.Text namespace, and it represents a mutable string. It provides methods for manipulating a string, like Append(), Insert(), etc.

## 13. Working with Files, Directories, and Paths
[File Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/FileAndFileInfo) | [Directory Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/DirectoryAndDirectoryInfo) | [Path Introduction](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/Path) | [Exercise](https://github.com/Cameron85Smith/CS-Fundamentals/tree/main/FileExercise)

### File classes

File, FileInfo classes provide methods for creating, copying, deleting, moving, and opening files.

- File provides **static** methods.
- FileInfo provides **instance** methods.

The difference between the two is that if you are going to perform a **small number of operations** on a file, it is more convenient to access the static methods of the **File class**. However, the **problem** with the static method is that every time you call a static method, some **security checking** is done by the operating system to make sure that the current user has access to the file. If you are going to have a **large number of operations** on a file, this is going to **affect the performance** of the application. Alternatively, it is **more efficient** to create an instance of the **FileInfo class** and access its instance methods. Using this approach, the **security check is done once** when creating an instance of the FileInfo class.

### Directory classes

Similar to the File and FileInfo class, we have Directory and DirectoryInfo class.

- Directory provides static methods.
- DirectoryInfo provides instance methods.

### Path class

The Path class provides methods to work with a string that contains a file, or directory path information.