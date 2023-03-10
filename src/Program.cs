string[] processNames = { "StudentMain", "ProcessProtect", "Multi", "Student" };
foreach (string processName in processNames)
{
    foreach (Process process in Process.GetProcessesByName(processName))
    {
        process.Kill();
        process.WaitForExit();
    }
}
