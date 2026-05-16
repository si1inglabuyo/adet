# Blog Post Application

A clean and simple ASP.NET Core MVC blog post application demonstrating MVC patterns with Razor views and controllers.

## Features

- **MVC Architecture**: Clean separation of Models, Views, and Controllers
- **Blog Display**: View a list of all blog posts
- **Post Details**: View full details of individual blog posts
- **Responsive Design**: Bootstrap 5 responsive layout
- **Mock Data**: Sample blog posts for demonstration

## Project Structure

```
├── Controllers/
│   ├── BlogController.cs       # Blog-related MVC controller
│   └── HomeController.cs       # Home page controller
├── Models/
│   └── Post.cs                 # Post model
├── Views/
│   ├── Blog/
│   │   ├── Index.cshtml        # List all blog posts
│   │   └── Details.cshtml      # Show post details
│   ├── Home/
│   │   ├── Index.cshtml        # Home page
│   │   └── Privacy.cshtml      # Privacy page
│   └── Shared/
│       ├── _Layout.cshtml      # Master layout
│       └── Error.cshtml        # Error page
├── wwwroot/                    # Static files (CSS, JS, images)
├── Program.cs                  # Application configuration
└── appsettings.json            # Application settings
```

## Getting Started

### Prerequisites

- .NET 8.0 SDK or higher
- Visual Studio Code or Visual Studio

### Installation

1. Clone or download the repository
2. Navigate to the project directory:
   ```bash
   cd blog-post-application
   ```

3. Restore NuGet packages:
   ```bash
   dotnet restore
   ```

### Running the Application

Run the application using:
```bash
dotnet run
```

The application will start on:
- HTTP: `http://localhost:5000`
- HTTPS: `https://localhost:44300`

### Accessing the Application

- **Home Page**: Navigate to `http://localhost:5000/` or `http://localhost:5000/Home/Index`
- **Blog Posts**: Navigate to `http://localhost:5000/Blog` or `http://localhost:5000/Blog/Index`
- **Post Details**: Navigate to `http://localhost:5000/Blog/Details/{id}` (e.g., `/Blog/Details/1`)

## MVC Routes

The application uses the following routes:

| Route | Controller | Action | Description |
|-------|-----------|--------|-------------|
| `/` | Home | Index | Home page |
| `/Blog` | Blog | Index | List all blog posts |
| `/Blog/Details/{id}` | Blog | Details | Show post details |
| `/Home/Privacy` | Home | Privacy | Privacy policy page |

## Components

### Models
- **Post.cs**: Represents a blog post with Id, Title, Content, Author, and CreatedAt

### Controllers
- **BlogController.cs**: 
  - `Index()` - Displays a list of all blog posts
  - `Details(id)` - Displays the details of a single blog post
- **HomeController.cs**:
  - `Index()` - Displays the home page
  - `Privacy()` - Displays the privacy policy page
  - `Error()` - Handles error pages

### Views
- **Blog/Index.cshtml** - Displays blog posts in a card layout with links to details
- **Blog/Details.cshtml** - Shows full post content with title, author, and date
- **Home/Index.cshtml** - Welcome page with information about the blog
- **Shared/_Layout.cshtml** - Master layout with navigation and Bootstrap styling
- **Shared/Error.cshtml** - Error page

## Styling

The application uses:
- **Bootstrap 5** - For responsive design and components
- **Custom CSS** - In `wwwroot/css/site.css` for additional styling

## Building the Project

Build the project:
```bash
dotnet build
```

## Technology Stack

- **Framework**: ASP.NET Core 8.0
- **Frontend**: HTML5, CSS3, Bootstrap 5
- **Language**: C#

## Sample Data

The application includes 4 sample blog posts with mock data:
1. "Getting Started with C#"
2. "ASP.NET Core Best Practices"
3. "Entity Framework Core Guide"
4. "Building RESTful APIs"

## Future Enhancements

- Add database persistence with Entity Framework Core
- Implement user authentication
- Add comment functionality
- Create admin panel for post management
- Add search and filtering capabilities
- Implement pagination
- Add tags or categories

## License

This project is provided as-is for educational purposes.

## Support

For issues or questions, please refer to the [ASP.NET Core Documentation](https://docs.microsoft.com/aspnet/core).
