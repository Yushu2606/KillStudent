string[] processNames = ["StudentMain", "ProcessProtect", "Multi", "Student", "Smonitor", "REDAgent", "checkrs", "rscheck"];
List<Process> processes = new();
foreach (string processName in processNames)
{
    foreach (Process process in Process.GetProcessesByName(processName))
    {
        process.Kill();
        processes.Add(process);
    }
}
foreach (Process process in processes)
{
    process.WaitForExit();
}
