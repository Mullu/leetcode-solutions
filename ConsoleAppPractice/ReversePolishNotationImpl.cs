using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class ReversePolishNotationImpl
    {

        // Change these Boolean values to control whether you see 
        // the expected result and/or hints.
        public static Boolean ShowExpectedResult = false;
        public static Boolean ShowHints = false;

        public static bool IsNumber(string token)
        {
            try
            {
                double.Parse(token);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        public static bool IsOperator(string token)
        {
            return "+-*/".Contains(token);
        }

        public static double PerformOperation(string @operator, double operand1, double operand2)
        {
            switch (@operator)
            {
                case "+":
                    return operand1 + operand2;
                case "-":
                    return operand1 - operand2;
                case "*":
                    return operand1 * operand2;
                case "/":
                    if (operand2 == 0)
                    {
                        throw new DivideByZeroException("Division by zero is not allowed.");
                    }
                    return operand1 / operand2;
                default:
                    throw new ArgumentException("Invalid operator: " + @operator);
            }
        }

        public static double EvaluateRPN(string expression)
        {
            Stack<double> result = new Stack<double>();
            double operationResult = 0.0;

            if (string.IsNullOrWhiteSpace(expression))
                throw new ArgumentException("Expression cannot be empty.");

            var tokens = expression.Split(' ');

            foreach (var token in tokens)
            {
                if (IsNumber(token))
                {
                    result.Push(double.Parse(token));
                }
                else if (IsOperator(token))
                {
                    if (result.Count < 2)
                    {
                        throw new ArgumentException("Not enough operands for operation.");
                    }

                    double operand2 = result.Pop();
                    double operand1 = result.Pop();

                    operationResult = PerformOperation(token, operand1, operand2);

    
                    result.Push(operationResult);
                }
                else
                {
                    throw new ArgumentException("Invalid token: " + token);
                }
            }

            if (result.Count != 1)
            {
                throw new ArgumentException("Invalid RPN expression.");
            }

            return result.Pop();
        }
    }
}