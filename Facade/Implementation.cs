namespace Facade
{
    using System;

    // The Facade class
    class Computer
    {
        private CPU cpu;
        private Memory memory;
        private HardDrive hardDrive;

        public Computer()
        {
            cpu = new CPU();
            memory = new Memory();
            hardDrive = new HardDrive();
        }

        public void Start()
        {
            cpu.Freeze();
            memory.Load(BOOT_ADDRESS, hardDrive.Read(BOOT_SECTOR, SECTOR_SIZE));
            cpu.Jump(BOOT_ADDRESS);
            cpu.Execute();
        }

        private const long BOOT_ADDRESS = 0x00000000;
        private const long BOOT_SECTOR = 0x00000000;
        private const int SECTOR_SIZE = 512;
    }

    // The Subsystem classes
    class CPU
    {
        public void Freeze() { Console.WriteLine("CPU is frozen."); }
        public void Jump(long position) { Console.WriteLine("CPU jumped to position: " + position); }
        public void Execute() { Console.WriteLine("CPU is executing."); }
    }

    class Memory
    {
        public void Load(long position, byte[] data) { Console.WriteLine("Data loaded into memory at position: " + position); }
    }

    class HardDrive
    {
        public byte[] Read(long lba, int size) { Console.WriteLine("Data read from hard drive at LBA: " + lba); return new byte[size]; }
    }

}
