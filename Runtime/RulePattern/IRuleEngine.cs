
namespace RealbizGames.RulePattern
{
    public interface IRuleEngine<T, E>
    {
        void AddRule(IRule<T, E> rule);

        T Execute(E expression);
    }
}