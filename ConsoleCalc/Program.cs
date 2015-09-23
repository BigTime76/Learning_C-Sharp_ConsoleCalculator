using System;
using System . Collections . Generic;
using System . Linq;
using System . Text;
using System . Threading . Tasks;

namespace ConsoleCalc
    {
    internal class Program
        {
        private static void Main ( string [ ] args )
            {
            // Values for calulation
            double firstDouble = GetValue( "Enter First Value: " );
            double secondDouble = GetValue( "Enter Second Value: " );

            // Value for result
            double resultDouble = 0;

            // Math operation
            while ( true )
                {
                Console . Write ( "(A)dd (S)ubtract (M)ultiply (D)ivide: " ); // Add more advanced options

                ConsoleKeyInfo info = Console.ReadKey();
                string operation = info.Key.ToString();

                switch ( operation . ToUpper ( ) )
                    {
                    case "A":
                        resultDouble = Add ( firstDouble , secondDouble );
                        break;

                    case "S":
                        resultDouble = Subtract ( firstDouble , secondDouble );
                        break;

                    case "M":
                        resultDouble = Multiply ( firstDouble , secondDouble );
                        break;

                    case "D":
                        resultDouble = Divide ( firstDouble , secondDouble );
                        break;

                    default:
                        Console . WriteLine ( "Pick from the supported operations only: " );
                        continue;
                    }
                Console . WriteLine ( "\nYour Result: " + resultDouble );
                Console . Read ( );
                break;
                }
            }

        private static double GetValue ( string label )
            {
            // value to be returned
            double value;

            // loop till valid
            while ( true )
                {
                Console . Write ( label );
                string input = Console.ReadLine();
                if ( Double . TryParse ( input , out value ) )
                    {
                    return value;
                    }
                else
                    {
                    Console . WriteLine ( "Value can't be parsed as a number" );
                    }
                }
            }

        private static double Add ( double firstDouble , double secondDouble )
            {
            return firstDouble + secondDouble;
            }

        private static double Subtract ( double firstDouble , double secondDouble )
            {
            return firstDouble - secondDouble;
            }

        private static double Multiply ( double firstDouble , double secondDouble )
            {
            return firstDouble * secondDouble;
            }

        private static double Divide ( double firstDouble , double secondDouble )
            {
            // Check for divide by zero error ...
            if ( firstDouble == 0 || secondDouble == 0 )
                {
                Console . WriteLine ( "11th Commandment: Thou shalt not divide by zero!" );
                return 0;
                }
            else
                {
                return firstDouble / secondDouble;
                }
            }
        }
    }