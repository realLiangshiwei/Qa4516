namespace ModelA;

public static class ModelADbProperties
{
    public static string DbTablePrefix { get; set; } = "ModelA";

    public static string DbSchema { get; set; } = null;

    public const string ConnectionStringName = "ModelA";
}
