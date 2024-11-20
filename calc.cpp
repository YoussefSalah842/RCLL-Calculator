#include <iostream>
#include <cmath> // For additional functions like square root

using namespace std;

void showMenu() {
    cout << "\nSimple Calculator Menu\n";
    cout << "1. Add\n";
    cout << "2. Subtract\n";
    cout << "3. Multiply\n";
    cout << "4. Divide\n";
    cout << "5. Square Root\n";
    cout << "6. Exit\n";
    cout << "Enter your choice: ";
}

double add(double a, double b) {
    return a + b;
}

double subtract(double a, double b) {
    return a - b;
}

double multiply(double a, double b) {
    return a * b;
}

double divide(double a, double b) {
    if (b == 0) {
        cout << "Error! Division by zero is not allowed.\n";
        return 0;
    }
    return a / b;
}

double squareRoot(double a) {
    if (a < 0) {
        cout << "Error! Cannot calculate square root of a negative number.\n";
        return -1;
    }
    return sqrt(a);
}

int main() {
    double num1, num2;
    int choice;
    
    while (true) {
        showMenu();
        cin >> choice;

        switch (choice) {
            case 1:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                cout << "Result: " << add(num1, num2) << endl;
                break;
            case 2:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                cout << "Result: " << subtract(num1, num2) << endl;
                break;
            case 3:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                cout << "Result: " << multiply(num1, num2) << endl;
                break;
            case 4:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                cout << "Result: " << divide(num1, num2) << endl;
                break;
            case 5:
                cout << "Enter a number: ";
                cin >> num1;
                cout << "Square root: " << squareRoot(num1) << endl;
                break;
            case 6:
                cout << "Exiting calculator. Goodbye!" << endl;
                return 0;
            default:
                cout << "Invalid choice! Please select a valid option.\n";
        }
    }

    return 0;
}

