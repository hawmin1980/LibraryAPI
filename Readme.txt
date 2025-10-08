Library API
This API provides access to a library, supporting books, magazines, and audiobooks. It is organized into two main categories: Master Reference Data and Media Items.

API Overview
- Master Reference Data
Use the following endpoint to retrieve static reference data used across the system:

Code
GET /api/master
Returns master data such as:

Country
Employee Role
Language
Genre
Media Type
Borrow Status

- Media Items
These endpoints manage media content. All media types—books, magazines, and audiobooks—inherit from the MediaItem base class and are handled by the MediaController.

Books
GET /api/book/all – List all books
POST /api/book/add – Add a new book

Magazines
GET /api/magazine/all – List all magazines
POST /api/magazine/add – Add a new magazine

Audiobooks
GET /api/audiobook/all – List all audiobooks
POST /api/audiobook/add – Add a new audiobook

Borrow Records
Track borrowing activity using these endpoints:

GET /api/BorrowRecord/all – List all borrow records
POST /api/BorrowRecord/add – Add a new borrow record

Employee and Member Management
Manage users of the media library system:

Employees
GET /api/employee – List all employees
POST /api/employee/add – Add a new employee

Members
GET /api/member/all – List all members
POST /api/member/add – Add a new member

Database
This API uses Localdb as its database engine. To restore the database, use the provided backup file:

Code
DB Backup.zip

Notes
MediaItem: Base class for all media types.

MediaController: Shared controller logic for handling media-related endpoints.

Getting Started
To run the API locally:

Restore the database using DB Backup.zip.

Start the API project.
Access and test endpoints via the Swagger UI.
