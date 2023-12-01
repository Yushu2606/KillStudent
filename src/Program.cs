string[] processNames = ["StudentMain", "ProcessProtect", "Multi", "Student", "Smonitor", "REDAgent", "checkrs", "rscheck"];
foreach (string processName in processNames)
{
    foreach (Process process in Process.GetProcessesByName(processName))
    {
        process.Kill();
        process.WaitForExit();
    }
}
