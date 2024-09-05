## Project Structure

The project consists of six main classes:
1. Book (Abstract Class)
2. State (Enum)
3. BookScience, BookRoman, BookHistory (Sub Classes)
4. Imember (Interface)
5. Member (Class)
6. Pole House (Class)

### Book 1 (Abstract Class)
- Contains the basic properties of books (ISBN, title, author, publication year, etc.).
- Acts as a base class for other book types.
- Holds the current status (available for loan, on loan, not available).

#### 2nd State (Enum)
- Indicates the loan status of books for use within the book class.
- Values: Borrowable, Borrowed, Not Available

### BookScience, BookRoman, BookHistory (Sub Classes)
- Represents the book types in the library by inheriting from the Book class.

### 4. IUye (Interface)
- Provides an interface that specifies the properties and methods of the member class.
- Properties: First Name, Last Name, Member Number, List of Borrowed Books
- Methods: BookOduncAl, BookReturn, OduncAlinanKitaplariGoruntule

### 5. Uye (Class)
- Implements the IMember interface.
- It contains the properties and methods of the members of the library.

### 6. Polar Library (Class)
- This is the main class that manages books and members.
- It performs operations such as lending, returning and updating the current status of books.

## Creating a Project Step by Step

### Step 1: Project Creation
- A new Class Library project is created.
- The project is named `LibraryProject`.

### Step 2: Defining Basic Classes and Structures

#### Book Class and Status Enum
- Create an abstract class containing the basic properties of the books.
- An enum is defined to indicate the current state of the books.

#### Book Types Classes
- Subclasses representing the book types in the library are created by inheriting from the Book class (BookScience, BookRoman, BookHistory).

#### IUye Interface
- Define an interface that specifies the properties and methods of the member class.

#### Member Class
- A class is created that implements the IUye interface and contains the properties and methods of the people who are members of the library.

#### Kutuphane Class
- Create a main class that manages books and members.
- Methods for lending, returning and updating the current status of books are added.

Translated with DeepL.com (free version)
