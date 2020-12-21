using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OurCalculator.Models
{
    public class Calculator
    {
        public Calculator()
        {
            this.Result = 0;
        }
        public String SpaceObject { get; set; }

        public Double Weight { get; set; }
        public string Operator { get; set; }
        public Double Result { get; set; }

        public void CalculateResult()
        {
                switch (this.SpaceObject)
            {
                case "mercury":
                    this.Result = this.Weight * 0.38;
                       break;
                   case "venus":
                       this.Result = this.Weight * 0.91;
                        break;
                    case "earth":
                        this.Result = this.Weight;
                        break;
                    case "moon":
                        this.Result = (this.Weight / 9.81) * 1.622;
                        break;
                    case "mars":
                        this.Result = this.Weight * 0.38;
                        break;
                    case "jupiter":
                        this.Result = this.Weight * 2.640 - 10;
                        break;
                    case "saturn":
                        this.Result = this.Weight * 1.06;
                        break;
                    case "uranus":
                        this.Result = this.Weight * 0.917;
                        break;
                    case "neptune":
                        this.Result = this.Weight * 1.148;
                        break;
                    case "pluto":
                        this.Result = this.Weight * 0.16 / 2 - 1;
                        break;
                    default:
                        break;
                /*case "-":
                       this.Result = this.RightOperand - this.LeftOperand;
                       break;
                   case "*":
                       this.Result = this.RightOperand * this.LeftOperand;
                       break;
                   case "/":
                       this.Result = this.RightOperand / this.LeftOperand;
                       break;
                   default:
                       break;*/
               }
           
                /*switch (this.Operator)
                {
                    case "+":
                        this.Result = this.RightOperand + this.LeftOperand;
                        break;
                    case "-":
                        this.Result = this.RightOperand - this.LeftOperand;
                        break;
                    case "*":
                        this.Result = this.RightOperand * this.LeftOperand;
                        break;
                    case "/":
                        this.Result = this.RightOperand / this.LeftOperand;
                        break;
                    default:
                        break;
                }*/
            }
        }
    }

