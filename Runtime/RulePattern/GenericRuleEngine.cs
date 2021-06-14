using System.Collections;
using System.Collections.Generic;

namespace RealbizGames.RulePattern
{
    public class GenericRuleEngine<T, E> : IRuleEngine<T, E>
    {
        private List<IRule<T, E>> rules = new List<IRule<T, E>>();

        public void AddRule(IRule<T, E> rule)
        {
            rules.Add(rule);
        }

        public T Execute(E expression)
        {
            foreach (IRule<T, E> rule in rules)
            {
                if (rule.Valuate(expression))
                {
                    return rule.Execute(expression);
                }
            }
            return default;
        }
    }
}