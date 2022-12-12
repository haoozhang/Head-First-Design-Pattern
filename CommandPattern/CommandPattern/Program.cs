
// Command Pattern

using CommandPattern.Command;
using CommandPattern.Command.DoorCommand;
using CommandPattern.Command.FanCommand;
using CommandPattern.Command.LightCommand;
using CommandPattern.Command.MacroCommand;

namespace CommandPattern
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light light = new Light();
            LightOn lightOn = new LightOn(light);
            LightOff lightOff = new LightOff(light);

            Door door = new Door();
            DoorOn doorOn = new DoorOn(door);
            DoorOff doorOff = new DoorOff(door);

            Fan fan = new Fan();
            FanHigh fanHigh = new FanHigh(fan);
            FanMedium fanMedium = new FanMedium(fan);
            FanLow fanLow = new FanLow(fan);
            FanOff fanOff = new FanOff(fan);


            ICommand[] onCommands = new ICommand[] {lightOn, doorOff, fanHigh};
            MacroOn macroOn = new MacroOn(onCommands);
            ICommand[] offCommands = new ICommand[] {lightOff, doorOn, fanOff};
            MacroOff macroOff = new MacroOff(offCommands);
            
            // test 1
            
            remoteControl.OnCommands[0] = lightOn;
            remoteControl.OffCommands[0] = lightOff;
            remoteControl.OnCommands[1] = doorOn;
            remoteControl.OffCommands[1] = doorOff;
            
            Console.WriteLine(remoteControl.ToString());
            remoteControl.OnButtonPressed(0);
            remoteControl.OffButtonPressed(0);
            remoteControl.OnButtonPressed(1);
            remoteControl.OffButtonPressed(1);
            
            remoteControl.UndoButtonPressed();
            
            // test 2
            
            remoteControl.OnCommands[2] = fanLow;
            remoteControl.OffCommands[2] = fanOff;
            
            Console.WriteLine(remoteControl.ToString());
            remoteControl.OnButtonPressed(2);
            remoteControl.OffButtonPressed(2);
            
            remoteControl.UndoButtonPressed();
            
            // test 3
            remoteControl.OnCommands[3] = macroOn;
            remoteControl.OffCommands[3] = macroOff;
            
            Console.WriteLine(remoteControl.ToString());
            remoteControl.OnButtonPressed(3);
            remoteControl.OffButtonPressed(3);
            
            remoteControl.UndoButtonPressed();

        }
    }
}