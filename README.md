<<<<<<< HEAD
# Blogapp

This project was generated using [Angular CLI](https://github.com/angular/angular-cli) version 19.0.6.

## Development server

To start a local development server, run:

```bash
ng serve
```

Once the server is running, open your browser and navigate to `http://localhost:4200/`. The application will automatically reload whenever you modify any of the source files.

## Code scaffolding

Angular CLI includes powerful code scaffolding tools. To generate a new component, run:

```bash
ng generate component component-name
```

For a complete list of available schematics (such as `components`, `directives`, or `pipes`), run:

```bash
ng generate --help
```

## Building

To build the project run:

```bash
ng build
```

This will compile your project and store the build artifacts in the `dist/` directory. By default, the production build optimizes your application for performance and speed.

## Running unit tests

To execute unit tests with the [Karma](https://karma-runner.github.io) test runner, use the following command:

```bash
ng test
```

## Running end-to-end tests

For end-to-end (e2e) testing, run:

```bash
ng e2e
```

Angular CLI does not come with an end-to-end testing framework by default. You can choose one that suits your needs.

## Additional Resources

For more information on using the Angular CLI, including detailed command references, visit the [Angular CLI Overview and Command Reference](https://angular.dev/tools/cli) page.
=======
# Blog App Using Angular & .NET Core Web API  

## 📌 Project Overview  
This is a full-stack blog application built using **Angular** for the frontend and **.NET Core Web API** for the backend. The app allows users to create, edit, delete, and view blog posts while ensuring a smooth and user-friendly experience.  

## 🚀 Features  
- 📝 **User Authentication** (Signup/Login with JWT)  
- 📰 **Create, Read, Update, and Delete (CRUD) Blog Posts**  
- 📂 **Image Upload Support for Blog Posts**  
- 📢 **Commenting System**  
- 🔎 **Search & Filtering Options**  
- 🎨 **Responsive UI (Bootstrap + Material Design)**  
- 🔐 **Secure API with Token-Based Authentication**  
- 📊 **Dashboard for Managing Posts**  

## 🛠️ Technologies Used  
### Frontend (Angular)  
- **Angular 16+**  
- **TypeScript**  
- **Bootstrap / Material UI**  
- **Angular Router**  
- **HTTP Client for API Calls**  

### Backend (.NET Core Web API)  
- **ASP.NET Core 7+**  
- **Entity Framework Core (EF Core)**  
- **SQL Server / MySQL Database**  
- **JWT Authentication**  
- **CORS Configuration**  

## 🎯 Setup & Installation  

### Prerequisites  
Ensure you have the following installed:  
- **Node.js** (LTS version)  
- **Angular CLI** (`npm install -g @angular/cli`)  
- **.NET Core SDK 7+**  
- **SQL Server / MySQL**  

### 🔥 Backend Setup (.NET Core Web API)  
1. Clone the repository:  
   ```bash
   git clone https://github.com/Zainulabdeenoffical/Blog-app-using-angualr-.netcorewebapi.git
   cd Blog-app-using-angualr-.netcorewebapi/Backend
   ```
2. Restore dependencies:  
   ```bash
   dotnet restore
   ```
3. Configure database connection in `appsettings.json`.  
4. Apply database migrations:  
   ```bash
   dotnet ef database update
   ```
5. Run the API server:  
   ```bash
   dotnet run
   ```
   The API should be running at `http://localhost:5000/` or `https://localhost:5001/`.  

### 🎨 Frontend Setup (Angular)  
1. Navigate to the Angular app directory:  
   ```bash
   cd Blog-app-using-angualr-.netcorewebapi/Frontend
   ```
2. Install dependencies:  
   ```bash
   npm install
   ```
3. Run the Angular development server:  
   ```bash
   ng serve
   ```
   The app should be running at `http://localhost:4200/`.  

## 🛡️ API Endpoints  

### Authentication  
- `POST /api/auth/register` → Register a new user  
- `POST /api/auth/login` → Authenticate user & generate JWT  

### Blog Posts  
- `GET /api/posts` → Get all posts  
- `GET /api/posts/{id}` → Get post by ID  
- `POST /api/posts` → Create a new post  
- `PUT /api/posts/{id}` → Update a post  
- `DELETE /api/posts/{id}` → Delete a post  

### Comments  
- `POST /api/comments` → Add a comment  
- `GET /api/comments/{postId}` → Get comments for a post  

## 🏆 Contributors  
- **Zainulabdeen** ([GitHub](https://github.com/Zainulabdeenoffical))  

## 📜 License  
This project is licensed under the **MIT License**.  

## 🎯 Future Enhancements  
- 📢 Social Media Sharing  
- 🌍 Multi-language Support  
- 📊 User Profile & Dashboard  
- 📸 Rich Media Integration  



>>>>>>> 734fa56e7d1a3307e88a89a95ca81598ec635a33
