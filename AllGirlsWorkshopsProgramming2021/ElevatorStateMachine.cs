//using System;
//using System.Threading;
//using CTRE.Phoenix;
//using CTRE.Phoenix.Controller;
//using CTRE.Phoenix.MotorControl;
//using CTRE.Phoenix.MotorControl.CAN;
//using Microsoft.SPOT;
//using Microsoft.SPOT.Hardware;

//namespace ElevatorStateMachine
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            //Create Gamepad Object
//            GameController gamepad = new GameController(UsbHostDevice.GetInstance(0));
//            //Create motor object and configure
//            TalonSRX elevatorTalon = new TalonSRX(0);
//            elevatorTalon.ConfigFactoryDefault();
//            //Make variables

//            /*loop forever*/
//            while (true)
//            { 
//                float xAxis = gamepad.GetAxis(0);
//                if (xAxis > 0.75)
//                {
//                    elevatorTalon.Set(ControlMode.PercentOutput, 0.25);
//                }
//                else if (xAxis < -0.75)
//                {
//                    elevatorTalon.Set(ControlMode.PercentOutput, -0.25);
//                }
//                else
//                {
//                    elevatorTalon.Set(ControlMode.PercentOutput, 0.0);
//                }

//                System.Threading.Thread.Sleep(20);
//                CTRE.Phoenix.Watchdog.Feed();
//            }
//        }
//    }
//}