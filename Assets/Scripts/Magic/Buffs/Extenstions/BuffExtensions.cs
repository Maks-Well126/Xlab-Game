public static class BuffExtensions
{
    public static void Refresh(this IBuff buff, BuffContainer buffConteiner)
    {
        buff.Deinitialize();
        buff.Initialize(buffConteiner);
    }
}
