class Program {
    static void Main() {
        byte count = 0;
        string[] processNames = new[] { "StudentMain", "ProcessProtect", "Multi", "Student" };
        foreach (string processName in processNames)
            foreach (System.Diagnostics.Process process in System.Diagnostics.Process.GetProcessesByName(processName)) {
                process.Kill();
                process.WaitForExit();
                System.Console.WriteLine($"Process {process.ProcessName} killed", count++);
            }
        System.Console.WriteLine($"Done! {count} process(es) killed");
        System.Threading.Thread.Sleep(1000);
    }
}