# MunicipalApp

**Version:** 1.0  
**Author:** Phaka Phuti Thabiso  
**Date:** 2025-09-08  

---

## Overview

MunicipalApp is a **Windows Forms C# application** designed for municipal residents to interact with local services.  

**Key Features:**  
- **Report Issues:** Submit complaints/issues with optional file attachments.  
- **Local Events:** Placeholder for upcoming municipal events.  
- **Service Status:** Placeholder for monitoring municipal service statuses.  
- **Progress Tracking:** Step-by-step guidance for submitting reports.  
- **Data Persistence:** Reports are saved in a CSV file and displayed within the app.  

---

## Project Structure

MunicipalApp (Solution)
├── MunicipalApp (Project)
│ ├── Properties
│ │ ├── AssemblyInfo.cs
│ │ ├── Resources.resx
│ │ └── Settings.settings
│ ├── References
│ ├── App.config
│ ├── Form1.cs
│ ├── Form1.Designer.cs
│ ├── Form1.resx
│ ├── Program.cs
│ ├── Report.cs
│ ├── ReportIssuesForm.cs
│ ├── ReportIssuesForm.Designer.cs
│ └── ReportIssuesForm.resx
├── MunicipalApp.sln
├── README.md
└── MunicipalApp_Readme.pdf


> **Notes:**  
> - `Form1` is the **Main Menu** form.  
> - `ReportIssuesForm` handles **report submission**.  
> - `Report.cs` contains the **data model** for reports.  

---

## Prerequisites

- **IDE:** Visual Studio 2019 or 2022  
- **.NET Framework:** 4.7.2 or higher  

---

## How to Compile and Run

1. Open **Visual Studio**.  
2. Click **File → Open → Project/Solution**.  
3. Select `MunicipalApp.sln` to open the solution.  
4. Build the project: **Build → Build Solution** (`Ctrl+Shift+B`).  
5. Run the application: **F5** or click **Start**.  
6. The **Main Menu** (`Form1`) will appear.  

---

## How to Use the System

### Main Menu
- **Report Issues:** Opens the report form.  
- **Local Events:** Displays “coming soon” message.  
- **Service Status:** Displays “coming soon” message.  

### Reporting an Issue
1. Click **Report Issues**.  
2. Fill in all fields:
   - **Report Name** (required)  
   - **Location** (required)  
   - **Category** (dropdown, required)  
   - **Description** (required)  
3. Optional: Attach an image/file via **Attach Media**.  
4. Follow the **progress bar and step indicator** to complete all steps.  
5. Click **Submit**:
   - Saves report to `Reports.csv`.  
   - Displays the report in the ListBox.  
6. Click **Back** to return to the Main Menu.  

---

## Data Storage

- Reports are saved in **Reports.csv** in the application directory.  
- Each record contains:
  - Report Name  
  - Location  
  - Category  
  - Description  
  - File attachment path  
  - Submission timestamp  

---

## Future Enhancements

- Fully implement **Local Events** and **Service Status** features.  
- Integrate a **database** for persistent storage.  
- Add **user authentication** for residents and staff.  
- Improve **UI/UX design**.  
- Enable **exporting reports** to PDF or Excel.  

---
---
---

 
