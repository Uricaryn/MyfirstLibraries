## Project Structure

The project consists of six main classes:
1. IPersonnel (Interface)
2. Administrator (Classroom)
3. Clerk (Class)
4. Payroll (Classroom)
5. ReadFile (Class)

### 1. IPersonnel (Interface)
- Defines the properties that personnel classes should have and salary calculation methods.

### 2. Administrator (Class)
- Implements the IPersonnel interface.
- It includes managers' properties and salary calculation methods.

#### 3. Clerk (Class)
- Implements the IPersonnel interface.
- It contains the properties of Clerks and salary calculation methods.

### 4. Payroll (Class)
- It contains functionality that calculates the salaries of the personnel list and saves them to the file.
- It has two methods, MaaslariHesaplaVeKaydet and AzCalisanlariRaporla.

### 5. ReadFile (Class)
- Contains functionality for writing data in JSON format to and reading from a file.
- It has two methods, Write to JsonFile and Read from JsonFile.

## Creating a Project Step by Step

### Step 1: Project Creation
- A new Class Library project is created.
- The project is named `LibraryProject`.

### Step 2: Defining Basic Classes and Structures

#### IPersonnel Interface
- Provides an interface specifying the properties of personnel classes and salary calculation methods.

#### Manager Class
- Implements the IPersonnel interface.
- It includes properties of managers and salary calculation methods.

#### Clerk Class
- Implements the IPersonnel interface.
- It contains properties of Clerks and salary calculation methods.

#### Payroll Class
- Contains functionality that calculates the salaries of the staff list and saves them to the file.

#### ReadFile Class
- It includes functionality for writing data in JSON format to and reading from a file.

Translated with DeepL.com (free version)
