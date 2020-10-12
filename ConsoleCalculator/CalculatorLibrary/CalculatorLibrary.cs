using System;
using System.Diagnostics;
using System.IO;
using Newtonsoft.Json;

namespace CalculatorLibrary
{
    public class Calculator
    {
        private String messageDivideByZero = "";
        private static JsonWriter writer;
        public Calculator()
        {
            /*
            StreamWriter logFile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting Calculator Log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));
            */
            StreamWriter logFile = File.CreateText("calculator.json");

            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);

            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }
        public string getMessageDivideByZero()
        {
            return messageDivideByZero;
        }

        public void setMessageDivideByZero(string messageDivideByZero)
        {
            this.messageDivideByZero = messageDivideByZero;
        }

        public double DoOperation(double number1, double number2, string operation)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("Operand1");
            writer.WriteValue(number1);
            writer.WritePropertyName("Operand2");
            writer.WriteValue(number2);
            writer.WritePropertyName("Operation");
            double result = 0.0;
            setMessageDivideByZero("");
            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    //Trace.WriteLine(String.Format("{0} + {1} = {2}", number1, number2, result));
                    writer.WriteValue("Add");
                    break;
                case "-":
                    result = number1 - number2;
                    //Trace.WriteLine(String.Format("{0} - {1} = {2}", number1, number2, result));
                    writer.WriteValue("Subtract");
                    break;
                case "*":
                    result = number1 * number2;
                    //Trace.WriteLine(String.Format("{0} * {1} = {2}", number1, number2, result));
                    writer.WriteValue("Multiply");

                    break;
                case "/":
                    writer.WriteValue("Divide");
                    if (number2 == 0)
                    {
                        setMessageDivideByZero("Divide By Zero Impossible!");
                        //Trace.WriteLine("Divide By Zero Impossible!");
                    }
                    else
                    {
                        result = number1 / number2;
                        //Trace.WriteLine(String.Format("{0} / {1} = {2}", number1, number2, result));
                    }
                    break;
                case "%":
                    result = number1 % number2;
                    writer.WriteValue("Modulo");
                    //Trace.WriteLine(String.Format("{0} % {1} = {2}", number1, number2, result));
                    break;
                default:
                    break;

            }
            writer.WritePropertyName("Result");
            if (!getMessageDivideByZero().Trim().Equals(""))
            {
                writer.WriteValue("Divide By Zero Impossible!");
            }
            else
            {
                writer.WriteValue(result);

            }
            writer.WriteEndObject();
            return result;
        }

        public void Finish()
        {
            writer.WriteEndArray();
            writer.WriteEndObject();
            writer.Close();
        }
    }
}
