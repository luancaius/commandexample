using Command.Business.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Business.Command
{
    public abstract class AbsCommand
    {
        public List<Rule> _repository;
        public AbsCommand()
        {
            _repository = new List<Rule>();
        }

        public abstract string Execute(List<String> parameters);
    }
}
