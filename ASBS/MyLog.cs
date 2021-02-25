using System.IO;

static class MyLog
{
    public static void Log(string str)
        => File.AppendAllText("log.txt", "\n" + str);
}

