using Command.Business.Model;
using System;
using System.Collections.Generic;

namespace Command.Business.Command
{
    public class AddRuleCommand : AbsCommand
    {
        public override string Execute(List<string> parameters)
        {
            var rule = new Rule
            {
                Predicate = parameters[0],
                Number = Convert.ToInt32(parameters[1]),
                Text = parameters[2]
            };
            _repository.Add(rule);
            return "";
        }
    }
}
