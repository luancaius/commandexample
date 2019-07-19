using Command.Business.Model;
using Command.Business.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Command.Business.Service
{
    public class CommandService
    {
        private List<Rule> _repository;

        public CommandService()
        {
            _repository = new List<Rule>();
        }

        public string Process(string command)
        {
            //validate input
            var result = String.Empty;
            var list = command.Split().ToList();
             var commandName = list[0];
            list.RemoveAt(0);
            if (commandName.CompareIgnoreCase("ADDRULE"))
            {
                var rule = new Rule
                {
                    Predicate = list[0],
                    Number = Convert.ToInt32(list[1]),
                    Text = list[2]
                };
                _repository.Add(rule);
            }
            else if (commandName.CompareIgnoreCase("LIST"))
            {
                foreach (var rule in _repository)
                {
                    result += rule.ToString() + "\n";
                }
            }
            else if (commandName.CompareIgnoreCase("print"))
            {
                var number = list[0];
                result = PrintRule(Convert.ToInt32(number));
            }
            else if (commandName.CompareIgnoreCase("printrange"))
            {
                var number1 = Convert.ToInt32(list[0]);
                var number2 = Convert.ToInt32(list[1]);
                
                for (int i=number1; i <= number2; i++)
                {
                    var temp = PrintRule(i);
                    result += temp;
                }                
            }

            return result;
        }

        private string PrintRule(int number)
        {
            var result = string.Empty;

            foreach(var rule in _repository)
            {
                if(rule.Predicate.CompareIgnoreCase("LESS"))
                {
                    result += number < rule.Number ? rule.Text : number.ToString();
                }
                else if (rule.Predicate.CompareIgnoreCase("GREATER"))
                {
                    result += number > rule.Number ? rule.Text : number.ToString();
                }
                result += "\n";
            }

            return result ;
        }
    }
}
