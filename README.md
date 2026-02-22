# Library Management System

A console-based library management application built with C# and .NET 8.

## Features

- **Add books** — Add new books to the library (max 5 books)
- **Remove books** — Remove a book by title
- **Search books** — Search for a book by title
- **Display books** — List all books with their ID, title, and borrow status
- **Borrow books** — Mark a book as borrowed (max 3 books at a time)
- **Return books** — Return all currently borrowed books

## Requirements

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

## Getting Started

```bash
# Clone the repository
git clone <repository-url>
cd Library.Management.System

# Run the application
dotnet run --project Library.Management.System
```

## Usage

When the application starts, type one of the following commands at the prompt:

| Command   | Description                        |
|-----------|------------------------------------|
| `add`     | Add a new book to the library      |
| `remove`  | Remove a book by title             |
| `search`  | Search for a book by title         |
| `display` | Display all books                  |
| `borrow`  | Borrow a book                      |
| `return`  | Return all borrowed books          |
| `exit`    | Exit the application               |

## Project Structure

```
Library.Management.System/
├── Library.Management.System.sln
├── global.json
└── Library.Management.System/
    ├── Program.cs          # Entry point
    ├── Book.cs             # Book model
    ├── BookService.cs      # Business logic (add, remove, borrow, etc.)
    └── LibraryMenu.cs      # Console menu loop
```

## Constraints

- Maximum **5 books** can be held in the library at once
- Maximum **3 books** can be borrowed at a time
- Returning books returns **all** borrowed books at once
