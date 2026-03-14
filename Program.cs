using TP_MODUL4_103022400044;

KodePos kodePos = new KodePos();

Console.WriteLine("=== TABLE DRIVEN: KODE POS ===");
Console.WriteLine("Batununggal -> " + kodePos.getKodePos("Batununggal"));
Console.WriteLine("Kujangsari -> " + kodePos.getKodePos("Kujangsari"));
Console.WriteLine("Mengger -> " + kodePos.getKodePos("Mengger"));
Console.WriteLine("Wates -> " + kodePos.getKodePos("Wates"));
Console.WriteLine("Cijaura -> " + kodePos.getKodePos("Cijaura"));
Console.WriteLine("Jatisari -> " + kodePos.getKodePos("Jatisari"));
Console.WriteLine("Margasari -> " + kodePos.getKodePos("Margasari"));
Console.WriteLine("Sekejati -> " + kodePos.getKodePos("Sekejati"));
Console.WriteLine("Kebonwaru -> " + kodePos.getKodePos("Kebonwaru"));
Console.WriteLine("Maleer -> " + kodePos.getKodePos("Maleer"));

Console.WriteLine();
Console.WriteLine("=== STATE BASED CONSTRUCTION: DOOR MACHINE ===");

DoorMachine door = new DoorMachine();
door.BukaPintu();
door.KunciPintu();