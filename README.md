# Form Submission Management Application

This application allows users to manage form submissions through a Windows Forms interface. Users can create new submissions, view existing submissions, and delete submissions. The application communicates with a backend server to store and retrieve data.

## Table of Contents

- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
- [API Integration](#api-integration)
- [Usage](#usage)
  - [Creating a Submission](#creating-a-submission)
  - [Viewing Submissions](#viewing-submissions)
- [Images](#images)
  - [How to Start](#how-to-start)
  - [Main Interface](#main-interface)
  - [View Submissions Page](#view-submissions-page)
  - [Create Submission Page](#create-submission-page)

## Features

- **Create Submission**: Users can fill out a form with Name, Email, Phone, GithubLink, and StopwatchTime to create a new submission.
- **View Submissions**: Users can view existing submissions with navigation controls (Previous, Next).
- **Delete Submission**: Users can Delete existing submissions with Button and (Ctrl + D).
- **Keyboard Shortcuts**: Supports keyboard shortcuts for quick actions (Ctrl + N for New Submission, Ctrl + V for View Submissions, etc.).

## Getting Started

Follow these instructions to set up and run the application on your local machine.

### Prerequisites

- Visual Studio with Visual Basic installed

### Installation

1. **Clone the repository:**

    ```bash
    git clone https://github.com/ashishpatil3101/desktop-VB-App-slidely
    cd <repository-directory>
    ```

2. **Open the project in Visual Studio:**

    Open `WinFormsApp1.vbproj` or `WinFormsApp1.sln` or the corresponding project file in Visual Studio.

3. **Run the application:**

    Press `F5` or click on the "Start" button in Visual Studio to run the application.

## API Integration

The application interacts with a backend API hosted at `http://localhost:3000`. Ensure the API is running and accessible for full functionality.

## Usage

### Creating a Submission

1. **Launch the application**.
2. Click on the "Create Submission" button or press `Ctrl + N`.
3. Fill out the form fields (Name, Email, Phone, GithubLink).
4. Start/Stop the stopwatch using the "Toggle Stopwatch" button or `Ctrl + T`.
5. Click "Save" to submit the form data to the backend server.

### Viewing Submissions

1. **Launch the application**.
2. Click on the "View Submissions" button or press `Ctrl + V`.
3. Navigate through submissions using the "Previous" and "Next" buttons or `Ctrl + P` and `Ctrl + N`.
4. Delete a submission by clicking the "Delete" button or pressing `Ctrl + D`.

## Images

### How to Start
![How to Start](https://github.com/ashishpatil3101/desktop-VB-App-slidely/assets/43375060/5c30675b-7141-42d0-8e47-95944259751f)

### Main Interface
![Main Interface](https://github.com/ashishpatil3101/desktop-VB-App-slidely/assets/43375060/c8159725-000c-4673-bed9-ab2265a78395)

### View Submissions Page
![View Submissions Page](https://github.com/ashishpatil3101/desktop-VB-App-slidely/assets/43375060/d76a2947-6d35-467c-a60a-bb815641b10f)

### Create Submission Page
![Create Submission Page](https://github.com/ashishpatil3101/desktop-VB-App-slidely/assets/43375060/419e796f-37ad-434c-9d61-3a10d1e4f14b)
