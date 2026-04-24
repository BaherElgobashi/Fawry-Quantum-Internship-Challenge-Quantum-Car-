🚗 Quantum Car – Fawry N² Internship Challenge
A C# object-oriented solution for the Quantum Car Factory design problem, demonstrating core OOP principles including inheritance, composition, and the Factory Pattern.

📋 Problem Overview
Design a car factory system that supports three engine types:

Gas Engine
Electric Engine
Hybrid Engine (Gas + Electric combined)
Each car supports Start, Stop, Accelerate (+20 km/h, max 200), and Brake (-20 km/h).
The Hybrid engine automatically switches to Electric below 50 km/h, and Gas at 50+.

🏗️ Project Structure
QuantumCar/
├── Engines/
│   ├── Engine.cs           # Abstract base class
│   ├── GasEngine.cs        # Gas engine implementation
│   ├── ElectricEngine.cs   # Electric engine implementation
│   └── HybridEngine.cs     # Hybrid (composition of Gas + Electric)
├── Car.cs                  # Car class with 4 operations
├── CarFactory.cs           # Factory: create cars & replace engines
└── Program.cs              # Main demo & test cases
🧠 Design Patterns & OOP Concepts
Concept	Where Applied
Abstract Class	Engine – enforces UpdateSpeed() contract
Inheritance	Gas, Electric, Hybrid all extend Engine
Composition	HybridEngine contains Gas + Electric engines
Polymorphism	Car holds an Engine reference, works with any type
Factory Pattern	CarFactory handles creation and engine replacement
⚙️ How to Run
Clone the repository:
   git clone https://github.com/YOUR_USERNAME/Quantum-Car-OOP.git
Open QuantumCar.sln in Visual Studio
Press F5 or click Run
🧪 Test Cases Covered
✅ Gas car: full start → accelerate → brake → stop cycle
✅ Electric car: attempt stop while moving (rejected correctly)
✅ Hybrid car: engine switches at the 50 km/h threshold
✅ Engine replacement: hot-swap engine on an existing car
