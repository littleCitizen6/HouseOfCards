using HouseOfCards.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HouseOfCards.Participents
{
    public abstract class Participant
    {
        public int Id { get; }
        protected List<IOperation> _allowedOperations;
        public Participant(int id)
        {
            _allowedOperations = LoadOperations();
            Id = id;
        }

        private List<IOperation> LoadOperations()
        {
            List<IOperation> operations = new List<IOperation>();
            var operationsType = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(type => typeof(IOperation).IsAssignableFrom(type) && type != typeof(IOperation)).ToList();
            operationsType.ForEach(type => operations.Add((IOperation)Activator.CreateInstance(type)));
            return operations;
        }

        public abstract void MakeTurn();

    }
}
