#include <iostream>
#include <cmath>
#include <vector>
#include <sstream> // For string conversion

using namespace std;

// Function to display the menu
void showMenu() {
    cout << "\n--- Enhanced Calculator Menu ---\n";
    cout << "1. Add\n";
    cout << "2. Subtract\n";
    cout << "3. Multiply\n";
    cout << "4. Divide\n";
    cout << "5. Square Root\n";
    cout << "6. Power (a^b)\n";
    cout << "7. Modulo\n";
    cout << "8. View History\n";
    cout << "9. Clear Screen\n";
    cout << "10. Exit\n";
    cout << "Enter your choice: ";
}

// Function to convert double to string (replacing std::to_string)
string doubleToString(double value) {
    stringstream ss;
    ss << value;
    return ss.str();
}

// Function to display calculation history
void displayHistory(const vector<string>& history) {
    if (history.empty()) {
        cout << "No calculations performed yet.\n";
    } else {
        cout << "\n--- Calculation History ---\n";
        for (size_t i = 0; i < history.size(); ++i) {
            cout << history[i] << endl;
        }
    }
}

// Other functions remain unchanged
double add(double a, double b) { return a + b; }
double subtract(double a, double b) { return a - b; }
double multiply(double a, double b) { return a * b; }
double divide(double a, double b) { return b != 0 ? a / b : NAN; }
double squareRoot(double a) { return a >= 0 ? sqrt(a) : NAN; }
double power(double base, double exp) { return pow(base, exp); }
int modulo(int a, int b) { return b != 0 ? a % b : 0; }

void updateHistory(vector<string>& history, const string& operation) {
    if (history.size() >= 5) {
        history.erase(history.begin()); // Remove oldest entry if history is full
    }
    history.push_back(operation);
}

int main() {
    double num1, num2, result;
    int choice;
    vector<string> history;

    while (true) {
        showMenu();
        cin >> choice;

        switch (choice) {
            case 1:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                result = add(num1, num2);
                cout << "Result: " << result << endl;
                updateHistory(history, "Add: " + doubleToString(num1) + " + " + doubleToString(num2) + " = " + doubleToString(result));
                break;
            case 2:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                result = subtract(num1, num2);
                cout << "Result: " << result << endl;
                updateHistory(history, "Subtract: " + doubleToString(num1) + " - " + doubleToString(num2) + " = " + doubleToString(result));
                break;
            case 3:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                result = multiply(num1, num2);
                cout << "Result: " << result << endl;
                updateHistory(history, "Multiply: " + doubleToString(num1) + " * " + doubleToString(num2) + " = " + doubleToString(result));
                break;
            case 4:
                cout << "Enter two numbers: ";
                cin >> num1 >> num2;
                result = divide(num1, num2);
                if (!isnan(result)) {
                    cout << "Result: " << result << endl;
                    updateHistory(history, "Divide: " + doubleToString(num1) + " / " + doubleToString(num2) + " = " + doubleToString(result));
                }
                break;
            case 5:
                cout << "Enter a number: ";
                cin >> num1;
                result = squareRoot(num1);
                if (!isnan(result)) {
                    cout << "Square Root: " << result << endl;
                    updateHistory(history, "Square Root: sqrt(" + doubleToString(num1) + ") = " + doubleToString(result));
                }
                break;
            case 6:
                cout << "Enter base and exponent: ";
                cin >> num1 >> num2;
                result = power(num1, num2);
                cout << "Result: " << result << endl;
                updateHistory(history, "Power: " + doubleToString(num1) + "^" + doubleToString(num2) + " = " + doubleToString(result));
                break;
            case 7:
                int intNum1, intNum2;
                cout << "Enter two integers: ";
                cin >> intNum1 >> intNum2;
                result = modulo(intNum1, intNum2);
                cout << "Result: " << result << endl;
                updateHistory(history, "Modulo: " + doubleToString(intNum1) + " % " + doubleToString(intNum2) + " = " + doubleToString(result));
                break;
            case 8:
                displayHistory(history);
                break;
            case 9:
                system("cls"); // Clear screen (works on Windows)
                break;
            case 10:
                cout << "Exiting calculator. Goodbye!\n";
                return 0;
            default:
                cout << "Invalid choice! Please select a valid option.\n";
        }
    }

    return 0;
}
