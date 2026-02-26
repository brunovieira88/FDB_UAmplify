# UAmplify

![C#](https://img.shields.io/badge/c%23-%23239120.svg?style=for-the-badge&logo=csharp&logoColor=white)
![.Net](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![Visual_Studio](https://img.shields.io/badge/Visual%20Studio-5C2D91.svg?style=for-the-badge&logo=visual-studio&logoColor=white)
![SQL](https://img.shields.io/badge/SQL-003B57?style=for-the-badge&logo=sqlite&logoColor=white)
![Windows](https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white)

## Overview
**UAmplify** is a Windows Forms desktop application built with C# and .NET 8.0. It was developed as part of the Database Foundations (FBD - *Fundamentos de Bases de Dados*) course. The application simulates a music streaming platform's management system, allowing users to interact with a robust database to manage music, albums, playlists, and user profiles.

## Features
The platform supports different user roles, each with specific permissions and views:
* 🔐 **User Authentication**: Secure Login and Registration (`Registo`) for new users.
* 👥 **Role-Based Access Control**:
  * **Listeners**: Can browse music, create and manage personal playlists, and edit their profiles.
  * **Artists**: Can manage their discography (add/edit albums and musics) and view their artist page.
  * **Moderators**: Have administrative privileges to manage users and platform content.
* 🎵 **Music & Album Management**: Add, edit, and view details for musics and albums.
* 🎧 **Playlist System**: Create, edit, and view custom playlists.
* 👤 **Profile Management**: Users can edit their personal information.

## Technologies Used
* **Language**: C#
* **Framework**: .NET 8.0 (Windows Forms)
* **IDE**: Visual Studio 2022
* **Database**: SQL (Relational Database Management System)

## Project Structure
* `Login.cs` / `Registo.cs`: Authentication forms.
* `Home.cs`: Main dashboard of the application.
* `Musics.cs` / `MusicEdit.cs`: Management of individual tracks.
* `Albums.cs` / `AlbumDetails.cs` / `AlbumEdit.cs`: Management of albums.
* `Playlists.cs` / `CreatePlaylist.cs` / `EditPlaylist.cs` / `PlaylistDetails.cs`: Playlist creation and display.
* `ArtistPage.cs` / `ArtistEdit.cs`: Artist-specific interfaces.
* `ListenerPage.cs` / `Listeners.cs`: Listener-specific interfaces.
* `ModeratorPage.cs`: Admin/Moderator dashboard.
* `EditProfile.cs` / `EditUser.cs`: Account and profile management.

## How to Run
1. **Clone the repository**:
   ```bash
   git clone https://github.com/brunovieira88/fdb_uamplify.git
   ```
2. **Open the Project**: Open the `FBD-2526.sln` solution file in Visual Studio 2022.
3. **Database Configuration**: Ensure your database server is running and update the connection string in the application settings to point to your local database instance.
4. **Build and Run**: Compile the project and press `F5` or click **Start** in Visual Studio to run the application.

## Authors
* [Bruno Vieira](https://github.com/brunovieira88)
* [Bernardo Santos](https://github.com/bernardo125)
