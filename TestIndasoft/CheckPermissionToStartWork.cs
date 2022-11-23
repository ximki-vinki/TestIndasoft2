namespace TestIndasoft;

/// <summary>
///     Проверка на возможность проведения начала анализа
/// </summary>
internal class CheckPermissionToWork
{
    private static bool AllCheckPermissions => All();

    private static bool All()
    {
        return Data() && MicroClimat() && IsPickGrad();
    }

    private static bool Data()
    {
        return true;
    }

    private static bool MicroClimat()
    {
        return true;
    }

    private static bool IsPickGrad()
    {
        return true;
    }

    public static void GetAll()
    {
        if (AllCheckPermissions) Print.InMessage("дается разрешение на анализ");
    }
}