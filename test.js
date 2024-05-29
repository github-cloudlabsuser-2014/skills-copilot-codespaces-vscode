class Calculator {
    add(a, b) {
        return a + b;
    }

    subtract(a, b) {
        return a - b;
    }

    multiply(a, b) {
        return a * b;
    }

    divide(a, b) {
        if (b === 0) {
            throw new Error("Cannot divide by zero");
        }
        return a / b;
    }
}

// Usage
const calculator = new Calculator();
console.log("Addition: " + calculator.add(5, 3));       // Outputs: Addition: 8
console.log("Subtraction: " + calculator.subtract(5, 3)); // Outputs: Subtraction: 2
console.log("Multiplication: " + calculator.multiply(5, 3)); // Outputs: Multiplication: 15
console.log("Division: " + calculator.divide(6, 3));     // Outputs: Division: 2