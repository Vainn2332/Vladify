namespace Vladify.Config;

public static class EnvLoader
{
    public static void LoadEnvVariables()
    {
        DotNetEnv.Env.Load();
    }
}
