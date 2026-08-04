# 🚑 Disaster Relief Dispatch System

A console-based emergency dispatch engine built with **C#** and **.NET 8**. The system models dynamic priority scoring for emergency shelters, vehicle terrain traversal using Object-Oriented Programming (OOP) principles, and local data persistence via JSON.

---

## 📌 Features

- **Dynamic Priority Engine:** Ranks emergency shelters automatically based on real-time casualty counts and remaining water reserve hours.
- **OOP Architecture:** 
  - **Polymorphism & Abstraction:** Vehicle types (`EmergencyDrone`, `SupplyTruck`) process payload capacities and terrain constraints (e.g., aerial flight vs. flooded roads) dynamically.
  - **Encapsulation:** Protects internal domain state while exposing clean accessors and priority formulas.
- **Data Persistence:** Serializes shelter updates to disk (`shelters.json`) using `System.Text.Json` so state persists across runs.
- **Interactive CLI:** Provides a menu loop for users to view priority dispatch lists, enter new shelter data, and trigger updates.

---

## 🛠 Tech Stack

- **Language:** C#
- **Framework:** .NET 8.0 SDK
- **Data Format:** JSON (`System.Text.Json`)
- **IDE/Tools:** Visual Studio Code, Git

---

## 🚀 Getting Started

### Prerequisites
Make sure you have the [.NET 8 SDK](https://dotnet.microsoft.com/download) installed on your system.

### Installation & Execution

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/ArsalKhan-123/DisasterReliefSystem.git](https://github.com/ArsalKhan-123/DisasterReliefSystem.git)