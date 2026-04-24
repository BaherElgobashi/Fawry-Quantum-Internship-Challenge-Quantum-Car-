# 🚗 Quantum Car – Fawry N² Internship Challenge

A C# object-oriented solution for the **Quantum Car Factory** problem.
This project demonstrates solid understanding of core OOP principles and design patterns using a simple but practical scenario.

---

## 📌 Overview

The system simulates a car factory that supports multiple engine types:

* Gas Engine
* Electric Engine
* Hybrid Engine (combines Gas + Electric)

Each car supports basic operations:

* Start
* Stop
* Accelerate (+20 km/h, max 200)
* Brake (-20 km/h, min 0)

The **Hybrid engine** automatically switches:

* 🔋 Electric mode → below 50 km/h
* ⛽ Gas mode → 50 km/h and above

---

## 🏗️ Project Structure

```
QuantumCar/
│
├── Engines/
│   ├── Engine.cs           # Abstract base class
│   ├── GasEngine.cs        # Gas engine implementation
│   ├── ElectricEngine.cs   # Electric engine implementation
│   └── HybridEngine.cs     # Hybrid engine (composition)
│
├── Car.cs                  # Car behavior and operations
├── CarFactory.cs           # Factory for creating/replacing engines
├── Program.cs              # Entry point and test scenarios
```

---

## 🧠 Concepts & Design

This project focuses on applying clean architecture and OOP fundamentals:

* **Abstraction**
  `Engine` defines a common contract for all engine types.

* **Inheritance**
  Gas, Electric, and Hybrid engines extend the base engine.

* **Composition**
  Hybrid engine internally uses both Gas and Electric engines.

* **Polymorphism**
  The `Car` interacts with engines through a common interface/abstraction.

* **Factory Pattern**
  `CarFactory` centralizes object creation and engine replacement logic.

---

## ⚙️ How to Run

1. Clone the repository:

```bash
git clone https://github.com/YOUR_USERNAME/Quantum-Car-OOP.git
```

2. Open the solution in Visual Studio

3. Run the project:

* Press **F5** or click **Run**

---

## 🧪 Test Scenarios

The project includes several test cases:

* ✅ Gas car: full lifecycle (start → accelerate → brake → stop)
* ✅ Electric car: prevents stopping while still moving
* ✅ Hybrid car: automatically switches engine at 50 km/h
* ✅ Engine replacement: dynamically swapping engines at runtime

---

## 💡 Notes

* The project is intentionally simple to focus on **design quality over complexity**
* Code is structured to be easily extendable (e.g., adding new engine types)

---

## 👨‍💻 Author

**Baher Elgobashi**
Backend Developer (.NET) | Problem Solver | Passionate about clean code
