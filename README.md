# ScientificSharp
The code is a Windows Forms application for a basic scientific calculator, allowing users to perform mathematical operations like addition, subtraction, multiplication, division, trigonometrics, and logarithms.

[![Static Badge](https://img.shields.io/badge/System;-red)](https://www.nuget.org/packages/System;/)
[![Static Badge](https://img.shields.io/badge/System.Collections.Generic;-yellow)](https://www.nuget.org/packages/System.Collections.Generic;/)
[![Static Badge](https://img.shields.io/badge/System.ComponentModel;-green)](https://www.nuget.org/packages/System.ComponentModel;/)
[![Static Badge](https://img.shields.io/badge/System.Data;-orange)](https://www.nuget.org/packages/System.Data;/)
[![Static Badge](https://img.shields.io/badge/System.Drawing;-yellow)](https://www.nuget.org/packages/System.Drawing;/)
[![Static Badge](https://img.shields.io/badge/System.Linq;-red)](https://www.nuget.org/packages/System.Linq;/)
[![Static Badge](https://img.shields.io/badge/System.Security.Cryptography;-orange)](https://www.nuget.org/packages/System.Security.Cryptography;/)
[![Static Badge](https://img.shields.io/badge/System.Text;-yellow)](https://www.nuget.org/packages/System.Text;/)
[![Static Badge](https://img.shields.io/badge/System.Threading.Tasks;-red)](https://www.nuget.org/packages/System.Threading.Tasks;/)
[![Static Badge](https://img.shields.io/badge/System.Windows.Forms;-brown)](https://www.nuget.org/packages/System.Windows.Forms;/)
[![Static Badge](https://img.shields.io/badge/System.Windows.Forms.VisualStyles.VisualStyleElement;-pink)](https://www.nuget.org/packages/System.Windows.Forms.VisualStyles.VisualStyleElement;/)

## Table of Contents

- [About](#about)
- [Features](#features)
- [Imports](#Imports)
- [Rating: 5/10](#Rating)

# About

The code is a Windows Forms application that functions as a basic scientific calculator, allowing users to perform mathematical operations like addition, subtraction, multiplication, division, trigonometric, and logarithmic functions. The interface features buttons for entering numerical digits and a text box for input and output.

# Features

The Windows Forms scientific calculator application offers a range of features to simplify mathematical computations. It allows users to perform basic arithmetic operations such as addition, subtraction, multiplication, and division. The calculator also includes trigonometric functions such as sine, cosine, and tangent. Logarithmic functions include natural logarithm (ln) and common logarithm (log). The user-friendly interface is built using Windows Forms, allowing users to input numerical digits using buttons and display output in a text box. Overall, the calculator simplifies mathematical computations and provides essential functions for users.

# Imports

System, System.Collections.Generic, System.ComponentModel, System.Data, System.Drawing, System.Linq, System.Security.Cryptography, System.Text, System.Threading.Tasks; System.Windows.Forms

# Rating

The calculator offers basic arithmetic operations and some scientific functions, including division by zero and mathematical errors for large numbers. It has a simple user interface with buttons for digits, arithmetic operations, and scientific functions. However, it lacks visual aesthetics and design elements that could improve user experience.
The code structure is structured into event handlers for button clicks and helper methods for performing calculations. However, the logic for handling arithmetic operations could be simplified and made more readable by refactoring repetitive code segments. Variable names like `first_number`, `second_number`, and `oper` are descriptive and intuitive, but some variables could have more descriptive names, such as `plus_min`.
Error handling is lacking for scenarios like division by zero or invalid input, and adding error checks and user feedback would enhance the calculator's robustness and user experience. Code readability could benefit from more comments explaining the purpose of methods and complex logic, and some parts of the code could be refactored to improve readability and reduce redundancy.
The calculator performs calculations efficiently, but there are opportunities to optimize repetitive operations and improve overall performance, especially for complex scientific functions. Overall, with refinements, the calculator could become a more robust and user-friendly application.
