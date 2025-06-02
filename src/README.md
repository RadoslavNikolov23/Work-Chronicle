# 📅 Work Chronicle App – Code Preview

This repository contains **partial source code** for my .NET MAUI app **Work Chronicle**, designed to help users manage and track work shifts efficiently.

---

## 🎓 Purpose

The uploaded code is shared **strictly for educational and demonstration purposes**. It provides a general overview of the app’s architecture, structure, and project layering.

If you're interested in:

- Exploring the full codebase  
- Contributing to the project  
- Asking questions or offering feedback  

Please contact me via **GitHub messages** or at **[custom_rd@abv.bg]**.

---

## 📂 Project Structure Included

The repository includes the following projects:

### 🟦 Main App Project
- Entry point of the .NET MAUI application.
- Contains the Views and ViewModels.
- Handles user interaction and delegates to the Services layer.

### 📦 Common Class Library
- Shared components used across the entire app.
- Includes:
  - Enums
  - Static helpers
  - Constants and utilities


### 🔌 Services Library
- **Bridges the ViewModel layer with the Structure (Core Logic) and Data (Database) layers.**
- Responsibilities:
  - Calls methods from the **Structure Library** for shift and schedule logic.
  - Interacts with the **Data Library** to load/save data.
  - Exposes high-level functions tailored for the UI.
  - Centralizes application workflows (e.g., creating and saving a schedule).

### ⚙️ Structure Library (Core Logic)
- Core business logic layer.
- Handles:
  - Shift pattern management
  - Schedule generation algorithms
  - Business rules and validations

### 🗄️ Data Library
- Manages data persistence using **SQLite.NET PCL**.
- Includes:
  - Database access logic
  - Data models and table mappings
  - Partial repository implementations

### 🎛️ MAUI Controls Library
- Reusable UI components for the application.
- Includes:
  - Custom calendar views
  - Popups and dialogs
  - Toolkit-based components to enhance UI/UX

### ✅ Unit Test Project
- Covers testing for:
  - Business logic (Structure)
  - Data layer (SQLite operations)
  - Service workflows (end-to-end logic)

---

## ⚠️ Code Limitations & Protection

To protect the app’s proprietary content and logic, **significant parts of the implementation have been removed**, including:

- `Platforms` folder and all platform-specific files
- Application assets: images, icons, splash screens
- Portions of logic from ViewModels and Views
- Core functionality in `Structure` logic classes
- Key models and repository logic from the database layer
- Most main logic in the unit test classes

This repository is intended only as a **preview of the architecture** and **coding style** used in the app.

---

## 📬 Contact

To view the complete codebase or discuss collaboration, please contact me via:

- GitHub: [[RadoslavNikolov23](https://github.com/RadoslavNikolov23)]  
- Email: **[custom_rd@abv.bg]**

---

## 📄 License

This code is provided **for study purposes only**. Redistribution, reproduction, or commercial use of any part of this code or app is not permitted without prior written consent.  
Please see `CUSTOM_LICENSE.txt` from the previous folder for more details.
