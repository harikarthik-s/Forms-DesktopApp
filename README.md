# Forms Desktop App

## Overview

This repository contains the code for the Forms Desktop Application built using Visual Basic in Visual Studio. The application provides functionalities to create new form submissions and view existing submissions. It interacts with a backend server to save and retrieve data.

## Getting Started

Follow the instructions below to clone the repository, open it in Visual Studio, and run the application.

## Prerequisites

Ensure you have the following installed on your system:

- Visual Studio (not Visual Studio Code)
- .NET Framework

## Installation

1. **Clone the repository:**

   ```bash
   git clone https://github.com/harikarthik-s/Forms-DesktopApp.git
   ```

2. **Open the project in Visual Studio:**

   - Launch Visual Studio.
   - Open the solution file (`Forms-DesktopApp.sln`) from the cloned repository.

3. **Run the application:**

   - Build the solution.
   - Start the application by pressing `F5` or by selecting `Debug > Start Debugging`.

## Backend Server

Before starting the desktop app, ensure the backend server is running. Follow the instructions in the [backend server repository](https://github.com/harikarthik-s/Forms-DesktopApp-Backend) to set up and run the server.

https://github.com/harikarthik-s/Forms-DesktopApp/assets/147190571/1babd596-5f29-4075-ad23-0f4d46da466c

## Application Structure

### Main Form

The main form has two buttons: 

- **"View Submissions"**: Opens the View Submissions form.
- **"Create New Submission"**: Opens the Create New Submission form.

### View Submissions Form

- **Description**: Displays saved form submissions.
- **Buttons**:
  - **Previous**: Navigates to the previous submission.
  - **Next**: Navigates to the next submission.
- **Default Behavior**: Shows the first submitted form entry.

### Create New Submission Form

- **Description**: Allows users to create a new submission.
- **Fields**:
  - Name
  - Email
  - Phone Number
  - GitHub Repo Link
- **Stopwatch**: A button to resume and pause the stopwatch. The stopwatch does not reset on pause.
- **Submit Button**: Submits the form details to the backend.

Happy coding!
