
namespace RealbizGames.RulePattern
{
    public interface IRule<T, E>
    {
        bool Valuate(E expression);

        T Execute(E expression);
    }

}
