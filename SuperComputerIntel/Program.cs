using System;

namespace SuperComputerIntel
{
    class Program
    {
        static void Main(string[] args)
        {

            Monitor MSImonitor = new Monitor("1280x720", true, 32);
            Printer DELLPrinter = new Printer("HP", "MP102", 50);
            Vga nvdiaVga = new Vga("Nvidia rtx ", 2070, 2080);
            Ram samsungRam = new Ram("DDR4", 4000, 8000);
            Processor intelProcessor = new Processor();
            intelProcessor.setCache(2000);
            intelProcessor.setCore(12);
            intelProcessor.setSeries("CORE i9 9th Gen");

            Computer computer = new Computer.Builder(samsungRam, nvdiaVga, intelProcessor)
                .withMonitor(MSImonitor).withPrinter(DELLPrinter).build();

            Console.WriteLine(computer.ToString());
        }
    }
}