# Windows 10 Calculator Clone

This repository contains a multi-file WPF calculator app designed to mimic the look and feel of the Windows 10 Calculator.

## Features
- Modern Windows 10-inspired layout
- Responsive calculator UI
- Arithmetic operations: add, subtract, multiply, divide
- Decimal support
- Clear entry and clear all
- Backspace support
- Percentage calculation
- Sign toggle
- Keyboard support (optional, if you extend it)

## Run
1. Open `CalculatorApp.sln` in Visual Studio 2022.
2. Restore NuGet packages.
3. Set `CalculatorApp` as the startup project.
4. Press `F5` to run.

## Project structure
- `CalculatorApp/CalculatorApp.csproj` - project definition
- `CalculatorApp/App.xaml` - app startup
- `CalculatorApp/App.xaml.cs` - app entry point
- `CalculatorApp/MainWindow.xaml` - UI layout
- `CalculatorApp/MainWindow.xaml.cs` - calculator logic
- `CalculatorApp/CalculatorEngine.cs` - calculation helpers

## Notes
This is a desktop WPF application and is intended for Windows environments.
